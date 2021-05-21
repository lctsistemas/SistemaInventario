using CapaDatos.Entities;
using CapaNegocio.Repositories;
using CapaPresentacion.Helps;
using CapaPresentacion.SubVista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Vista
{
    public partial class FrmMoneda : Form
    {
        readonly DMoneda dMoneda;
        readonly RMoneda rMoneda;
        public FrmMoneda()
        {
            InitializeComponent();
            dMoneda = new DMoneda();
            rMoneda = new RMoneda();
            Show_moneda();
            Tabla();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            using (FrmV_Moneda vmon = new FrmV_Moneda())
            {
                vmon.StartPosition = FormStartPosition.CenterParent;
                vmon.btnmodificar.Visible = false;
                vmon.btnguardar.Visible = true;
                vmon.ShowDialog();
                //Show_business("ACTIVO");
            }
        }

        private void Show_moneda()
        {
            Dgv_moneda.DataSource = rMoneda.Getdata(dMoneda);

        }

        //TABLA
        private void Tabla()
        {
            Dgv_moneda.Columns[0].Visible = false;
            Dgv_moneda.Columns[1].HeaderText = "CODIGO";
            Dgv_moneda.Columns[2].HeaderText = "MONEDA";
            Dgv_moneda.Columns[3].HeaderText = "ABREVIATURA";
            Dgv_moneda.Columns[4].HeaderText = "SIMBOLO";
            Dgv_moneda.Columns[4].HeaderText = "DESCRIPCION";
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (Dgv_moneda.Rows.Count <= 0)
            {
                Msg.M_warning("Seleccione una Fila para poder modificar");
                return;
            }


            using (FrmV_Moneda mon = new FrmV_Moneda())
            {
                mon.StartPosition = FormStartPosition.CenterParent;
                mon.Txt_idmon.Text = Dgv_moneda.CurrentRow.Cells[0].Value.ToString();
                mon.txtmoneda.Text = Dgv_moneda.CurrentRow.Cells[1].Value.ToString();
                mon.txtabrev.Text = Dgv_moneda.CurrentRow.Cells[2].Value.ToString();
                mon.txtsimbolo.Text = Dgv_moneda.CurrentRow.Cells[3].Value.ToString();
                mon.txtDesc.Text = Dgv_moneda.CurrentRow.Cells[4].Value.ToString();

                mon.btnmodificar.Visible = true;
                mon.btnguardar.Visible = false;
                mon.ShowDialog();
                Show_moneda();
            }
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            Dgv_moneda.DataSource = rMoneda.Search(txtbuscar.Text.Trim());
        }
    }
}
