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
    public partial class FrmTipoExistencia : Form
    {
        readonly DTipoExistencia dTipoExist;
        readonly RTipoExistencia rTipoExist;
        string result;
        List<DTipoExistencia> lst;
        public FrmTipoExistencia()
        {
            InitializeComponent();
            dTipoExist = new DTipoExistencia();
            rTipoExist = new RTipoExistencia();
            Dgv_tipoExist.AutoGenerateColumns = false;
            Show_TipoExist();
            Tabla();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            using (FrmVTipo_Existencia tipoExistencia = new FrmVTipo_Existencia())
            {
                tipoExistencia.StartPosition = FormStartPosition.CenterParent;
                tipoExistencia.btnguardar.Visible = true;
                tipoExistencia.btnmodificar.Visible = false;
                tipoExistencia.ShowDialog();
                Show_TipoExist();

            }
        }

        private void Tabla()
        {

            Dgv_tipoExist.Columns[1].Visible = true;
           // Dgv_Unidadmedida.Columns[2].HeaderText = "DESCRIPCION";
        }

        private void Show_TipoExist()
        {
            Dgv_tipoExist.DataSource = rTipoExist.Getdata(null);
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (Dgv_tipoExist.Rows.Count <= 0)
            {
                Msg.M_warning("Seleccione una Fila para poder modificar");
                return;
            }


            using (FrmVTipo_Existencia tipoExistencia = new FrmVTipo_Existencia())
            {
                tipoExistencia.StartPosition = FormStartPosition.CenterParent;
                tipoExistencia.txtidTipoDoc.Text = Dgv_tipoExist.CurrentRow.Cells[0].Value.ToString();
                tipoExistencia.txtcodDoc.Text = Dgv_tipoExist.CurrentRow.Cells[1].Value.ToString();
                tipoExistencia.txtDescDoc.Text = Dgv_tipoExist.CurrentRow.Cells[2].Value.ToString();

                tipoExistencia.btnmodificar.Visible = true;
                tipoExistencia.btnguardar.Visible = false;
                tipoExistencia.txtDescDoc.Focus();
                tipoExistencia.ShowDialog();

                Show_TipoExist();
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!(this.Dgv_tipoExist.RowCount > 0))
                return;

            string men = string.Format("Registrando {0} Filas...", Dgv_tipoExist.RowCount.ToString("N0"));
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
            lst = new List<DTipoExistencia>();
            foreach (DataGridViewRow item in Dgv_tipoExist.Rows)
            {
                lst.Add(new DTipoExistencia()
                {
                    Codigo = item.Cells[1].Value.ToString(),
                    Descripcion = item.Cells[2].Value.ToString()

                });
            }
            result = rTipoExist.Add_Multiple(lst);
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
                Dgv_tipoExist.DataSource = rTipoExist.ImportarAchivoExcel(dialog.FileName);
                BtnGuardar.Visible = true;
                Tabla();
            }
            dialog.Dispose();
        }
    }
}
