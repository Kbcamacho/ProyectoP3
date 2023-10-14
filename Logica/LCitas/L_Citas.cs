using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using HospitalAPP;

namespace Logica.LCitas
{
    public class L_Citas : AbsCrud<Cita, String>
    {
        protected override List<Cita> Filtro(string type)
        {
            try
            {
                return ConsultarTask().Result.List.FindAll(c => c.IdCita.StartsWith(type));
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public override Task<Response<Cita>> ActualizarTask(string id, Cita entity)
        {
            throw new NotImplementedException();
        }

        protected override Response<Cita> Validar(Cita entity)
        {
            return new Response<Cita>( "Validado",true, null, entity);
        }

        protected override int Posicion(string id)
        {
            return ConsultarTask().Result.List.FindIndex(c => c.IdCita.Equals(id));
        }
    }
}
