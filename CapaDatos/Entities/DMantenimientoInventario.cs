using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entities
{
    public class DMantenimientoInventario
    {
        public int Inv_cantidad { get; set; }
        public string Inv_cod_exis { get; set; }
        public string Inv_existencia { get; set; }
        public double Inv_entrada { get; set; }
        public double Inv_salida { get; set; }
        public double Inv_final { get; set; }

    }
}
