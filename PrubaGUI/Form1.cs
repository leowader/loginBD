using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PrubaGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnConectar_Click(object sender, EventArgs e)
        {
            //var respuesta= new Datos.BaseDatos().abrir();
            var respuesta = new Datos.BaseDatos().abrir();
            //respuesta.conexion.Open();
            MessageBox.Show(respuesta.ToString());
        }
    }
}
