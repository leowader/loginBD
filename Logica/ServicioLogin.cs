using System;
using Entidades;
using Datos;
namespace Logica
{
    public class ServicioLogin
    {
        RepositorioLogin repositorioLogin = new RepositorioLogin();
        Conexion conexion = new Conexion();
        public string RegistrarUser(Usuario usuario)
        {
            try
            {
                var estado = repositorioLogin.RegistrarUser(usuario);
                return estado;
            }
            catch (Exception e )
            {

                return e.Message;
            }
        }
        public string verificarUsuario(Usuario user)
        {
            try
            {
                var estado=repositorioLogin.verificarUsuario(user);
                return estado;
            }
            catch (Exception e )
            {
                return e.Message;
            }
        }
    }
}
