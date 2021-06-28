using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using CapaPresentacion.Helps;
using CapaDatos.Entities;
using CapaDatos.Cache;

using CapaNegocio.Repositories;
using CapaPresentacion.SubVista;

using Microsoft.Office.Interop.Excel; // PARA CREAR EXCEL
using objExcel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace CapaPresentacion.Vista
{
    public partial class FrmEntradaImpotacion : Form
    {
        readonly REntrada rentra;
        private List<DEntrada> lista_en;
        System.Data.DataTable dt;

        public FrmEntradaImpotacion()
        {
            InitializeComponent();
            rentra = new REntrada();          
            Lbl_cantidad.Text = "";
            this.Dgv_Importar.DoubleBuffered(true);
            ShowMes();
            //ColumnasTabla();
        }

        private void ShowMes()
        {
            using (REntrada re = new REntrada())
            {
                Cbomes.DataSource = re.Get_mes();
                Cbomes.DisplayMember = "nombre_mes";
                Cbomes.ValueMember = "idmes";
            }

            Num_periodo.Value = Convert.ToInt32(UserCache.C_periodo);
        }

        //MOSTRAR MES DE MAQUINA ACTUAL AL INICIAR PLANILLA
        private void Mes_actual()
        {
            int mact = DateTime.Now.Month;
            Cbomes.SelectedIndex = (mact - 1);
        }

        private void Btn_importExcel_Click(object sender, EventArgs e)
        {
            this.Panel_excel.Visible = true;
            this.Panel_excel.BringToFront();
        }

        //SUMA DE ENTRADAS Y SALIDAS DE DATAGRIDVIEW
        private void SumaEntradas()
        {
            double sumaEntrada = 0;                       
            for (int i = 0; i < Dgv_Importar.RowCount ; i++)
            {
                //if (Dgv_Importar.CurrentRow.Cells["entradas"].Value != null)
                sumaEntrada += Convert.ToDouble(Dgv_Importar.Rows[i].Cells[16].Value);
            }
            Txt_entradas.Text = sumaEntrada.ToString("N2");

        }

        private void SumaSalidas()
        {
            double sumaSalida = 0;
            for (int i = 0; i < Dgv_Importar.RowCount ; i++)
            {
                //if (row.Cells["salidas"].Value != null)
                    sumaSalida += Convert.ToDouble(Dgv_Importar.Rows[i].Cells[17].Value);
            }
            Txt_salidas.Text = sumaSalida.ToString("N2");
        }

        private void InventarioFinal()
        {
            if(!(string.IsNullOrWhiteSpace(Txt_entradas.Text) && string.IsNullOrWhiteSpace(Txt_salidas.Text)))
            {
                double entra = Convert.ToDouble(Txt_entradas.Text.Trim());
                double sali = Convert.ToDouble(Txt_salidas.Text.Trim());

                double inv_final = (entra - sali);
                Txt_invFinal.Text = inv_final.ToString("N2");
            }

        }

        private void TotalRegistro()
        {
            Lbl_cantidad.Text = "Total Registro : " + (Dgv_Importar.RowCount ).ToString("N0");
        }

        //COLUMNAS DE TABLA

        private void ColumnasTabla()
        {
            using (dt = new System.Data.DataTable())
            {
                dt.Columns.Add("1", typeof(string));
                dt.Columns.Add("2", typeof(string));
                dt.Columns.Add("3", typeof(string));
                dt.Columns.Add("4", typeof(string));
                dt.Columns.Add("5", typeof(string));
                dt.Columns.Add("6", typeof(string));
                dt.Columns.Add("7", typeof(string));
                dt.Columns.Add("8", typeof(string));
                dt.Columns.Add("9", typeof(string));
                dt.Columns.Add("10", typeof(DateTime));
                dt.Columns.Add("11", typeof(string));
                dt.Columns.Add("12", typeof(string));
                dt.Columns.Add("13", typeof(string));
                dt.Columns.Add("14", typeof(string));
                dt.Columns.Add("15", typeof(string));
                dt.Columns.Add("16", typeof(string));
                dt.Columns.Add("17", typeof(double));
                dt.Columns.Add("18", typeof(double));
                //dt.Columns.Add("19", typeof(string));
                Dgv_Importar.DataSource = dt;
                Tabla();
            }
        }

        private void Tabla()
        {
            /*Dgv_Importar.Columns[0].HeaderText = "PERIODO";
            Dgv_Importar.Columns[0].Width = 150;*/
            Dgv_Importar.Columns[0].Visible = false;

            /*Dgv_Importar.Columns[1].HeaderText = "COU";
            Dgv_Importar.Columns[1].Width = 300;*/
            Dgv_Importar.Columns[1].Visible = false;

            //Dgv_Importar.Columns[2].HeaderText = "NUM ASIENTO";
            Dgv_Importar.Columns[2].Visible = false;

            //Dgv_Importar.Columns[3].HeaderText = "COD. ANEXO";
            Dgv_Importar.Columns[3].Visible = false;

            Dgv_Importar.Columns[4].HeaderText = "COD. CATALOGO";
            
            Dgv_Importar.Columns[5].HeaderText = "TIPO EXISTENCIA";
            
            Dgv_Importar.Columns[6].HeaderText = "COD. EXISTENCIA";

            //Dgv_Importar.Columns[7].HeaderText = "COD CTL";
            Dgv_Importar.Columns[7].Visible = false;

            //Dgv_Importar.Columns[8].HeaderText = "COD. EXITENCIA CTL";
            Dgv_Importar.Columns[8].Visible = false;

            Dgv_Importar.Columns[9].HeaderText = "FECHA EMISION";
            
            Dgv_Importar.Columns[10].HeaderText = "TIPO DOCUMENTO";
            
            Dgv_Importar.Columns[11].HeaderText = "SERIE";
            
            Dgv_Importar.Columns[12].HeaderText = "NUMERO DOCUMENTO";
            
            Dgv_Importar.Columns[13].HeaderText = "TIPO OPERACION";            
            
            Dgv_Importar.Columns[14].HeaderText = "EXISTENCIA";
            Dgv_Importar.Columns[14].Width = 250;
            
            Dgv_Importar.Columns[15].HeaderText = "UNIDAD MEDIDA";
            
            Dgv_Importar.Columns[16].HeaderText = "ENTRADAS";
            
            Dgv_Importar.Columns[17].HeaderText = "SALIDAS";

            /*this.Dgv_Importar.Rows[Dgv_Importar.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Beige;
            this.Dgv_Importar.Rows[Dgv_Importar.Rows.Count - 1].DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9, FontStyle.Bold);*/

        }

        private void Btnprueba_Click(object sender, EventArgs e)
        {
            /*lista_en = rentra.ImportarAchivoExcel(Lblruta.Text.Trim());
            Dgv_Importar.DataSource = lista_en.OrderBy(d => d.Id).Skip(20).Take(20).ToList();*/

            /*Msg.M_info("lista en from :  " + lista_en.Count);
            Msg.M_info("lista en back :  " + rentra.list_entrada.Count);*/
        }

        private void Btn_procesaEntrada_Click(object sender, EventArgs e)
        {
            List<DEntrada> result = (from item in lista_en
                                     where item.entradas  >=0.01 select item).ToList();
            Dgv_Importar.DataSource = result;
            TotalRegistro();
         
        }

        private void Btn_procesaSalida_Click(object sender, EventArgs e)
        {
           List<DEntrada> result = (from item in lista_en
                                     where item.salidas < 0.00
                                     select item).ToList();
            Dgv_Importar.DataSource = result;
            TotalRegistro();
           
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            ExportarExcel3();
        }
        private void ExportarExcel3()
        {
            int inHeaderLength = 3, inColumn = 0, inRow = 0;
            //System.Reflection.Missing Default = System.Reflection.Missing.Value; 

            objExcel.Application app = new objExcel.Application();
            objExcel.Workbook libro = app.Workbooks.Add(Type.Missing);
            //objExcel.Worksheet hoja = libro.Sheets.Add(Default, libro.Sheets[libro.Sheets.Count], 1, Default); // con esto estamos creando otro libro y ahi se mostrara datos
            objExcel.Worksheet hoja = (Worksheet)libro.Worksheets[1];
            hoja.Name = "PROFESSIONAL";

            //app.Visible = true;

            //Excel Header
            objExcel.Range cellRang = hoja.get_Range("A1", "G3");
            //cellRang.Merge(false);
            //cellRang.Interior.Color = System.Drawing.Color.White;           
            cellRang.Font.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            //cellRang.HorizontalAlignment = objExcel.XlHAlign.xlHAlignCenter;
            cellRang.HorizontalAlignment = objExcel.XlHAlign.xlHAlignLeft;
            //cellRang.VerticalAlignment = objExcel.XlVAlign.xlVAlignCenter;
            cellRang.VerticalAlignment = objExcel.XlVAlign.xlVAlignCenter;
            cellRang.Font.Size = 11;
            //cellRang.Font.Bold = true;
            hoja.Cells[1, 1] = "User : ";
            hoja.Cells[1, 1].Font.Bold = true;
            hoja.Cells[1, 2] = "Carlos Meza Curasma";


            // STYLE TABLE COLUMN NAMES
            cellRang = hoja.get_Range("A4", "H4");
            cellRang.Font.Bold = true;
            cellRang.Font.Size = 11;


            //write column name
            for (int i = 0; i < Dgv_Importar.Columns.Count - 1; i++)
                hoja.Cells[inHeaderLength + 1, i + 1] = Dgv_Importar.Columns[i + 1].HeaderText.ToUpper();

            //whire Rows
            for (int m = 0; m < Dgv_Importar.Rows.Count; m++)
            {
                for (int n = 0; n < Dgv_Importar.Columns.Count - 1; n++)
                {
                    inColumn = n + 1;
                    inRow = inHeaderLength + 2 + m;
                    hoja.Cells[inRow, inColumn] = Dgv_Importar.Rows[m].Cells[n + 1].Value.ToString();
                    if (m % 2 == 0)
                        hoja.get_Range("A" + inRow.ToString(), "H" + inRow.ToString()).Interior.Color = System.Drawing.ColorTranslator.FromHtml("#FCE4D6");

                }
            }

            app.Columns.AutoFit();
            app.Visible = true;


        }

        #region Metodos y enventos: para importar TXT
        private void BtnExaminar_Click(object sender, EventArgs e)
        {
            string url;         
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "TXT Files | *.txt;";
            //dialog.Filter = "Excel Files | *.xls;*.xlsx;*.xlsm;";
            //dialog.Title = "Importar Excel";
            dialog.Title = "Importar TXT";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                url = dialog.FileName;

                Txt_ruta.Text = url.Trim();
            }
            dialog.Dispose();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Panel_excel.Visible = false;
            Txt_ruta.Text = string.Empty;
        }

        private void Btn_entrar_Click(object sender, EventArgs e)
        {            
            if (string.IsNullOrEmpty(Txt_ruta.Text.Trim()))
                return;

            #region export excel
            /*lista_en = new List<DEntrada>();

            void CargarData()
            {
                lista_en = rentra.ImportarAchivoExcel(Txt_ruta.Text.Trim());
            }
            this.Panel_excel.Visible = false;
            using (var frmpro = new FrmProcesoWait(CargarData, "Procesando..."))
            {
                frmpro.StartPosition = FormStartPosition.CenterParent;
                frmpro.ShowDialog(this);
                Dgv_Importar.DataSource = lista_en;
                Tabla();
            }*/
            #endregion
            this.Panel_excel.Visible = false;
            using (var frmpro = new FrmProcesoWait(ImportarTxt, "Procesando..."))
            {
                frmpro.StartPosition = FormStartPosition.CenterParent;
                frmpro.ShowDialog(this);
                Dgv_Importar.DataSource = dt;
                Tabla();
                TotalRegistro();
                SumaEntradas();
                SumaSalidas();
                InventarioFinal();
                Txt_ruta.Text = "";
                lbl_idmes.Text = Cbomes.SelectedValue.ToString();
            }           
          
        }

        private void ImportarTxt()
        {
            using (dt = new System.Data.DataTable())
            {

                dt.Columns.Add("1", typeof(string));
                dt.Columns.Add("2", typeof(string));
                dt.Columns.Add("3", typeof(string));
                dt.Columns.Add("4", typeof(string));
                dt.Columns.Add("5", typeof(string));
                dt.Columns.Add("6", typeof(string));
                dt.Columns.Add("7", typeof(string));
                dt.Columns.Add("8", typeof(string));
                dt.Columns.Add("9", typeof(string));
                dt.Columns.Add("10", typeof(DateTime));
                dt.Columns.Add("11", typeof(string));
                dt.Columns.Add("12", typeof(string));
                dt.Columns.Add("13", typeof(string));
                dt.Columns.Add("14", typeof(string));
                dt.Columns.Add("15", typeof(string));
                dt.Columns.Add("16", typeof(string));
                dt.Columns.Add("17", typeof(double));
                dt.Columns.Add("18", typeof(double));

                string[] lines = File.ReadAllLines(Txt_ruta.Text.Trim());
                string[] data;
                // MessageBox.Show("LINES " + lines.Length); // muestra cantidad de lineas en filas.
                for (int i = 0; i < lines.Length; i++)
                {
                    data = lines[i].ToString().Split('|');
                    string[] row = new string[data.Length - 2]; // MENOS 2 COLUMAS DEL FINAL 

                    for (int j = 0; j < data.Length - 2; j++) // j=1 ignoro la fila 1
                    {
                        row[j] = data[j].Trim();
                        if (row[j].Contains("-"))
                        {
                            //MessageBox.Show("nega " + row[j]);
                            row[j] = row[j].Replace("-", "+");
                        }
                    }
                    //MessageBox.Show("data " + data.Length);
                    dt.Rows.Add(row);
                }
            }
        }

        #endregion

        private void FrmEntradaImpotacion_Load(object sender, EventArgs e)
        {
            Mes_actual();
           
            this.toolTip1.SetToolTip(BtnExaminar,"Examinar archivos .TXT");

        }
    }
}