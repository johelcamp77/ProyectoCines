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
        public static string Cartel5;
        public static string Cartel6;
        public static string Cartel7;
        public static string Cartel8;
        Conexion conexionBase = new Conexion();
        public static int Cartel = 0;
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
            String[,] Capturar = new String[8, 7];
            for (int i = 0; i < 8; i++)
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
            //Informacion 5
            Nombre = Capturar[4, 0];
            idioma = Capturar[4, 1];
            Sala = Capturar[4, 2] + " " + Capturar[4, 3];
            Horario = Capturar[4, 4];
            Categoria = Capturar[4, 5];

            Nombre5Lbl.Text = Nombre;
            Idioma5Lbl.Text = idioma;
            Sala5Lbl.Text = Sala;
            Horario5Lbl.Text = Horario;
            Categoria5Lbl.Text = Categoria;
            Cartel5 = Capturar[4, 2];
            //Informacion 6
            Nombre = Capturar[5, 0];
            idioma = Capturar[5, 1];
            Sala = Capturar[5, 2] + " " + Capturar[5, 3];
            Horario = Capturar[5, 4];
            Categoria = Capturar[5, 5];

            Nombre6Lbl.Text = Nombre;
            Idioma6Lbl.Text = idioma;
            Sala6Lbl.Text = Sala;
            Horario6Lbl.Text = Horario;
            Categoria6Lbl.Text = Categoria;
            Cartel6 = Capturar[5, 2];
            //Informacion 7
            Nombre = Capturar[6, 0];
            idioma = Capturar[6, 1];
            Sala = Capturar[6, 2] + " " + Capturar[6, 3];
            Horario = Capturar[6, 4];
            Categoria = Capturar[6, 5];

            Nombre7Lbl.Text = Nombre;
            Idioma7Lbl.Text = idioma;
            Sala7Lbl.Text = Sala;
            Horario7Lbl.Text = Horario;
            Categoria7Lbl.Text = Categoria;
            Cartel7 = Capturar[6, 2];
            //Informacion 8
            Nombre = Capturar[7, 0];
            idioma = Capturar[7, 1];
            Sala = Capturar[7, 2] + " " + Capturar[7, 3];
            Horario = Capturar[7, 4];
            Categoria = Capturar[7, 5];

            Nombre8Lbl.Text = Nombre;
            Idioma8Lbl.Text = idioma;
            Sala8Lbl.Text = Sala;
            Horario8Lbl.Text = Horario;
            Categoria8Lbl.Text = Categoria;
            Cartel8 = Capturar[7, 2];

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

        private void SiguienteBtn_Click(object sender, EventArgs e)
        {
            Cartel1Btn.Visible = false;
            Cartel2Btn.Visible = false;
            Cartel3Btn.Visible = false;
            Cartel4Btn.Visible = false;
            Cartel5Btn.Visible = true;
            Cartel6Btn.Visible = true;
            Cartel7Btn.Visible = true;
            Cartel8Btn.Visible = true;

            Nombre1Lbl.Visible = false;
            Nombre2Lbl.Visible = false;
            Nombre3Lbl.Visible = false;
            Nombre4Lbl.Visible = false;
            Nombre5Lbl.Visible = true;
            Nombre6Lbl.Visible = true;
            Nombre7Lbl.Visible = true;
            Nombre8Lbl.Visible = true;

            Idioma1Lbl.Visible = false;
            Idioma2Lbl.Visible = false;
            Idioma3Lbl.Visible = false;
            Idioma4Lbl.Visible = false;
            Idioma5Lbl.Visible = true;
            Idioma6Lbl.Visible = true;
            Idioma7Lbl.Visible = true;
            Idioma8Lbl.Visible = true;

            Sala1Lbl.Visible = false;
            Sala2Lbl.Visible = false;
            Sala3Lbl.Visible = false;
            Sala4Lbl.Visible = false;
            Sala5Lbl.Visible = true;
            Sala6Lbl.Visible = true;
            Sala7Lbl.Visible = true;
            Sala8Lbl.Visible = true;

            Horario1Lbl.Visible = false;
            Horario2Lbl.Visible = false;
            Horario3Lbl.Visible = false;
            Horario4Lbl.Visible = false;
            Horario5Lbl.Visible = true;
            Horario6Lbl.Visible = true;
            Horario7Lbl.Visible = true;
            Horario8Lbl.Visible = true;

            Categoria1Lbl.Visible = false;
            Categoria2Lbl.Visible = false;
            Categoria3Lbl.Visible = false;
            Categoria4Lbl.Visible = false;
            Categoria5Lbl.Visible = true;
            Categoria6Lbl.Visible = true;
            Categoria7Lbl.Visible = true;
            Categoria8Lbl.Visible = true;





        }

        private void AnteriorBtn_Click(object sender, EventArgs e)
        {
            Cartel1Btn.Visible = true;
            Cartel2Btn.Visible = true;
            Cartel3Btn.Visible = true;
            Cartel4Btn.Visible = true;
            Cartel5Btn.Visible = false;
            Cartel6Btn.Visible = false;
            Cartel7Btn.Visible = false;
            Cartel8Btn.Visible = false;

            Nombre1Lbl.Visible = true;
            Nombre2Lbl.Visible = true;
            Nombre3Lbl.Visible = true;
            Nombre4Lbl.Visible = true;
            Nombre5Lbl.Visible = false;
            Nombre6Lbl.Visible = false;
            Nombre7Lbl.Visible = false;
            Nombre8Lbl.Visible = false;

            Idioma1Lbl.Visible = true;
            Idioma2Lbl.Visible = true;
            Idioma3Lbl.Visible = true;
            Idioma4Lbl.Visible = true;
            Idioma5Lbl.Visible = false;
            Idioma6Lbl.Visible = false;
            Idioma7Lbl.Visible = false;
            Idioma8Lbl.Visible = false;

            Sala1Lbl.Visible = true;
            Sala2Lbl.Visible = true;
            Sala3Lbl.Visible = true;
            Sala4Lbl.Visible = true;
            Sala5Lbl.Visible = false;
            Sala6Lbl.Visible = false;
            Sala7Lbl.Visible = false;
            Sala8Lbl.Visible = false;

            Horario1Lbl.Visible = true;
            Horario2Lbl.Visible = true;
            Horario3Lbl.Visible = true;
            Horario4Lbl.Visible = true;
            Horario5Lbl.Visible = false;
            Horario6Lbl.Visible = false;
            Horario7Lbl.Visible = false;
            Horario8Lbl.Visible = false;

            Categoria1Lbl.Visible = true;
            Categoria2Lbl.Visible = true;
            Categoria3Lbl.Visible = true;
            Categoria4Lbl.Visible = true;
            Categoria5Lbl.Visible = false;
            Categoria6Lbl.Visible = false;
            Categoria7Lbl.Visible = false;
            Categoria8Lbl.Visible = false;
        }

        private void Cartel5Btn_Click(object sender, EventArgs e)
        {
            Cartel = 5;
            AsientosMaquinaNuevaIMAX Sala = new AsientosMaquinaNuevaIMAX();
            Sala.Show();
        }

        private void Cartel6Btn_Click(object sender, EventArgs e)
        {
            Cartel = 6;
            AsientosMaquinaNuevaIMAX Sala = new AsientosMaquinaNuevaIMAX();
            Sala.Show();
        }

        private void Cartel7Btn_Click(object sender, EventArgs e)
        {
            Cartel = 7;
            AsientosMaquinaNuevaIMAX Sala = new AsientosMaquinaNuevaIMAX();
            Sala.Show();
        }

        private void Cartel8Btn_Click(object sender, EventArgs e)
        {
            Cartel = 8;
            AsientosMaquinaNuevaIMAX Sala = new AsientosMaquinaNuevaIMAX();
            Sala.Show();
        }
    }
}
