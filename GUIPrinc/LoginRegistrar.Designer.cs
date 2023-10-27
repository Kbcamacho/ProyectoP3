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
            this.txtNombrePaCC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLimpiarCP = new System.Windows.Forms.Button();
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
            this.cmbTipoIdenPaCC = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.btnVolverCC);
            this.panel1.Location = new System.Drawing.Point(-16, -20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 69);
            this.panel1.TabIndex = 0;
            // 
            // btnVolverCC
            // 
            this.btnVolverCC.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnVolverCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverCC.Location = new System.Drawing.Point(28, 32);
            this.btnVolverCC.Name = "btnVolverCC";
            this.btnVolverCC.Size = new System.Drawing.Size(104, 31);
            this.btnVolverCC.TabIndex = 0;
            this.btnVolverCC.Text = "Volver";
            this.btnVolverCC.UseVisualStyleBackColor = false;
            this.btnVolverCC.Click += new System.EventHandler(this.btnVolverCC_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbTipoIdenPaCC);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtNombrePaCC);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnLimpiarCP);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 387);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cuenta para Paciente";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtNombrePaCC
            // 
            this.txtNombrePaCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePaCC.Location = new System.Drawing.Point(21, 194);
            this.txtNombrePaCC.Name = "txtNombrePaCC";
            this.txtNombrePaCC.Size = new System.Drawing.Size(297, 27);
            this.txtNombrePaCC.TabIndex = 30;
            this.txtNombrePaCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombrePaCC_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Nombre Completo:";
            // 
            // btnLimpiarCP
            // 
            this.btnLimpiarCP.BackColor = System.Drawing.Color.LightBlue;
            this.btnLimpiarCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCP.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiarCP.Location = new System.Drawing.Point(462, 318);
            this.btnLimpiarCP.Name = "btnLimpiarCP";
            this.btnLimpiarCP.Size = new System.Drawing.Size(94, 36);
            this.btnLimpiarCP.TabIndex = 28;
            this.btnLimpiarCP.Text = "Limpiar";
            this.btnLimpiarCP.UseVisualStyleBackColor = false;
            this.btnLimpiarCP.Click += new System.EventHandler(this.btnLimpiarCP_Click);
            // 
            // cmbGeneroPaCC
            // 
            this.cmbGeneroPaCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGeneroPaCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGeneroPaCC.FormattingEnabled = true;
            this.cmbGeneroPaCC.Items.AddRange(new object[] {
            "Hombre",
            "Mujer",
            "Transexual",
            "Prefiero no decirlo",
            "Otro"});
            this.cmbGeneroPaCC.Location = new System.Drawing.Point(364, 194);
            this.cmbGeneroPaCC.Name = "cmbGeneroPaCC";
            this.cmbGeneroPaCC.Size = new System.Drawing.Size(297, 24);
            this.cmbGeneroPaCC.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(360, 171);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 20);
            this.label14.TabIndex = 13;
            this.label14.Text = "Genero:";
            // 
            // btnCrearPacCC
            // 
            this.btnCrearPacCC.BackColor = System.Drawing.Color.LightBlue;
            this.btnCrearPacCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearPacCC.ForeColor = System.Drawing.Color.Black;
            this.btnCrearPacCC.Location = new System.Drawing.Point(586, 318);
            this.btnCrearPacCC.Name = "btnCrearPacCC";
            this.btnCrearPacCC.Size = new System.Drawing.Size(75, 36);
            this.btnCrearPacCC.TabIndex = 12;
            this.btnCrearPacCC.Text = "Crear";
            this.btnCrearPacCC.UseVisualStyleBackColor = false;
            this.btnCrearPacCC.Click += new System.EventHandler(this.btnCrearPacCC_Click);
            // 
            // txtEdadPaCC
            // 
            this.txtEdadPaCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdadPaCC.Location = new System.Drawing.Point(364, 129);
            this.txtEdadPaCC.Name = "txtEdadPaCC";
            this.txtEdadPaCC.Size = new System.Drawing.Size(297, 27);
            this.txtEdadPaCC.TabIndex = 11;
            this.txtEdadPaCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdadPaCC_KeyPress);
            // 
            // txtCorreoPaCC
            // 
            this.txtCorreoPaCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoPaCC.Location = new System.Drawing.Point(364, 259);
            this.txtCorreoPaCC.Name = "txtCorreoPaCC";
            this.txtCorreoPaCC.Size = new System.Drawing.Size(297, 27);
            this.txtCorreoPaCC.TabIndex = 10;
            this.txtCorreoPaCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorreoPaCC_KeyPress);
            // 
            // txtNumPaCC
            // 
            this.txtNumPaCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumPaCC.Location = new System.Drawing.Point(364, 64);
            this.txtNumPaCC.Name = "txtNumPaCC";
            this.txtNumPaCC.Size = new System.Drawing.Size(297, 27);
            this.txtNumPaCC.TabIndex = 9;
            this.txtNumPaCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumPaCC_KeyPress);
            // 
            // txtIdenPaCC
            // 
            this.txtIdenPaCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdenPaCC.Location = new System.Drawing.Point(21, 323);
            this.txtIdenPaCC.Name = "txtIdenPaCC";
            this.txtIdenPaCC.Size = new System.Drawing.Size(297, 27);
            this.txtIdenPaCC.TabIndex = 8;
            this.txtIdenPaCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdenPaCC_KeyPress);
            // 
            // txtPassPaCC
            // 
            this.txtPassPaCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassPaCC.Location = new System.Drawing.Point(21, 129);
            this.txtPassPaCC.Name = "txtPassPaCC";
            this.txtPassPaCC.Size = new System.Drawing.Size(297, 27);
            this.txtPassPaCC.TabIndex = 7;
            this.txtPassPaCC.TextChanged += new System.EventHandler(this.txtPassPaCC_TextChanged);
            this.txtPassPaCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassPaCC_KeyPress);
            // 
            // txtUserPaCC
            // 
            this.txtUserPaCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserPaCC.Location = new System.Drawing.Point(21, 64);
            this.txtUserPaCC.Name = "txtUserPaCC";
            this.txtUserPaCC.Size = new System.Drawing.Size(297, 27);
            this.txtUserPaCC.TabIndex = 6;
            this.txtUserPaCC.TextChanged += new System.EventHandler(this.txtUserPaCC_TextChanged);
            this.txtUserPaCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserPaCC_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 300);
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
            this.label5.Location = new System.Drawing.Point(360, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Edad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(360, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numero Celular:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(360, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Correo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbTipoIdenPaCC
            // 
            this.cmbTipoIdenPaCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoIdenPaCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoIdenPaCC.FormattingEnabled = true;
            this.cmbTipoIdenPaCC.Items.AddRange(new object[] {
            "Cedula de Ciudadanía",
            "Cedula de Extranjeria",
            "Pasaporte",
            "Tarjeta de Identidad",
            "Registro Civil"});
            this.cmbTipoIdenPaCC.Location = new System.Drawing.Point(21, 262);
            this.cmbTipoIdenPaCC.Name = "cmbTipoIdenPaCC";
            this.cmbTipoIdenPaCC.Size = new System.Drawing.Size(297, 24);
            this.cmbTipoIdenPaCC.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "Tipo de Identificación:";
            // 
            // LoginRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(708, 454);
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
        private System.Windows.Forms.Button btnCrearPacCC;
        private System.Windows.Forms.Button btnVolverCC;
        private System.Windows.Forms.ComboBox cmbGeneroPaCC;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnLimpiarCP;
        private System.Windows.Forms.TextBox txtNombrePaCC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTipoIdenPaCC;
        private System.Windows.Forms.Label label8;
    }
}