using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace Datos
{
    public abstract class ABSRepositorio<T> where T : class
    {
        protected string Ruta;

        public async Task<Response<T>> LeerAsync()
        {
            try
            {
                using (var sr = new StreamReader(Ruta))
                {
                    var list = new List<T>();
                    string jsonLine;

                    while ((jsonLine = sr.ReadLine()) != null)
                    {
                        var item = JsonSerializer.Deserialize<T>(jsonLine);
                        list.Add(item);
                    }

                    return new Response<T>("OK", list);
                }
            }
            catch (System.Text.Json.JsonException ex)
            {
                return new Response<T>($"Error al deserializar JSON: {ex.Message}", false);
            }
            catch (Exception e)
            {
                return new Response<T>(e.Message, false);
            }
        }

        public Task<Response<T>> GuardarAsync(T entity = null)
        {
            try
            {
                var jsonSerial = JsonConvert.SerializeObject(entity);
                using (var wr = new StreamWriter(Ruta, true))
                {
                    wr.WriteLine(jsonSerial);
                    wr.Close();
                }

                return Task.FromResult(new Response<T>("Exito", entity));
            }
            catch (Exception e)
            {
                return Task.FromResult(new Response<T>(e.Message, entity, false));
            }
        }


        public Response<T> SobreescribirAsync(List<T> lista = null)
        {
            try
            {
                if (lista == null || lista.Count == 0)
                    File.Delete(Ruta);
                else
                {
                    using var sw = new StreamWriter(Ruta);
                    foreach (var item in lista)
                    {
                        var jsonSerial = JsonConvert.SerializeObject(item);
                        sw.WriteLine(jsonSerial);
                    }

                    sw.Close();
                }

                return new Response<T>("Exito", lista);
            }
            catch (Exception e)
            {
                return new Response<T>(e.Message, lista, false);
            }
        }

       
        
    }
}
