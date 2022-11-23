using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        Logica.ServicioLogin ServicioLogin = new Logica.ServicioLogin();
        public void conectarmeBD()
        {
            var user = new Usuario();
            user.UserName = txtUsuario.Text;
            user.Password = txtContraseña.Text;
            var respuesta = ServicioLogin.verificarUsuario(user);
            if (respuesta.Equals("SI"))
            {
                Prueba prueba = new Prueba();
                prueba.Show();
            }
            else
            {
                MessageBox.Show(respuesta.ToString());
            }
        }
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            conectarmeBD();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            registrar prueba = new registrar();
            this.Visible = false;
            prueba.Show();
   
        }
        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(Keys.Enter)))
            {
                this.Visible = false;
                conectarmeBD();
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
