﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entities
{
    public class DUnidadMedida
    {
        private int idUnidadMedida;
        private int codigo;
        private string abrev;
        private string descripcion;

        public DUnidadMedida(int idUnidadMedida, int codigo, string abrev,string descripcion)
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
        public int Codigo { get => codigo; set => codigo = value; }
        public string Abrev { get => abrev; set => abrev = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
