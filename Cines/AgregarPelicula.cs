using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cines
{
    public partial class AgregarPelicula : Form
    {
        Conexion conexionBase = new Conexion();
        public AgregarPelicula()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            nuevaPelicula();
            MessageBox.Show("Película agregada");
            generarAsientos();
        }

        public void nuevaPelicula()
        {
            if (txtNombre.Text != "" && txtIdentificador.Text != "" && txtIdioma.Text != "" && comboTipoSala.SelectedItem != null && txtNumeroSala.Text != "" && txtHorario.Text != ""
                && txtCategoria.Text != "" && txtDuracion.Text != "")
            {
                string sql = "insert into Pelicula (idPelicula, nombrePelicula,idioma,tipoSala,NumeroSala,horario,categoria,duracion)values(" +
                    "'" + Convert.ToInt32(txtIdentificador.Text) + "','" + txtNombre.Text + "','" + txtIdioma.Text + "','" + comboTipoSala.SelectedItem.ToString()
                    + "','" + Convert.ToInt32(txtNumeroSala.Text) + "','" + txtHorario.Text + "','" + txtCategoria.Text + "','" + Convert.ToDateTime(txtDuracion.Text) + "')";
                DataTable dt = new DataTable();
                conexionBase.abrirConexion();
                SqlDataAdapter sqla = new SqlDataAdapter(sql, conexionBase.sqlconn);
                sqla.Fill(dt);
                conexionBase.sqlconn.Close();
            }
            else
            {
                MessageBox.Show("No se permiten campos vacíos");
            }

        }
        public void generarAsientos()
        {
            string sql = "insert into Sala (idAsiento, idPelicula, estado, tipoSala) values('" + txtNombre.Text + "-" + comboTipoSala.SelectedItem.ToString() + "-A1'," + Convert.ToInt32(txtIdentificador.Text) + "," + 0 + ",'" + comboTipoSala.SelectedItem.ToString() + "')" +
                "insert into Sala (idAsiento, idPelicula, estado, tipoSala) values('" + txtNombre.Text + "-" + comboTipoSala.SelectedItem.ToString() + "-A2'," + Convert.ToInt32(txtIdentificador.Text) + "," + 0 + ",'" + comboTipoSala.SelectedItem.ToString() + "')" +
                "insert into Sala (idAsiento, idPelicula, estado, tipoSala) values('" + txtNombre.Text + "-" + comboTipoSala.SelectedItem.ToString() + "-A3'," + Convert.ToInt32(txtIdentificador.Text) + "," + 0 + ",'" + comboTipoSala.SelectedItem.ToString() + "')" +
                "insert into Sala (idAsiento, idPelicula, estado, tipoSala) values('" + txtNombre.Text + "-" + comboTipoSala.SelectedItem.ToString() + "-A4'," + Convert.ToInt32(txtIdentificador.Text) + "," + 0 + ",'" + comboTipoSala.SelectedItem.ToString() + "')" +
                "insert into Sala (idAsiento, idPelicula, estado, tipoSala) values('" + txtNombre.Text + "-" + comboTipoSala.SelectedItem.ToString() + "-A5'," + Convert.ToInt32(txtIdentificador.Text) + "," + 0 + ",'" + comboTipoSala.SelectedItem.ToString() + "')" +
                "insert into Sala (idAsiento, idPelicula, estado, tipoSala) values('" + txtNombre.Text + "-" + comboTipoSala.SelectedItem.ToString() + "-A6'," + Convert.ToInt32(txtIdentificador.Text) + "," + 0 + ",'" + comboTipoSala.SelectedItem.ToString() + "')" +
                "insert into Sala (idAsiento, idPelicula, estado, tipoSala) values('" + txtNombre.Text + "-" + comboTipoSala.SelectedItem.ToString() + "-A7'," + Convert.ToInt32(txtIdentificador.Text) + "," + 0 + ",'" + comboTipoSala.SelectedItem.ToString() + "')" +
                "insert into Sala (idAsiento, idPelicula, estado, tipoSala) values('" + txtNombre.Text + "-" + comboTipoSala.SelectedItem.ToString() + "-A8'," + Convert.ToInt32(txtIdentificador.Text) + "," + 0 + ",'" + comboTipoSala.SelectedItem.ToString() + "')" +
                "insert into Sala (idAsiento, idPelicula, estado, tipoSala) values('" + txtNombre.Text + "-" + comboTipoSala.SelectedItem.ToString() + "-A9'," + Convert.ToInt32(txtIdentificador.Text) + "," + 0 + ",'" + comboTipoSala.SelectedItem.ToString() + "')" +
                "insert into Sala (idAsiento, idPelicula, estado, tipoSala) values('" + txtNombre.Text + "-" + comboTipoSala.SelectedItem.ToString() + "-B1'," + Convert.ToInt32(txtIdentificador.Text) + "," + 0 + ",'" + comboTipoSala.SelectedItem.ToString() + "')" +
                "insert into Sala (idAsiento, idPelicula, estado, tipoSala) values('" + txtNombre.Text + "-" + comboTipoSala.SelectedItem.ToString() + "-B2'," + Convert.ToInt32(txtIdentificador.Text) + "," + 0 + ",'" + comboTipoSala.SelectedItem.ToString() + "')" +
                "insert into Sala (idAsiento, idPelicula, estado, tipoSala) values('" + txtNombre.Text + "-" + comboTipoSala.SelectedItem.ToString() + "-B3'," + Convert.ToInt32(txtIdentificador.Text) + "," + 0 + ",'" + comboTipoSala.SelectedItem.ToString() + "')" +
                "insert into Sala (idAsiento, idPelicula, estado, tipoSala) values('" + txtNombre.Text + "-" + comboTipoSala.SelectedItem.ToString() + "-B4'," + Convert.ToInt32(txtIdentificador.Text) + "," + 0 + ",'" + comboTipoSala.SelectedItem.ToString() + "')" +
                "insert into Sala (idAsiento, idPelicula, estado, tipoSala) values('" + txtNombre.Text + "-" + comboTipoSala.SelectedItem.ToString() + "-B5'," + Convert.ToInt32(txtIdentificador.Text) + "," + 0 + ",'" + comboTipoSala.SelectedItem.ToString() + "')" +
                "insert into Sala (idAsiento, idPelicula, estado, tipoSala) values('" + txtNombre.Text + "-" + comboTipoSala.SelectedItem.ToString() + "-B6'," + Convert.ToInt32(txtIdentificador.Text) + "," + 0 + ",'" + comboTipoSala.SelectedItem.ToString() + "')" +
                "insert into Sala (idAsiento, idPelicula, estado, tipoSala) values('" + txtNombre.Text + "-" + comboTipoSala.SelectedItem.ToString() + "-B7'," + Convert.ToInt32(txtIdentificador.Text) + "," + 0 + ",'" + comboTipoSala.SelectedItem.ToString() + "')" +
                "insert into Sala (idAsiento, idPelicula, estado, tipoSala) values('" + txtNombre.Text + "-" + comboTipoSala.SelectedItem.ToString() + "-B8'," + Convert.ToInt32(txtIdentificador.Text) + "," + 0 + ",'" + comboTipoSala.SelectedItem.ToString() + "')" +
                "insert into Sala (idAsiento, idPelicula, estado, tipoSala) values('" + txtNombre.Text + "-" + comboTipoSala.SelectedItem.ToString() + "-B9'," + Convert.ToInt32(txtIdentificador.Text) + "," + 0 + ",'" + comboTipoSala.SelectedItem.ToString() + "')" +
                "insert into Sala (idAsiento, idPelicula, estado, tipoSala) values('" + txtNombre.Text + "-" + comboTipoSala.SelectedItem.ToString() + "-C1'," + Convert.ToInt32(txtIdentificador.Text) + "," + 0 + ",'" + comboTipoSala.SelectedItem.ToString() + "')" +
                "insert into Sala (idAsiento, idPelicula, estado, tipoSala) values('" + txtNombre.Text + "-" + comboTipoSala.SelectedItem.ToString() + "-C2'," + Convert.ToInt32(txtIdentificador.Text) + "," + 0 + ",'" + comboTipoSala.SelectedItem.ToString() + "')" +
                "insert into Sala (idAsiento, idPelicula, estado, tipoSala) values('" + txtNombre.Text + "-" + comboTipoSala.SelectedItem.ToString() + "-C3'," + Convert.ToInt32(txtIdentificador.Text) + "," + 0 + ",'" + comboTipoSala.SelectedItem.ToString() + "')" +
                "insert into Sala (idAsiento, idPelicula, estado, tipoSala) values('" + txtNombre.Text + "-" + comboTipoSala.SelectedItem.ToString() + "-C4'," + Convert.ToInt32(txtIdentificador.Text) + "," + 0 + ",'" + comboTipoSala.SelectedItem.ToString() + "')" +
                "insert into Sala (idAsiento, idPelicula, estado, tipoSala) values('" + txtNombre.Text + "-" + comboTipoSala.SelectedItem.ToString() + "-C5'," + Convert.ToInt32(txtIdentificador.Text) + "," + 0 + ",'" + comboTipoSala.SelectedItem.ToString() + "')" +
                "insert into Sala (idAsiento, idPelicula, estado, tipoSala) values('" + txtNombre.Text + "-" + comboTipoSala.SelectedItem.ToString() + "-C6'," + Convert.ToInt32(txtIdentificador.Text) + "," + 0 + ",'" + comboTipoSala.SelectedItem.ToString() + "')" +
                "insert into Sala (idAsiento, idPelicula, estado, tipoSala) values('" + txtNombre.Text + "-" + comboTipoSala.SelectedItem.ToString() + "-C7'," + Convert.ToInt32(txtIdentificador.Text) + "," + 0 + ",'" + comboTipoSala.SelectedItem.ToString() + "')" +
                "insert into Sala (idAsiento, idPelicula, estado, tipoSala) values('" + txtNombre.Text + "-" + comboTipoSala.SelectedItem.ToString() + "-C8'," + Convert.ToInt32(txtIdentificador.Text) + "," + 0 + ",'" + comboTipoSala.SelectedItem.ToString() + "')" +
                "insert into Sala (idAsiento, idPelicula, estado, tipoSala) values('" + txtNombre.Text + "-" + comboTipoSala.SelectedItem.ToString() + "-C9'," + Convert.ToInt32(txtIdentificador.Text) + "," + 0 + ",'" + comboTipoSala.SelectedItem.ToString() + "')" +
                "insert into Sala (idAsiento, idPelicula, estado, tipoSala) values('" + txtNombre.Text + "-" + comboTipoSala.SelectedItem.ToString() + "-D1'," + Convert.ToInt32(txtIdentificador.Text) + "," + 0 + ",'" + comboTipoSala.SelectedItem.ToString() + "')" +
                "insert into Sala (idAsiento, idPelicula, estado, tipoSala) values('" + txtNombre.Text + "-" + comboTipoSala.SelectedItem.ToString() + "-D2'," + Convert.ToInt32(txtIdentificador.Text) + "," + 0 + ",'" + comboTipoSala.SelectedItem.ToString() + "')" +
                "insert into Sala (idAsiento, idPelicula, estado, tipoSala) values('" + txtNombre.Text + "-" + comboTipoSala.SelectedItem.ToString() + "-D3'," + Convert.ToInt32(txtIdentificador.Text) + "," + 0 + ",'" + comboTipoSala.SelectedItem.ToString() + "')" +
                "insert into Sala (idAsiento, idPelicula, estado, tipoSala) values('" + txtNombre.Text + "-" + comboTipoSala.SelectedItem.ToString() + "-D4'," + Convert.ToInt32(txtIdentificador.Text) + "," + 0 + ",'" + comboTipoSala.SelectedItem.ToString() + "')" +
                "insert into Sala (idAsiento, idPelicula, estado, tipoSala) values('" + txtNombre.Text + "-" + comboTipoSala.SelectedItem.ToString() + "-D5'," + Convert.ToInt32(txtIdentificador.Text) + "," + 0 + ",'" + comboTipoSala.SelectedItem.ToString() + "')" +
                "insert into Sala (idAsiento, idPelicula, estado, tipoSala) values('" + txtNombre.Text + "-" + comboTipoSala.SelectedItem.ToString() + "-D6'," + Convert.ToInt32(txtIdentificador.Text) + "," + 0 + ",'" + comboTipoSala.SelectedItem.ToString() + "')" +
                "insert into Sala (idAsiento, idPelicula, estado, tipoSala) values('" + txtNombre.Text + "-" + comboTipoSala.SelectedItem.ToString() + "-D7'," + Convert.ToInt32(txtIdentificador.Text) + "," + 0 + ",'" + comboTipoSala.SelectedItem.ToString() + "')" +
                "insert into Sala (idAsiento, idPelicula, estado, tipoSala) values('" + txtNombre.Text + "-" + comboTipoSala.SelectedItem.ToString() + "-D8'," + Convert.ToInt32(txtIdentificador.Text) + "," + 0 + ",'" + comboTipoSala.SelectedItem.ToString() + "')" +
                "insert into Sala (idAsiento, idPelicula, estado, tipoSala) values('" + txtNombre.Text + "-" + comboTipoSala.SelectedItem.ToString() + "-D9'," + Convert.ToInt32(txtIdentificador.Text) + "," + 0 + ",'" + comboTipoSala.SelectedItem.ToString() + "')" +
                "insert into Sala (idAsiento, idPelicula, estado, tipoSala) values('" + txtNombre.Text + "-" + comboTipoSala.SelectedItem.ToString() + "-E1'," + Convert.ToInt32(txtIdentificador.Text) + "," + 0 + ",'" + comboTipoSala.SelectedItem.ToString() + "')" +
                "insert into Sala (idAsiento, idPelicula, estado, tipoSala) values('" + txtNombre.Text + "-" + comboTipoSala.SelectedItem.ToString() + "-E2'," + Convert.ToInt32(txtIdentificador.Text) + "," + 0 + ",'" + comboTipoSala.SelectedItem.ToString() + "')" +
                "insert into Sala (idAsiento, idPelicula, estado, tipoSala) values('" + txtNombre.Text + "-" + comboTipoSala.SelectedItem.ToString() + "-E3'," + Convert.ToInt32(txtIdentificador.Text) + "," + 0 + ",'" + comboTipoSala.SelectedItem.ToString() + "')" +
                "insert into Sala (idAsiento, idPelicula, estado, tipoSala) values('" + txtNombre.Text + "-" + comboTipoSala.SelectedItem.ToString() + "-E4'," + Convert.ToInt32(txtIdentificador.Text) + "," + 0 + ",'" + comboTipoSala.SelectedItem.ToString() + "')" +
                "insert into Sala (idAsiento, idPelicula, estado, tipoSala) values('" + txtNombre.Text + "-" + comboTipoSala.SelectedItem.ToString() + "-E5'," + Convert.ToInt32(txtIdentificador.Text) + "," + 0 + ",'" + comboTipoSala.SelectedItem.ToString() + "')" +
                "insert into Sala (idAsiento, idPelicula, estado, tipoSala) values('" + txtNombre.Text + "-" + comboTipoSala.SelectedItem.ToString() + "-E6'," + Convert.ToInt32(txtIdentificador.Text) + "," + 0 + ",'" + comboTipoSala.SelectedItem.ToString() + "')" +
                "insert into Sala (idAsiento, idPelicula, estado, tipoSala) values('" + txtNombre.Text + "-" + comboTipoSala.SelectedItem.ToString() + "-E7'," + Convert.ToInt32(txtIdentificador.Text) + "," + 0 + ",'" + comboTipoSala.SelectedItem.ToString() + "')" +
                "insert into Sala (idAsiento, idPelicula, estado, tipoSala) values('" + txtNombre.Text + "-" + comboTipoSala.SelectedItem.ToString() + "-E8'," + Convert.ToInt32(txtIdentificador.Text) + "," + 0 + ",'" + comboTipoSala.SelectedItem.ToString() + "')" +
                "insert into Sala (idAsiento, idPelicula, estado, tipoSala) values('" + txtNombre.Text + "-" + comboTipoSala.SelectedItem.ToString() + "-E9'," + Convert.ToInt32(txtIdentificador.Text) + "," + 0 + ",'" + comboTipoSala.SelectedItem.ToString() + "')";
            DataTable dt = new DataTable();
            conexionBase.abrirConexion();
            SqlDataAdapter sqla = new SqlDataAdapter(sql, conexionBase.sqlconn);
            sqla.Fill(dt);
            conexionBase.sqlconn.Close();

        }

    }
}
