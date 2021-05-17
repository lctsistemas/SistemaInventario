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

        public DUnidadMedida(int idUnidadMedida, string codigo, string abrev,string descripcion)
        {
            this.IdUnidadMedida = idUnidadMedida;
            this.Codigo = codigo;
            this.Abrev = abrev;
            this.Descripcion = descripcion;
        }

        public DUnidadMedida()
        {

        }

        public int IdUnidadMedida { get => idUnidadMedida; set => idUnidadMedida = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Abrev { get => abrev; set => abrev = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
