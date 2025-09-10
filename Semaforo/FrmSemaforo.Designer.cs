namespace Semaforo
{
    partial class FrmSemaforo
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
            components = new System.ComponentModel.Container();
            pcbVerde = new PictureBox();
            pcbAmarillo = new PictureBox();
            pcbRojo = new PictureBox();
            btnIniciar = new Button();
            btnDetener = new Button();
            btnConfigurar = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            numericVerde = new Label();
            numericAmarillo = new Label();
            numericRojo = new Label();
            numericRojo2 = new Label();
            numericAmarillo2 = new Label();
            numericVerde2 = new Label();
            pcbRojo2 = new PictureBox();
            pcbAmarillo2 = new PictureBox();
            pcbVerde2 = new PictureBox();
            btnSensorP1 = new Button();
            btnSensorP2 = new Button();
            label1 = new Label();
            label2 = new Label();
            lblColaP1 = new Label();
            lblColaP2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pcbVerde).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbAmarillo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbRojo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbRojo2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbAmarillo2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbVerde2).BeginInit();
            SuspendLayout();
            // 
            // pcbVerde
            // 
            pcbVerde.BackColor = Color.Gray;
            pcbVerde.Location = new Point(198, 195);
            pcbVerde.Margin = new Padding(3, 4, 3, 4);
            pcbVerde.Name = "pcbVerde";
            pcbVerde.Size = new Size(180, 180);
            pcbVerde.TabIndex = 0;
            pcbVerde.TabStop = false;
            // 
            // pcbAmarillo
            // 
            pcbAmarillo.BackColor = Color.Gray;
            pcbAmarillo.Location = new Point(488, 195);
            pcbAmarillo.Margin = new Padding(3, 4, 3, 4);
            pcbAmarillo.Name = "pcbAmarillo";
            pcbAmarillo.Size = new Size(180, 180);
            pcbAmarillo.TabIndex = 1;
            pcbAmarillo.TabStop = false;
            // 
            // pcbRojo
            // 
            pcbRojo.BackColor = Color.Gray;
            pcbRojo.Location = new Point(770, 195);
            pcbRojo.Margin = new Padding(3, 4, 3, 4);
            pcbRojo.Name = "pcbRojo";
            pcbRojo.Size = new Size(180, 180);
            pcbRojo.TabIndex = 2;
            pcbRojo.TabStop = false;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.FromArgb(77, 205, 255);
            btnIniciar.FlatAppearance.BorderSize = 0;
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnIniciar.ForeColor = Color.White;
            btnIniciar.Location = new Point(262, 35);
            btnIniciar.Margin = new Padding(3, 4, 3, 4);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(106, 53);
            btnIniciar.TabIndex = 3;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnDetener
            // 
            btnDetener.BackColor = Color.FromArgb(77, 205, 255);
            btnDetener.FlatAppearance.BorderSize = 0;
            btnDetener.FlatStyle = FlatStyle.Flat;
            btnDetener.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDetener.ForeColor = Color.White;
            btnDetener.Location = new Point(525, 36);
            btnDetener.Margin = new Padding(3, 4, 3, 4);
            btnDetener.Name = "btnDetener";
            btnDetener.Size = new Size(106, 52);
            btnDetener.TabIndex = 4;
            btnDetener.Text = "Detener";
            btnDetener.UseVisualStyleBackColor = false;
            btnDetener.Click += btnDetener_Click;
            // 
            // btnConfigurar
            // 
            btnConfigurar.BackColor = Color.FromArgb(77, 205, 255);
            btnConfigurar.FlatAppearance.BorderSize = 0;
            btnConfigurar.FlatStyle = FlatStyle.Flat;
            btnConfigurar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnConfigurar.ForeColor = Color.White;
            btnConfigurar.Location = new Point(764, 35);
            btnConfigurar.Margin = new Padding(3, 4, 3, 4);
            btnConfigurar.Name = "btnConfigurar";
            btnConfigurar.Size = new Size(106, 53);
            btnConfigurar.TabIndex = 5;
            btnConfigurar.Text = "Configurar";
            btnConfigurar.UseVisualStyleBackColor = false;
            btnConfigurar.Click += btnConfigurar_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // numericVerde
            // 
            numericVerde.AutoSize = true;
            numericVerde.BackColor = Color.Transparent;
            numericVerde.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            numericVerde.ForeColor = Color.White;
            numericVerde.Location = new Point(281, 272);
            numericVerde.Name = "numericVerde";
            numericVerde.Size = new Size(18, 20);
            numericVerde.TabIndex = 12;
            numericVerde.Text = "1";
            // 
            // numericAmarillo
            // 
            numericAmarillo.AutoSize = true;
            numericAmarillo.BackColor = Color.Transparent;
            numericAmarillo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            numericAmarillo.ForeColor = Color.White;
            numericAmarillo.Location = new Point(577, 272);
            numericAmarillo.Name = "numericAmarillo";
            numericAmarillo.Size = new Size(18, 20);
            numericAmarillo.TabIndex = 13;
            numericAmarillo.Text = "1";
            // 
            // numericRojo
            // 
            numericRojo.AutoSize = true;
            numericRojo.BackColor = Color.Transparent;
            numericRojo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            numericRojo.ForeColor = Color.White;
            numericRojo.Location = new Point(853, 272);
            numericRojo.Name = "numericRojo";
            numericRojo.Size = new Size(18, 20);
            numericRojo.TabIndex = 14;
            numericRojo.Text = "1";
            // 
            // numericRojo2
            // 
            numericRojo2.AutoSize = true;
            numericRojo2.BackColor = Color.Transparent;
            numericRojo2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            numericRojo2.ForeColor = Color.White;
            numericRojo2.Location = new Point(853, 645);
            numericRojo2.Name = "numericRojo2";
            numericRojo2.Size = new Size(18, 20);
            numericRojo2.TabIndex = 20;
            numericRojo2.Text = "1";
            // 
            // numericAmarillo2
            // 
            numericAmarillo2.AutoSize = true;
            numericAmarillo2.BackColor = Color.Transparent;
            numericAmarillo2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            numericAmarillo2.ForeColor = Color.White;
            numericAmarillo2.Location = new Point(577, 645);
            numericAmarillo2.Name = "numericAmarillo2";
            numericAmarillo2.Size = new Size(18, 20);
            numericAmarillo2.TabIndex = 19;
            numericAmarillo2.Text = "1";
            // 
            // numericVerde2
            // 
            numericVerde2.AutoSize = true;
            numericVerde2.BackColor = Color.Transparent;
            numericVerde2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            numericVerde2.ForeColor = Color.White;
            numericVerde2.Location = new Point(281, 645);
            numericVerde2.Name = "numericVerde2";
            numericVerde2.Size = new Size(18, 20);
            numericVerde2.TabIndex = 18;
            numericVerde2.Text = "1";
            // 
            // pcbRojo2
            // 
            pcbRojo2.BackColor = Color.Gray;
            pcbRojo2.Location = new Point(770, 568);
            pcbRojo2.Margin = new Padding(3, 4, 3, 4);
            pcbRojo2.Name = "pcbRojo2";
            pcbRojo2.Size = new Size(180, 180);
            pcbRojo2.TabIndex = 17;
            pcbRojo2.TabStop = false;
            // 
            // pcbAmarillo2
            // 
            pcbAmarillo2.BackColor = Color.Gray;
            pcbAmarillo2.Location = new Point(486, 568);
            pcbAmarillo2.Margin = new Padding(3, 4, 3, 4);
            pcbAmarillo2.Name = "pcbAmarillo2";
            pcbAmarillo2.Size = new Size(180, 180);
            pcbAmarillo2.TabIndex = 16;
            pcbAmarillo2.TabStop = false;
            // 
            // pcbVerde2
            // 
            pcbVerde2.BackColor = Color.Gray;
            pcbVerde2.Location = new Point(198, 568);
            pcbVerde2.Margin = new Padding(3, 4, 3, 4);
            pcbVerde2.Name = "pcbVerde2";
            pcbVerde2.Size = new Size(180, 180);
            pcbVerde2.TabIndex = 15;
            pcbVerde2.TabStop = false;
            // 
            // btnSensorP1
            // 
            btnSensorP1.BackColor = Color.FromArgb(34, 200, 84);
            btnSensorP1.FlatAppearance.BorderSize = 0;
            btnSensorP1.FlatStyle = FlatStyle.Flat;
            btnSensorP1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSensorP1.ForeColor = Color.White;
            btnSensorP1.Location = new Point(488, 399);
            btnSensorP1.Margin = new Padding(3, 4, 3, 4);
            btnSensorP1.Name = "btnSensorP1";
            btnSensorP1.Size = new Size(180, 47);
            btnSensorP1.TabIndex = 23;
            btnSensorP1.Text = "Proceso";
            btnSensorP1.UseVisualStyleBackColor = false;
            btnSensorP1.Click += btnSensorP1_Click;
            // 
            // btnSensorP2
            // 
            btnSensorP2.BackColor = Color.FromArgb(34, 200, 84);
            btnSensorP2.FlatAppearance.BorderSize = 0;
            btnSensorP2.FlatStyle = FlatStyle.Flat;
            btnSensorP2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSensorP2.ForeColor = Color.White;
            btnSensorP2.Location = new Point(488, 794);
            btnSensorP2.Margin = new Padding(3, 4, 3, 4);
            btnSensorP2.Name = "btnSensorP2";
            btnSensorP2.Size = new Size(178, 47);
            btnSensorP2.TabIndex = 24;
            btnSensorP2.Text = "Proceso";
            btnSensorP2.UseVisualStyleBackColor = false;
            btnSensorP2.Click += btnSensorP2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(90, 152);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 25;
            label1.Text = "Semaforo 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(90, 526);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 26;
            label2.Text = "Semaforo 2";
            // 
            // lblColaP1
            // 
            lblColaP1.AutoSize = true;
            lblColaP1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColaP1.ForeColor = Color.White;
            lblColaP1.Location = new Point(719, 412);
            lblColaP1.Name = "lblColaP1";
            lblColaP1.Size = new Size(51, 20);
            lblColaP1.TabIndex = 27;
            lblColaP1.Text = "label3";
            // 
            // lblColaP2
            // 
            lblColaP2.AutoSize = true;
            lblColaP2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColaP2.ForeColor = Color.White;
            lblColaP2.Location = new Point(719, 807);
            lblColaP2.Name = "lblColaP2";
            lblColaP2.Size = new Size(51, 20);
            lblColaP2.TabIndex = 28;
            lblColaP2.Text = "label4";
            // 
            // FrmSemaforo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 90, 209);
            ClientSize = new Size(1147, 908);
            Controls.Add(lblColaP2);
            Controls.Add(lblColaP1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSensorP2);
            Controls.Add(btnSensorP1);
            Controls.Add(numericRojo2);
            Controls.Add(numericAmarillo2);
            Controls.Add(numericVerde2);
            Controls.Add(pcbRojo2);
            Controls.Add(pcbAmarillo2);
            Controls.Add(pcbVerde2);
            Controls.Add(numericRojo);
            Controls.Add(numericAmarillo);
            Controls.Add(numericVerde);
            Controls.Add(btnConfigurar);
            Controls.Add(btnDetener);
            Controls.Add(btnIniciar);
            Controls.Add(pcbRojo);
            Controls.Add(pcbAmarillo);
            Controls.Add(pcbVerde);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FrmSemaforo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmSemaforo";
            FormClosing += FrmSemaforo_FormClosing_1;
            Load += FrmSemaforo_Load;
            ((System.ComponentModel.ISupportInitialize)pcbVerde).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbAmarillo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbRojo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbRojo2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbAmarillo2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbVerde2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbVerde;
        private PictureBox pcbAmarillo;
        private PictureBox pcbRojo;
        private Button btnIniciar;
        private Button btnDetener;
        private Button btnConfigurar;
        private System.Windows.Forms.Timer timer1;
        private Label numericVerde;
        private Label numericAmarillo;
        private Label numericRojo;
        private Label numericRojo2;
        private Label numericAmarillo2;
        private Label numericVerde2;
        private PictureBox pcbRojo2;
        private PictureBox pcbAmarillo2;
        private PictureBox pcbVerde2;
        private Button btnSensorP1;
        private Button btnSensorP2;
        private Label label1;
        private Label label2;
        private Label lblColaP1;
        private Label lblColaP2;
    }
}