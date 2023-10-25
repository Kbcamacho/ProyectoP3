﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalAPP;

namespace GUIPrinc
{
    public partial class ProgramCita : Form
    {
        public ProgramCita()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form btVolver = new GestCitas();
            btVolver.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ProgramCita_Load(object sender, EventArgs e)
        {
            
        }

        private void btnProgramarCita_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(txtNombre.Text) || String.IsNullOrWhiteSpace(txtIdent.Text) || String.IsNullOrWhiteSpace(txtNumCel.Text)
                || String.IsNullOrWhiteSpace(txtDireccion.Text) || cmbTipoIdent.SelectedIndex == -1 || cmbGenero.SelectedIndex == -1
                || cmbTipoCita.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                StreamWriter escribir = new StreamWriter(@"C:\Users\User\OneDrive\Escritorio\P3\ArchivosCitas.txt", true);
                try
                {
                    escribir.WriteLine("Nom. Paciente: " + txtNombre.Text);
                    escribir.WriteLine("Tipo Ident: " + cmbTipoIdent.Text);
                    escribir.WriteLine("Identificación: " + txtIdent.Text);
                    escribir.WriteLine("Genero: " + cmbGenero.Text);
                    escribir.WriteLine("Celular: " + txtNumCel.Text);
                    escribir.WriteLine("Dirección: " + txtDireccion.Text);
                    escribir.WriteLine("Tipo de Cita: " + cmbTipoCita.Text);
                    escribir.WriteLine("\n");
                }
                catch
                {
                    MessageBox.Show("ERROR");
                }
                escribir.Close();

                txtNombre.Clear();
                cmbTipoIdent.Items.Clear();
                txtIdent.Clear();
                cmbGenero.Items.Clear();
                txtNumCel.Clear();
                txtDireccion.Clear();
                cmbTipoCita.Items.Clear();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiarPC_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            cmbTipoIdent.Items.Clear();
            txtIdent.Clear();
            cmbGenero.Items.Clear();
            txtNumCel.Clear();
            txtDireccion.Clear();
            cmbTipoCita.Items.Clear();

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back) 
            {
                e.Handled = true;
            }
        }

        private void txtIdent_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtNumCel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumCel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
