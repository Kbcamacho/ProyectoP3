﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GUIPrinc
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnIngresarIS_Click(object sender, EventArgs e)
        {
            try
            {

                TextReader Inicio = new StreamReader(txtUserPaCC.Text + ".txt");

                if (Inicio.ReadLine() == txtPassPaCC.Text)
                {
                    Form btIngresar = new GestCitas();
                    btIngresar.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña incorrectos!", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Usuario y/o Contraseña incorrectos.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form btCrearCuenta = new LoginRegistrar();
            btCrearCuenta.Show();
            this.Hide();
        }

        private void btnLimpiarIS_Click(object sender, EventArgs e)
        {
            txtPassPaCC.Clear();
            txtUserPaCC.Clear();
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }
    }
}
