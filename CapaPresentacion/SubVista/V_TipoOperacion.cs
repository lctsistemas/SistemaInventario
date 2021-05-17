using CapaDatos.Entities;
using CapaNegocio.Repositories;
using CapaPresentacion.Helps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.SubVista
{
    public partial class Frm_VTipoOper : Form
    {
        readonly DTipoOperacion dTipoOperacion;
        readonly RTipoOperacion rTipoOperacion;
        public Frm_VTipoOper()
        {
            InitializeComponent();
            dTipoOperacion = new DTipoOperacion();
            rTipoOperacion = new RTipoOperacion();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string result = "";
            dTipoOperacion.Codigo = txtcodOper.Text.Trim();
            dTipoOperacion.Descripcion = txtDesc.Text.Trim();

            result = rTipoOperacion.Add(dTipoOperacion);


            txtcodOper.Text = string.Empty;
            txtDesc.Text = string.Empty;
            Msg.M_info(result);
        }
    }
}
