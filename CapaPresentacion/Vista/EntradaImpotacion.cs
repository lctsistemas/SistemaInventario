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
        //private List<DEntrada> lista_en;
        System.Data.DataTable dt;
        string result = "";
        List<DEntrada> lst;
        readonly REntrada ren;
        readonly DEntrada den;

        public FrmEntradaImpotacion()
        {
            InitializeComponent();            
            ren = new REntrada();
            den = new DEntrada();

            rentra = new REntrada();
            Lbl_cantidad.Text = "";
            this.Dgv_Importar.DoubleBuffered(true);
            ShowMes();
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

        //LIMPIAR CAJAS
        private void LimpiarCajas(){
            Txt_entradas.Text = "0.00";
            Txt_salidas.Text = "0.00";
            Txt_invFinal.Text = "0.00";
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
                    sumaSalida += Convert.ToDouble(Dgv_Importar.Rows[i].Cells[17].Value);
                //if (row.Cells["salidas"].Value != null)
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
       
        private void Tabla()
        {
            Dgv_Importar.Columns[0].HeaderText = "PERIODO";
            //Dgv_Importar.Columns[0].Width = 150;
            //Dgv_Importar.Columns[0].Visible = false;

            Dgv_Importar.Columns[1].HeaderText = "CUO";
            Dgv_Importar.Columns[1].Width = 200;            
            Dgv_Importar.Columns[2].HeaderText = "NUM ASIENTO";           
            Dgv_Importar.Columns[3].HeaderText = "COD. ANEXO";           
            Dgv_Importar.Columns[4].HeaderText = "COD. CATALOGO";           
            Dgv_Importar.Columns[5].HeaderText = "TIPO EXISTENCIA";            
            Dgv_Importar.Columns[6].HeaderText = "COD. EXISTENCIA";
            Dgv_Importar.Columns[7].HeaderText = "COD CTL";           
            Dgv_Importar.Columns[8].HeaderText = "COD. EXITENCIA CTL";           
            Dgv_Importar.Columns[9].HeaderText = "FECHA EMISION";            
            Dgv_Importar.Columns[10].HeaderText = "TIPO DOCUMENTO";            
            Dgv_Importar.Columns[11].HeaderText = "SERIE";            
            Dgv_Importar.Columns[12].HeaderText = "NUMERO DOCUMENTO";            
            Dgv_Importar.Columns[13].HeaderText = "TIPO OPERACION";            
            Dgv_Importar.Columns[14].HeaderText = "EXISTENCIA";
            Dgv_Importar.Columns[14].Width = 270;            
            Dgv_Importar.Columns[15].HeaderText = "UNIDAD MEDIDA";            
            Dgv_Importar.Columns[16].HeaderText = "ENTRADAS";            
            Dgv_Importar.Columns[17].HeaderText = "SALIDAS";
            Dgv_Importar.Columns[18].HeaderText = "ESTADO DE OPERACION";
            OcultarColumasTabla(false);

            /*this.Dgv_Importar.Rows[Dgv_Importar.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Beige;
            this.Dgv_Importar.Rows[Dgv_Importar.Rows.Count - 1].DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9, FontStyle.Bold);*/

        }

        private void OcultarColumasTabla(bool v)
        {
            Dgv_Importar.Columns[1].Visible = v;
            Dgv_Importar.Columns[2].Visible = v;
            Dgv_Importar.Columns[3].Visible = v;
            Dgv_Importar.Columns[4].Visible = v;
            Dgv_Importar.Columns[7].Visible = v;
            Dgv_Importar.Columns[8].Visible = v;
            Dgv_Importar.Columns[18].Visible = v;
        }

        //GUARDAR INVENTARIO.
        private void Btn_procesaEntrada_Click(object sender, EventArgs e)
        {
            if (!(this.Dgv_Importar.RowCount > 0))
                return;

            string men = string.Format("Registrando {0} Filas...", Dgv_Importar.RowCount.ToString("N0"));
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
            lst = new List<DEntrada>();
            foreach (DataGridViewRow item in Dgv_Importar.Rows)
            {
                lst.Add(new DEntrada()
                {
                    periodo = item.Cells["inv_1"].Value.ToString(),
                    COU = item.Cells["inv_2"].Value.ToString(),
                    numero_asiento = item.Cells["inv_3"].Value.ToString(),
                    cod_anexo = item.Cells["inv_4"].Value.ToString(),
                    cod_catalogo = item.Cells["inv_5"].Value.ToString(),
                    tipo_existencia = item.Cells["inv_6"].Value.ToString(),
                    cod_existencia = item.Cells["inv_7"].Value.ToString(),
                    cod_ctl = item.Cells["inv_8"].Value.ToString(),// == "" ? null : item.Cells["inv_8"].Value.ToString(),
                    cod_ext_ctl = item.Cells["inv_9"].Value.ToString(),
                    fecha_emision = Convert.ToDateTime(item.Cells["inv_10"].Value),
                    tipo_documento = item.Cells["inv_11"].Value.ToString(),
                    serie = item.Cells["inv_12"].Value.ToString(),
                    num_documento = item.Cells["inv_13"].Value.ToString(),
                    tipo_operacion = item.Cells["inv_14"].Value.ToString(),
                    existencia = item.Cells["inv_15"].Value.ToString(),
                    unida_medida = item.Cells["inv_16"].Value.ToString(),
                    entradas = Convert.ToDouble(item.Cells["inv_17"].Value),
                    salidas = Convert.ToDouble(item.Cells["inv_18"].Value),
                    estado_operacion = item.Cells["inv_19"].Value.ToString(),
                    Id_empresa = UserCache.C_idempresa,
                    Id_periodo = UserCache.C_idperiodo,
                    Id_mes = Convert.ToInt32(lbl_idmes.Text.Trim())

                });
            }
            result = ren.Add_Multiple(lst);
        }
     

        private void Btn_limpiar_Click(object sender, EventArgs e)
        {
            if (Dgv_Importar.Rows.Count > 0)
            {
                dt.Rows.Clear();
                TotalRegistro();
                LimpiarCajas();                   
            }
                                       
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


        // PARA TXT
        #region Metodos y enventos: para importar TXT
        private void BtnExaminar_Click(object sender, EventArgs e)
        {
            string url, extension;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "TXT Files | *.txt;";            
            dialog.Title = "Importar TXT";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                LimpiarError();
                url = dialog.FileName;
                Lbl_nombrefile.Text = dialog.SafeFileName;         
                Txt_ruta.Text = url.Trim();
                
                if (Lbl_nombrefile.Text.Length >= 33 && Lbl_nombrefile.Text.Length < 38)
                {
                    extension = Lbl_nombrefile.Text.Trim().Substring(Lbl_nombrefile.Text.Length - 4, 4);
                    //Msg.M_info(extension);
                    if (extension == ".txt")
                    {
                        Lbl_ruc.Text = Lbl_nombrefile.Text.Trim().Substring(2, 11);
                        Lbl_ano.Text = Lbl_nombrefile.Text.Trim().Substring(13, 4);
                        Lbl_mes.Text = Lbl_nombrefile.Text.Trim().Substring(17, 2);

                        if (ValidarImportacionTXT())
                        {
                            Boton_image(true, false);
                            Btn_entrar.Enabled = true;
                        }
                        else
                        {
                            Boton_image(false, true);
                            Btn_entrar.Enabled = false;
                        } 
                    }else
                        Lbl_menUno.Text = "Formato Incorrecto";
                }
                else
                    Lbl_menUno.Text = "Formato Incorrecto";
                
            }
            dialog.Dispose();
        }
        
        private void Boton_image(bool che, bool err)
        {
            this.Pict_check.Visible = che;
            this.Pict_error.Visible = err;
        }

        private void Mensaje(string msg)
        {
            Lbl_menUno.Text = msg;
            Lbl_menDos.Text = msg;
            Lbl_menTres.Text = msg;
        }

        private bool ValidarImportacionTXT()
        {
            bool result = true;
            //validar si existe inventario registrado en el mes.
            den.Id_empresa = UserCache.C_idempresa;
            den.Id_mes = Convert.ToInt32(Cbomes.SelectedValue);
            den.Id_periodo = UserCache.C_idperiodo;

            if (!(Lbl_ruc.Text == UserCache.C_ruc))
            {
                result = false;
                Lbl_menUno.Text = "► Archivo TXT no Corresponde a la Empresa, Seleccione otro Archivo.";
            }            

            Int16 x = Convert.ToInt16(Lbl_mes.Text);
            if (!(Lbl_ano.Text == UserCache.C_periodo && x == Convert.ToInt16(Cbomes.SelectedValue)))
            {
                result = false;
                Lbl_menDos.Text = "► El Periodo no Corresponden al Archivo TXT";
            }           

            if (ren.ValidarInventario(den) == false)
            {
                result = false;
                Lbl_menTres.Text = string.Format("► Ya existe Registro en {0}, Seleccione otro Mes", Cbomes.Text);
            }

            return result;
        }

        private void LimpiarError()
        {
            Lbl_menUno.Text = "";
            Lbl_menDos.Text = "";
            Lbl_menTres.Text = "";
        }

        //boton cancelar
        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Panel_excel.Visible = false;
            Txt_ruta.Text = string.Empty;
            Lbl_nombrefile.Text = string.Empty;
            LimpiarError();
            Boton_image(false, false);
            Mes_actual();
        }

        //METODO IMPORTAR TXT
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
            using (var frmpro = new FrmProcesoWait(ImportarTxt, "Importando TXT..."))
            {
                frmpro.StartPosition = FormStartPosition.CenterParent;
                frmpro.ShowDialog(this);
                Dgv_Importar.DataSource = dt;
               
                TotalRegistro();
                SumaEntradas();
                SumaSalidas();
                InventarioFinal();
                Txt_ruta.Text = "";
                lbl_idmes.Text = Cbomes.SelectedValue.ToString();
                Boton_image(false, false);
                Lbl_correlativo.Visible = true;
            }           
          
        }

        private void ImportarTxt()
        {
            using (dt = new System.Data.DataTable())
            {
                dt.Columns.Add("invt_1", typeof(string));
                dt.Columns.Add("invt_2", typeof(string));
                dt.Columns.Add("invt_3", typeof(string));
                dt.Columns.Add("invt_4", typeof(string));
                dt.Columns.Add("invt_5", typeof(string));
                dt.Columns.Add("invt_6", typeof(string));
                dt.Columns.Add("invt_7", typeof(string));
                dt.Columns.Add("invt_8", typeof(string));
                dt.Columns.Add("invt_9", typeof(string));
                dt.Columns.Add("invt_10", typeof(DateTime));
                dt.Columns.Add("invt_11", typeof(string));
                dt.Columns.Add("invt_12", typeof(string));
                dt.Columns.Add("invt_13", typeof(string));
                dt.Columns.Add("invt_14", typeof(string));
                dt.Columns.Add("invt_15", typeof(string));
                dt.Columns.Add("invt_16", typeof(string));
                dt.Columns.Add("invt_17", typeof(double));
                dt.Columns.Add("invt_18", typeof(double));
                dt.Columns.Add("invt_19", typeof(string));

                string[] lines = File.ReadAllLines(Txt_ruta.Text.Trim());
                string[] data;
                // MessageBox.Show("LINES " + lines.Length); // muestra cantidad de lineas en filas.
                for (int i = 0; i < lines.Length; i++)
                {
                    data = lines[i].ToString().Split('|');
                    string[] row = new string[data.Length - 1]; // MENOS 1 COLUMAS DEL FINAL 

                    for (int j = 0; j < data.Length -1; j++) // j=1 ignoro la fila 1 del final de la derecha
                    {
                        row[j] = data[j].Trim();
                        if (row[j].Contains("-"))
                        {                           
                            row[j] = row[j].Replace("-", "+");
                        }
                    }                  
                    dt.Rows.Add(row);
                }
            }
        }
        #endregion

        private void FrmEntradaImpotacion_Load(object sender, EventArgs e)
        {
            Mes_actual();
            Tabla();
            Mensaje("");
            this.toolTip1.SetToolTip(BtnExaminar,"Examinar archivos .TXT");
        }

        private void Dgv_Importar_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(Dgv_Importar.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 1, e.RowBounds.Location.Y + 3);
            }
        }

        private void Cbomes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(Txt_ruta.Text.Trim()))){
                LimpiarError();
                if (ValidarImportacionTXT())
                {
                    Boton_image(true, false);
                    Btn_entrar.Enabled = true;
                }
                else
                {
                    Boton_image(false, true);
                    Btn_entrar.Enabled = false;
                }
            }
            
        }

        private void Chk_column_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_column.Checked)
                OcultarColumasTabla(true);
            else
                OcultarColumasTabla(false);
        }
    }
}