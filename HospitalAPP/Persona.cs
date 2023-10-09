using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAPP
{
    public class Persona
    {
        public Persona()
        {

        }

        public String Nombre { get; set; }
        public String Cedula { get; set; }
        public String Telefono { get; set; }
        public String Direccion { get; set; }
        public String CorreoElectronico { get; set; }
        public String Sexo { get; set; }

        public Persona(String nombre, String cedula, String telefono, String direccion, String correoElectronico, String sexo)
        {
            nombre = Nombre;
            cedula = Cedula;
            telefono = Telefono;
            direccion = Direccion;
            correoElectronico = CorreoElectronico;
            sexo = Sexo;
        }
    }

    
}
