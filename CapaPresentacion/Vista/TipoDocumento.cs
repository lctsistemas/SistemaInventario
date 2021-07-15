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
        string result;
        List<DTipoDocumento> lst;
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
            dgvTipoDoc.Columns[0].Visible = true;
            dgvTipoDoc.Columns[1].Visible = false;
            dgvTipoDoc.Columns[2].HeaderText = "CODIGO";
            dgvTipoDoc.Columns[3].HeaderText = "DESCRIPCION";
        }

        private void Show_Documento()
        {
            dgvTipoDoc.DataSource = rtipoDoc.Getdata(dtipoDoc);
        }

        private void Txtbuscar_TextChanged(object sender, EventArgs e)
        {
            dgvTipoDoc.DataSource = rtipoDoc.Search(Txtbuscar.Text.Trim());
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
                TipoDoc.txtcodDoc.Text = dgvTipoDoc.CurrentRow.Cells[2].Value.ToString();
                TipoDoc.txtDescDoc.Text = dgvTipoDoc.CurrentRow.Cells[3].Value.ToString();

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

        private void Btnexcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Excel Files | *.xls;*.xlsx;*.xlsm;";
            dialog.Title = "Importar";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Lbl_ruta.Visible = true;
                Lbl_ruta.Text = dialog.FileName;
                dgvTipoDoc.DataSource = rtipoDoc.ImportarAchivoExcel(dialog.FileName);
                Tabla();
                BtnGuardar.Visible = true;

                // Dgv_Importar.Columns[0].HeaderText = "CODIGO";
                //ImportarAchivoExcel(dialog.FileName);
            }
            dialog.Dispose();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!(this.dgvTipoDoc.RowCount > 0))
                return;

            string men = string.Format("Registrando {0} Filas...", dgvTipoDoc.RowCount.ToString("N0"));
            using (var frmpro = new FrmProcesoWait(SetInventario, men))
            {
                frmpro.StartPosition = FormStartPosition.CenterParent;
                frmpro.ShowDialog(this);

                if (result.Contains("El Registro"))
                    Msg.M_info(result);
                else
                    Msg.M_error(result);
            }
        }

        private void SetInventario()
        {
            lst = new List<DTipoDocumento>();
            foreach (DataGridViewRow item in dgvTipoDoc.Rows)
            {
                lst.Add(new DTipoDocumento()
                {
                    Codigo = item.Cells[1].Value.ToString(),
                    Descripcion = item.Cells[2].Value.ToString(),
                  

                });
            }
            result = rtipoDoc.Add_Multiple(lst);
        }

        private void dgvTipoDoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string result = "";
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == this.dgvTipoDoc.Columns["dgv_txtdelete"].Index)
                {
                    if (Msg.M_question("¿Desea Eliminar la Operacion?") == DialogResult.Yes)
                    {

                        dtipoDoc.Iddocumento = Convert.ToInt32(dgvTipoDoc.CurrentRow.Cells[1].Value);
                        //dunidMed.Abrev = Dgv_Unidadmedida.CurrentRow.Cells[1].Value.ToString();
                        //dunidMed.Descripcion = Dgv_Unidadmedida.CurrentRow.Cells[2].Value.ToString();
                        result = rtipoDoc.Delete(dtipoDoc);

                        if (result.Contains("Se Elimino"))
                        {
                            Msg.M_info(result);
                            Show_Documento();
                        }
                        else
                            Msg.M_error(result);

                    }
                }
            }
        }
    }
}
