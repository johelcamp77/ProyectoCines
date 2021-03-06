﻿using System;
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
    public partial class Cartelera2 : Form
    {
        Conexion conexionBase = new Conexion();
        public Cartelera2()
        {
            InitializeComponent();
            string sql;
            DataTable dt = new DataTable();
            sql = "select nombrePelicula as 'Película', idioma as Idioma, tipoSala as Sala, numeroSala as 'Sala número', horario as 'Horario'," +
                " categoria as 'Categoría', duracion as 'Duración' from Pelicula where tipoSala = 'IMAX'";
            conexionBase.abrirConexion();
            SqlDataAdapter sqla = new SqlDataAdapter(sql, conexionBase.sqlconn);
            sqla.Fill(dt);

            dataGridView1.DataSource = dt;
            conexionBase.sqlconn.Close();
            

            

            String[,] Capturar = new String[3, 7];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Capturar[i, j] = "";
                }
            }
            int numero = dataGridView1.RowCount * dataGridView1.ColumnCount;
            for (int r = 0; r < dataGridView1.RowCount; r++)
            {
                for (int c = 0; c < dataGridView1.ColumnCount; c++)
                {
                    Capturar[r, c] = dataGridView1.Rows[r].Cells[c].Value.ToString();
                }
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

        private void Cartelera2_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
