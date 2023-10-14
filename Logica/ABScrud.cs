using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Logica
{
    public abstract class AbsCrud<T, idType> : ICrud<T, idType> where T : class, new()
    {
        protected new ICrudRep<T> Ar;

        public new async Task<Response<T>> ConsultarTask()
        {
            try
            {
                return await Ar.LeerAsync();
            }
            catch (Exception e)
            {
                return new Response<T>(e.Message, false);
            }
        }

        public async Task<Response<T>> GuardarTask(T entity)
        {
            var response = Validar(entity);
            try
            {
                if (response.Status) return await Ar.GuardarAsync(entity);

                return new Response<T>(response.Message, false);
            }
            catch (Exception e)
            {
                return new Response<T>(e.Message, false);
            }
        }

        public async Task<Response<T>> EliminarTask(idType id)
        {
            try
            {
                var response = await ConsultarTask();
                var lista = response.List;
                if (lista != null)
                {
                    var pos = Posicion(id);
                    lista.RemoveAt(pos);
                    return Ar.SobreescribirAsync(lista);
                }

                return new Response<T>("No hay registro", false);
            }
            catch (Exception e)
            {
                return new Response<T>(e.Message, false);
            }
        }
        public async Task<Response<T>> ConsultaFiltradaTask(string type)
        {
            try
            {
                return new Response<T>("OK", Filtro(type));
            }
            catch (Exception e)
            {
                return new Response<T>(e.Message, false);
            }
        }
        protected abstract List<T> Filtro(string type);
        public abstract Task<Response<T>> ActualizarTask(idType id, T entity);



        protected abstract Response<T> Validar(T entity);
        protected abstract int Posicion(idType id);
    }


}
