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
            }
          
        }

        private DataView ImportarAchivoExcel(string ruta)
        {
            //CREAR CONEXION
            string conexion = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source= {0};" +
                " Extended Properties = 'Excel 8.0;HDR=Yes;IMEX=1;MAXSCANROWS=0'", ruta); // cuando esta abierto el archivo

            /*string conexion = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= {0};" +
                " Extended Properties = 'Excel 12.0;'", ruta);*/

            OleDbConnection conector = default(OleDbConnection);
            conector = new OleDbConnection(conexion);

            //Abrir conexion
            conector.Open();
            /*if (conector.State == ConnectionState.Open)
            {
                Msg.M_info("conexion exitosa");
            }
            else
                Msg.M_error("Error al conectar");*/

            //crar consulta
            OleDbCommand cmd = default(OleDbCommand);
            cmd = new OleDbCommand("select * from [Usuarios$]", conector);

            //crear dataptador
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;

            //creamos Dataset
            DataSet ds = new DataSet();

            //Llenamos Adaptador
            da.Fill(ds);
            da.Dispose();

            //Cerrar conexion
            conector.Close();

            return ds.Tables[0].DefaultView;

        }

    }
}