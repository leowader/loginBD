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
    public partial class registrar : Form
    {
        public registrar()
        {
            InitializeComponent();
        }
        Login milog =new Login();
        OracleConnection conexion = new OracleConnection("DATA SOURCE= XEPDB1 ; PASSWORD = 1066268141 ; USER ID = leonardo");
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            registrarUsuario();
        }
        void registrarUsuario()
        {
            try
            {
                conexion.Open();
                OracleCommand command = new OracleCommand("crear_user", conexion);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("v_id", OracleType.VarChar).Value = txtId.Text;
                command.Parameters.Add("v_nombre", OracleType.VarChar).Value = txtUsuario.Text;
                command.Parameters.Add("v_clave", OracleType.VarChar).Value = txtContraseña.Text;
                command.ExecuteNonQuery();
                MessageBox.Show("USUARIO CREADO");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            conexion.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Visible = false;
            login.Show();
        }
    }
}
