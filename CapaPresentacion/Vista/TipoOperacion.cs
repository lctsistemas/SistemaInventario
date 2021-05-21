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
    public partial class FrmTipoOperacion : Form
    {
        readonly DTipoOperacion dtipoOper;
        readonly RTipoOperacion rtipoOper;
        public FrmTipoOperacion()
        {
            InitializeComponent();
            dtipoOper = new DTipoOperacion();
            rtipoOper = new RTipoOperacion();
            Show_TipoOper();
            Tabla();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            using (Frm_VTipoOper tipoOper = new Frm_VTipoOper())
            {
                tipoOper.StartPosition = FormStartPosition.CenterParent;
                tipoOper.btnguardar.Visible = true;
                tipoOper.btnmodificar.Visible = false;
                tipoOper.ShowDialog();
                Show_TipoOper();
            }
        }

        private void Show_TipoOper()
        {
            Dgv_tipoOper.DataSource = rtipoOper.Getdata(dtipoOper);

        }

        //TABLA
        private void Tabla()
        {
            Dgv_tipoOper.Columns[0].Visible = false;
            Dgv_tipoOper.Columns[1].HeaderText = "CODIGO";
            Dgv_tipoOper.Columns[2].HeaderText = "DESCRIPCION";
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (Dgv_tipoOper.Rows.Count <= 0)
            {
                Msg.M_warning("Seleccione una Fila para poder modificar");
                return;
            }


            using (Frm_VTipoOper tipoOper = new Frm_VTipoOper())
            {
                tipoOper.StartPosition = FormStartPosition.CenterParent;
                tipoOper.txtidTipoOper.Text = Dgv_tipoOper.CurrentRow.Cells[0].Value.ToString();
                tipoOper.txtcodOper.Text = Dgv_tipoOper.CurrentRow.Cells[1].Value.ToString();
                tipoOper.txtDesc.Text = Dgv_tipoOper.CurrentRow.Cells[2].Value.ToString();

                tipoOper.btnmodificar.Visible = true;
                tipoOper.btnguardar.Visible = false;
                tipoOper.ShowDialog();
                Show_TipoOper();
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            Dgv_tipoOper.DataSource = rtipoOper.Search(txtbuscar.Text.Trim());
        }
    }
}
