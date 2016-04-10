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
    public partial class MaquinaNuevaForm : Form
    {
        Conexion conexionBase = new Conexion();
        public MaquinaNuevaForm()
        {
            InitializeComponent();
            string sql;
            string sql2;
            DataTable dt = new DataTable();
            sql = "select nombrePelicula as 'Película'," +
                "idioma as Idioma, tipoSala as Sala," +
                "numeroSala as 'Sala número'," +
                "horario as 'Horario'," +
                " categoria as 'Categoría'," +
                "duracion as 'Duración' from Pelicula";
            


            conexionBase.abrirConexion();
            SqlDataAdapter sqla = new SqlDataAdapter(sql, conexionBase.sqlconn);
            sqla.Fill(dt);
            conexionBase.sqlconn.Close();
            dataGridView1.DataSource = dt;
            //Informacion 1
            string Nombre = dataGridView1.Rows[0].Cells[0].Value.ToString();
            string idioma = dataGridView1.Rows[0].Cells[1].Value.ToString();
            string Sala = dataGridView1.Rows[0].Cells[2].Value.ToString()+" "+
                          dataGridView1.Rows[0].Cells[3].Value.ToString();
            string Horario = dataGridView1.Rows[0].Cells[4].Value.ToString();
            string Categoria = dataGridView1.Rows[0].Cells[5].Value.ToString();

            Nombre1Lbl.Text = Nombre;
            Idioma1Lbl.Text = idioma;
            Sala1Lbl.Text = Sala;
            Horario1Lbl.Text = Horario;
            Categoria1Lbl.Text = Categoria;
            //Informacion 2
            Nombre = dataGridView1.Rows[1].Cells[0].Value.ToString();
             idioma = dataGridView1.Rows[1].Cells[1].Value.ToString();
             Sala = dataGridView1.Rows[1].Cells[2].Value.ToString() + " " +
                          dataGridView1.Rows[1].Cells[3].Value.ToString();
             Horario = dataGridView1.Rows[1].Cells[4].Value.ToString();
             Categoria = dataGridView1.Rows[1].Cells[5].Value.ToString();

            Nombre2Lbl.Text = Nombre;
            Idioma2Lbl.Text = idioma;
            Sala2Lbl.Text = Sala;
            Horario2Lbl.Text = Horario;
            Categoria2Lbl.Text = Categoria;
            //Informacion 3
            Nombre = dataGridView1.Rows[2].Cells[0].Value.ToString();
            idioma = dataGridView1.Rows[2].Cells[1].Value.ToString();
            Sala = dataGridView1.Rows[2].Cells[2].Value.ToString() + " " +
                         dataGridView1.Rows[2].Cells[3].Value.ToString();
            Horario = dataGridView1.Rows[2].Cells[4].Value.ToString();
            Categoria = dataGridView1.Rows[2].Cells[5].Value.ToString();

            Nombre3Lbl.Text = Nombre;
            Idioma3Lbl.Text = idioma;
            Sala3Lbl.Text = Sala;
            Horario3Lbl.Text = Horario;
            Categoria3Lbl.Text = Categoria;


        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void VolverBtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
