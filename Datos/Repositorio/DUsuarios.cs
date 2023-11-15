using HospitalAPP;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DUsuarios
    {
        int IdUsuario; 

        public DataTable Mostrar(string cTexto)
        {
            OracleDataReader Resultado;
            DataTable Tabla = new DataTable();
            OracleConnection SqlCon = new OracleConnection();
            try
            {
                cTexto = "%" + cTexto + "%"; 
                SqlCon = ConexionBD.GetInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("select * from VISTA_PACIENTE where ID_PACIENTE like '" + cTexto + "' ", SqlCon);
                Comando.CommandType = CommandType.Text;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

        }

        //public string Guardar(Paciente oPa)
        //{
        //    string Rpta = "";
        //    OracleConnection SqlCon = new OracleConnection();
        //    try
        //    {
        //        SqlCon = ConexionBD.GetInstancia().CrearConexion();
        //        OracleCommand Comando = new OracleCommand("PRC_GUARDAR_P", SqlCon);
        //        Comando.CommandType = CommandType.StoredProcedure;
        //        Comando.Parameters.Add("pCedula", OracleDbType.Int32).Value = oPa.Id;
        //        Comando.Parameters.Add("pNombre", OracleDbType.Varchar2).Value = oPa.Nombre;
        //        Comando.Parameters.Add("pApellido", OracleDbType.Varchar2).Value = oPa.Apellido;
        //        Comando.Parameters.Add("pTelefono", OracleDbType.Varchar2).Value = oPa.Telefono;
        //        Comando.Parameters.Add("pCorreo", OracleDbType.Varchar2).Value = oPa.Correo;
        //        SqlCon.Open();
        //        Comando.ExecuteNonQuery();
        //        Rpta = "OK";


        //    }
        //    catch (Exception ex)
        //    {

        //        Rpta = ex.Message;
        //    }
        //    finally
        //    {
        //        if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
        //    }
        //    return Rpta;
        //}
    }
}
