using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalAPP;
using Logica.LPacientes;

namespace GUIPrinc
{
    public partial class GrillUsuario : Form
    {
        public GrillUsuario()
        {
            InitializeComponent();
        }
        private void Mostrar(string cTexto)
        {
            try
            {

                Grillausuarios.DataSource = L_Paciente.Mostrar(cTexto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnVolverCC_Click(object sender, EventArgs e)
        {

        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

<<<<<<< HEAD
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
=======
        private void GrillUsuario_Load(object sender, EventArgs e)
        {
            

        }

        private void GrillUsuario_Load_1(object sender, EventArgs e)
        {
            Mostrar("%");
        }

        private void BtnModificar_Click(object sender, EventArgs e)
>>>>>>> 94aa99c875e1318a81a94c923097ce6c138c37c4
        {

        }
    }
}
