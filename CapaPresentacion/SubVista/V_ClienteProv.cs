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
    public partial class FrmV_ClienteProv : Form
    {
        readonly DClienteProv dClienteProv;
        readonly RClienteProv rClienteProv;
        public FrmV_ClienteProv()
        {
            InitializeComponent();
            dClienteProv = new DClienteProv();
            rClienteProv = new RClienteProv();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string result = "";
            dClienteProv.Nom_prov = txtnomprov.Text.Trim();
            dClienteProv.Ruc = txtruc.Text.Trim();

            result = rClienteProv.Add(dClienteProv);


            txtnomprov.Text = string.Empty;
            txtruc.Text = string.Empty;
            Msg.M_info(result);
            //MessageBox.Show(result);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnomprov.Text) || string.IsNullOrWhiteSpace(txtruc.Text))
                 
            {
                ValidateChildren();
                return;
            }

            string result = "";
            dClienteProv.Idprov = int.Parse(Txt_idprov.Text.Trim());
            dClienteProv.Nom_prov = txtnomprov.Text.Trim();
            dClienteProv.Ruc = txtruc.Text.Trim();
            

            result = rClienteProv.Edit(dClienteProv);
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
            txtnomprov.Focus();

        }
    }
}
