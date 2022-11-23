using System.Data;
//using System.Data.OracleClient;
using Oracle.ManagedDataAccess.Client;
using Oracle.DataAccess;
namespace Datos
{
    public class Conexion
    {
        OracleConnection conexion;
        public string ruta = "DATA SOURCE= LOCALHOST:1521/XEPDB1 ; PASSWORD = 1066268141 ; USER ID = leonardo";
        public Conexion()
        {
            conexion = new OracleConnection(ruta);
        }
        public void CerrarBd()
        {
            if (ConnectionState.Open==conexion.State)
            {
                conexion.Close();
            }
        }
        public void AbrirBD()
        {
            conexion.Open();
        }
        public OracleConnection Miconexion()
        {
            return conexion;
        }
    }
}
