namespace GUIPrinc
{
    partial class LoginRegistrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginRegistrar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVolverCC = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbGeneroPaCC = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnCrearPacCC = new System.Windows.Forms.Button();
            this.txtEdadPaCC = new System.Windows.Forms.TextBox();
            this.txtCorreoPaCC = new System.Windows.Forms.TextBox();
            this.txtNumPaCC = new System.Windows.Forms.TextBox();
            this.txtIdenPaCC = new System.Windows.Forms.TextBox();
            this.txtPassPaCC = new System.Windows.Forms.TextBox();
            this.txtUserPaCC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCrearDocCC = new System.Windows.Forms.Button();
            this.cmbEspeCC = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEdadCC = new System.Windows.Forms.TextBox();
            this.txtCorreoCC = new System.Windows.Forms.TextBox();
            this.txtNumCC = new System.Windows.Forms.TextBox();
            this.txtIdenCC = new System.Windows.Forms.TextBox();
            this.txtPassCC = new System.Windows.Forms.TextBox();
            this.txtUserCC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.btnVolverCC);
            this.panel1.Location = new System.Drawing.Point(-16, -20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1185, 69);
            this.panel1.TabIndex = 0;
            // 
            // btnVolverCC
            // 
            this.btnVolverCC.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnVolverCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverCC.Location = new System.Drawing.Point(984, 32);
            this.btnVolverCC.Name = "btnVolverCC";
            this.btnVolverCC.Size = new System.Drawing.Size(104, 31);
            this.btnVolverCC.TabIndex = 0;
            this.btnVolverCC.Text = "Volver";
            this.btnVolverCC.UseVisualStyleBackColor = false;
            this.btnVolverCC.Click += new System.EventHandler(this.btnVolverCC_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbGeneroPaCC);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.btnCrearPacCC);
            this.groupBox1.Controls.Add(this.txtEdadPaCC);
            this.groupBox1.Controls.Add(this.txtCorreoPaCC);
            this.groupBox1.Controls.Add(this.txtNumPaCC);
            this.groupBox1.Controls.Add(this.txtIdenPaCC);
            this.groupBox1.Controls.Add(this.txtPassPaCC);
            this.groupBox1.Controls.Add(this.txtUserPaCC);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.LightCyan;
            this.groupBox1.Location = new System.Drawing.Point(553, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 396);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cuenta para Paciente";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbGeneroPaCC
            // 
            this.cmbGeneroPaCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGeneroPaCC.FormattingEnabled = true;
            this.cmbGeneroPaCC.Items.AddRange(new object[] {
            "Hombre",
            "Mujer",
            "Transexual",
            "Prefiero no decirlo",
            "Otro"});
            this.cmbGeneroPaCC.Location = new System.Drawing.Point(222, 290);
            this.cmbGeneroPaCC.Name = "cmbGeneroPaCC";
            this.cmbGeneroPaCC.Size = new System.Drawing.Size(296, 24);
            this.cmbGeneroPaCC.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(132, 298);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 20);
            this.label14.TabIndex = 13;
            this.label14.Text = "Genero:";
            // 
            // btnCrearPacCC
            // 
            this.btnCrearPacCC.BackColor = System.Drawing.Color.LightBlue;
            this.btnCrearPacCC.ForeColor = System.Drawing.Color.Black;
            this.btnCrearPacCC.Location = new System.Drawing.Point(444, 340);
            this.btnCrearPacCC.Name = "btnCrearPacCC";
            this.btnCrearPacCC.Size = new System.Drawing.Size(75, 36);
            this.btnCrearPacCC.TabIndex = 12;
            this.btnCrearPacCC.Text = "Crear";
            this.btnCrearPacCC.UseVisualStyleBackColor = false;
            // 
            // txtEdadPaCC
            // 
            this.txtEdadPaCC.Location = new System.Drawing.Point(222, 250);
            this.txtEdadPaCC.Name = "txtEdadPaCC";
            this.txtEdadPaCC.Size = new System.Drawing.Size(296, 27);
            this.txtEdadPaCC.TabIndex = 11;
            // 
            // txtCorreoPaCC
            // 
            this.txtCorreoPaCC.Location = new System.Drawing.Point(222, 208);
            this.txtCorreoPaCC.Name = "txtCorreoPaCC";
            this.txtCorreoPaCC.Size = new System.Drawing.Size(296, 27);
            this.txtCorreoPaCC.TabIndex = 10;
            // 
            // txtNumPaCC
            // 
            this.txtNumPaCC.Location = new System.Drawing.Point(222, 165);
            this.txtNumPaCC.Name = "txtNumPaCC";
            this.txtNumPaCC.Size = new System.Drawing.Size(296, 27);
            this.txtNumPaCC.TabIndex = 9;
            // 
            // txtIdenPaCC
            // 
            this.txtIdenPaCC.Location = new System.Drawing.Point(222, 123);
            this.txtIdenPaCC.Name = "txtIdenPaCC";
            this.txtIdenPaCC.Size = new System.Drawing.Size(296, 27);
            this.txtIdenPaCC.TabIndex = 8;
            // 
            // txtPassPaCC
            // 
            this.txtPassPaCC.Location = new System.Drawing.Point(222, 81);
            this.txtPassPaCC.Name = "txtPassPaCC";
            this.txtPassPaCC.Size = new System.Drawing.Size(296, 27);
            this.txtPassPaCC.TabIndex = 7;
            // 
            // txtUserPaCC
            // 
            this.txtUserPaCC.Location = new System.Drawing.Point(222, 41);
            this.txtUserPaCC.Name = "txtUserPaCC";
            this.txtUserPaCC.Size = new System.Drawing.Size(296, 27);
            this.txtUserPaCC.TabIndex = 6;
            this.txtUserPaCC.TextChanged += new System.EventHandler(this.txtUserPaCC_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(89, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Identificación:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(149, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Edad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numero Celular:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Correo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Usuario:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCrearDocCC);
            this.groupBox2.Controls.Add(this.cmbEspeCC);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtEdadCC);
            this.groupBox2.Controls.Add(this.txtCorreoCC);
            this.groupBox2.Controls.Add(this.txtNumCC);
            this.groupBox2.Controls.Add(this.txtIdenCC);
            this.groupBox2.Controls.Add(this.txtPassCC);
            this.groupBox2.Controls.Add(this.txtUserCC);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.LightCyan;
            this.groupBox2.Location = new System.Drawing.Point(12, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(534, 396);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cuenta para Doctor";
            // 
            // btnCrearDocCC
            // 
            this.btnCrearDocCC.BackColor = System.Drawing.Color.LightBlue;
            this.btnCrearDocCC.ForeColor = System.Drawing.Color.Black;
            this.btnCrearDocCC.Location = new System.Drawing.Point(442, 340);
            this.btnCrearDocCC.Name = "btnCrearDocCC";
            this.btnCrearDocCC.Size = new System.Drawing.Size(75, 36);
            this.btnCrearDocCC.TabIndex = 26;
            this.btnCrearDocCC.Text = "Crear";
            this.btnCrearDocCC.UseVisualStyleBackColor = false;
            this.btnCrearDocCC.Click += new System.EventHandler(this.btnCrearDocCC_Click);
            // 
            // cmbEspeCC
            // 
            this.cmbEspeCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEspeCC.FormattingEnabled = true;
            this.cmbEspeCC.Items.AddRange(new object[] {
            "Acupuntura",
            "Cardiologia",
            "Cirugia General",
            "Cirugia Maxilofacial (odontologia)",
            "Cirugia Plastica",
            "Dermatologia",
            "Endocrinologia",
            "Endodoncia",
            "Gastroenterologia",
            "Laboratorio Clinico",
            "Medicina General",
            "Neumologia",
            "Neurologia",
            "Nutricion y Dietetica",
            "Odontologia",
            "Odontologia Estetica",
            "Odontologia Pediatrica",
            "Oftalmologia",
            "Optometria",
            "Ortodoncia",
            "Otorrinolaringologia",
            "Psicologia",
            "Radiologia",
            "Urologia",
            "Vacunacion"});
            this.cmbEspeCC.Location = new System.Drawing.Point(221, 290);
            this.cmbEspeCC.Name = "cmbEspeCC";
            this.cmbEspeCC.Size = new System.Drawing.Size(296, 24);
            this.cmbEspeCC.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(100, 298);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "Espcialidad:";
            // 
            // txtEdadCC
            // 
            this.txtEdadCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdadCC.Location = new System.Drawing.Point(221, 250);
            this.txtEdadCC.Name = "txtEdadCC";
            this.txtEdadCC.Size = new System.Drawing.Size(296, 27);
            this.txtEdadCC.TabIndex = 23;
            // 
            // txtCorreoCC
            // 
            this.txtCorreoCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoCC.Location = new System.Drawing.Point(221, 208);
            this.txtCorreoCC.Name = "txtCorreoCC";
            this.txtCorreoCC.Size = new System.Drawing.Size(296, 27);
            this.txtCorreoCC.TabIndex = 22;
            // 
            // txtNumCC
            // 
            this.txtNumCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumCC.Location = new System.Drawing.Point(221, 165);
            this.txtNumCC.Name = "txtNumCC";
            this.txtNumCC.Size = new System.Drawing.Size(296, 27);
            this.txtNumCC.TabIndex = 21;
            // 
            // txtIdenCC
            // 
            this.txtIdenCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdenCC.Location = new System.Drawing.Point(221, 123);
            this.txtIdenCC.Name = "txtIdenCC";
            this.txtIdenCC.Size = new System.Drawing.Size(296, 27);
            this.txtIdenCC.TabIndex = 20;
            // 
            // txtPassCC
            // 
            this.txtPassCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassCC.Location = new System.Drawing.Point(221, 81);
            this.txtPassCC.Name = "txtPassCC";
            this.txtPassCC.Size = new System.Drawing.Size(296, 27);
            this.txtPassCC.TabIndex = 19;
            // 
            // txtUserCC
            // 
            this.txtUserCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserCC.Location = new System.Drawing.Point(221, 41);
            this.txtUserCC.Name = "txtUserCC";
            this.txtUserCC.Size = new System.Drawing.Size(296, 27);
            this.txtUserCC.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(88, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Identificación:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(148, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Edad:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(69, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Numero Celular:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(135, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Correo:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(100, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "Contraseña:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(41, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(159, 20);
            this.label12.TabIndex = 12;
            this.label12.Text = "Nombre de Usuario:";
            // 
            // LoginRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1101, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginRegistrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Cuenta";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEdadPaCC;
        private System.Windows.Forms.TextBox txtCorreoPaCC;
        private System.Windows.Forms.TextBox txtNumPaCC;
        private System.Windows.Forms.TextBox txtIdenPaCC;
        private System.Windows.Forms.TextBox txtPassPaCC;
        private System.Windows.Forms.TextBox txtUserPaCC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtEdadCC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbEspeCC;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnCrearPacCC;
        private System.Windows.Forms.Button btnCrearDocCC;
        private System.Windows.Forms.Button btnVolverCC;
        private System.Windows.Forms.ComboBox cmbGeneroPaCC;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCorreoCC;
        private System.Windows.Forms.TextBox txtNumCC;
        private System.Windows.Forms.TextBox txtIdenCC;
        private System.Windows.Forms.TextBox txtPassCC;
        private System.Windows.Forms.TextBox txtUserCC;
    }
}