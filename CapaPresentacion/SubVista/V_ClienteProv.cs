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
    }
}
