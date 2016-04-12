using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Cines
{
    class Conexion
    {
        //public static string conexion = "Data Source=DESKTOP-ABP4LKI;" + "Initial Catalog=bd_Cine;" + "Integrated Security=True;";//Jonathan
        public static string conexion = @"Data Source=JOECAMP77;" + "Initial Catalog=bd_Cine;" + "Integrated Security=True;";//Johel
        public SqlConnection sqlconn = new SqlConnection(Conexion.conexion);
        public SqlCommand sqlcomm = new SqlCommand();

        public void abrirConexion()
        {
            try
            {
                sqlconn.Open();
                
            }
            catch
            {
               
            }


        }
    }
}
