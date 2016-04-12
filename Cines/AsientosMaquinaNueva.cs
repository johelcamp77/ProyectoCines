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
        string Id;
        string Pelicula;
        string Sala;
        string asiento;
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
            int numero = dataGridView1.RowCount * dataGridView1.ColumnCount;
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
            if (MaquinaNuevaForm.Cartel != 4)
            {
                Id = Capturar[0, 0];
                Pelicula = Capturar[0, 1];
                Sala = Capturar[0, 3];
            }
        }

        private void A1Btn_Click(object sender, EventArgs e)
        {
           
          A1Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "A1";
            CambiarBase(asiento);
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
        }
        private void A2Btn_Click(object sender, EventArgs e)
        {
            A2Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "A2";
            CambiarBase(asiento);
        }

        private void A3Btn_Click(object sender, EventArgs e)
        {
            A3Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "A3";
            CambiarBase(asiento);
        }

        private void A4Btn_Click(object sender, EventArgs e)
        {
            A4Btn.BackgroundImage = ((System.Drawing.Image)
                (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "A4";
            CambiarBase(asiento);
        }

        private void A5Btn_Click(object sender, EventArgs e)
        {
            A5Btn.BackgroundImage = ((System.Drawing.Image)
                (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "A5";
            CambiarBase(asiento);
        }

        private void A6Btn_Click(object sender, EventArgs e)
        {
            A6Btn.BackgroundImage = ((System.Drawing.Image)
                (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "A6";
            CambiarBase(asiento);
        }

        private void A7Btn_Click(object sender, EventArgs e)
        {
            A7Btn.BackgroundImage = ((System.Drawing.Image)
                (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "A7";
            CambiarBase(asiento);
        }

        private void A8Btn_Click(object sender, EventArgs e)
        {
            A8Btn.BackgroundImage = ((System.Drawing.Image)
                (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "A8";
            CambiarBase(asiento);
        }

        private void A9Btn_Click(object sender, EventArgs e)
        {
            A9Btn.BackgroundImage = ((System.Drawing.Image)
                (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "A9";
            CambiarBase(asiento);
        }

        private void B1Btn_Click(object sender, EventArgs e)
        {
            B1Btn.BackgroundImage = ((System.Drawing.Image)
               (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "B1";
            CambiarBase(asiento);
        }

        private void B2Btn_Click(object sender, EventArgs e)
        {
            B2Btn.BackgroundImage = ((System.Drawing.Image)
               (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "B2";
            CambiarBase(asiento);
        }

        private void B3Btn_Click(object sender, EventArgs e)
        {
            B3Btn.BackgroundImage = ((System.Drawing.Image)
               (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "B3";
            CambiarBase(asiento);
        }

        private void B4Btn_Click(object sender, EventArgs e)
        {
            B4Btn.BackgroundImage = ((System.Drawing.Image)
               (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "B4";
            CambiarBase(asiento);
        }

        private void B5Btn_Click(object sender, EventArgs e)
        {
            B5Btn.BackgroundImage = ((System.Drawing.Image)
                           (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "B5";
            CambiarBase(asiento);
        }

        private void B6Btn_Click(object sender, EventArgs e)
        {
            B6Btn.BackgroundImage = ((System.Drawing.Image)
               (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "B6";
            CambiarBase(asiento);
        }

        private void B7Btn_Click(object sender, EventArgs e)
        {
            B7Btn.BackgroundImage = ((System.Drawing.Image)
               (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "B7";
            CambiarBase(asiento);
        }

       

        private void B9Btn_Click(object sender, EventArgs e)
        {
            B9Btn.BackgroundImage = ((System.Drawing.Image)
                           (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "B9";
            CambiarBase(asiento);
        }

        private void C1Btn_Click(object sender, EventArgs e)
        {
            C1Btn.BackgroundImage = ((System.Drawing.Image)
                           (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "C1";
            CambiarBase(asiento);
        }

        private void C2Btn_Click(object sender, EventArgs e)
        {
            C2Btn.BackgroundImage = ((System.Drawing.Image)
                           (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "C2";
            CambiarBase(asiento);
        }

        private void C3Btn_Click(object sender, EventArgs e)
        {
            C3Btn.BackgroundImage = ((System.Drawing.Image)
                           (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "C3";
            CambiarBase(asiento);
        }

        private void C4Btn_Click(object sender, EventArgs e)
        {
            C4Btn.BackgroundImage = ((System.Drawing.Image)
                                       (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "C4";
            CambiarBase(asiento);
        }

        private void C5Btn_Click(object sender, EventArgs e)
        {
            C5Btn.BackgroundImage = ((System.Drawing.Image)
                           (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "C5";
            CambiarBase(asiento);
        }

        private void C6Btn_Click(object sender, EventArgs e)
        {
            C6Btn.BackgroundImage = ((System.Drawing.Image)
                           (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "C6";
            CambiarBase(asiento);
        }

        private void C7Btn_Click(object sender, EventArgs e)
        {
            C7Btn.BackgroundImage = ((System.Drawing.Image)
                           (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "C7";
            CambiarBase(asiento);
        }

        private void C8Btn_Click(object sender, EventArgs e)
        {
            C8Btn.BackgroundImage = ((System.Drawing.Image)
                           (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "C8";
            CambiarBase(asiento);
        }

        private void C9Btn_Click(object sender, EventArgs e)
        {
            C9Btn.BackgroundImage = ((System.Drawing.Image)
                           (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "C9";
            CambiarBase(asiento);
        }

        private void D1Btn_Click(object sender, EventArgs e)
        {
            D1Btn.BackgroundImage = ((System.Drawing.Image)
                           (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "D1";
            CambiarBase(asiento);
        }

        private void D2Btn_Click(object sender, EventArgs e)
        {
            D2Btn.BackgroundImage = ((System.Drawing.Image)
                           (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "D2";
            CambiarBase(asiento);
        }

        private void D3Btn_Click(object sender, EventArgs e)
        {
            D3Btn.BackgroundImage = ((System.Drawing.Image)
                                       (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "D3";
            CambiarBase(asiento);
        }

        private void D4Btn_Click(object sender, EventArgs e)
        {
            D4Btn.BackgroundImage = ((System.Drawing.Image)
                                       (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "D4";
            CambiarBase(asiento);
        }

        private void D5Btn_Click(object sender, EventArgs e)
        {
            D5Btn.BackgroundImage = ((System.Drawing.Image)
                                       (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "D5";
            CambiarBase(asiento);
        }

        private void D6Btn_Click(object sender, EventArgs e)
        {
            D6Btn.BackgroundImage = ((System.Drawing.Image)
                                       (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "D6";
            CambiarBase(asiento);
        }

        private void D7Btn_Click(object sender, EventArgs e)
        {
            D7Btn.BackgroundImage = ((System.Drawing.Image)
                                       (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "D7";
            CambiarBase(asiento);
        }

        private void D8Btn_Click(object sender, EventArgs e)
        {
            D8Btn.BackgroundImage = ((System.Drawing.Image)
                                       (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "D8";
            CambiarBase(asiento);
        }

        private void D9Btn_Click(object sender, EventArgs e)
        {
            D9Btn.BackgroundImage = ((System.Drawing.Image)
                                       (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "D9";
            CambiarBase(asiento);
        }

        private void E1Btn_Click(object sender, EventArgs e)
        {
           E1Btn.BackgroundImage = ((System.Drawing.Image)
                           (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "E1";
            CambiarBase(asiento);
        }

        private void E2Btn_Click(object sender, EventArgs e)
        {
            E2Btn.BackgroundImage = ((System.Drawing.Image)
                                      (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "E2";
            CambiarBase(asiento);
        }

        private void E3Btn_Click(object sender, EventArgs e)
        {
            E3Btn.BackgroundImage = ((System.Drawing.Image)
                                      (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "E3";
            CambiarBase(asiento);
        }

        private void E4Btn_Click(object sender, EventArgs e)
        {
            E4Btn.BackgroundImage = ((System.Drawing.Image)
                                      (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "E4";
            CambiarBase(asiento);
        }

        private void E5Btn_Click(object sender, EventArgs e)
        {
            E5Btn.BackgroundImage = ((System.Drawing.Image)
                          (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "E5";
            CambiarBase(asiento);
        }

        private void E6Btn_Click(object sender, EventArgs e)
        {
            E6Btn.BackgroundImage = ((System.Drawing.Image)
                          (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "E6";
            CambiarBase(asiento);
        }

        private void E7Btn_Click(object sender, EventArgs e)
        {
            E7Btn.BackgroundImage = ((System.Drawing.Image)
                          (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "E7";
            CambiarBase(asiento);
        }

        private void E8Btn_Click(object sender, EventArgs e)
        {
            E8Btn.BackgroundImage = ((System.Drawing.Image)
                          (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "E8";
            CambiarBase(asiento);
        }

        private void E9Btn_Click(object sender, EventArgs e)
        {
            E9Btn.BackgroundImage = ((System.Drawing.Image)
                          (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "E9";
            CambiarBase(asiento);
        }

        private void B8Btn_Click_1(object sender, EventArgs e)
        {
            B8Btn.BackgroundImage = ((System.Drawing.Image)
               (Properties.Resources.Asiento_seleccionado));
            asiento = Pelicula + "-" + Sala + "-" + "B8";
            CambiarBase(asiento);
        }
    }
}
