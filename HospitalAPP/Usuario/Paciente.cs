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

        public Paciente(String cedula, String password, String nombre, String apellido, String telefono, DateTime fechaNacimiento, String sexo, String correoElectronico, String tipoSangre) : base(cedula, password, nombre, apellido, telefono,
          fechaNacimiento, sexo, correoElectronico)
        {
            TipoSangre = tipoSangre;
        }
    }
}
