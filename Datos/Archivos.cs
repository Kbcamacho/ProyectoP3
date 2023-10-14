using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Datos
{
    public class Archivos
    {
        protected String Filename;
        public Archivos(string filename)
        {
            this.Filename = filename;
        }

        public String Guardar(String Datos)
        {
            try
            {
                StreamWriter writer = new StreamWriter(Filename, true);
                writer.WriteLine(Datos);
                writer.Close();
                return "Datos guardados correctamente";
            }
            catch (Exception e)
            {
                return "Error al guardar los datos: ";
            }
            

        } 
    }
}
