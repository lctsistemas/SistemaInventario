using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entities
{
    public class DTipoOperacion
    {
        private int idTipo_Oper;
        private int codigo;
        private string descripcion;

        public DTipoOperacion(int idTipo_Oper, int codigo, string descripcion)
        {
            this.IdTipo_Oper = idTipo_Oper;
            this.Codigo = codigo;
            this.Descripcion = descripcion;
        }

        public DTipoOperacion()
        {
        }

        public int IdTipo_Oper { get => idTipo_Oper; set => idTipo_Oper = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
