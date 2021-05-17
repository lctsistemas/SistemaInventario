using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entities
{
    public class DMoneda
    {
        private int idmoneda;
        private string codigo;
        private string nom_moneda;
        private string abrev;
        private string simbolo;
        private string descripcion;

        public DMoneda(int idmoneda, string codigo, string nom_moneda, string abrev, string simbolo, string descripcion)
        {
            this.Idmoneda = idmoneda;
            this.Codigo = codigo;
            this.Nom_moneda = nom_moneda;
            this.Abrev = abrev;
            this.Simbolo = simbolo;
            this.Descripcion = descripcion;
        }

        public DMoneda()
        {

        }

        public int Idmoneda { get => idmoneda; set => idmoneda = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Nom_moneda { get => nom_moneda; set => nom_moneda = value; }
        public string Abrev { get => abrev; set => abrev = value; }
        public string Simbolo { get => simbolo; set => simbolo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
