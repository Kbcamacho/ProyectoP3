﻿namespace GUIPrinc
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCrearCuentaIS = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLimpiarIS = new System.Windows.Forms.Button();
            this.btnIngresarIS = new System.Windows.Forms.Button();
            this.txtPassPaCC = new System.Windows.Forms.TextBox();
            this.txtUserPaCC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.ChbDoctor = new System.Windows.Forms.CheckBox();
            this.ChbUsuario = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCyan;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "INICIO DE SESION";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ChbUsuario);
            this.groupBox1.Controls.Add(this.ChbDoctor);
            this.groupBox1.Controls.Add(this.btnCrearCuentaIS);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnLimpiarIS);
            this.groupBox1.Controls.Add(this.btnIngresarIS);
            this.groupBox1.Controls.Add(this.txtPassPaCC);
            this.groupBox1.Controls.Add(this.txtUserPaCC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.LightCyan;
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 311);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese sus datos:";
            // 
            // btnCrearCuentaIS
            // 
            this.btnCrearCuentaIS.BackColor = System.Drawing.Color.LightCyan;
            this.btnCrearCuentaIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCuentaIS.ForeColor = System.Drawing.Color.Black;
            this.btnCrearCuentaIS.Location = new System.Drawing.Point(238, 222);
            this.btnCrearCuentaIS.Name = "btnCrearCuentaIS";
            this.btnCrearCuentaIS.Size = new System.Drawing.Size(146, 28);
            this.btnCrearCuentaIS.TabIndex = 9;
            this.btnCrearCuentaIS.Text = "Crear Cuenta!";
            this.btnCrearCuentaIS.UseVisualStyleBackColor = false;
            this.btnCrearCuentaIS.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "¿No tienes una cuenta?";
            // 
            // btnLimpiarIS
            // 
            this.btnLimpiarIS.BackColor = System.Drawing.Color.Wheat;
            this.btnLimpiarIS.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiarIS.Location = new System.Drawing.Point(113, 147);
            this.btnLimpiarIS.Name = "btnLimpiarIS";
            this.btnLimpiarIS.Size = new System.Drawing.Size(96, 38);
            this.btnLimpiarIS.TabIndex = 6;
            this.btnLimpiarIS.Text = "Limpiar";
            this.btnLimpiarIS.UseVisualStyleBackColor = false;
            this.btnLimpiarIS.Click += new System.EventHandler(this.btnLimpiarIS_Click);
            // 
            // btnIngresarIS
            // 
            this.btnIngresarIS.BackColor = System.Drawing.Color.LightBlue;
            this.btnIngresarIS.ForeColor = System.Drawing.Color.Black;
            this.btnIngresarIS.Location = new System.Drawing.Point(363, 147);
            this.btnIngresarIS.Name = "btnIngresarIS";
            this.btnIngresarIS.Size = new System.Drawing.Size(96, 38);
            this.btnIngresarIS.TabIndex = 4;
            this.btnIngresarIS.Text = "Ingresar";
            this.btnIngresarIS.UseVisualStyleBackColor = false;
            this.btnIngresarIS.Click += new System.EventHandler(this.btnIngresarIS_Click);
            // 
            // txtPassPaCC
            // 
            this.txtPassPaCC.Location = new System.Drawing.Point(113, 103);
            this.txtPassPaCC.Name = "txtPassPaCC";
            this.txtPassPaCC.PasswordChar = '*';
            this.txtPassPaCC.Size = new System.Drawing.Size(375, 27);
            this.txtPassPaCC.TabIndex = 3;
            // 
            // txtUserPaCC
            // 
            this.txtUserPaCC.Location = new System.Drawing.Point(113, 38);
            this.txtUserPaCC.Name = "txtUserPaCC";
            this.txtUserPaCC.Size = new System.Drawing.Size(375, 27);
            this.txtUserPaCC.TabIndex = 2;
            this.txtUserPaCC.TextChanged += new System.EventHandler(this.txtUserPaCC_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Usuario:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(406, 527);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(68, 16);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // ChbDoctor
            // 
            this.ChbDoctor.AutoSize = true;
            this.ChbDoctor.Location = new System.Drawing.Point(406, 256);
            this.ChbDoctor.Name = "ChbDoctor";
            this.ChbDoctor.Size = new System.Drawing.Size(82, 24);
            this.ChbDoctor.TabIndex = 3;
            this.ChbDoctor.Text = "Doctor";
            this.ChbDoctor.UseVisualStyleBackColor = true;
            this.ChbDoctor.CheckedChanged += new System.EventHandler(this.ChbDoctor_CheckedChanged);
            // 
            // ChbUsuario
            // 
            this.ChbUsuario.AutoSize = true;
            this.ChbUsuario.Location = new System.Drawing.Point(286, 257);
            this.ChbUsuario.Name = "ChbUsuario";
            this.ChbUsuario.Size = new System.Drawing.Size(98, 24);
            this.ChbUsuario.TabIndex = 10;
            this.ChbUsuario.Text = "Usuarios";
            this.ChbUsuario.UseVisualStyleBackColor = true;
            this.ChbUsuario.CheckedChanged += new System.EventHandler(this.ChbUsuario_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Seleccione el correspondiente:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(588, 392);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpiarIS;
        private System.Windows.Forms.Button btnIngresarIS;
        private System.Windows.Forms.TextBox txtPassPaCC;
        private System.Windows.Forms.TextBox txtUserPaCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCrearCuentaIS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ChbUsuario;
        private System.Windows.Forms.CheckBox ChbDoctor;
    }
}