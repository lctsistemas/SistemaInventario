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
        private string abrev;
        private string descripcion;

        public DUnidadMedida(int idUnidadMedida, string abrev, string descripcion)
        {
            this.idUnidadMedida = idUnidadMedida;
            this.abrev = abrev;
            this.descripcion = descripcion;
        }

        public DUnidadMedida()
        {
            
        }

        public int IdUnidadMedida { get => idUnidadMedida; set => idUnidadMedida = value; }
        public string Abrev { get => abrev; set => abrev = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

    }
}
