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
        public String IdPaciente { get; set; }
        public String IdDoctor { get; set; }
        public String FechaCita { get; set; }
        public String HoraCita { get; set; }
        public String TipoCita { get; set; }

        public Cita()
        {

        }

        public Cita(String idCita, String idPaciente, String idDoctor, String fechaCita, String horaCita,
            String tipoCita)
        {
            IdCita = idCita;
            IdPaciente = idPaciente;
            IdDoctor = idDoctor;
            FechaCita = fechaCita;
            HoraCita = horaCita;
            TipoCita = tipoCita;
        }
    }
}
