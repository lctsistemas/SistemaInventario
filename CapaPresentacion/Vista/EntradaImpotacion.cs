using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaPresentacion.Helps;

namespace CapaPresentacion.Vista
{
    public partial class FrmEntradaImpotacion : Form
    {
        public FrmEntradaImpotacion()
        {
            InitializeComponent();
        }

        private void Btn_importExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Excel Files | *.xls;*.xlsx;*.xlsm;";
            dialog.Title = "Importar";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Lblruta.Text = dialog.FileName;
                Dgv_Importar.DataSource = ImportarAchivoExcel(dialog.FileName);
                // Dgv_Importar.Columns[0].HeaderText = "CODIGO";
                //ImportarAchivoExcel(dialog.FileName);
                Lbl_cantidad.Text = Dgv_Importar.RowCount.ToString();
            }
          
        }

        private DataView ImportarAchivoExcel(string ruta)
        {
            //CREAR CONEXION
            string conexion = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source= {0};" +
                " Extended Properties = 'Excel 8.0;HDR=Yes;IMEX=1;MAXSCANROWS=0'", ruta);

            DataTable dt = null;

            using (OleDbConnection conector = new OleDbConnection(conexion))
            {
                conector.Open();
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = conector;
                    cmd.CommandText = "select * from [Usuarios$]";

                    OleDbDataAdapter da = new OleDbDataAdapter();
                    da.SelectCommand = cmd;
                    using (dt =new DataTable())
                    {
                        da.Fill(dt);
                        da.Dispose();
                    }
                }
            }

            return dt.DefaultView;
        }



    }
}