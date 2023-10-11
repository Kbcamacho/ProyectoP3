namespace GUIPrinc
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSoporte = new System.Windows.Forms.Button();
            this.btnAtencionOnline = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnGestHistorialClinico = new System.Windows.Forms.Button();
            this.btnGestFacturas = new System.Windows.Forms.Button();
            this.btnGestCitas = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(656, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clinica Tres Rios";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.LightCyan;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(740, 66);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(188, 37);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Location = new System.Drawing.Point(-18, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1138, 136);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GUIPrinc.Properties.Resources.circulo_de_usuario1;
            this.pictureBox2.Location = new System.Drawing.Point(687, 66);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUIPrinc.Properties.Resources.Imagen2;
            this.pictureBox1.Location = new System.Drawing.Point(951, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(237, 152);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(856, 271);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Selecciones una opción.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightBlue;
            this.panel3.Controls.Add(this.btnSoporte);
            this.panel3.Controls.Add(this.btnAtencionOnline);
            this.panel3.Controls.Add(this.btnUser);
            this.panel3.Controls.Add(this.btnGestHistorialClinico);
            this.panel3.Controls.Add(this.btnGestFacturas);
            this.panel3.Controls.Add(this.btnGestCitas);
            this.panel3.Location = new System.Drawing.Point(14, 152);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(202, 480);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnSoporte
            // 
            this.btnSoporte.BackColor = System.Drawing.Color.LightCyan;
            this.btnSoporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoporte.Location = new System.Drawing.Point(19, 409);
            this.btnSoporte.Name = "btnSoporte";
            this.btnSoporte.Size = new System.Drawing.Size(165, 58);
            this.btnSoporte.TabIndex = 5;
            this.btnSoporte.Text = "Soporte";
            this.btnSoporte.UseVisualStyleBackColor = false;
            this.btnSoporte.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnAtencionOnline
            // 
            this.btnAtencionOnline.BackColor = System.Drawing.Color.LightCyan;
            this.btnAtencionOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtencionOnline.Location = new System.Drawing.Point(19, 333);
            this.btnAtencionOnline.Name = "btnAtencionOnline";
            this.btnAtencionOnline.Size = new System.Drawing.Size(165, 58);
            this.btnAtencionOnline.TabIndex = 4;
            this.btnAtencionOnline.Text = "Doctor";
            this.btnAtencionOnline.UseVisualStyleBackColor = false;
            this.btnAtencionOnline.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.LightCyan;
            this.btnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.Location = new System.Drawing.Point(19, 247);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(165, 58);
            this.btnUser.TabIndex = 3;
            this.btnUser.Text = "Gestión Usuarios";
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnGestHistorialClinico
            // 
            this.btnGestHistorialClinico.BackColor = System.Drawing.Color.LightCyan;
            this.btnGestHistorialClinico.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestHistorialClinico.Location = new System.Drawing.Point(19, 170);
            this.btnGestHistorialClinico.Name = "btnGestHistorialClinico";
            this.btnGestHistorialClinico.Size = new System.Drawing.Size(165, 58);
            this.btnGestHistorialClinico.TabIndex = 2;
            this.btnGestHistorialClinico.Text = "Gestión Historial Clinico";
            this.btnGestHistorialClinico.UseVisualStyleBackColor = false;
            this.btnGestHistorialClinico.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnGestFacturas
            // 
            this.btnGestFacturas.BackColor = System.Drawing.Color.LightCyan;
            this.btnGestFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestFacturas.Location = new System.Drawing.Point(19, 94);
            this.btnGestFacturas.Name = "btnGestFacturas";
            this.btnGestFacturas.Size = new System.Drawing.Size(165, 58);
            this.btnGestFacturas.TabIndex = 1;
            this.btnGestFacturas.Text = "Gestión Facturas";
            this.btnGestFacturas.UseVisualStyleBackColor = false;
            this.btnGestFacturas.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnGestCitas
            // 
            this.btnGestCitas.BackColor = System.Drawing.Color.LightCyan;
            this.btnGestCitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestCitas.Location = new System.Drawing.Point(19, 12);
            this.btnGestCitas.Name = "btnGestCitas";
            this.btnGestCitas.Size = new System.Drawing.Size(165, 58);
            this.btnGestCitas.TabIndex = 0;
            this.btnGestCitas.Text = "Gestión Citas";
            this.btnGestCitas.UseVisualStyleBackColor = false;
            this.btnGestCitas.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightBlue;
            this.panel5.Location = new System.Drawing.Point(237, 443);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(856, 189);
            this.panel5.TabIndex = 7;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1105, 653);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinica Tres Ríos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSoporte;
        private System.Windows.Forms.Button btnAtencionOnline;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnGestHistorialClinico;
        private System.Windows.Forms.Button btnGestFacturas;
        private System.Windows.Forms.Button btnGestCitas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
    }
}

