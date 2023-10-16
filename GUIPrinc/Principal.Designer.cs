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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSoporte = new System.Windows.Forms.Button();
            this.btnAtencionOnline = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnGestHistorialClinico = new System.Windows.Forms.Button();
            this.btnGestFacturas = new System.Windows.Forms.Button();
            this.btnGestCitas = new System.Windows.Forms.Button();
            this.btnVolverPR = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(46, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clinica Tres Rios";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-18, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 134);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GUIPrinc.Properties.Resources.circulo_de_usuario1;
            this.pictureBox2.Location = new System.Drawing.Point(78, 56);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUIPrinc.Properties.Resources.Imagen2;
            this.pictureBox1.Location = new System.Drawing.Point(334, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightBlue;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnSoporte);
            this.panel3.Controls.Add(this.btnAtencionOnline);
            this.panel3.Controls.Add(this.btnUser);
            this.panel3.Controls.Add(this.btnGestHistorialClinico);
            this.panel3.Controls.Add(this.btnGestFacturas);
            this.panel3.Controls.Add(this.btnGestCitas);
            this.panel3.Location = new System.Drawing.Point(12, 139);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(469, 322);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Seleccione la opción de su preferencia:";
            // 
            // btnSoporte
            // 
            this.btnSoporte.BackColor = System.Drawing.Color.LightCyan;
            this.btnSoporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoporte.Location = new System.Drawing.Point(257, 239);
            this.btnSoporte.Name = "btnSoporte";
            this.btnSoporte.Size = new System.Drawing.Size(186, 58);
            this.btnSoporte.TabIndex = 5;
            this.btnSoporte.Text = "Soporte";
            this.btnSoporte.UseVisualStyleBackColor = false;
            this.btnSoporte.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnAtencionOnline
            // 
            this.btnAtencionOnline.BackColor = System.Drawing.Color.LightCyan;
            this.btnAtencionOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtencionOnline.Location = new System.Drawing.Point(257, 145);
            this.btnAtencionOnline.Name = "btnAtencionOnline";
            this.btnAtencionOnline.Size = new System.Drawing.Size(186, 58);
            this.btnAtencionOnline.TabIndex = 4;
            this.btnAtencionOnline.Text = "Doctor";
            this.btnAtencionOnline.UseVisualStyleBackColor = false;
            this.btnAtencionOnline.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.LightCyan;
            this.btnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.Location = new System.Drawing.Point(257, 54);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(186, 58);
            this.btnUser.TabIndex = 3;
            this.btnUser.Text = "Gestión Usuarios";
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnGestHistorialClinico
            // 
            this.btnGestHistorialClinico.BackColor = System.Drawing.Color.LightCyan;
            this.btnGestHistorialClinico.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestHistorialClinico.Location = new System.Drawing.Point(23, 239);
            this.btnGestHistorialClinico.Name = "btnGestHistorialClinico";
            this.btnGestHistorialClinico.Size = new System.Drawing.Size(186, 58);
            this.btnGestHistorialClinico.TabIndex = 2;
            this.btnGestHistorialClinico.Text = "Gestión Historial Clinico";
            this.btnGestHistorialClinico.UseVisualStyleBackColor = false;
            this.btnGestHistorialClinico.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnGestFacturas
            // 
            this.btnGestFacturas.BackColor = System.Drawing.Color.LightCyan;
            this.btnGestFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestFacturas.Location = new System.Drawing.Point(23, 145);
            this.btnGestFacturas.Name = "btnGestFacturas";
            this.btnGestFacturas.Size = new System.Drawing.Size(186, 58);
            this.btnGestFacturas.TabIndex = 1;
            this.btnGestFacturas.Text = "Gestión Facturas";
            this.btnGestFacturas.UseVisualStyleBackColor = false;
            this.btnGestFacturas.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnGestCitas
            // 
            this.btnGestCitas.BackColor = System.Drawing.Color.LightCyan;
            this.btnGestCitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestCitas.Location = new System.Drawing.Point(23, 54);
            this.btnGestCitas.Name = "btnGestCitas";
            this.btnGestCitas.Size = new System.Drawing.Size(186, 58);
            this.btnGestCitas.TabIndex = 0;
            this.btnGestCitas.Text = "Gestión Citas";
            this.btnGestCitas.UseVisualStyleBackColor = false;
            this.btnGestCitas.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnVolverPR
            // 
            this.btnVolverPR.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnVolverPR.Location = new System.Drawing.Point(195, 467);
            this.btnVolverPR.Name = "btnVolverPR";
            this.btnVolverPR.Size = new System.Drawing.Size(105, 44);
            this.btnVolverPR.TabIndex = 6;
            this.btnVolverPR.Text = "Volver";
            this.btnVolverPR.UseVisualStyleBackColor = false;
            this.btnVolverPR.Click += new System.EventHandler(this.btnVolverPR_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCyan;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(424, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(494, 521);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVolverPR);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinica Tres Ríos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSoporte;
        private System.Windows.Forms.Button btnAtencionOnline;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnGestHistorialClinico;
        private System.Windows.Forms.Button btnGestFacturas;
        private System.Windows.Forms.Button btnGestCitas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVolverPR;
        private System.Windows.Forms.Button button1;
    }
}

