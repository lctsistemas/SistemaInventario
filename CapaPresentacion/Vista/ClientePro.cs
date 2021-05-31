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
            Dgv_cliente.Columns[0].Visible = true; //bton eliminar
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

        private void btneliminar_Click(object sender, EventArgs e)
        {
            

        }

        private void Dgv_cliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string result = "";
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == this.Dgv_cliente.Columns["dgv_txtdelete"].Index)
                {
                    if (Msg.M_question("¿Desea Eliminar el proveedor?") == DialogResult.Yes)
                    {

                        dclienteprov.Idprov = Convert.ToInt32(Dgv_cliente.CurrentRow.Cells[1].Value);
                        dclienteprov.Nom_prov = Dgv_cliente.CurrentRow.Cells[2].Value.ToString();
                        result = rclienteprov.Delete(dclienteprov);

                        if (result.Contains("¡Se Eliminar"))
                        {
                            Msg.M_info(result);
                            Show_business();
                        }
                        else
                            Msg.M_error(result);

                    }
                }

            }
        }
    }
}
