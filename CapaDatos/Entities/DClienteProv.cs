using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entities
{
    public class DClienteProv
    {
        private int idprov;
        private string nom_prov;
        private string ruc;

        public DClienteProv(int idprov, string nom_prov, string ruc)
        {
            this.idprov = idprov;
            this.nom_prov = nom_prov;
            this.ruc = ruc;
        }

        public DClienteProv()
        {
        }

        public int Idprov { get => idprov; set => idprov = value; }
        public string Nom_prov { get => nom_prov; set => nom_prov = value; }
        public string Ruc { get => ruc; set => ruc = value; }
    }
}
