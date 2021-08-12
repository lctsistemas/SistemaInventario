using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio.Repositories;
using CapaDatos.Entities;
using CapaDatos.Cache;
using CapaPresentacion.Helps;
using System.IO;
using CapaPresentacion.SubVista;

namespace CapaPresentacion.Vista
{
    public partial class FrmMantenimiento : Form
    {

        readonly DEntrada de;
        readonly RMantenimientoInventario rema;  
        public FrmMantenimiento()
        {
            InitializeComponent();
            de = new DEntrada();
            rema = new RMantenimientoInventario();
            this.Dgv_grupo_.DoubleBuffered(true);
            this.Dgv_vistaDetalle.DoubleBuffered(true);
            this.Dgv_vistaDetalle.AutoGenerateColumns = false;
            ShowMes();
            Tabla();
        }


        //TABLA
        private void Tabla()
        {
            Dgv_vistaDetalle.Columns[0].HeaderText = "ID";
            Dgv_vistaDetalle.Columns[0].Visible = false;

            Dgv_vistaDetalle.Columns[1].HeaderText = "PERIODO";
            //Dgv_Importar.Columns[1].Width = 150;
            //Dgv_Importar.Columns[1].Visible = false;

            Dgv_vistaDetalle.Columns[2].HeaderText = "CUO";
            Dgv_vistaDetalle.Columns[2].Width = 200;

            Dgv_vistaDetalle.Columns[3].HeaderText = "NUM ASIENTO";
            Dgv_vistaDetalle.Columns[4].HeaderText = "COD. ANEXO";
            Dgv_vistaDetalle.Columns[5].HeaderText = "COD. CATALOGO";
            Dgv_vistaDetalle.Columns[6].HeaderText = "TIPO EXISTENCIA";
            Dgv_vistaDetalle.Columns[7].HeaderText = "COD. EXISTENCIA";
            Dgv_vistaDetalle.Columns[8].HeaderText = "COD CTL";
            Dgv_vistaDetalle.Columns[9].HeaderText = "COD. EXITENCIA CTL";
            Dgv_vistaDetalle.Columns[10].HeaderText = "FECHA EMISION";
            Dgv_vistaDetalle.Columns[11].HeaderText = "TIPO DOCUMENTO";
            Dgv_vistaDetalle.Columns[12].HeaderText = "SERIE";
            Dgv_vistaDetalle.Columns[13].HeaderText = "NUMERO DOCUMENTO";
            Dgv_vistaDetalle.Columns[14].HeaderText = "TIPO OPERACION";
            Dgv_vistaDetalle.Columns[15].HeaderText = "EXISTENCIA";
            Dgv_vistaDetalle.Columns[15].Width = 270;
            Dgv_vistaDetalle.Columns[16].HeaderText = "UNIDAD MEDIDA";
            Dgv_vistaDetalle.Columns[17].HeaderText = "ENTRADAS";
            Dgv_vistaDetalle.Columns[18].HeaderText = "SALIDAS";
            Dgv_vistaDetalle.Columns[19].HeaderText = "ESTADO DE OPERACION";
            OcultarColumasTabla(false);

        }

        private void OcultarColumasTabla(bool v)
        {
            Dgv_vistaDetalle.Columns[1].Visible = v;
            Dgv_vistaDetalle.Columns[2].Visible = v;
            Dgv_vistaDetalle.Columns[3].Visible = v;
            Dgv_vistaDetalle.Columns[4].Visible = v;
            Dgv_vistaDetalle.Columns[5].Visible = v;
            Dgv_vistaDetalle.Columns[8].Visible = v;
            Dgv_vistaDetalle.Columns[9].Visible = v;
            Dgv_vistaDetalle.Columns[19].Visible = v;
        }

        private void ShowMes()
        {
            using (REntrada re = new REntrada())
            {
                Cbomes.DataSource = re.Get_mes();
                Cbomes.DisplayMember = "nombre_mes";
                Cbomes.ValueMember = "idmes";
            }
        }

        private void GetMes_Exportacion()
        {
            string[] dmes = { "ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SETIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE" };
            Cbo_mes_export.Items.AddRange(dmes);

        }

        private void SumaCantidad()
        {
            double sumaStock = 0;
            for (int i = 0; i < Dgv_grupo_.RowCount; i++)
            {
                sumaStock += Convert.ToDouble(Dgv_grupo_.Rows[i].Cells["invgrupo_1"].Value);
            }
            Txt_cantidad.Text = sumaStock.ToString("N0");
        }

        private double SumaEntradas(DataGridView dgv, string celda)
        {
            double sumaEntrada = 0;
            for (int i = 0; i < dgv.RowCount; i++)
            {
                sumaEntrada += Convert.ToDouble(dgv.Rows[i].Cells[celda].Value);
            }       
            return sumaEntrada;
        }

        private double SumaSalidas(DataGridView dgv, string celda)
        {
            double sumaSalida = 0;
            for (int i = 0; i < dgv.RowCount; i++)
            {
                sumaSalida += Convert.ToDouble(dgv.Rows[i].Cells[celda].Value);
            }
            return sumaSalida;
        }

        private void SumaStock()
        {
            double sumaStock = 0;
            for (int i = 0; i < Dgv_grupo_.RowCount; i++)
            {
                sumaStock += Convert.ToDouble(Dgv_grupo_.Rows[i].Cells["invgrupo_6"].Value);
            }
            Txt_totalStock.Text = sumaStock.ToString("N2");
        }

        //MOSTRAR PRODUCTOS AGRUPADOS
        private void ShowGrupoInventario()
        {
            de.Id_empresa = UserCache.C_idempresa;
            de.Id_mes = (int)Cbomes.SelectedValue;
            de.Id_periodo = UserCache.C_idperiodo;

            Dgv_grupo_.DataSource = rema.Get_showGrupo(de);
            Lbl_cantiEntrada.Text = rema.GetCantidadEntrada(de).ToString("N0");
            Lbl_cantiSalida.Text = rema.GetCantidadSalida(de).ToString("N0");
        }

        // SHOW PARA TXT
        private void ShowInventarioTxt()
        {
            de.Id_empresa = UserCache.C_idempresa;
            de.Id_mes = (Cbo_mes_export.SelectedIndex + 1);
            de.Id_periodo = UserCache.C_idperiodo;
            Dgv_txtList.DataSource = rema.Get_InventarioTxt(de);
        }


        private void ShowDetalleInventario(string cod_exist)
        {
            de.Id_empresa = UserCache.C_idempresa;
            de.Id_mes = (int)Cbomes.SelectedValue;
            de.Id_periodo = UserCache.C_idperiodo;
            de.cod_existencia = cod_exist;

            Dgv_vistaDetalle.DataSource = rema.GetDetalleInventario(de);
        }


        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            if (Panel_exportarTXT.Visible == true)
                return;
            ShowGrupoInventario();
            Txt_Total_entrada.Text = SumaEntradas(Dgv_grupo_, "invgrupo_4").ToString("N2");
            Txt_totalSalida.Text = SumaSalidas(Dgv_grupo_, "invgrupo_5").ToString("N2");
            SumaStock();
            SumaCantidad();
            
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Panel_detalleInventario.Visible = false;
        }

        private void Dgv_grupo__CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.Panel_exportarTXT.Visible == true)
                return;
            
            if (e.RowIndex > -1)
            {
                string cod_exi = "";
                double tstock = 0, saldo_ini = 0;
                if (e.ColumnIndex == this.Dgv_grupo_.Columns["Dgv_btndetalle"].Index)
                {
                    this.Panel_detalleInventario.Visible = true;
                    Lbl_existencia.Text = Dgv_grupo_.CurrentRow.Cells["invgrupo_3"].Value.ToString(); // Existencia.
                    cod_exi = Dgv_grupo_.CurrentRow.Cells["invgrupo_2"].Value.ToString(); // codigo existencia clave unica.
                    ShowDetalleInventario(cod_exi);

                    //establecer datos
                    Lbl_cantiRegistro.Text = Dgv_vistaDetalle.RowCount.ToString("N0");
                    Lbl_totaEntradadetalle.Text = SumaEntradas(Dgv_vistaDetalle, "inv_17").ToString("N2");
                    Lbl_totaSalidadetalle.Text = SumaSalidas(Dgv_vistaDetalle, "inv_18").ToString("N2");
                    tstock = (Convert.ToDouble(Lbl_totaEntradadetalle.Text) - Convert.ToDouble(Lbl_totaSalidadetalle.Text));
                    Lbl_totaStockdetalle.Text = tstock.ToString("N2");

                    

                    foreach (DataGridViewRow item in Dgv_vistaDetalle.Rows)
                    {
                        if (item.Cells["inv_14"].Value.ToString() == "16")
                        {
                            saldo_ini = Convert.ToDouble(item.Cells["inv_17"].Value.ToString());
                            break;
                        }
                       
                    }

                    Lbl_saldoIniciodetalle.Text = saldo_ini.ToString();
                }
            }
        }

        private void Dgv_vistaDetalle_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(Dgv_vistaDetalle.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 1, e.RowBounds.Location.Y + 3);
            }
        }

        private void Dgv_grupo__RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(Dgv_grupo_.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 1, e.RowBounds.Location.Y + 3);
            }
        }

        #region PANEL EXPORTAR TXT DE INVENTARIO UNID. FISICAS
        private void BtnExaminar_Click(object sender, EventArgs e)
        {
            string url = "";
            FolderBrowserDialog fbd = new FolderBrowserDialog();            
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                url = fbd.SelectedPath;
            }

            Txt_ruta.Text = url;
            fbd.Dispose();
        }

        private void Btn_procesaEntrada_Click(object sender, EventArgs e)
        {
            this.Panel_exportarTXT.Visible = true;          
            int mact = DateTime.Now.Month; //numeo de mes
            Cbo_mes_export.SelectedIndex = (mact -1);
            CargarDatos();
            EstructuraLEinventario();
        }

        private void lblcerrar_Click(object sender, EventArgs e)
        {
            this.Panel_exportarTXT.Visible = false;
            Limpiar();
        }

        private void FrmMantenimiento_Load(object sender, EventArgs e)
        {
            GetMes_Exportacion();
        }

        private void Cbo_mes_export_SelectedIndexChanged(object sender, EventArgs e)
        {
            string num_mes = "";
            switch (Cbo_mes_export.SelectedItem)
            {
                case "ENERO":
                    num_mes = "01";
                    break;
                case "FEBRERO":
                    num_mes = "02";
                    break;
                case "MARZO":
                    num_mes = "03";
                    break;
                case "ABRIL":
                    num_mes = "04";
                    break;
                case "MAYO":
                    num_mes = "05";
                    break;
                case "JUNIO":
                    num_mes = "06";
                    break;
                case "JULIO":
                    num_mes = "07";
                    break;
                case "AGOSTO":
                    num_mes = "08";
                    break;
                case "SETIEMBRE":
                    num_mes = "09";
                    break;
                case "OCTUBRE":
                    num_mes = "10";
                    break;
                case "NOVIEMBRE":
                    num_mes = "11";
                    break;
                case "DICIEMBRE":
                    num_mes = "12";
                    break;                

            }
            Txt_numeroMes.Text = num_mes;            
            EstructuraLEinventario();
            ShowInventarioTxt();
            Txt_cantiFilas.Text = Dgv_txtList.RowCount.ToString("N0");

        }

        //METODO PARA INICIAR DATOS AL EXPORTAR TXT
        private void CargarDatos()
        {
            Num_periodo.Value = Convert.ToInt32(UserCache.C_periodo);
            Txt_ruc.Text = UserCache.C_ruc;
        }

        //LIMPIAR CAJAS
        private void Limpiar()
        {
            Txt_ruta.Text = "";
        }
        private void EstructuraLEinventario()
        {
            string le = string.Format("LE{0}{1}{2}120100001111", Txt_ruc.Text, Num_periodo.Value, Txt_numeroMes.Text);
            Txt_nombreArchivo.Text = le.Trim();
        }

        private void lblcerrar_MouseLeave(object sender, EventArgs e)
        {
            lblcerrar.BackColor = Color.Empty;
        }

        private void lblcerrar_MouseMove(object sender, MouseEventArgs e)
        {
            lblcerrar.BackColor = Color.FromArgb(238, 238, 238);
        }


       

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Panel_exportarTXT.Visible = false;
            Limpiar();
        }

        private void Cbomes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (Dgv_grupo_.RowCount > 0)
                
        }

        private void Btn_entrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_ruta.Text.Trim()))
                return;

            using (var frmpro = new FrmProcesoWait(ExportarTxt, "Exportando Archivo .txt"))
            {
                frmpro.StartPosition = FormStartPosition.CenterParent;
                frmpro.ShowDialog(this);
                Msg.M_info("¡Archivo Exportado Correctamente!");
            }

        }

        private void ExportarTxt()
        {
            try
            {
                string rutarelativa = Txt_ruta.Text.Trim();
                string nombrefile = @"\" + Txt_nombreArchivo.Text.Trim();
                string ruta = string.Format("{0}{1}.txt", rutarelativa, nombrefile);

                //MessageBox.Show("ruta:  " + ruta);
                TextWriter writer = new StreamWriter(ruta);

                for (int i = 0; i < Dgv_txtList.Rows.Count; i++)
                {
                    for (int j = 0; j < Dgv_txtList.Columns.Count; j++)
                    {
                        if (j == Dgv_txtList.Columns.Count - 3 && Convert.ToDouble(Dgv_txtList.Rows[i].Cells[Dgv_txtList.Columns.Count - 2].Value) > 0.00)
                        {
                            writer.Write(Dgv_txtList.Rows[i].Cells[j].Value.ToString().Trim() + "|-");
                        }
                        else
                            writer.Write(Dgv_txtList.Rows[i].Cells[j].Value.ToString().Trim() + "|");
                    }

                    if (i < Dgv_txtList.Rows.Count - 1)
                        writer.WriteLine("");

                }
                writer.Close();
            }
            catch (Exception ex)
            {
                Msg.M_error(ex.Message);
            }
        }

        #endregion


    }
}
