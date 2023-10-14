using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using HospitalAPP;

namespace Datos
{
    public class CitaRepository : ABSRepositorio<Cita>
    {

        public CitaRepository()
        {
            Ruta = "Citas.txt";
        }
        
    }
}
