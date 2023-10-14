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
        public String TipoSangre { get; set; }

        public Paciente()
        {

        }

        public Paciente(String nombre, String cedula, String telefono, String direccion, String correoElectronico,
            String sexo, String tipoSangre) : base(nombre, cedula, telefono, direccion, correoElectronico, sexo)
        {
            TipoSangre = tipoSangre;
        }
    }
}
