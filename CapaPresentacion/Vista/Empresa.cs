using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaDatos.Entities;
using CapaDatos.Contracts;
using CapaNegocio.Repositories;
using CapaPresentacion.SubVista;
using CapaPresentacion.Helps;

namespace CapaPresentacion.Vista
{
    public partial class FrmEmpresa : Form
    {

        readonly Dempresa dempresa;
        readonly Rempresa rempresa;
       
        public FrmEmpresa()
        {
            InitializeComponent();
            dempresa = new Dempresa();
            rempresa = new Rempresa();
            Show_business("ACTIVO");
            Tabla();
        }

        //METODO CARGAR DATAGRIDVIEW
        private void Show_business(string st)
        {
            dempresa.Estado = st;
            Dgv_empresa.DataSource = rempresa.Getdata(dempresa);
            
        }

        //TABLA
        private void Tabla()
        {
            Dgv_empresa.Columns[1].Visible = false; // idempresa
            Dgv_empresa.Columns[2].HeaderText = "RUC";
            Dgv_empresa.Columns[3].HeaderText = "RAZON SOCIAL";
            Dgv_empresa.Columns[4].HeaderText = "NOMBRE COMERCIAL";
            Dgv_empresa.Columns[5].HeaderText = "DIRECCION";
            Dgv_empresa.Columns[6].HeaderText = "DOMICILIO FISCAL";
            Dgv_empresa.Columns[7].HeaderText = "REGIMEN";
            Dgv_empresa.Columns[8].Visible = false; // estado
            
        }


        private void Txtrazon_TextChanged(object sender, EventArgs e)
        {
            Dgv_empresa.DataSource = rempresa.Search(Txtbuscar.Text.Trim());
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            using (FrmV_Empresa vem= new FrmV_Empresa())
            {
               vem.StartPosition = FormStartPosition.CenterParent;
                vem.Btn_modificar.Visible = false;
                vem.Btn_guardar.Visible = true;
                vem.ShowDialog();
                Show_business("ACTIVO");
            }
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (Dgv_empresa.Rows.Count <= 0 )
            {
                Msg.M_warning("Seleccione una Fila para poder modificar");
                return;
            }
             
            
            using (FrmV_Empresa vem = new FrmV_Empresa())
            {
                vem.StartPosition = FormStartPosition.CenterParent;
                vem.Txt_idempresa.Text = Dgv_empresa.CurrentRow.Cells[1].Value.ToString();
                vem.Txtruc.Text = Dgv_empresa.CurrentRow.Cells[2].Value.ToString();
                vem.Txtrazon.Text = Dgv_empresa.CurrentRow.Cells[3].Value.ToString();
                vem.Txtnombre_comercial.Text = Dgv_empresa.CurrentRow.Cells[4].Value.ToString();
                vem.Txtdireccion.Text = Dgv_empresa.CurrentRow.Cells[5].Value.ToString();
                vem.Txtfiscal.Text = Dgv_empresa.CurrentRow.Cells[6].Value.ToString();
                vem.Cboregimen.Text = Dgv_empresa.CurrentRow.Cells[7].Value.ToString();

                vem.Btn_modificar.Visible = true;
                vem.Btn_guardar.Visible = false;
                vem.ShowDialog();
                Show_business("ACTIVO");
            }
        }

        private void Dgv_empresa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string result = "";
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == this.Dgv_empresa.Columns["dgv_txtdelete"].Index)
                {
                    if (Msg.M_question("¿Desea Anular la Empresa?") == DialogResult.Yes)
                    {                      

                        dempresa.Id_empresa = Convert.ToInt32(Dgv_empresa.CurrentRow.Cells[1].Value);
                        dempresa.Estado = "ANULADO";
                        result = rempresa.Delete(dempresa);

                        if (result.Contains("¡Se Anulo"))
                        {
                            Msg.M_info(result);
                            Show_business("ACTIVO");
                        }                           
                        else
                            Msg.M_error(result);

                    }
                }

            }
        }
    }
}
