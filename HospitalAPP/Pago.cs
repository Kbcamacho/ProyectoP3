using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalAPP;

namespace HospitalAPP
{
    public class Pago : Factura
    {
        public String IdPago { get; set; }
        public String FechaPago { get; set; }
        public String HoraPago { get; set; }
        public double Monto { get; set; }

        public Pago()
        {
        }

        public Pago(String idPago, String fechaPago, String horaPago, double monto, String idFactura, String servicio,
            double precio, String idCita, String idPaciente,
            String idDoctor, String fechaCita, String horaCita, String tipoCita) : base(idFactura, servicio, precio,
            idCita, idPaciente, idDoctor,
            fechaCita, horaCita, tipoCita)
        {
            IdPago = idPago;
            FechaPago = fechaPago;
            HoraPago = horaPago;
            Monto = monto;
        }
    }
}
