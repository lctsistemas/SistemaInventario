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
    public partial class FrmClientePro : Form
    {
        readonly DClienteProv dclienteprov;
        readonly RClienteProv rclienteprov;
        public FrmClientePro()
        {
            InitializeComponent();
            dclienteprov = new DClienteProv();
            rclienteprov = new RClienteProv();
            Show_business();
            Tabla();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            using (FrmV_ClienteProv cprov = new FrmV_ClienteProv())
            {
                cprov.StartPosition = FormStartPosition.CenterParent;
                cprov.btnguardar.Visible = true;
                cprov.btnmodificar.Visible = false;
                cprov.ShowDialog();
               Show_business();
            }
        }

        //METODO CARGAR DATAGRIDVIEW
        private void Show_business()
        {
            Dgv_cliente.DataSource = rclienteprov.Getdata(dclienteprov);

        }

        //TABLA
        private void Tabla()
        {
            Dgv_cliente.Columns[0].Visible = false;
            Dgv_cliente.Columns[1].HeaderText = "PROVEEDOR";
            Dgv_cliente.Columns[2].HeaderText = "RUC";
        }

        private void Txtbuscar_TextChanged(object sender, EventArgs e)
        {
            Dgv_cliente.DataSource = rclienteprov.Search(Txtbuscar.Text.Trim());
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (Dgv_cliente.Rows.Count <= 0)
            {
                Msg.M_warning("Seleccione una Fila para poder modificar");
                return;
            }


            using (FrmV_ClienteProv cliprov = new FrmV_ClienteProv())
            {
                cliprov.StartPosition = FormStartPosition.CenterParent;
                cliprov.Txt_idprov.Text = Dgv_cliente.CurrentRow.Cells[0].Value.ToString();
                cliprov.txtnomprov.Text = Dgv_cliente.CurrentRow.Cells[1].Value.ToString();
                cliprov.txtruc.Text = Dgv_cliente.CurrentRow.Cells[2].Value.ToString();

                cliprov.btnmodificar.Visible = true;
                cliprov.btnguardar.Visible = false;
                cliprov.ShowDialog();
                Show_business();
            }
        }
    }
}
