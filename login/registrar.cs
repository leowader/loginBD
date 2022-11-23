using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class registrar : Form
    {
        public registrar()
        {
            InitializeComponent();
        }
        Login milog =new Login();
        Logica.ServicioLogin ServicioLogin = new Logica.ServicioLogin();
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            registrarUsuario();
        }
        void registrarUsuario()
        {
            try
            {
                var User = new Usuario();
                User.UserName = txtUsuario.Text;
                User.IdUser = txtId.Text;
                User.Password = txtContraseña.Text;
                var estado=ServicioLogin.RegistrarUser(User);
                MessageBox.Show(estado.ToString ());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Visible = false;
            login.Show();
        }
    }
}
