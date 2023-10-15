using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
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
            btnProgramarCita.Enabled = false;
        }

        private void btnProgramarCita_Click(object sender, EventArgs e)
        {
            Cita cita = new();
            cita.IdCita = 10000.ToString();
            
        }
    }
}
