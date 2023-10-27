using System;
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
                try
                {

                    TextWriter RegistrarUser = new StreamWriter("CITAS.txt", true);
                    RegistrarUser.WriteLine("Nombre: " + txtNombre.Text);
                    RegistrarUser.WriteLine("Tipo Ident: " + cmbTipoIdent.Text);
                    RegistrarUser.WriteLine("Identificación: " + txtIdent.Text);
                    RegistrarUser.WriteLine("Genero: " + cmbGenero.Text);
                    RegistrarUser.WriteLine("Celular: " + txtNumCel.Text);
                    RegistrarUser.WriteLine("Dirección: " + txtDireccion.Text);
                    RegistrarUser.WriteLine("Tipo de Cita: " + cmbTipoCita.Text);
                    RegistrarUser.WriteLine("\n");
                    RegistrarUser.Close();

                    MessageBox.Show("La cita fue agendadad con exito", "Verificado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtNombre.Clear();
                    cmbGenero.SelectedIndex = -1;
                    txtIdent.Clear();
                    cmbGenero.SelectedIndex = -1;
                    txtNumCel.Clear();
                    txtDireccion.Clear();
                    cmbTipoCita.SelectedIndex = -1;
                }
                catch
                {
                    MessageBox.Show("No se pudo agendar la cita", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

                Form btProgram = new GestCitas();
                btProgram.Show();
                this.Hide();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiarPC_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            cmbTipoIdent.SelectedIndex = -1;
            txtIdent.Clear();
            cmbGenero.SelectedIndex = -1;
            txtNumCel.Clear();
            txtDireccion.Clear();
            cmbTipoCita.SelectedIndex =1;

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
