using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using System.IO;

namespace Semaforo
{
    public partial class FrmSemaforo : Form
    {
        private List<Semaforo> semaforos = new List<Semaforo> { new Semaforo(), new Semaforo() };
        private int conteoSensores = 0;
        private bool isPlaying = false;

        public FrmSemaforo()
        {
            InitializeComponent();
            semaforos[0].Otro = semaforos[1];
            semaforos[1].Otro = semaforos[0];
            InicializarComponentes();
            ConfigurarEventos();
        }

        private void InicializarComponentes()
        {
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            timer1.Stop();

            ReiniciarInterfazSemaforos();
            ConfigurarSemaforosCoordinados();
            ActualizarValoresNumericos();

            lblColaP1.Text = "Cola P1: 0";
            lblColaP2.Text = "Cola P2: 0";
        }

        private void ConfigurarEventos()
        {
            semaforos[0].CambioDeEstado += OnCambioEstadoSemaforo1;
            semaforos[1].CambioDeEstado += OnCambioEstadoSemaforo2;

            semaforos[0].ColaActualizada += (count) =>
            {
                if (InvokeRequired)
                    Invoke(new Action(() => lblColaP1.Text = $"Cola P1: {count}"));
                else
                    lblColaP1.Text = $"Cola P1: {count}";
            };

            semaforos[1].ColaActualizada += (count) =>
            {
                if (InvokeRequired)
                    Invoke(new Action(() => lblColaP2.Text = $"Cola P2: {count}"));
                else
                    lblColaP2.Text = $"Cola P2: {count}";
            };
        }

        private void ConfigurarSemaforosCoordinados()
        {
            var s1 = semaforos[0];
            var s2 = semaforos[1];
            s2.TiempoRojo = s1.TiempoVerde + s1.TiempoAmarillo;
            s2.TiempoAmarillo = s1.TiempoAmarillo;
            s2.TiempoVerde = s1.TiempoRojo - s2.TiempoAmarillo;
            s1.Reiniciar();
            s2.ForzarEstado(EstadoSemaforo.EnEjecucion);
        }

        private void ReiniciarInterfazSemaforos()
        {
            pcbRojo.BackColor = Color.Gray;
            pcbAmarillo.BackColor = Color.Gray;
            pcbVerde.BackColor = Color.Gray;
            pcbRojo2.BackColor = Color.Gray;
            pcbAmarillo2.BackColor = Color.Gray;
            pcbVerde2.BackColor = Color.Gray;
        }

        private void ActualizarValoresNumericos()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(ActualizarValoresNumericos));
                return;
            }

            var s1 = semaforos[0];
            var s2 = semaforos[1];

            numericRojo.Text = (s1.Estado == EstadoSemaforo.Bloqueado) ? s1.ContadorActual.ToString() : s1.TiempoRojo.ToString();
            numericVerde.Text = (s1.Estado == EstadoSemaforo.EnEjecucion) ? s1.ContadorActual.ToString() : s1.TiempoVerde.ToString();
            numericAmarillo.Text = (s1.Estado == EstadoSemaforo.Esperando) ? s1.ContadorActual.ToString() : s1.TiempoAmarillo.ToString();

            numericRojo2.Text = (s2.Estado == EstadoSemaforo.Bloqueado) ? s2.ContadorActual.ToString() : s2.TiempoRojo.ToString();
            numericVerde2.Text = (s2.Estado == EstadoSemaforo.EnEjecucion) ? s2.ContadorActual.ToString() : s2.TiempoVerde.ToString();
            numericAmarillo2.Text = (s2.Estado == EstadoSemaforo.Esperando) ? s2.ContadorActual.ToString() : s2.TiempoAmarillo.ToString();
        }

        private void ActualizarInterfazSemaforo(Semaforo semaforo, PictureBox pcbRojo, PictureBox pcbAmarillo, PictureBox pcbVerde)
        {
            pcbRojo.BackColor = Color.Gray;
            pcbAmarillo.BackColor = Color.Gray;
            pcbVerde.BackColor = Color.Gray;
            switch (semaforo.Estado)
            {
                case EstadoSemaforo.Bloqueado:
                    pcbRojo.BackColor = Color.Red;
                    break;
                case EstadoSemaforo.Esperando:
                    pcbAmarillo.BackColor = Color.Yellow;
                    break;
                case EstadoSemaforo.EnEjecucion:
                    pcbVerde.BackColor = Color.Green;
                    break;
            }
        }

        private void ActualizarInterfazCompleta()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(ActualizarInterfazCompleta));
                return;
            }

            ActualizarInterfazSemaforo(semaforos[0], pcbRojo, pcbAmarillo, pcbVerde);
            ActualizarInterfazSemaforo(semaforos[1], pcbRojo2, pcbAmarillo2, pcbVerde2);
            ActualizarValoresNumericos();
            ActualizarEstadoEnTitulo();
        }

        private void ActualizarEstadoEnTitulo()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(ActualizarEstadoEnTitulo));
                return;
            }

            var s1 = semaforos[0];
            var s2 = semaforos[1];

            this.Text = $"Semáforos - P1: {s1.GetDescripcionEstado()} ({s1.ContadorActual}s) | P2: {s2.GetDescripcionEstado()} ({s2.ContadorActual}s)";
        }

        private async void OnCambioEstadoSemaforo1(EstadoSemaforo anterior, EstadoSemaforo nuevo)
        {
            ActualizarInterfazCompleta();
            await PlaySoundAsync();
        }

        private async void OnCambioEstadoSemaforo2(EstadoSemaforo anterior, EstadoSemaforo nuevo)
        {
            ActualizarInterfazCompleta();
            await PlaySoundAsync();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            ConfigurarSemaforosCoordinados();
            timer1.Start();
            ActualizarInterfazCompleta();

            btnIniciar.Enabled = false;
            btnDetener.Enabled = true;
            btnConfigurar.Enabled = false;
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            foreach (var s in semaforos)
            {
                s.Reiniciar();
            }
            ReiniciarInterfazSemaforos();
            ActualizarValoresNumericos();
            this.Text = "Semáforos - Detenido";

            btnIniciar.Enabled = true;
            btnDetener.Enabled = false;
            btnConfigurar.Enabled = true;
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            using (var frmConfig = new FrmConfig(
                semaforos[0].TiempoRojo,
                semaforos[0].TiempoAmarillo,
                semaforos[0].TiempoVerde,
                conteoSensores))
            {
                if (frmConfig.ShowDialog() == DialogResult.OK)
                {
                    semaforos[0].TiempoRojo = frmConfig.NuevoTiempoRojo;
                    semaforos[0].TiempoAmarillo = frmConfig.NuevoTiempoAmarillo;
                    semaforos[0].TiempoVerde = frmConfig.NuevoTiempoVerde;

                    semaforos[1].TiempoRojo = semaforos[0].TiempoVerde + semaforos[0].TiempoAmarillo;
                    semaforos[1].TiempoAmarillo = semaforos[0].TiempoAmarillo;
                    semaforos[1].TiempoVerde = semaforos[0].TiempoRojo - semaforos[1].TiempoAmarillo;

                    if (semaforos[1].TiempoVerde <= 0)
                    {
                        MessageBox.Show("Los tiempos configurados no permiten una coordinación válida.",
                            "Configuración inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    semaforos[0].Reiniciar();
                    semaforos[1].Reiniciar();
                    ActualizarValoresNumericos();
                }
            }
        }

        private void btnSensorP1_Click(object sender, EventArgs e)
        {
            conteoSensores++;
            semaforos[0].AgregarProceso(new Proceso($"Proceso_{conteoSensores}"));
            ActualizarInterfazCompleta();
        }

        private void btnSensorP2_Click(object sender, EventArgs e)
        {
            conteoSensores++;
            semaforos[1].AgregarProceso(new Proceso($"Proceso_{conteoSensores}"));
            ActualizarInterfazCompleta();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            semaforos[0].Avanzar();
            semaforos[1].Avanzar();
            ActualizarInterfazCompleta();
        }

        private async Task PlaySoundAsync()
        {
            if (isPlaying) return;

            try
            {
                isPlaying = true;

                string projectSoundsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Sounds");
                string outputSoundsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Sounds");

                if (!Directory.Exists(outputSoundsPath))
                    Directory.CreateDirectory(outputSoundsPath);

                string sourceFile = Path.Combine(projectSoundsPath, "Jump.mp3");
                string destFile = Path.Combine(outputSoundsPath, "Jump.mp3");

                if (File.Exists(sourceFile) && !File.Exists(destFile))
                    File.Copy(sourceFile, destFile, true);

                if (File.Exists(destFile))
                {
                    using var audioFile = new AudioFileReader(destFile);
                    using var outputDevice = new WaveOutEvent();
                    outputDevice.Init(audioFile);
                    outputDevice.Play();

                    int maxWait = Math.Min((int)audioFile.TotalTime.TotalMilliseconds, 2000);
                    await Task.Delay(maxWait);
                }
            }
            finally
            {
                isPlaying = false;
            }
        }

        private void FrmSemaforo_Load(object sender, EventArgs e)
        {
            ActualizarInterfazCompleta();
            this.Text = "Semáforos - Listo";

            btnIniciar.Enabled = true;
            btnDetener.Enabled = false;
            btnConfigurar.Enabled = true;
        }
        private void FrmSemaforo_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            semaforos[0].CambioDeEstado -= OnCambioEstadoSemaforo1;
            semaforos[1].CambioDeEstado -= OnCambioEstadoSemaforo2;
        }
    }
}
