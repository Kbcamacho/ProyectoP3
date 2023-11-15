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
