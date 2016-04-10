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
    public partial class Cartelera3 : Form
    {
        Conexion conexionBase = new Conexion();
        public Cartelera3()
        {
            InitializeComponent();
            string sql;
            DataTable dt = new DataTable();
            sql = "select nombrePelicula as 'Película', idioma as Idioma\n, tipoSala as Sala, numeroSala as 'Sala número', horario as 'Horario'," +
                " categoria as 'Categoría', duracion as 'Duración' from Pelicula where tipoSala = '3D'";
            conexionBase.abrirConexion();
            SqlDataAdapter sqla = new SqlDataAdapter(sql, conexionBase.sqlconn);
            sqla.Fill(dt);
            conexionBase.sqlconn.Close();
            dataGridView1.DataSource = dt;
           
           string Nombre = dataGridView1.Rows[0].Cells[0].Value.ToString();
            string idioma = dataGridView1.Rows[0].Cells[1].Value.ToString();
            string Sala = dataGridView1.Rows[0].Cells[3].Value.ToString();              
            string Horario = dataGridView1.Rows[0].Cells[4].Value.ToString();
            string Categoria = dataGridView1.Rows[0].Cells[5].Value.ToString();

            NombreLbl.Text = Nombre;
            IdiomaLbl.Text = idioma;
            SalaLbl.Text = Sala;
            HorarioLbl.Text = Horario;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cartelera3_Load(object sender, EventArgs e)
        {

        }
    }
}
