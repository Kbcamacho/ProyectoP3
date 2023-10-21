using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalAPP;

namespace HospitalAPP
{
    public class Doctor : Persona
    {
        public String Especialidad { get; set; }
        public bool Disponibilidad { get; set; }

        public Doctor()
        {

        }

        public Doctor(String nombre, String cedula, String telefono, String direccion, String correoElectronico,
            String sexo, String especialidad, String usuario, String password, bool disponibilidad) : base(nombre, cedula, telefono, direccion,
            correoElectronico, sexo, usuario, password)
        {
            Especialidad = especialidad;
            Disponibilidad = disponibilidad;
        }
    }
}
