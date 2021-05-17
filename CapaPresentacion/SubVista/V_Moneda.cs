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
    public partial class V_Moneda : Form
    {
        readonly DMoneda dMoneda;
        readonly RMoneda rMoneda;
        public V_Moneda()
        {
            InitializeComponent();
            dMoneda = new DMoneda();
            rMoneda = new RMoneda();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string result = "";
            dMoneda.Codigo = txtcodMon.Text.Trim();
            dMoneda.Nom_moneda = txtmoneda.Text.Trim();
            dMoneda.Abrev = txtabrev.Text.Trim();
            dMoneda.Simbolo = txtsimbolo.Text.Trim();
            dMoneda.Descripcion = txtDesc.Text.Trim();

            result = rMoneda.Add(dMoneda);


            txtcodMon.Text = string.Empty;
            txtmoneda.Text = string.Empty;
            txtabrev.Text = string.Empty;
            txtsimbolo.Text = string.Empty;
            txtDesc.Text = string.Empty;
            Msg.M_info(result);
        }
    }
}
