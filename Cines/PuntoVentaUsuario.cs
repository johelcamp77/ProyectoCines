using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Cines
{
    public partial class PuntoVentaUsuario : Form
    {
        Conexion conexionBase = new Conexion();
        public PuntoVentaUsuario()
        {
            InitializeComponent();
            //txtPassword.Text = "";
            // The password character is an asterisk.
            txtPassword.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql;
            DataTable dt = new DataTable();
            sql = "select * from Empleado where nombreUsuarioEmpleado= '" + txtUsuario.Text + "' and contrasenaUsuarioEmpleado= '" + txtPassword.Text + "'";
            conexionBase.abrirConexion();
            SqlDataAdapter sqla = new SqlDataAdapter(sql, conexionBase.sqlconn);
            sqla.Fill(dt);
            conexionBase.sqlconn.Close();
            try
            {
                MessageBox.Show("Usuario: "+Convert.ToString(dt.Rows[0][1])+" correcto");
                PuntoVenta puntoVenta = new PuntoVenta();
                puntoVenta.Show();
                this.Dispose();

            }
            catch { MessageBox.Show("Usuario/Contraseña incorrecto"); }
        }

        private void VolverBtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
