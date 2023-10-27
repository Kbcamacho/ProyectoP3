using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;

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

        }

        private void txtUserPaCC_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCrearPacCC_Click(object sender, EventArgs e)
        {         
            if (String.IsNullOrWhiteSpace(txtUserPaCC.Text) || String.IsNullOrWhiteSpace(txtPassPaCC.Text)
                || String.IsNullOrWhiteSpace(txtNombrePaCC.Text) || String.IsNullOrWhiteSpace(txtIdenPaCC.Text)
                || String.IsNullOrWhiteSpace(txtNumPaCC.Text) || String.IsNullOrWhiteSpace(txtEdadPaCC.Text)
                || String.IsNullOrWhiteSpace(txtCorreoPaCC.Text) || cmbGeneroPaCC.SelectedIndex == -1
                || cmbTipoIdenPaCC.SelectedIndex == -1 )
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                   
                    TextWriter RegistrarUser = new StreamWriter(txtUserPaCC.Text + ".txt", true);
                    RegistrarUser.WriteLine(txtPassPaCC.Text);
                    RegistrarUser.WriteLine(txtNombrePaCC.Text);
                    RegistrarUser.WriteLine(txtIdenPaCC.Text);
                    RegistrarUser.WriteLine(txtNumPaCC.Text);
                    RegistrarUser.WriteLine(txtEdadPaCC.Text);
                    RegistrarUser.WriteLine(cmbGeneroPaCC.Text);
                    RegistrarUser.WriteLine(txtCorreoPaCC.Text);
                    RegistrarUser.Close();

                    MessageBox.Show("El Usuario fue registrado con Exito", "Verificado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtUserPaCC.Clear();
                    txtPassPaCC.Clear();
                    txtNombrePaCC.Clear();
                    txtIdenPaCC.Clear();
                    txtNumPaCC.Clear();
                    txtCorreoPaCC.Clear();
                    txtEdadPaCC.Clear();
                    cmbGeneroPaCC.SelectedIndex = -1;
                    cmbTipoIdenPaCC.SelectedIndex = -1;
                }
                catch
                {
                    MessageBox.Show("No se pudo registrar al usuario", "ERROR", MessageBoxButtons.OKCancel);
                }
            }
        }

        private void txtPassPaCC_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiarCD_Click(object sender, EventArgs e)
        {
        }

        private void btnLimpiarCP_Click(object sender, EventArgs e)
        {
            txtUserPaCC.Clear();
            txtPassPaCC.Clear();
            txtNombrePaCC.Clear();
            txtIdenPaCC.Clear();
            txtNumPaCC.Clear();
            txtCorreoPaCC.Clear();
            txtEdadPaCC.Clear();
            cmbGeneroPaCC.SelectedIndex = -1;
            cmbTipoIdenPaCC.SelectedIndex = -1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUserPaCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void txtPassPaCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void txtNombrePaCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtIdenPaCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtNumPaCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtEdadPaCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtCorreoPaCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
