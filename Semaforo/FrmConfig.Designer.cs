namespace Semaforo
{
    partial class FrmConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            numericRojoConfig = new NumericUpDown();
            numericAmarilloConfig = new NumericUpDown();
            numericVerdeConfig = new NumericUpDown();
            btnAceptar = new Button();
            btnCancelar = new Button();
            label4 = new Label();
            lbContador = new Label();
            ((System.ComponentModel.ISupportInitialize)numericRojoConfig).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericAmarilloConfig).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericVerdeConfig).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(118, 61);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 0;
            label1.Text = "Tiempo Rojo (Seg):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(118, 122);
            label2.Name = "label2";
            label2.Size = new Size(129, 15);
            label2.TabIndex = 1;
            label2.Text = "Tiempo Amarillo (Seg):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(118, 174);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 2;
            label3.Text = "Tiempo Verde (Seg):";
            // 
            // numericRojoConfig
            // 
            numericRojoConfig.BackColor = Color.Red;
            numericRojoConfig.ForeColor = Color.White;
            numericRojoConfig.Location = new Point(275, 59);
            numericRojoConfig.Name = "numericRojoConfig";
            numericRojoConfig.Size = new Size(120, 23);
            numericRojoConfig.TabIndex = 3;
            // 
            // numericAmarilloConfig
            // 
            numericAmarilloConfig.BackColor = Color.Yellow;
            numericAmarilloConfig.ForeColor = Color.Black;
            numericAmarilloConfig.Location = new Point(275, 120);
            numericAmarilloConfig.Name = "numericAmarilloConfig";
            numericAmarilloConfig.Size = new Size(120, 23);
            numericAmarilloConfig.TabIndex = 4;
            // 
            // numericVerdeConfig
            // 
            numericVerdeConfig.BackColor = Color.Green;
            numericVerdeConfig.ForeColor = Color.White;
            numericVerdeConfig.Location = new Point(275, 174);
            numericVerdeConfig.Name = "numericVerdeConfig";
            numericVerdeConfig.Size = new Size(120, 23);
            numericVerdeConfig.TabIndex = 5;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(0, 64, 0);
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(133, 263);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(93, 32);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(0, 64, 0);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(302, 263);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(93, 32);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(431, 37);
            label4.Name = "label4";
            label4.Size = new Size(121, 15);
            label4.TabIndex = 8;
            label4.Text = "Contador de sensores";
            // 
            // lbContador
            // 
            lbContador.AutoSize = true;
            lbContador.ForeColor = Color.White;
            lbContador.Location = new Point(456, 67);
            lbContador.Name = "lbContador";
            lbContador.Size = new Size(13, 15);
            lbContador.TabIndex = 9;
            lbContador.Text = "1";
            // 
            // FrmConfig
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 0);
            ClientSize = new Size(564, 368);
            Controls.Add(lbContador);
            Controls.Add(label4);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(numericVerdeConfig);
            Controls.Add(numericAmarilloConfig);
            Controls.Add(numericRojoConfig);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmConfig";
            Text = "FrmConfig";
            ((System.ComponentModel.ISupportInitialize)numericRojoConfig).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericAmarilloConfig).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericVerdeConfig).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown numericRojoConfig;
        private NumericUpDown numericAmarilloConfig;
        private NumericUpDown numericVerdeConfig;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label label4;
        private Label lbContador;
    }
}