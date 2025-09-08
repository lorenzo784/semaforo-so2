using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semaforo
{
    public class Semaforo
    {
        public int TiempoRojo { get; set; } = 30; 
        public int TiempoAmarillo { get; set; } = 5;
        public int TiempoVerde { get; set; } = 25;
        public int Estado { get; private set; } = 0; 
        public int ContadorActual { get; private set; }

        public Semaforo()
        {
            Reiniciar();
        }

        public void Reiniciar()
        {
            Estado = 0;
            ContadorActual = TiempoRojo;
        }

        public void Avanzar()
        {
            ContadorActual--;
            if (ContadorActual <= 0)
            {
                CambiarEstado();
            }
        }
        private void CambiarEstado()
        {
            Estado = (Estado + 1) % 3;
            switch (Estado)
            {
                case 0:
                    ContadorActual = TiempoRojo;
                    break;
                case 1:
                    ContadorActual = TiempoVerde;
                    break;
                case 2:
                    ContadorActual = TiempoAmarillo;
                    break;
            }
        }

        public void ForzarRojo()
        {
            Estado = 0; 
            ContadorActual = TiempoRojo;
        }

        public void ForzarVerde()
        {
            Estado = 1; 
            ContadorActual = TiempoVerde;
        }

        public string GetColorActual()
        {
            switch (Estado)
            {
                case 0: return "Rojo";
                case 1: return "Verde";
                case 2: return "Amarillo";
                default: return "Apagado";
            }
        }
    }
}
