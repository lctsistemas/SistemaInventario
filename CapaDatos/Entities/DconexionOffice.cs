using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace CapaDatos.Entities
{
    public class DconexionOffice
    {
        private static string conexion;
        public static OleDbConnection GetConectarOffice(string url)
        {
            conexion = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source= {0};" +
               " Extended Properties = 'Excel 8.0;HDR=Yes;IMEX=1;MAXSCANROWS=0'", url);
            return new OleDbConnection(conexion);
        }
    }
}
