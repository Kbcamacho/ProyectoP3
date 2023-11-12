using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalAPP;

namespace HospitalAPP
{
    public class Cita
    {
        //public String Nombre { get; set; }
        //public String TipoIdent {  get; set; }
        //public int Identificacion {  get; set; }
        //public string FechaNaci { get; set; }
        //public String Sexo {  get; set; }
        //public int Celular { get; set; }
        //public String Direccion { get; set; }
        //public String Tipocita { get; set; }
        //public String FechaCita { get; set; }
        //public String Correo {  get; set; }

        //public Cita()
        //{

        //}

        //public Cita(string nombre, string tipoIdent, int identificacion, string fechaNaci, string sexo, int celular, string direccion, string tipocita, string fechaCita, string correo)
        //{
        //    Nombre = nombre;
        //    TipoIdent = tipoIdent;
        //    Identificacion = identificacion;
        //    FechaNaci = fechaNaci;
        //    Sexo = sexo;
        //    Celular = celular;
        //    Direccion = direccion;
        //    Tipocita = tipocita;
        //    FechaCita = fechaCita;
        //    Correo = correo;
        //}



        public String IdCita { get; set; }
        public Paciente Paciente { get; set; }
        public String MotivoCita { get; set; }
        public Doctor Doctor { get; set; }
        public DateTime FechaCita { get; set; }
        public String Especialidad { get; set; }
        public double Precio { get; set; }

        public Cita()
        {

        }

        public Cita(string idCita, Paciente paciente, string motivoCita, Doctor doctor, DateTime fechaCita, string especialidad, double precio)
        {
            IdCita = idCita;
            Paciente = paciente;
            MotivoCita = motivoCita;
            Doctor = doctor;
            FechaCita = fechaCita;
            Especialidad = especialidad;
            Precio = precio;
        }
    }
}
