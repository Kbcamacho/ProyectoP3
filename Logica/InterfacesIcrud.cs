using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface ICrud<T, in TIdType> : ILectura<T> where T : class
    {
        Task<Response<T>> GuardarTask(T entity);
        Task<Response<T>> EliminarTask(TIdType id);
        Task<Response<T>> ActualizarTask(TIdType id, T entity);
    }
    public interface ILectura<T> where T : class
    {
        Task<Response<T>> ConsultarTask();
    }
}
