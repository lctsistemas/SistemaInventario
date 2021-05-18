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
    public partial class FrmV_Moneda : Form
    {
        readonly DMoneda dMoneda;
        readonly RMoneda rMoneda;
        public FrmV_Moneda()
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

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtcodMon.Text) || string.IsNullOrWhiteSpace(txtmoneda.Text) || 
                string.IsNullOrWhiteSpace(txtabrev.Text) || string.IsNullOrWhiteSpace(txtsimbolo.Text) ||
                string.IsNullOrWhiteSpace(txtDesc.Text))

            {
                ValidateChildren();
                return;
            }

            string result = "";
            dMoneda.Idmoneda = int.Parse(Txt_idmon.Text.Trim());
            dMoneda.Codigo = txtcodMon.Text.Trim();
            dMoneda.Nom_moneda = txtmoneda.Text.Trim();
            dMoneda.Abrev = txtabrev.Text.Trim();
            dMoneda.Descripcion = txtDesc.Text.Trim();
            


            result = rMoneda.Edit(dMoneda);
            if (result.Contains("Se Modifico"))
                Msg.M_info(result);
            else
                Msg.M_error(result);

            Limpiar();
        }

        private void Limpiar()
        {
            //Control x;

            foreach (dynamic item in this.panelregistro.Controls)
            {
                if (item is Guna.UI2.WinForms.Guna2TextBox || item is ComboBox)
                {
                    item.Text = null;
                }

            }
            txtcodMon.Focus();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
