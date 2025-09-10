using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Semaforo
{
    public enum EstadoSemaforo
    {
        Bloqueado,   // Rojo
        Esperando,   // Amarillo
        EnEjecucion  // Verde
    }

    public class Proceso
    {
        public string Nombre { get; set; }

        public Proceso(string nombre)
        {
            Nombre = nombre;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }

    public class Semaforo
    {
        public int TiempoRojo { get; set; } = 30;
        public int TiempoAmarillo { get; set; } = 5;
        public int TiempoVerde { get; set; } = 25;

        public EstadoSemaforo Estado { get; private set; } = EstadoSemaforo.Bloqueado;
        public int ContadorActual { get; private set; }

        private readonly Queue<Proceso> colaProcesos = new Queue<Proceso>();
        private static readonly object syncLock = new object();

        public Semaforo Otro { get; set; }

        public event Action<EstadoSemaforo, EstadoSemaforo>? CambioDeEstado;
        public event Action<int>? ColaActualizada;
        public event Action<string>? ProcesoEjecutado;

        public Semaforo()
        {
            Reiniciar();
        }

        public void Reiniciar()
        {
            lock (syncLock)
            {
                Estado = EstadoSemaforo.Bloqueado;
                ContadorActual = TiempoRojo;
                colaProcesos.Clear();
                NotificarCola();
            }
        }

        public void AgregarProceso(Proceso p)
        {
            lock (syncLock)
            {
                colaProcesos.Enqueue(p);
                NotificarCola();

                if (Estado == EstadoSemaforo.Bloqueado && colaProcesos.Count > 0)
                {
                    CambiarEstado(EstadoSemaforo.Esperando);
                    ContadorActual = TiempoAmarillo;
                }
            }
        }

        public void Avanzar()
        {
            lock (syncLock)
            {
                if (ContadorActual > 0)
                {
                    ContadorActual--;
                    return;
                }

                switch (Estado)
                {
                    case EstadoSemaforo.Bloqueado:
                        if (colaProcesos.Count > 0)
                        {
                            CambiarEstado(EstadoSemaforo.Esperando);
                            ContadorActual = TiempoAmarillo;
                        }
                        else
                        {
                            ContadorActual = TiempoRojo; 
                        }
                        break;

                    case EstadoSemaforo.Esperando:
                        if (Otro?.Estado != EstadoSemaforo.EnEjecucion)
                        {
                            CambiarEstado(EstadoSemaforo.EnEjecucion);
                            ContadorActual = TiempoVerde;
                            if (colaProcesos.Count > 0)
                            {
                                ProcesoEjecutado?.Invoke(colaProcesos.Peek().Nombre);
                            }
                        }
                        break;

                    case EstadoSemaforo.EnEjecucion:
                        if (colaProcesos.Count > 0)
                        {
                            colaProcesos.Dequeue();
                            NotificarCola();
                        }
                        CambiarEstado(EstadoSemaforo.Bloqueado);
                        ContadorActual = TiempoRojo;
                        break;
                }
            }
        }

        public void ForzarEstado(EstadoSemaforo nuevo)
        {
            lock (syncLock)
            {
                var anterior = Estado;
                Estado = nuevo;
                switch (nuevo)
                {
                    case EstadoSemaforo.Bloqueado:
                        ContadorActual = TiempoRojo;
                        break;
                    case EstadoSemaforo.Esperando:
                        ContadorActual = TiempoAmarillo;
                        break;
                    case EstadoSemaforo.EnEjecucion:
                        ContadorActual = TiempoVerde;
                        break;
                }
                CambioDeEstado?.Invoke(anterior, nuevo);
            }
        }

        public string GetDescripcionEstado()
        {
            return Estado switch
            {
                EstadoSemaforo.Bloqueado => "Bloqueado (Rojo)",
                EstadoSemaforo.Esperando => "Esperando (Amarillo)",
                EstadoSemaforo.EnEjecucion => "En Ejecución (Verde)",
                _ => "Desconocido"
            };
        }

        private void CambiarEstado(EstadoSemaforo nuevoEstado)
        {
            var anterior = Estado;
            Estado = nuevoEstado;
            CambioDeEstado?.Invoke(anterior, nuevoEstado);
        }

        private void NotificarCola()
        {
            ColaActualizada?.Invoke(colaProcesos.Count);
        }
    }
}