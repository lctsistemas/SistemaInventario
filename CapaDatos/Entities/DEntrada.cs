using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entities
{
    public class DEntrada
    {
        //public string periodo { get; set; } //1
        //public string COU { get; set; } //2
        //public string numero_asiento { get; set; } //3
        //public string cod_anexo { get; set; } //4
        public string cod_catalogo { get; set; } //5
        public string tipo_existencia { get; set; } //6
        public string cod_existencia { get; set; } //7
        //public string cod_ctl { get; set; } //8  no obligatorio
        //public string cod_ext_ctl { get; set; } //9  no obligatorio
        public DateTime fecha_emision { get; set; } //10
        public string tipo_documento { get; set; } //11
        public string serie { get; set; } //12
        public string num_documento { get; set; } //13
        public string tipo_operacion { get; set; } //14
        public string existencia { get; set; } //15
        public string unida_medida { get; set; } //16
        public double entradas { get; set; } //17
        public double salidas { get; set; } //18
        public int Id_empresa { get; set; }
        public int Id_periodo { get; set; }
        public int Id_mes { get; set; }

    }
}
