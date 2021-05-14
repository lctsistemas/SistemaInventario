using System.Configuration;
using System.Data.SqlClient;

namespace CapaDatos.Entities
{
    public class Dconexion
    {
        private static string conexion;

        public static SqlConnection Getconectar()
        {
            conexion = ConfigurationManager.ConnectionStrings["Dbinvent"].ToString();
            return new SqlConnection(conexion);
        }
    }
}
