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
    public partial class Cartelera1 : Form
    {
        Conexion conexionBase = new Conexion();
        public Cartelera1()
        {
            InitializeComponent();
            string sql;
            DataTable dt = new DataTable();
            sql = "select nombrePelicula as 'Película', idioma as Idioma, tipoSala as Sala, numeroSala as 'Sala número', horario as 'Horario',"+
                " categoria as 'Categoría', duracion as 'Duración' from Pelicula where tipoSala = 'Sencilla'";
            conexionBase.abrirConexion();
            SqlDataAdapter sqla = new SqlDataAdapter(sql, conexionBase.sqlconn);
            sqla.Fill(dt);
            conexionBase.sqlconn.Close();
            dataGridView1.DataSource = dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cartelera1_Load(object sender, EventArgs e)
        {

        }
    }
}
