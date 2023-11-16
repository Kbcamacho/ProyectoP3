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
using static Logica.LPacientes.L_Paciente;

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
            string username = txtUserPaCC.Text;
            string password = txtPassPaCC.Text;

            BusinessLayer businessLayer = new BusinessLayer();
            bool isAuthenticated = businessLayer.AuthenticateUser(username, password);

            if (isAuthenticated)
            {
                MessageBox.Show("Inicio de sesión exitoso.");
                Form btIngresar = new GestCitas();
                btIngresar.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Inicio de sesión fallido.");
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

        private void txtUserPaCC_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
