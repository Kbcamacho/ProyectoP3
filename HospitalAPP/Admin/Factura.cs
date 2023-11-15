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
        public double Precio { get; set; } 
        public double Descuento { get; set; }
        public Cita Cita { get; set; } = new Cita();

        public Factura()
        {
        }

        public Factura(string idFactura, double precio, double descuento, Cita cita)
        {
            IdFactura = idFactura;
            Descuento = descuento;
            Precio = GetDescuento(); 
        }

        public double GetDescuento()
        {
            return Cita.Precio - (Cita.Precio * Descuento);
        }
    }
}
