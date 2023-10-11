using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalAPP;

namespace HospitalAPP
{
    public class Factura : Cita
    {
        public String IdFactura { get; set; }
        public String Servicio { get; set; }
        public double Precio { get; set; }

        public Factura()
        {
        }

        public Factura(String idFactura, String servicio, double precio, String idCita, String idPaciente,
                       String idDoctor, String fechaCita, String horaCita, String tipoCita) : base(idCita, idPaciente, idDoctor,
                       fechaCita, horaCita, tipoCita)
        {
            IdFactura = idFactura;
            Servicio = servicio;
            Precio = precio;
        }
    }
}
