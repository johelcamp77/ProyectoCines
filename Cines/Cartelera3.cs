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
            //dataGridView2 = null;
            string sql;
            DataTable dt = new DataTable();
            sql = "select nombrePelicula as 'Película', idioma as Idioma\n, tipoSala as Sala, numeroSala as 'Sala número', horario as 'Horario'," +
                " categoria as 'Categoría', duracion as 'Duración' from Pelicula where tipoSala = '3D'";
            conexionBase.abrirConexion();
            SqlDataAdapter sqla = new SqlDataAdapter(sql, conexionBase.sqlconn);
            sqla.Fill(dt);
           
            conexionBase.sqlconn.Close();
            dataGridView1.DataSource = dt;



            string[,] Capturar = new string[3, 7];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Capturar[i, j] = "";
                }
            }
            int numero = dataGridView1.RowCount;
           // dataGridView1 = new DataGridView();
            for (int r = 0; r < dataGridView1.RowCount-1; r++)
            {
                for (int c = 0; c < dataGridView1.ColumnCount; c++)
                {
                    Capturar[r, c] = dataGridView1.Rows[r].Cells[c].Value.ToString();
                    //MessageBox.Show(Convert.ToString(dataGridView1.RowCount));
                }
                
                //dataGridView1.DataSource = dt;
            }
            

            //Cartelera 1
            string Nombre = Capturar[0, 0];
            string idioma = Capturar[0, 1];
            string Sala = Capturar[0, 3];
            string Horario = Capturar[0, 4];
            string Categoria = Capturar[0, 5];

            NombreLbl.Text = Nombre;
            IdiomaLbl.Text = idioma;
            SalaLbl.Text = Sala;
            HorarioLbl.Text = Horario;
            //Cartelera 2
            Nombre = Capturar[1, 0];
            idioma = Capturar[1, 1];
            Sala = Capturar[1, 3];
            Horario = Capturar[1, 4];
            Categoria = Capturar[1, 5];

            Nombre2Lbl.Text = Nombre;
            Idioma2Lbl.Text = idioma;
            Sala2Lbl.Text = Sala;
            Horario2Lbl.Text = Horario;
            //Cartelera 3
            Nombre = Capturar[2, 0];
            idioma = Capturar[2, 1];
            Sala = Capturar[2, 3];
            Horario = Capturar[2, 4];
            Categoria = Capturar[2, 5];


            Nombre3Lbl.Text = Nombre;
            Idioma3Lbl.Text = idioma;
            Sala3Lbl.Text = Sala;
            Horario3Lbl.Text = Horario;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cartelera3_Load(object sender, EventArgs e)
        {

        }
    }
}
