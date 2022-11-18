using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
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
        OracleConnection conexion = new OracleConnection("DATA SOURCE= XEPDB1 ; PASSWORD = 1066268141 ; USER ID = leonardo");
        public void conectarmeBD()
        {
            conexion.Open();
            OracleCommand command = new OracleCommand("SELECT * FROM LOGIN WHERE USUARIO_NAME =:usuario_name AND CLAVE_USER =: contra",conexion);
            command.Parameters.AddWithValue(":usuario_name",txtUsuario.Text);
            command.Parameters.AddWithValue(":contra", txtContraseña.Text);
            OracleDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Prueba prueba = new Prueba();
                conexion.Close();
                prueba.Show();
            }
            else
            {
                MessageBox.Show("CONTRASEÑA INCORRECTA");
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
    }
}
