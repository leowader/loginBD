using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
//using System.Data.OracleClient;
namespace Datos
{
    public class BaseDatos
    {
        string cadena = string.Format("DATA SOURCE= XEPDB1 ; PASSWORD = 1066268141 ; USER ID = leonardo");
        public OracleConnection conexion = new OracleConnection();
        public BaseDatos()
        {
            conexion.ConnectionString = "DATA SOURCE= localhost:1521/xepdb1 ; PASSWORD = 1066268141 ; USER ID = leonardo;";
        }
        public string abrir()
        {
            try
            {
                conexion.Open();
                return "SIUUUUU";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
