using Entidades;
using System;
//using System.Data.OracleClient;
using Oracle.ManagedDataAccess.Client;
namespace Datos
{
    public class RepositorioLogin: Conexion
    {
        OracleCommand command;
        OracleConnection connection;
        Datos.Conexion conexion = new Datos.Conexion();
        public string RegistrarUser(Usuario usuario)
        {
            try
            {
                AbrirBD();
                connection= Miconexion();
                command = new OracleCommand("crear_user", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("v_id", OracleDbType.Varchar2).Value = usuario.IdUser;
                command.Parameters.Add("v_nombre", OracleDbType.Varchar2).Value = usuario.UserName;
                command.Parameters.Add("v_clave", OracleDbType.Varchar2).Value = usuario.Password;
                command.ExecuteNonQuery();
                conexion.CerrarBd();
                return "usuario creado";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public string verificarUsuario(Usuario user)
        {
            try
            {
                AbrirBD();
                connection= Miconexion();
                command = new OracleCommand("SELECT * FROM LOGIN WHERE USUARIO_NAME =:usuario_name AND CLAVE_USER =: contra", connection);
                command.Parameters.Add(":usuario_name", user.UserName);
                command.Parameters.Add(":contra", user.Password);
                OracleDataReader raided = command.ExecuteReader();
                if (raided.Read())
                {
                    conexion.CerrarBd();
                    return "SI";
                }
                else
                {
                    return "NO";
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
