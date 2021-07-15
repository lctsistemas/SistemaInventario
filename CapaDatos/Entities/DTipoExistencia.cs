using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entities
{
    public class DTipoExistencia
    {
        private int idTipoExist;
        private string codigo;
        private string descripcion;

        public int IdTipoExist { get => idTipoExist; set => idTipoExist = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
