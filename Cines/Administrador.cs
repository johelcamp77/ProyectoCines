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
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }
        Conexion conexionBase = new Conexion();
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string sql;
            DataTable dt = new DataTable();
            sql = "select * from Administrador where administrador= '" + txtUsuario.Text + "' and contrasenaAdministrador= '" + txtPassword.Text + "'";
            conexionBase.abrirConexion();
            SqlDataAdapter sqla = new SqlDataAdapter(sql, conexionBase.sqlconn);
            sqla.Fill(dt);
            conexionBase.sqlconn.Close();
            try
            {
                MessageBox.Show("Usuario: " + Convert.ToString(dt.Rows[0][1]) + " correcto");
                VentanaAdministrador admin = new VentanaAdministrador();
                admin.Show();
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

