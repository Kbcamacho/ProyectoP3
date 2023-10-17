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
            try
            {
                TextWriter RegistrarDoctor = new StreamWriter(@"C:\Users\User\OneDrive\Escritorio\P3\HospitalAPP\bin\Debug\" + txtUserCC.Text + ".txt", true);
                RegistrarDoctor.WriteLine(txtPassCC.Text);
                RegistrarDoctor.Close();

                MessageBox.Show("El Doctor fue registrado");
            }
            catch (Exception x)
            {
                MessageBox.Show("Hubo un Error" + x, "Error");
            }
            
        }

        private void txtUserPaCC_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCrearPacCC_Click(object sender, EventArgs e)
        {
            try
            {
                TextWriter RegistrarPaciente = new StreamWriter(@"C:\Users\User\OneDrive\Escritorio\P3\HospitalAPP\bin\Debug\" + txtUserPaCC, true);
                RegistrarPaciente.WriteLine(txtPassPaCC.Text);
                RegistrarPaciente.Close();

                MessageBox.Show("El Paciente fue registrado");
            }
            catch (Exception z)
            {
                MessageBox.Show("ERROR");
            }
        }

        private void txtPassPaCC_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiarCD_Click(object sender, EventArgs e)
        {
            txtUserCC.Clear();
            txtPassCC.Clear();
            txtIdenCC.Clear();
            txtNumCC.Clear();
            txtCorreoCC.Clear();
            txtEdadCC.Clear();
            cmbEspeCC.Items.Clear();
        }

        private void btnLimpiarCP_Click(object sender, EventArgs e)
        {
            txtUserPaCC.Clear();
            txtPassPaCC.Clear();
            txtIdenPaCC.Clear();
            txtNumPaCC.Clear();
            txtCorreoPaCC.Clear();
            txtEdadPaCC.Clear();
            cmbGeneroPaCC.Items.Clear();
        }
    }
}
