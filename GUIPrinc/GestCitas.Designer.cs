namespace GUIPrinc
{
    partial class GestCitas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancelarCita = new System.Windows.Forms.Button();
            this.btnConsulCita = new System.Windows.Forms.Button();
            this.btnSacarCita = new System.Windows.Forms.Button();
            this.btnActuCita = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Location = new System.Drawing.Point(-11, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1165, 139);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GUIPrinc.Properties.Resources.circulo_de_usuario1;
            this.pictureBox2.Location = new System.Drawing.Point(68, 67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUIPrinc.Properties.Resources.Imagen2;
            this.pictureBox1.Location = new System.Drawing.Point(332, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(37, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clinica Tres Rios";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.LightBlue;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(121, 67);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(188, 37);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightBlue;
            this.panel3.Controls.Add(this.btnCancelarCita);
            this.panel3.Controls.Add(this.btnConsulCita);
            this.panel3.Controls.Add(this.btnSacarCita);
            this.panel3.Controls.Add(this.btnActuCita);
            this.panel3.Controls.Add(this.btnVolver);
            this.panel3.Location = new System.Drawing.Point(14, 153);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(460, 252);
            this.panel3.TabIndex = 9;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnCancelarCita
            // 
            this.btnCancelarCita.BackColor = System.Drawing.Color.LightCyan;
            this.btnCancelarCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCita.Location = new System.Drawing.Point(243, 96);
            this.btnCancelarCita.Name = "btnCancelarCita";
            this.btnCancelarCita.Size = new System.Drawing.Size(199, 58);
            this.btnCancelarCita.TabIndex = 4;
            this.btnCancelarCita.Text = "Cancelar Cita";
            this.btnCancelarCita.UseVisualStyleBackColor = false;
            // 
            // btnConsulCita
            // 
            this.btnConsulCita.BackColor = System.Drawing.Color.LightCyan;
            this.btnConsulCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulCita.Location = new System.Drawing.Point(243, 12);
            this.btnConsulCita.Name = "btnConsulCita";
            this.btnConsulCita.Size = new System.Drawing.Size(199, 58);
            this.btnConsulCita.TabIndex = 3;
            this.btnConsulCita.Text = "Consular Cita Programada";
            this.btnConsulCita.UseVisualStyleBackColor = false;
            // 
            // btnSacarCita
            // 
            this.btnSacarCita.BackColor = System.Drawing.Color.LightCyan;
            this.btnSacarCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacarCita.Location = new System.Drawing.Point(19, 12);
            this.btnSacarCita.Name = "btnSacarCita";
            this.btnSacarCita.Size = new System.Drawing.Size(199, 58);
            this.btnSacarCita.TabIndex = 2;
            this.btnSacarCita.Text = "Programar Cita";
            this.btnSacarCita.UseVisualStyleBackColor = false;
            this.btnSacarCita.Click += new System.EventHandler(this.btnSacarCita_Click);
            // 
            // btnActuCita
            // 
            this.btnActuCita.BackColor = System.Drawing.Color.LightCyan;
            this.btnActuCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActuCita.Location = new System.Drawing.Point(19, 96);
            this.btnActuCita.Name = "btnActuCita";
            this.btnActuCita.Size = new System.Drawing.Size(199, 58);
            this.btnActuCita.TabIndex = 1;
            this.btnActuCita.Text = "Actualizar Cita";
            this.btnActuCita.UseVisualStyleBackColor = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVolver.Location = new System.Drawing.Point(151, 172);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(165, 58);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // GestCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(486, 418);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "GestCitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Citas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnActuCita;
        private System.Windows.Forms.Button btnCancelarCita;
        private System.Windows.Forms.Button btnConsulCita;
        private System.Windows.Forms.Button btnSacarCita;
    }
}