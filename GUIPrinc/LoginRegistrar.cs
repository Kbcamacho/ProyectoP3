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
    public partial class LoginRegistrar : Form
    {
        public LoginRegistrar()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnVolverCC_Click(object sender, EventArgs e)
        {
            Form btVolverLR = new Login();
            btVolverLR.Show();
            this.Close();
        }

        private void btnCrearDocCC_Click(object sender, EventArgs e)
        {
            StreamWriter escribir = new StreamWriter(@"C:\Users\User\OneDrive\Escritorio\Proyecto P3\ProyectoP3\ArchivosDoc.txt", true);
            try
            {
                escribir.WriteLine("Usuario: " + txtUserCC.Text);
                escribir.WriteLine("Password: " + txtPassCC.Text);
                escribir.WriteLine("Identificación: " + txtIdenCC.Text);
                escribir.WriteLine("Numero Celular: " + txtNumCC.Text);
                escribir.WriteLine("Correo: " + txtCorreoCC.Text);
                escribir.WriteLine("Edad: " + txtEdadCC.Text);
                escribir.WriteLine("Especialidad: " + cmbEspeCC.Text);
                escribir.WriteLine("\n");
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
            escribir.Close();
            
            txtUserCC.Clear();
            txtPassCC.Clear();
            txtIdenCC.Clear();
            txtNumCC.Clear();
            txtCorreoCC.Clear();
            txtEdadCC.Clear();
            cmbEspeCC.Items.Clear();

            Form btCrearDoc = new Principal();
            btCrearDoc.Show();
            this.Close();

        }

        private void txtUserPaCC_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCrearPacCC_Click(object sender, EventArgs e)
        {
            StreamWriter escribir = new StreamWriter(@"C:\Users\User\OneDrive\Escritorio\Proyecto P3\ProyectoP3\ArchivosPac.txt", true);
            try
            {
                escribir.WriteLine("Usuario: " + txtUserPaCC.Text);
                escribir.WriteLine("Password: " + txtPassPaCC.Text);
                escribir.WriteLine("Identificación: " + txtIdenPaCC.Text);
                escribir.WriteLine("Numero Celular: " + txtNumPaCC.Text);
                escribir.WriteLine("Correo: " + txtCorreoPaCC.Text);
                escribir.WriteLine("Edad: " + txtEdadPaCC.Text);
                escribir.WriteLine("Genero: " + cmbGeneroPaCC.Text);
                escribir.WriteLine("\n");
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
            escribir.Close();

            txtUserPaCC.Clear();
            txtPassPaCC.Clear();
            txtIdenPaCC.Clear();
            txtNumPaCC.Clear();
            txtCorreoPaCC.Clear();
            txtEdadPaCC.Clear();
            cmbGeneroPaCC.Items.Clear();

            Form btCrearPac = new Principal();
            btCrearPac.Show();
            this.Close();

        }

        private void txtPassPaCC_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
