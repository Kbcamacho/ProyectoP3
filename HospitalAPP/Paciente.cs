using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalAPP;

namespace HospitalAPP
{
    public class Paciente : Persona
    {
        public String FechaCita { get; set; }
        public String MotivoCita { get; set; }
        public String HoraCita { get; set; }
        public String TipoSangre { get; set; }
        public double Deuda { get; set; }

        public Paciente()
        {

        }

        public Paciente(String nombre, String cedula, String telefono, String direccion, String correoElectronico,
            String sexo, String fechaCita, String motivoCita, String horaCita, String tipoSangre, double deuda) : base(
            nombre, cedula, telefono, direccion, correoElectronico, sexo)
        {
            FechaCita = fechaCita;
            MotivoCita = motivoCita;
            HoraCita = horaCita;
            TipoSangre = tipoSangre;
            Deuda = deuda;
        }
    }
}
