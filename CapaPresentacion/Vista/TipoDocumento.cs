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
    public partial class FrmTipoDocumento : Form
    {
        readonly DTipoDocumento dtipoDoc;
        readonly RTipoDocumento rtipoDoc;
        public FrmTipoDocumento()
        {
            InitializeComponent();
            dtipoDoc = new DTipoDocumento();
            rtipoDoc = new RTipoDocumento();
            Show_TipoDoc();
            Tabla();
        }

        //METODO CARGAR DATAGRIDVIEW
        private void Show_TipoDoc()
        {
            dgvTipoDoc.DataSource = rtipoDoc.Getdata(dtipoDoc);

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            using (FrmVTipo_Doc TipoDoc = new FrmVTipo_Doc())
            {
                TipoDoc.StartPosition = FormStartPosition.CenterParent;
                TipoDoc.btnguardar.Visible = true;
                TipoDoc.btnmodificar.Visible = false;
                TipoDoc.ShowDialog();
                Show_Documento();
            }
        }

        private void Tabla()
        {
            dgvTipoDoc.Columns[0].Visible = false;
            dgvTipoDoc.Columns[1].HeaderText = "CODIGO";
            dgvTipoDoc.Columns[2].HeaderText = "DESCRIPCION";
        }

        private void Show_Documento()
        {
            dgvTipoDoc.DataSource = rtipoDoc.Getdata(dtipoDoc);

        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            dgvTipoDoc.DataSource = rtipoDoc.Search(txtbuscar.Text.Trim());
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (dgvTipoDoc.Rows.Count <= 0)
            {
                Msg.M_warning("Seleccione una Fila para poder modificar");
                return;
            }


            using (FrmVTipo_Doc TipoDoc = new FrmVTipo_Doc())
            {
                TipoDoc.StartPosition = FormStartPosition.CenterParent;
                TipoDoc.txtidTipoDoc.Text = dgvTipoDoc.CurrentRow.Cells[0].Value.ToString();
                TipoDoc.txtcodDoc.Text = dgvTipoDoc.CurrentRow.Cells[1].Value.ToString();
                TipoDoc.txtDescDoc.Text = dgvTipoDoc.CurrentRow.Cells[2].Value.ToString();

                TipoDoc.btnmodificar.Visible = true;
                TipoDoc.btnguardar.Visible = false;
                TipoDoc.ShowDialog();
                Show_TipoDoc();
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
