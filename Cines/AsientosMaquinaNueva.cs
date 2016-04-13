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
    public partial class AsientosMaquinaNuevaIMAX : Form
    {   
        Conexion conexionBase = new Conexion();
        String[,] Capturar = new String[3, 8];
        string[,] leer = new string[45, 1];
        string Id;
        string Pelicula;
        string Sala;
        string asiento;
        string devolver;
        string estado;
        public static double Pago;
        public AsientosMaquinaNuevaIMAX()
        {
            InitializeComponent();
            
            string sql = "select idPelicula as 'ID',nombrePelicula as 'Película', idioma as Idioma, tipoSala as Sala, numeroSala as 'Sala número', horario as 'Horario'," +
                                " categoria as 'Categoría', duracion as 'Duración' from Pelicula where tipoSala = 'IMAX'"; ;
            DataTable dt = new DataTable();
            if (MaquinaNuevaForm.Cartel==1)
            {
                sql = "select idPelicula as 'ID',nombrePelicula as 'Película', idioma as Idioma, tipoSala as Sala, numeroSala as 'Sala número', horario as 'Horario'," +
                                " categoria as 'Categoría', duracion as 'Duración' from Pelicula where tipoSala = 'IMAX'";
            }
            if (MaquinaNuevaForm.Cartel == 2)
            {
                sql = "select idPelicula as 'ID',nombrePelicula as 'Película', idioma as Idioma, tipoSala as Sala, numeroSala as 'Sala número', horario as 'Horario'," +
                                " categoria as 'Categoría', duracion as 'Duración' from Pelicula where tipoSala = 'Sencilla'";
            }
            if (MaquinaNuevaForm.Cartel == 3)
            {
                sql = "select idPelicula as 'ID',nombrePelicula as 'Película', idioma as Idioma, tipoSala as Sala, numeroSala as 'Sala número', horario as 'Horario'," +
                                " categoria as 'Categoría', duracion as 'Duración' from Pelicula where tipoSala = '3D'";
            }
            if (MaquinaNuevaForm.Cartel == 4)
            {
                if (MaquinaNuevaForm.Cartel4 == "Sencilla")
                {
                    sql = "select idPelicula as 'ID',nombrePelicula as 'Película', idioma as Idioma, tipoSala as Sala, numeroSala as 'Sala número', horario as 'Horario'," +
                                  " categoria as 'Categoría', duracion as 'Duración' from Pelicula where tipoSala = 'Sencilla'";
                }
                if (MaquinaNuevaForm.Cartel4 == "IMAX")
                {
                    sql = "select idPelicula as 'ID',nombrePelicula as 'Película', idioma as Idioma, tipoSala as Sala, numeroSala as 'Sala número', horario as 'Horario'," +
                                  " categoria as 'Categoría', duracion as 'Duración' from Pelicula where tipoSala = 'IMAX'";
                }
                if (MaquinaNuevaForm.Cartel4 == "3D")
                {
                    sql = "select idPelicula as 'ID',nombrePelicula as 'Película', idioma as Idioma, tipoSala as Sala, numeroSala as 'Sala número', horario as 'Horario'," +
                                  " categoria as 'Categoría', duracion as 'Duración' from Pelicula where tipoSala = '3D'";
                }

            }
            if (MaquinaNuevaForm.Cartel == 5)
            {
                if (MaquinaNuevaForm.Cartel5 == "Sencilla")
                {
                    sql = "select idPelicula as 'ID',nombrePelicula as 'Película', idioma as Idioma, tipoSala as Sala, numeroSala as 'Sala número', horario as 'Horario'," +
                                  " categoria as 'Categoría', duracion as 'Duración' from Pelicula where tipoSala = 'Sencilla'";
                }
                if (MaquinaNuevaForm.Cartel5 == "IMAX")
                {
                    sql = "select idPelicula as 'ID',nombrePelicula as 'Película', idioma as Idioma, tipoSala as Sala, numeroSala as 'Sala número', horario as 'Horario'," +
                                  " categoria as 'Categoría', duracion as 'Duración' from Pelicula where tipoSala = 'IMAX'";
                }
                if (MaquinaNuevaForm.Cartel5 == "3D")
                {
                    sql = "select idPelicula as 'ID',nombrePelicula as 'Película', idioma as Idioma, tipoSala as Sala, numeroSala as 'Sala número', horario as 'Horario'," +
                                  " categoria as 'Categoría', duracion as 'Duración' from Pelicula where tipoSala = '3D'";
                }

            }
            if (MaquinaNuevaForm.Cartel == 6)
            {
                if (MaquinaNuevaForm.Cartel6 == "Sencilla")
                {
                    sql = "select idPelicula as 'ID',nombrePelicula as 'Película', idioma as Idioma, tipoSala as Sala, numeroSala as 'Sala número', horario as 'Horario'," +
                                  " categoria as 'Categoría', duracion as 'Duración' from Pelicula where tipoSala = 'Sencilla'";
                }
                if (MaquinaNuevaForm.Cartel6 == "IMAX")
                {
                    sql = "select idPelicula as 'ID',nombrePelicula as 'Película', idioma as Idioma, tipoSala as Sala, numeroSala as 'Sala número', horario as 'Horario'," +
                                  " categoria as 'Categoría', duracion as 'Duración' from Pelicula where tipoSala = 'IMAX'";
                }
                if (MaquinaNuevaForm.Cartel6 == "3D")
                {
                    sql = "select idPelicula as 'ID',nombrePelicula as 'Película', idioma as Idioma, tipoSala as Sala, numeroSala as 'Sala número', horario as 'Horario'," +
                                  " categoria as 'Categoría', duracion as 'Duración' from Pelicula where tipoSala = '3D'";
                }

            }
            if (MaquinaNuevaForm.Cartel == 7)
            {
                if (MaquinaNuevaForm.Cartel7 == "Sencilla")
                {
                    sql = "select idPelicula as 'ID',nombrePelicula as 'Película', idioma as Idioma, tipoSala as Sala, numeroSala as 'Sala número', horario as 'Horario'," +
                                  " categoria as 'Categoría', duracion as 'Duración' from Pelicula where tipoSala = 'Sencilla'";
                }
                if (MaquinaNuevaForm.Cartel7 == "IMAX")
                {
                    sql = "select idPelicula as 'ID',nombrePelicula as 'Película', idioma as Idioma, tipoSala as Sala, numeroSala as 'Sala número', horario as 'Horario'," +
                                  " categoria as 'Categoría', duracion as 'Duración' from Pelicula where tipoSala = 'IMAX'";
                }
                if (MaquinaNuevaForm.Cartel7 == "3D")
                {
                    sql = "select idPelicula as 'ID',nombrePelicula as 'Película', idioma as Idioma, tipoSala as Sala, numeroSala as 'Sala número', horario as 'Horario'," +
                                  " categoria as 'Categoría', duracion as 'Duración' from Pelicula where tipoSala = '3D'";
                }

            }
            if (MaquinaNuevaForm.Cartel == 8)
            {
                if (MaquinaNuevaForm.Cartel8 == "Sencilla")
                {
                    sql = "select idPelicula as 'ID',nombrePelicula as 'Película', idioma as Idioma, tipoSala as Sala, numeroSala as 'Sala número', horario as 'Horario'," +
                                  " categoria as 'Categoría', duracion as 'Duración' from Pelicula where tipoSala = 'Sencilla'";
                }
                if (MaquinaNuevaForm.Cartel8 == "IMAX")
                {
                    sql = "select idPelicula as 'ID',nombrePelicula as 'Película', idioma as Idioma, tipoSala as Sala, numeroSala as 'Sala número', horario as 'Horario'," +
                                  " categoria as 'Categoría', duracion as 'Duración' from Pelicula where tipoSala = 'IMAX'";
                }
                if (MaquinaNuevaForm.Cartel8 == "3D")
                {
                    sql = "select idPelicula as 'ID',nombrePelicula as 'Película', idioma as Idioma, tipoSala as Sala, numeroSala as 'Sala número', horario as 'Horario'," +
                                  " categoria as 'Categoría', duracion as 'Duración' from Pelicula where tipoSala = '3D'";
                }

            }
            conexionBase.abrirConexion();
            SqlDataAdapter sqla = new SqlDataAdapter(sql, conexionBase.sqlconn);
            sqla.Fill(dt);
            conexionBase.sqlconn.Close();
            dataGridView1.DataSource = dt;
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Capturar[i, j] = "";
                }
            }
           
            for (int r = 0; r < dataGridView1.RowCount-1; r++)
            {
                for (int c = 0; c < dataGridView1.ColumnCount; c++)
                {
                    Capturar[r, c] = dataGridView1.Rows[r].Cells[c].Value.ToString();
                }
            }
            if (MaquinaNuevaForm.Cartel == 4)
            {
                Id = Capturar[1, 0];
                Pelicula = Capturar[1, 1];
                Sala = Capturar[1, 3];
            }
            if (MaquinaNuevaForm.Cartel == 5)
            {
                Id = Capturar[1, 0];
                Pelicula = Capturar[1, 1];
                Sala = Capturar[1, 3];
            }
            if (MaquinaNuevaForm.Cartel == 6)
            {
                Id = Capturar[1, 0];
                Pelicula = Capturar[1, 1];
                Sala = Capturar[1, 3];
            }
            if (MaquinaNuevaForm.Cartel == 7)
            {
                Id = Capturar[2, 0];
                Pelicula = Capturar[2, 1];
                Sala = Capturar[2, 3];
            }
            if (MaquinaNuevaForm.Cartel == 8)
            {
                Id = Capturar[2, 0];
                Pelicula = Capturar[2, 1];
                Sala = Capturar[2, 3];
            }
            if (MaquinaNuevaForm.Cartel != 4 
                && MaquinaNuevaForm.Cartel != 5
                && MaquinaNuevaForm.Cartel != 6
                && MaquinaNuevaForm.Cartel != 7
                && MaquinaNuevaForm.Cartel != 8)
            {
                Id = Capturar[0, 0];
                Pelicula = Capturar[0, 1];
                Sala = Capturar[0, 3];
            }
            Validar(Id);
        }
        public void Validar(string id)
        {
            string sql;
            DataTable dt = new DataTable();
            sql = "select estado as 'Estado' from Sala where idPelicula='"+id+"'";
            conexionBase.abrirConexion();
            SqlDataAdapter sqla = new SqlDataAdapter(sql, conexionBase.sqlconn);
            sqla.Fill(dt);
            conexionBase.sqlconn.Close();
            dataGridView2.DataSource = dt;

            for (int i = 0; i < 45; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    leer[i, j] = "false";
                }
            }
            for (int r = 0; r < dataGridView2.RowCount - 1; r++)
            {
                for (int c = 0; c < dataGridView2.ColumnCount; c++)
                {
                    leer[r, c] = dataGridView2.Rows[r].Cells[c].Value.ToString();
                }
            }
            
            estado = leer[0, 0];
            bool state= Convert.ToBoolean(estado);
            if (state==true)
            {
                A1Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Asiento_ocupado));
                A1Btn.Enabled = false;
            }
            
            estado = leer[0, 0];
            state = Convert.ToBoolean(estado);
            if (state == true)
            {
                A2Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Asiento_ocupado));
                A2Btn.Enabled = false;
            }
            estado = leer[1, 0];
            state = Convert.ToBoolean(estado);
            if (state == true)
            {
                A2Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Asiento_ocupado));
                A2Btn.Enabled = false;
            }
            estado = leer[2, 0];
            state = Convert.ToBoolean(estado);
            if (state == true)
            {
                A3Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Asiento_ocupado));
                A3Btn.Enabled = false;
            }
            estado = leer[3, 0];
            state = Convert.ToBoolean(estado);
            if (state == true)
            {
                A4Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Asiento_ocupado));
                A4Btn.Enabled = false;
            }
            estado = leer[4, 0];
            state = Convert.ToBoolean(estado);
            if (state == true)
            {
                A5Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Asiento_ocupado));
                A5Btn.Enabled = false;
            }
            estado = leer[5, 0];
            state = Convert.ToBoolean(estado);
            if (state == true)
            {
                A6Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Asiento_ocupado));
                A6Btn.Enabled = false;
            }
            estado = leer[6, 0];
            state = Convert.ToBoolean(estado);
            if (state == true)
            {
                A7Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Asiento_ocupado));
                A7Btn.Enabled = false;
            }
            estado = leer[7, 0];
            state = Convert.ToBoolean(estado);
            if (state == true)
            {
                A8Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Asiento_ocupado));
                A8Btn.Enabled = false;
            }
            estado = leer[8, 0];
            state = Convert.ToBoolean(estado);
            if (state == true)
            {
                A9Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Asiento_ocupado));
                A9Btn.Enabled = false;
            }
            estado = leer[9, 0];
            state = Convert.ToBoolean(estado);
            if (state == true)
            {
                B1Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Asiento_ocupado));
                B1Btn.Enabled = false;
            }
            estado = leer[10, 0];
            state = Convert.ToBoolean(estado);
            if (state == true)
            {
                B2Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Asiento_ocupado));
                B2Btn.Enabled = false;
            }
            estado = leer[11, 0];
            state = Convert.ToBoolean(estado);
            if (state == true)
            {
                B3Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Asiento_ocupado));
                B3Btn.Enabled = false;
            }
            estado = leer[12, 0];
            state = Convert.ToBoolean(estado);
            if (state == true)
            {
                B4Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Asiento_ocupado));
                B4Btn.Enabled = false;
            }
            estado = leer[13, 0];
            state = Convert.ToBoolean(estado);
            if (state == true)
            {
                B5Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Asiento_ocupado));
                B5Btn.Enabled = false;
            }
            estado = leer[14, 0];
            state = Convert.ToBoolean(estado);
            if (state == true)
            {
                B6Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Asiento_ocupado));
                B6Btn.Enabled = false;
            }
            estado = leer[15, 0];
            state = Convert.ToBoolean(estado);
            if (state == true)
            {
                B7Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Asiento_ocupado));
                B7Btn.Enabled = false;
            }
            estado = leer[16, 0];
            state = Convert.ToBoolean(estado);
            if (state == true)
            {
                B8Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Asiento_ocupado));
                B8Btn.Enabled = false;
            }
            estado = leer[17, 0];
            state = Convert.ToBoolean(estado);
            if (state == true)
            {
                B9Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Asiento_ocupado));
                B9Btn.Enabled = false;
            }
            estado = leer[18, 0];
            state = Convert.ToBoolean(estado);
            if (state == true)
            {
                C1Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Asiento_ocupado));
                C1Btn.Enabled = false;
            }
            estado = leer[19, 0];
            state = Convert.ToBoolean(estado);
            if (state == true)
            {
                C2Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Asiento_ocupado));
                C2Btn.Enabled = false;
            }
            estado = leer[20, 0];
            state = Convert.ToBoolean(estado);
            if (state == true)
            {
                C3Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Asiento_ocupado));
                C3Btn.Enabled = false;
            }
            estado = leer[21, 0];
            state = Convert.ToBoolean(estado);
            if (state == true)
            {
                C4Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Asiento_ocupado));
                C4Btn.Enabled = false;
            }
            estado = leer[22, 0];
            state = Convert.ToBoolean(estado);
            if (state == true)
            {
                C5Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Asiento_ocupado));
                C5Btn.Enabled = false;
            }
            estado = leer[23, 0];
            state = Convert.ToBoolean(estado);
            if (state == true)
            {
                C6Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Asiento_ocupado));
                C6Btn.Enabled = false;
            }
            estado = leer[24, 0];
            state = Convert.ToBoolean(estado);
            if (state == true)
            {
                C7Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Asiento_ocupado));
                C7Btn.Enabled = false;
            }
            estado = leer[25, 0];
            state = Convert.ToBoolean(estado);
            if (state == true)
            {
                C8Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Asiento_ocupado));
                C8Btn.Enabled = false;
            }
            estado = leer[26, 0];
            state = Convert.ToBoolean(estado);
            if (state == true)
            {
                C9Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Asiento_ocupado));
                C9Btn.Enabled = false;
            }
            estado = leer[27, 0];
            state = Convert.ToBoolean(estado);
            if (state == true)
            {
                D1Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Asiento_ocupado));
                D1Btn.Enabled = false;
            }
            estado = leer[28, 0];
            state = Convert.ToBoolean(estado);
            if (state == true)
            {
                D2Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Asiento_ocupado));
                D2Btn.Enabled = false;
            }
            estado = leer[29, 0];
            state = Convert.ToBoolean(estado);
            if (state == true)
            {
                D3Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Asiento_ocupado));
                D3Btn.Enabled = false;
            }
            estado = leer[30, 0];
            state = Convert.ToBoolean(estado);
            if (state == true)
            {
                D4Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Asiento_ocupado));
                D4Btn.Enabled = false;
            }
            estado = leer[31, 0];
            state = Convert.ToBoolean(estado);
            if (state == true)
            {
                D5Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Asiento_ocupado));
                D5Btn.Enabled = false;
            }
            estado = leer[32, 0];
            state = Convert.ToBoolean(estado);
            if (state == true)
            {
                D6Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Asiento_ocupado));
                D6Btn.Enabled = false;
            }
            estado = leer[33, 0];
            state = Convert.ToBoolean(estado);
            if (state == true)
            {
                D7Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Asiento_ocupado));
                D7Btn.Enabled = false;
            }
            estado = leer[34, 0];
            state = Convert.ToBoolean(estado);
            if (state == true)
            {
                D8Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Asiento_ocupado));
                D8Btn.Enabled = false;
            }
            estado = leer[35, 0];
            state = Convert.ToBoolean(estado);
            if (state == true)
            {
                D9Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Asiento_ocupado));
                D9Btn.Enabled = false;
            }
            estado = leer[36, 0];
            state = Convert.ToBoolean(estado);
            if (state == true)
            {
                C9Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Asiento_ocupado));
                C9Btn.Enabled = false;
            }
            estado = leer[37, 0];
            state = Convert.ToBoolean(estado);
            if (state == true)
            {
                E1Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Asiento_ocupado));
                E1Btn.Enabled = false;
            }
            estado = leer[37, 0];
            state = Convert.ToBoolean(estado);
            if (state == true)
            {
                E2Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Asiento_ocupado));
                E2Btn.Enabled = false;
            }
            estado = leer[38, 0];
            state = Convert.ToBoolean(estado);
            if (state == true)
            {
                E3Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Asiento_ocupado));
                E3Btn.Enabled = false;
            }
            estado = leer[39, 0];
            state = Convert.ToBoolean(estado);
            if (state == true)
            {
                E4Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Asiento_ocupado));
                E4Btn.Enabled = false;
            }
            estado = leer[40, 0];
            state = Convert.ToBoolean(estado);
            if (state == true)
            {
                E5Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Asiento_ocupado));
                E5Btn.Enabled = false;
            }
            estado = leer[41, 0];
            state = Convert.ToBoolean(estado);
            if (state == true)
            {
                E6Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Asiento_ocupado));
                E6Btn.Enabled = false;
            }
            estado = leer[42, 0];
            state = Convert.ToBoolean(estado);
            if (state == true)
            {
                E7Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Asiento_ocupado));
                E7Btn.Enabled = false;
            }
            estado = leer[43, 0];
            state = Convert.ToBoolean(estado);
            if (state == true)
            {
                E8Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Asiento_ocupado));
                E8Btn.Enabled = false;
            }
            estado = leer[44, 0];
            state = Convert.ToBoolean(estado);
            if (state == true)
            {
                E9Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Asiento_ocupado));
                E9Btn.Enabled = false;
            }



        }

        private void A1Btn_Click(object sender, EventArgs e)
        {
           
          A1Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "A1";
            CambiarBase(asiento);
            A1Btn.Enabled = false;

        }

        private void VolverBtn_Click(object sender, EventArgs e)
        {
           
            
            Dispose();
        }
        public void CambiarBase(string asiento)
        {
            VolverBtn.Visible = false;
            ComprarBtn.Visible = true;
            string sql = "update Sala set estado = " + 1 + "where idAsiento=" + "'" + asiento + "'";
            DataTable dt = new DataTable();
            conexionBase.abrirConexion();
            SqlDataAdapter sqla = new SqlDataAdapter(sql, conexionBase.sqlconn);
            sqla.Fill(dt);
            conexionBase.sqlconn.Close();
            Pago = Pago + 3000;
        }
        public void CambiarBase2(string asiento)
        {
            
            ComprarBtn.Visible = true;
            string sql = "update Sala set estado = " + 0 + "where idAsiento=" + "'" + asiento + "'";
            DataTable dt = new DataTable();
            conexionBase.abrirConexion();
            SqlDataAdapter sqla = new SqlDataAdapter(sql, conexionBase.sqlconn);
            sqla.Fill(dt);
            conexionBase.sqlconn.Close();
        }
        private void A2Btn_Click(object sender, EventArgs e)
        {
            A2Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "A2";
            CambiarBase(asiento);
            A2Btn.Enabled = false;
        }

        private void A3Btn_Click(object sender, EventArgs e)
        {
            A3Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "A3";
            CambiarBase(asiento);
            A3Btn.Enabled = false;
        }

        private void A4Btn_Click(object sender, EventArgs e)
        {
            A4Btn.BackgroundImage = ((System.Drawing.Image)
                (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "A4";
            CambiarBase(asiento);
            A4Btn.Enabled = false;
        }

        private void A5Btn_Click(object sender, EventArgs e)
        {
            A5Btn.BackgroundImage = ((System.Drawing.Image)
                (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "A5";
            CambiarBase(asiento);
            A5Btn.Enabled = false;
        }

        private void A6Btn_Click(object sender, EventArgs e)
        {
            A6Btn.BackgroundImage = ((System.Drawing.Image)
                (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "A6";
            CambiarBase(asiento);
            A6Btn.Enabled = false;
        }

        private void A7Btn_Click(object sender, EventArgs e)
        {
            A7Btn.BackgroundImage = ((System.Drawing.Image)
                (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "A7";
            CambiarBase(asiento);
            A7Btn.Enabled = false;
        }

        private void A8Btn_Click(object sender, EventArgs e)
        {
            A8Btn.BackgroundImage = ((System.Drawing.Image)
                (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "A8";
            CambiarBase(asiento);
            A8Btn.Enabled = false;
        }

        private void A9Btn_Click(object sender, EventArgs e)
        {
            A9Btn.BackgroundImage = ((System.Drawing.Image)
                (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "A9";
            CambiarBase(asiento);
            A9Btn.Enabled = false;
        }

        private void B1Btn_Click(object sender, EventArgs e)
        {
            B1Btn.BackgroundImage = ((System.Drawing.Image)
               (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "B1";
            CambiarBase(asiento);
            B1Btn.Enabled = false;
        }

        private void B2Btn_Click(object sender, EventArgs e)
        {
            B2Btn.BackgroundImage = ((System.Drawing.Image)
               (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "B2";
            CambiarBase(asiento);
            B2Btn.Enabled = false;
        }

        private void B3Btn_Click(object sender, EventArgs e)
        {
            B3Btn.BackgroundImage = ((System.Drawing.Image)
               (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "B3";
            CambiarBase(asiento);
            B3Btn.Enabled = false;
        }

        private void B4Btn_Click(object sender, EventArgs e)
        {
            B4Btn.BackgroundImage = ((System.Drawing.Image)
               (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "B4";
            CambiarBase(asiento);
            B4Btn.Enabled = false;
        }

        private void B5Btn_Click(object sender, EventArgs e)
        {
            B5Btn.BackgroundImage = ((System.Drawing.Image)
                           (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "B5";
            CambiarBase(asiento);
            B3Btn.Enabled = false;
        }

        private void B6Btn_Click(object sender, EventArgs e)
        {
            B6Btn.BackgroundImage = ((System.Drawing.Image)
               (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "B6";
            CambiarBase(asiento);
            B6Btn.Enabled = false;
        }

        private void B7Btn_Click(object sender, EventArgs e)
        {
            B7Btn.BackgroundImage = ((System.Drawing.Image)
               (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "B7";
            CambiarBase(asiento);
            B7Btn.Enabled = false;
        }

       

        private void B9Btn_Click(object sender, EventArgs e)
        {
            B9Btn.BackgroundImage = ((System.Drawing.Image)
                           (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "B9";
            CambiarBase(asiento);
            B9Btn.Enabled = false;
        }

        private void C1Btn_Click(object sender, EventArgs e)
        {
            C1Btn.BackgroundImage = ((System.Drawing.Image)
                           (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "C1";
            CambiarBase(asiento);
            C1Btn.Enabled = false;
        }

        private void C2Btn_Click(object sender, EventArgs e)
        {
            C2Btn.BackgroundImage = ((System.Drawing.Image)
                           (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "C2";
            CambiarBase(asiento);
            C2Btn.Enabled = false;
        }

        private void C3Btn_Click(object sender, EventArgs e)
        {
            C3Btn.BackgroundImage = ((System.Drawing.Image)
                           (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "C3";
            CambiarBase(asiento);
            C3Btn.Enabled = false;
        }

        private void C4Btn_Click(object sender, EventArgs e)
        {
            C4Btn.BackgroundImage = ((System.Drawing.Image)
                                       (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "C4";
            CambiarBase(asiento);
            C4Btn.Enabled = false;
        }

        private void C5Btn_Click(object sender, EventArgs e)
        {
            C5Btn.BackgroundImage = ((System.Drawing.Image)
                           (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "C5";
            CambiarBase(asiento);
            C5Btn.Enabled = false;
        }

        private void C6Btn_Click(object sender, EventArgs e)
        {
            C6Btn.BackgroundImage = ((System.Drawing.Image)
                           (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "C6";
            CambiarBase(asiento);
            C6Btn.Enabled = false;
        }

        private void C7Btn_Click(object sender, EventArgs e)
        {
            C7Btn.BackgroundImage = ((System.Drawing.Image)
                           (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "C7";
            CambiarBase(asiento);
            C7Btn.Enabled = false;
        }

        private void C8Btn_Click(object sender, EventArgs e)
        {
            C8Btn.BackgroundImage = ((System.Drawing.Image)
                           (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "C8";
            CambiarBase(asiento);
            C8Btn.Enabled = false;
        }

        private void C9Btn_Click(object sender, EventArgs e)
        {
            C9Btn.BackgroundImage = ((System.Drawing.Image)
                           (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "C9";
            CambiarBase(asiento);
            C9Btn.Enabled = false;
        }

        private void D1Btn_Click(object sender, EventArgs e)
        {
            D1Btn.BackgroundImage = ((System.Drawing.Image)
                           (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "D1";
            CambiarBase(asiento);
            D1Btn.Enabled = false;
        }

        private void D2Btn_Click(object sender, EventArgs e)
        {
            D2Btn.BackgroundImage = ((System.Drawing.Image)
                           (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "D2";
            CambiarBase(asiento);
            D2Btn.Enabled = false;
        }

        private void D3Btn_Click(object sender, EventArgs e)
        {
            D3Btn.BackgroundImage = ((System.Drawing.Image)
                                       (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "D3";
            CambiarBase(asiento);
            D3Btn.Enabled = false;
        }

        private void D4Btn_Click(object sender, EventArgs e)
        {
            D4Btn.BackgroundImage = ((System.Drawing.Image)
                                       (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "D4";
            CambiarBase(asiento);
            D4Btn.Enabled = false;
        }

        private void D5Btn_Click(object sender, EventArgs e)
        {
            D5Btn.BackgroundImage = ((System.Drawing.Image)
                                       (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "D5";
            CambiarBase(asiento);
            D5Btn.Enabled = false;
        }

        private void D6Btn_Click(object sender, EventArgs e)
        {
            D6Btn.BackgroundImage = ((System.Drawing.Image)
                                       (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "D6";
            CambiarBase(asiento);
            D6Btn.Enabled = false;
        }

        private void D7Btn_Click(object sender, EventArgs e)
        {
            D7Btn.BackgroundImage = ((System.Drawing.Image)
                                       (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "D7";
            CambiarBase(asiento);
            D7Btn.Enabled = false;
        }

        private void D8Btn_Click(object sender, EventArgs e)
        {
            D8Btn.BackgroundImage = ((System.Drawing.Image)
                                       (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "D8";
            CambiarBase(asiento);
            D8Btn.Enabled = false;
        }

        private void D9Btn_Click(object sender, EventArgs e)
        {
            D9Btn.BackgroundImage = ((System.Drawing.Image)
                                       (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "D9";
            CambiarBase(asiento);
            D9Btn.Enabled = false;
        }

        private void E1Btn_Click(object sender, EventArgs e)
        {
           E1Btn.BackgroundImage = ((System.Drawing.Image)
                           (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "E1";
            CambiarBase(asiento);
            E1Btn.Enabled = false;
        }

        private void E2Btn_Click(object sender, EventArgs e)
        {
            E2Btn.BackgroundImage = ((System.Drawing.Image)
                                      (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "E2";
            CambiarBase(asiento);
            E2Btn.Enabled = false;
        }

        private void E3Btn_Click(object sender, EventArgs e)
        {
            E3Btn.BackgroundImage = ((System.Drawing.Image)
                                      (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "E3";
            CambiarBase(asiento);
            E3Btn.Enabled = false;
        }

        private void E4Btn_Click(object sender, EventArgs e)
        {
            E4Btn.BackgroundImage = ((System.Drawing.Image)
                                      (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "E4";
            CambiarBase(asiento);
            E4Btn.Enabled = false;
        }

        private void E5Btn_Click(object sender, EventArgs e)
        {
            E5Btn.BackgroundImage = ((System.Drawing.Image)
                          (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "E5";
            CambiarBase(asiento);
            E5Btn.Enabled = false;
        }

        private void E6Btn_Click(object sender, EventArgs e)
        {
            E6Btn.BackgroundImage = ((System.Drawing.Image)
                          (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "E6";
            CambiarBase(asiento);
            E6Btn.Enabled = false;
        }

        private void E7Btn_Click(object sender, EventArgs e)
        {
            E7Btn.BackgroundImage = ((System.Drawing.Image)
                          (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "E7";
            CambiarBase(asiento);
            E7Btn.Enabled = false;
        }

        private void E8Btn_Click(object sender, EventArgs e)
        {
            E8Btn.BackgroundImage = ((System.Drawing.Image)
                          (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "E8";
            CambiarBase(asiento);
            E8Btn.Enabled = false;
        }

        private void E9Btn_Click(object sender, EventArgs e)
        {
            E9Btn.BackgroundImage = ((System.Drawing.Image)
                          (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "E9";
            CambiarBase(asiento);
            E9Btn.Enabled = false;
        }

        private void B8Btn_Click_1(object sender, EventArgs e)
        {
            B8Btn.BackgroundImage = ((System.Drawing.Image)
               (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "B8";
            CambiarBase(asiento);
            B8Btn.Enabled = false;
        }

        private void ComprarBtn_Click(object sender, EventArgs e)
        {
            Cobro Nuevo = new Cobro();
            Nuevo.Show();
            Dispose();
        }
    }
}
