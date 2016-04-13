using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace Cines
{
    class MaquinaVieja
    {
        Conexion conexionBase = new Conexion();
        Consola consola = new Consola();

        public void iniciar()
        {
            consola.AsignarConsola();
            Console.WriteLine("1-Comprar boleto\n2-Salir");
            string opcion = Console.ReadLine();
            if (opcion == "1")
            {
                imprimirCartelera();
                Console.WriteLine("Ingrese el número de identificador de la película");
                string idPelicula = Console.ReadLine();
                mostrarSala(idPelicula);
                Asientos asientos = new Asientos();
                Thread mostrarAsientos = new Thread(() =>
                {
                    asientos.Show();
                    Application.Run(asientos);
                });
                mostrarAsientos.SetApartmentState(ApartmentState.STA);
                mostrarAsientos.Start();
                Console.WriteLine("\nSeleccione su Pelicula");
                string pelicula = Console.ReadLine();
                Console.WriteLine("\nSeleccione su Sala");
                string sala = Console.ReadLine();
                Console.WriteLine("\nSeleccione su asiento");
                string asiento = Console.ReadLine();
                string asientoSeleccionado = pelicula + "-" + sala + "-" + asiento;
                Application.ExitThread();
                validarAsiento(asientoSeleccionado);
                string sql = "update Sala set estado = " + 1 + "where idAsiento=" + "'" + asientoSeleccionado + "'";
               
                if (validarAsiento(asientoSeleccionado))
                {
                    DataTable dt = new DataTable();
                    conexionBase.abrirConexion();
                    SqlDataAdapter sqla = new SqlDataAdapter(sql, conexionBase.sqlconn);
                    sqla.Fill(dt);
                    conexionBase.sqlconn.Close();

                }
                else
                {
                    Console.WriteLine("Asiento ocupado/No existe");
                }

                iniciar();
            }

            else if (opcion == "2")
            {
                consola.LiberarConsola();
            }
            else
            {
                Console.WriteLine("Opción inválida\n\n");
                iniciar();
            }
        }
        public bool validarAsiento(string idAsiento)
        {
            string sql = "select estado from Sala where idAsiento= '" + idAsiento+ "'";
            DataTable dt = new DataTable();
            conexionBase.abrirConexion();
            SqlDataAdapter sqla = new SqlDataAdapter(sql, conexionBase.sqlconn);
            sqla.Fill(dt);
            conexionBase.sqlconn.Close();
            string estado = Convert.ToString(dt.Rows[0][0].ToString());
            if (estado == "False")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void generarAsientos()
        {
        }

        public void imprimirCartelera()
        {
            string sql;
            DataTable dt = new DataTable();
            sql = "select nombrePelicula as 'Película', idioma as Idioma, tipoSala as Sala, numeroSala as 'Sala número', horario as 'Horario'," +
                " categoria as 'Categoría', duracion as 'Duración' from Pelicula";
            conexionBase.abrirConexion();
            SqlDataAdapter sqla = new SqlDataAdapter(sql, conexionBase.sqlconn);
            sqla.Fill(dt);
            conexionBase.sqlconn.Close();
            Console.WriteLine("\nIdentificador película | Película | Idioma | Sala tipo | Sala número | Horario | Categoría | Duración\n");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    Console.Write(i + 1 + " | " + Convert.ToString(dt.Rows[i][j].ToString()) + " | ");
                }
                Console.WriteLine("\n");
            }
        }
        public void mostrarSala(string idPelicula)
        {
            string sql;
            DataTable dt = new DataTable();
            sql = "select idAsiento from Sala where idPelicula=" + idPelicula + " and estado=" + 0;
            conexionBase.abrirConexion();
            SqlDataAdapter sqla = new SqlDataAdapter(sql, conexionBase.sqlconn);
            sqla.Fill(dt);
            conexionBase.sqlconn.Close();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Console.Write(Convert.ToString(dt.Rows[i][0].ToString()) + " - ");
            }

        }
    }
}
