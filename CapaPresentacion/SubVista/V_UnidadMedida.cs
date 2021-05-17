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
    public partial class V_UnidadMedida : Form
    {
        readonly DUnidadMedida dUnidadMedida;
        readonly RUnidadMedida rUnidadMedida;
        public V_UnidadMedida()
        {
            InitializeComponent();
            dUnidadMedida = new DUnidadMedida();
            rUnidadMedida = new RUnidadMedida();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string result = "";
            dUnidadMedida.Codigo = txtcodUM.Text.Trim();
            dUnidadMedida.Abrev = txtAbrev.Text.Trim();
            dUnidadMedida.Descripcion = txtDesc.Text.Trim();

            result = rUnidadMedida.Add(dUnidadMedida);

            txtcodUM.Text = string.Empty;
            txtAbrev.Text = string.Empty;
            txtDesc.Text = string.Empty;

            Msg.M_info(result);
        }
    }
}
