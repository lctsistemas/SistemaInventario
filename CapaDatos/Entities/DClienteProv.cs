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
        private string ruc;
        private string nom_prov;

        public DClienteProv(int idprov, string ruc, string nom_prov)
        {
            this.Idprov = idprov;
            this.Ruc = ruc;
            this.Nom_prov = nom_prov;
        }

        public DClienteProv()
        {

        }

        public string mensaje { get; set; }

        public int Idprov
        {
            get { return idprov; }
            set { idprov = value; }
        }

        public string Ruc
        {
            get { return ruc; }
            set { ruc = value; }
        }

        public string Nom_prov
        {
            get { return nom_prov; }
            set { nom_prov = value; }
        }
    }
}
