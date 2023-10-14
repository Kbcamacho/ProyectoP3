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
        public DateTime FechaPago { get; set; }
        public double Monto { get; set; }

        public Pago()
        {
        }

        public Pago(string idPago, DateTime fechaPago, double monto)
        {
            IdPago = idPago;
            FechaPago = fechaPago;
            Monto = monto;
        }
    }
}
