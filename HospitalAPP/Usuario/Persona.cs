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
        public String Usuario { get; set; }
        public String Password {  get; set; }


        public Persona(String nombre, String cedula, String telefono, String direccion, String correoElectronico, String sexo, string usuario, string password)
        {
            Nombre = nombre;
            Cedula = cedula;
            Telefono = telefono;
            Direccion = direccion;
            CorreoElectronico = correoElectronico;
            Sexo = sexo;
            Usuario = usuario;
            Password = password;
        }
    }

    
}
