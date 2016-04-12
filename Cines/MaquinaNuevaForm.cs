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
        public static string Cartel4;
        Conexion conexionBase = new Conexion();
        public static int Cartel=0;
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
            String[,] Capturar = new String[4, 7];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Capturar[i, j] = "";
                }
            }

            for (int r = 0; r < dataGridView1.RowCount - 1; r++)
            {
                for (int c = 0; c < dataGridView1.ColumnCount; c++)
                {

                    Capturar[r, c] = dataGridView1.Rows[r].Cells[c].Value.ToString();
                }
            }


            //Informacion 1

            string Nombre = Capturar[0, 0];
            string idioma = Capturar[0, 1];
            string Sala = Capturar[0, 2] + " " + Capturar[0, 3];
            string Horario = Capturar[0, 4];
            string Categoria = Capturar[0, 5];
            Nombre1Lbl.Text = Nombre;
            Idioma1Lbl.Text = idioma;
            Sala1Lbl.Text = Sala;
            Horario1Lbl.Text = Horario;
            Categoria1Lbl.Text = Categoria;
            //Informacion 2
            Nombre = Capturar[1, 0];
            idioma = Capturar[1, 1];
            Sala = Capturar[1, 2] + " " + Capturar[1, 3];
            Horario = Capturar[1, 4];
            Categoria = Capturar[1, 5];

            Nombre2Lbl.Text = Nombre;
            Idioma2Lbl.Text = idioma;
            Sala2Lbl.Text = Sala;
            Horario2Lbl.Text = Horario;
            Categoria2Lbl.Text = Categoria;
            //Informacion 3
            Nombre = Capturar[2, 0];
            idioma = Capturar[2, 1];
            Sala = Capturar[2, 2] + " " + Capturar[2, 3];
            Horario = Capturar[2, 4];
            Categoria = Capturar[2, 5];

            Nombre3Lbl.Text = Nombre;
            Idioma3Lbl.Text = idioma;
            Sala3Lbl.Text = Sala;
            Horario3Lbl.Text = Horario;
            Categoria3Lbl.Text = Categoria;
            //Informacion 4
            Nombre = Capturar[3, 0];
            idioma = Capturar[3, 1];
            Sala = Capturar[3, 2] + " " + Capturar[3, 3];
            Horario = Capturar[3, 4];
            Categoria = Capturar[3, 5];

            Nombre4Lbl.Text = Nombre;
            Idioma4Lbl.Text = idioma;
            Sala4Lbl.Text = Sala;
            Horario4Lbl.Text = Horario;
            Categoria4Lbl.Text = Categoria;
            Cartel4 = Capturar[3, 2];

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void VolverBtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Cartel1Btn_Click(object sender, EventArgs e)
        {
            Cartel = 1;
            AsientosMaquinaNuevaIMAX Sala = new AsientosMaquinaNuevaIMAX();
            Sala.Show();
            

        }

        private void Cartel2Btn_Click(object sender, EventArgs e)
        {
            Cartel = 2;
            AsientosMaquinaNuevaIMAX Sala = new AsientosMaquinaNuevaIMAX();
            Sala.Show();
           
        }

        private void Cartel3Btn_Click(object sender, EventArgs e)
        {
            Cartel = 3;
            AsientosMaquinaNuevaIMAX Sala = new AsientosMaquinaNuevaIMAX();
            Sala.Show();
           
            
        }

        private void Cartel4Btn_Click(object sender, EventArgs e)
        {
            Cartel = 4;
            AsientosMaquinaNuevaIMAX Sala = new AsientosMaquinaNuevaIMAX();
            Sala.Show();
            
        }
    }
}
