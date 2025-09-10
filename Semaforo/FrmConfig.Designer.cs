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
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(143, 120);
            label1.Name = "label1";
            label1.Size = new Size(143, 20);
            label1.TabIndex = 0;
            label1.Text = "Tiempo Rojo (Seg):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(136, 200);
            label2.Name = "label2";
            label2.Size = new Size(171, 20);
            label2.TabIndex = 1;
            label2.Text = "Tiempo Amarillo (Seg):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(136, 269);
            label3.Name = "label3";
            label3.Size = new Size(151, 20);
            label3.TabIndex = 2;
            label3.Text = "Tiempo Verde (Seg):";
            // 
            // numericRojoConfig
            // 
            numericRojoConfig.BackColor = Color.Red;
            numericRojoConfig.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            numericRojoConfig.ForeColor = Color.White;
            numericRojoConfig.Location = new Point(359, 118);
            numericRojoConfig.Margin = new Padding(3, 5, 3, 5);
            numericRojoConfig.Name = "numericRojoConfig";
            numericRojoConfig.Size = new Size(157, 27);
            numericRojoConfig.TabIndex = 3;
            // 
            // numericAmarilloConfig
            // 
            numericAmarilloConfig.BackColor = Color.Yellow;
            numericAmarilloConfig.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            numericAmarilloConfig.ForeColor = Color.Black;
            numericAmarilloConfig.Location = new Point(359, 200);
            numericAmarilloConfig.Margin = new Padding(3, 5, 3, 5);
            numericAmarilloConfig.Name = "numericAmarilloConfig";
            numericAmarilloConfig.Size = new Size(157, 27);
            numericAmarilloConfig.TabIndex = 4;
            // 
            // numericVerdeConfig
            // 
            numericVerdeConfig.BackColor = Color.Green;
            numericVerdeConfig.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            numericVerdeConfig.ForeColor = Color.White;
            numericVerdeConfig.Location = new Point(359, 278);
            numericVerdeConfig.Margin = new Padding(3, 5, 3, 5);
            numericVerdeConfig.Name = "numericVerdeConfig";
            numericVerdeConfig.Size = new Size(157, 27);
            numericVerdeConfig.TabIndex = 5;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(0, 192, 0);
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(166, 406);
            btnAceptar.Margin = new Padding(3, 4, 3, 4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(106, 43);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(0, 192, 0);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(332, 406);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(106, 43);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(515, 25);
            label4.Name = "label4";
            label4.Size = new Size(160, 20);
            label4.TabIndex = 8;
            label4.Text = "Contador de sensores";
            // 
            // lbContador
            // 
            lbContador.AutoSize = true;
            lbContador.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbContador.ForeColor = Color.White;
            lbContador.Location = new Point(585, 61);
            lbContador.Name = "lbContador";
            lbContador.Size = new Size(18, 20);
            lbContador.TabIndex = 9;
            lbContador.Text = "1";
            // 
            // FrmConfig
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 90, 209);
            ClientSize = new Size(679, 537);
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
            Margin = new Padding(3, 4, 3, 4);
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