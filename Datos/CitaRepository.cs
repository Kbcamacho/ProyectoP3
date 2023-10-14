using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using HospitalAPP;

namespace Datos
{
    public class CitaRepository : Archivos
    {
        public CitaRepository(string FileName) : base(FileName)
        {
        }

        public List<Cita> ConsultaCitas()
        {
            try
            {
                List<Cita> listaCitas = new List<Cita>();

                StreamReader reader = new StreamReader(FileName);
                while (!reader.EndOfStream)
                {
                    lista.add(new Mapear(reader.ReadLine()));
                }
                reader.Close();
                return lista;
            }
            catch (Exception a)
            {
                Console.WriteLine(a);
                throw;
            }
            return null;
        }

        public Cita BuscarcCita(String id)
        {
            var lista = ConsultaCitas();
            foreach (var item in lista)
            {
                if (item.IdCita == id)
                {
                    return item;
                }
            }
            return null;
        }

        private Cita Mapear(String linea)
        {
            var datos = linea.Split(';');
            Cita cita = new Cita();
            cita.IdCita = datos[0];
            cita.IdPaciente = datos[1];
            cita.IdMedico = datos[2];
            cita.Fecha = datos[3];
            cita.Hora = datos[4];
            cita.Estado = datos[5];
            return cita;
        }
    }
}
