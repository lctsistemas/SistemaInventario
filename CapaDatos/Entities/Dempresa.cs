using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entities
{
    public class Dempresa
    {
        public int Id_empresa { get; set; }
        public string Ruc { get; set; }
        public string Razon_social { get; set; }
        public string Nombre_comercial { get; set; }
        public string Direccion { get; set; }
        public string Domicilio_fiscal { get; set; }
        public string Regimen { get; set; }
        public string Estado { get; set; }


    }
}
