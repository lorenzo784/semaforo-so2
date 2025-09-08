using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semaforo
{
    public partial class FrmConfig : Form
    {
        public int NuevoTiempoRojo { get; private set; }
        public int NuevoTiempoAmarillo { get; private set; }
        public int NuevoTiempoVerde { get; private set; }

        private int conteoSensores;
        public FrmConfig(int tiempoRojoActual, int tiempoAmarilloActual, int tiempoVerdeActual, int conteoSensores)
        {
            InitializeComponent();
            numericRojoConfig.Value = tiempoRojoActual;
            numericAmarilloConfig.Value = tiempoAmarilloActual;
            numericVerdeConfig.Value = tiempoVerdeActual;
            this.conteoSensores = conteoSensores;
            lbContador.Text = $"Solicitudes: {conteoSensores}";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int rojo = (int)numericRojoConfig.Value;
            int amarillo = (int)numericAmarilloConfig.Value;
            int verde = (int)numericVerdeConfig.Value;

            if (rojo < (verde + amarillo))
            {
                MessageBox.Show("El tiempo en ROJO debe ser al menos igual a Verde + Amarillo del otro semáforo",
                                "Error en configuración", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            NuevoTiempoRojo = rojo;
            NuevoTiempoAmarillo = amarillo;
            NuevoTiempoVerde = verde;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; 
            this.Close();
        }
    }
}
