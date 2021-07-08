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
    public partial class FrmUnidadMedida : Form
    {
        readonly DUnidadMedida dunidMed;
        readonly RUnidadMedida runidMed;
        public FrmUnidadMedida()
        {
            InitializeComponent();
            dunidMed = new DUnidadMedida();
            runidMed = new RUnidadMedida();
            Show_UnidadMed();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            using (FrmV_UnidadMedida unidadMedida = new FrmV_UnidadMedida())
            {
                unidadMedida.StartPosition = FormStartPosition.CenterParent;
                unidadMedida.btnguardar.Visible = true;
                unidadMedida.btnmodificar.Visible = false;
                unidadMedida.ShowDialog();
                Show_UnidadMed();
            }
        }

        private void Show_UnidadMed()
        {
            Dgv_Unidadmedida.DataSource = runidMed.Getdata(dunidMed);

        }

        //TABLA
        private void Tabla()
        {
            Dgv_Unidadmedida.Columns[0].Visible = true; //ELIMINAR
            Dgv_Unidadmedida.Columns[1].HeaderText = "ID";
            Dgv_Unidadmedida.Columns[1].Visible = false;

            Dgv_Unidadmedida.Columns[2].HeaderText = "CODIGO";
            Dgv_Unidadmedida.Columns[2].Visible = false;
            Dgv_Unidadmedida.Columns[3].HeaderText = "ABREVIATURA";
            Dgv_Unidadmedida.Columns[4].HeaderText = "DESCRIPCION";
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_excel_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Excel Files | *.xls;*.xlsx;*.xlsm;";
            dialog.Title = "Importar";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Lbl_ruta.Visible = true;
                Lbl_ruta.Text = dialog.FileName;
                Dgv_Unidadmedida.DataSource = runidMed.ImportarAchivoExcel(dialog.FileName);
                Tabla();

            }
            dialog.Dispose();
        }

        private void Dgv_Unidadmedida_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string result = "";
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == this.Dgv_Unidadmedida.Columns["dgv_txtdelete"].Index)
                {
                    if (Msg.M_question("¿Desea Eliminar la Operacion?") == DialogResult.Yes)
                    {

                        dunidMed.IdUnidadMedida = Convert.ToInt32(Dgv_Unidadmedida.CurrentRow.Cells[1].Value);

                        dunidMed.Codigo = Dgv_Unidadmedida.CurrentRow.Cells[2].Value.ToString();
                        dunidMed.Abrev = Dgv_Unidadmedida.CurrentRow.Cells[3].Value.ToString();
                        dunidMed.Descripcion = Dgv_Unidadmedida.CurrentRow.Cells[4].Value.ToString();
                        result = runidMed.Delete(dunidMed);

                        if (result.Contains("Se Elimino"))
                        {
                            Msg.M_info(result);
                            Show_UnidadMed();
                        }
                        else
                            Msg.M_error(result);

                    }
                }

            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (Dgv_Unidadmedida.Rows.Count <= 0)
            {
                Msg.M_warning("Seleccione una Fila para poder modificar");
                return;
            }


            using (FrmV_UnidadMedida unidadMedida = new FrmV_UnidadMedida())
            {
                unidadMedida.StartPosition = FormStartPosition.CenterParent;
                unidadMedida.txtidUnidMed.Text = Dgv_Unidadmedida.CurrentRow.Cells[0].Value.ToString();
                unidadMedida.txtcodUM.Text = Dgv_Unidadmedida.CurrentRow.Cells[1].Value.ToString();
                unidadMedida.txtAbrev.Text = Dgv_Unidadmedida.CurrentRow.Cells[2].Value.ToString();
                unidadMedida.txtDesc.Text = Dgv_Unidadmedida.CurrentRow.Cells[3].Value.ToString();

                unidadMedida.btnmodificar.Visible = true;
                unidadMedida.btnguardar.Visible = false;
                unidadMedida.txtDesc.Focus();
                unidadMedida.ShowDialog();

                Show_UnidadMed();
            }
        }

        private void Txtbuscar_TextChanged(object sender, EventArgs e)
        {
            Dgv_Unidadmedida.DataSource = runidMed.Search(Txtbuscar.Text.Trim());
        }
    }
}
