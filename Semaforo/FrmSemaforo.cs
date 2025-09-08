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
using System.Threading.Tasks;


namespace Semaforo
{
    public partial class FrmSemaforo : Form
    {
        private List<Semaforo> semaforos = new List<Semaforo> { new Semaforo(), new Semaforo() };
        private int conteoSensores = 0;

        public FrmSemaforo()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            timer1.Stop();

            pcbRojo.BackColor = Color.Gray;
            pcbAmarillo.BackColor = Color.Gray;
            pcbVerde.BackColor = Color.Gray;
            pcbRojo2.BackColor = Color.Gray;
            pcbAmarillo2.BackColor = Color.Gray;
            pcbVerde2.BackColor = Color.Gray;

            numericRojo.Text = semaforos[0].TiempoRojo.ToString();
            numericAmarillo.Text = semaforos[0].TiempoAmarillo.ToString();
            numericVerde.Text = semaforos[0].TiempoVerde.ToString();
            numericRojo2.Text = semaforos[0].TiempoRojo.ToString();
            numericAmarillo2.Text = semaforos[0].TiempoAmarillo.ToString();
            numericVerde2.Text = semaforos[0].TiempoVerde.ToString();
        }

        private void ActualizarCountdowns()
        {
            var s1 = semaforos[0];
            var s2 = semaforos[1];

            numericRojo.Text = (s1.Estado == 0 && timer1.Enabled) ? s1.ContadorActual.ToString() : s1.TiempoRojo.ToString();
            numericVerde.Text = (s1.Estado == 1 && timer1.Enabled) ? s1.ContadorActual.ToString() : s1.TiempoVerde.ToString();
            numericAmarillo.Text = (s1.Estado == 2 && timer1.Enabled) ? s1.ContadorActual.ToString() : s1.TiempoAmarillo.ToString();

            numericRojo2.Text = (s2.Estado == 0 && timer1.Enabled) ? s2.ContadorActual.ToString() : s2.TiempoRojo.ToString();
            numericVerde2.Text = (s2.Estado == 1 && timer1.Enabled) ? s2.ContadorActual.ToString() : s2.TiempoVerde.ToString();
            numericAmarillo2.Text = (s2.Estado == 2 && timer1.Enabled) ? s2.ContadorActual.ToString() : s2.TiempoAmarillo.ToString();
        }

        private void ActualizarUI()
        {
            var s1 = semaforos[0];
            var s2 = semaforos[1];

            pcbRojo.BackColor = s1.Estado == 0 ? Color.Red : Color.Gray;
            pcbAmarillo.BackColor = s1.Estado == 2 ? Color.Yellow : Color.Gray;
            pcbVerde.BackColor = s1.Estado == 1 ? Color.Green : Color.Gray;

            pcbRojo2.BackColor = s2.Estado == 0 ? Color.Red : Color.Gray;
            pcbAmarillo2.BackColor = s2.Estado == 2 ? Color.Yellow : Color.Gray;
            pcbVerde2.BackColor = s2.Estado == 1 ? Color.Green : Color.Gray;

            ActualizarCountdowns();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            semaforos[0].Reiniciar();
            semaforos[1].Reiniciar();
            semaforos[1].ForzarVerde();
            timer1.Start();
            ActualizarUI();
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            pcbRojo.BackColor = Color.Gray;
            pcbAmarillo.BackColor = Color.Gray;
            pcbVerde.BackColor = Color.Gray;
            pcbRojo2.BackColor = Color.Gray;
            pcbAmarillo2.BackColor = Color.Gray;
            pcbVerde2.BackColor = Color.Gray;
            ActualizarCountdowns();
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

                    semaforos[0].Reiniciar();
                    semaforos[1].Reiniciar();
                    ActualizarCountdowns();
                }
            }
        }

        private async void timer1_Tick(object? sender, EventArgs e)
        {
            int estadoAnterior1 = semaforos[0].Estado;
            int estadoAnterior2 = semaforos[1].Estado;

            semaforos[0].Avanzar();
            semaforos[1].Avanzar();
            ActualizarUI();

            if (semaforos[0].Estado != estadoAnterior1 || semaforos[1].Estado != estadoAnterior2)
                await PlaySoundAsync();
        }


        private async Task PlaySoundAsync()
        {
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
                await Task.Delay((int)audioFile.TotalTime.TotalMilliseconds);
            }
        }


        private void FrmSemaforo_Load(object sender, EventArgs e)
        {

        }

        private void btnSensorP1_Click(object sender, EventArgs e)
        {
            conteoSensores++;
            semaforos[0].ForzarRojo();
            semaforos[1].ForzarVerde();
            ActualizarUI();
        }

        private void btnSensorP2_Click(object sender, EventArgs e)
        {
            conteoSensores++;
            semaforos[1].ForzarRojo();
            semaforos[0].ForzarVerde();
            ActualizarUI();
        }
    }
}