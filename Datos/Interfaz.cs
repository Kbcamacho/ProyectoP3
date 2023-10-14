using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public interface ICrudRep<T> : ILecturaRep<T> where T : class
    {
        Task<Response<T>> GuardarAsync(T entity = null);
        Response<T> SobreescribirAsync(List<T> lista = null);
    }
    public interface ILecturaRep<T> where T : class
    {
        Task<Response<T>> LeerAsync();
    }
}
