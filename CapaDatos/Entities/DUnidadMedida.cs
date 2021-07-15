using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entities
{
    public class DUnidadMedida
    {
        private int idUnidadMedida;
        private string codigo;
        private string abrev;
        private string descripcion;

      

        public int IdUnidadMedida { get => idUnidadMedida; set => idUnidadMedida = value; }
        public string Abrev { get => abrev; set => abrev = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

    }
}
