using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Datos
{
    public class Response<T> where T : class
    {
        public Response(string message = "", T entity = null, bool status = true, List<T> list = null)
        {
            Message = message;
            Status = status;
            Entity = entity;
            List = list;
        }

        public Response(string message = "", List<T> list = null, bool status = true, T entity = null)
        {
            Message = message;
            Status = status;
            Entity = entity;
            List = list;
        }

        public Response(string message = "", bool status = true, List<T> list = null, T entity = null)
        {
            Message = message;
            Status = status;
            Entity = entity;
            List = list;
        }

        public Response(bool status = true, string message = "", List<T> list = null, T entity = null)
        {
            Message = message;
            Status = status;
            Entity = entity;
            List = list;
        }

        public string Message { get; set; }
        public bool Status { get; set; }
        public T Entity { get; set; }
        public List<T> List { get; set; }
    }
}
