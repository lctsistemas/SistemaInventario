using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entities
{
    public class DTipoDocumento
    {
        private int iddocumento;
        private string codigo;
        private string descripcion;

        public DTipoDocumento(int iddocumento, int codigo, string descripcion)
        {
            this.Iddocumento = iddocumento;
            this.Codigo = codigo;
            this.Descripcion = descripcion;
        }

        public DTipoDocumento()
        {

        }

        public int Iddocumento { get => iddocumento; set => iddocumento = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
