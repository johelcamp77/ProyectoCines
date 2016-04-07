using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Cines
{
    public partial class PuntoVenta : Form
    {
        Conexion conexionBase = new Conexion();
        public PuntoVenta()
        {
            InitializeComponent();
        }

        private void PuntoVenta_Load(object sender, EventArgs e)
        {
            string sql;
            DataTable dt = new DataTable();
            sql = "select * from Pelicula";
            conexionBase.abrirConexion();
            SqlDataAdapter sqla = new SqlDataAdapter(sql, conexionBase.sqlconn);
            sqla.Fill(dt);
            conexionBase.sqlconn.Close();
            comboPelicula.DataSource = dt;
            comboPelicula.DisplayMember = "nombrePelicula";
            comboPelicula.ValueMember = "nombrePelicula".ToString();
            comboPelicula.SelectedIndex = 0;

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboPelicula_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string sql;
            DataTable dt = new DataTable();
            sql ="select * from Pelicula where nombrePelicula= '"+Convert.ToString(comboPelicula.SelectedValue)+"'";
            MessageBox.Show(sql);
            conexionBase.abrirConexion();
            SqlDataAdapter sqla = new SqlDataAdapter(sql, conexionBase.sqlconn);
            sqla.Fill(dt);
            conexionBase.sqlconn.Close();
            comboIdioma.DataSource = dt;
            comboIdioma.DisplayMember = "idioma";
            comboIdioma.SelectedIndex = 0;

            comboSala.DataSource = dt;
            comboSala.DisplayMember = "tipoSala";
            comboSala.SelectedIndex = 0;

            comboSalaNumero.DataSource = dt;
            comboSalaNumero.DisplayMember = "numeroSala";
            comboSalaNumero.SelectedIndex = 0;

            comboHorario.DataSource = dt;
            comboHorario.DisplayMember = "horario";
            comboHorario.SelectedIndex = 0;

            comboCategoria.DataSource = dt;
            comboCategoria.DisplayMember = "categoria";
            comboCategoria.SelectedIndex = 0;

            comboDuracion.DataSource = dt;
            comboDuracion.DisplayMember = "duracion";
            comboDuracion.SelectedIndex = 0;


        }
    }
}
