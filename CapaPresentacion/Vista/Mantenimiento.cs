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

        private void SumaEntradas()
        {
            double sumaEntrada = 0;
            for (int i = 0; i < Dgv_grupo_.RowCount; i++)
            {
                sumaEntrada += Convert.ToDouble(Dgv_grupo_.Rows[i].Cells["invgrupo_4"].Value);
            }
            Txt_Total_entrada.Text = sumaEntrada.ToString("N2");

        }

        private void SumaSalidas()
        {
            double sumaSalida = 0;
            for (int i = 0; i < Dgv_grupo_.RowCount; i++)
            {
                sumaSalida += Convert.ToDouble(Dgv_grupo_.Rows[i].Cells["invgrupo_5"].Value);
            }
            Txt_totalSalida.Text = sumaSalida.ToString("N2");
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

        private void ShowGrupoInventario()
        {
            de.Id_empresa = UserCache.C_idempresa;
            de.Id_mes = (int)Cbomes.SelectedValue;
            de.Id_periodo = UserCache.C_idperiodo;

            Dgv_grupo_.DataSource = rema.Get_showGrupo(de);
            Lbl_cantiEntrada.Text = rema.GetCantidadEntrada(de).ToString("N0");
            Lbl_cantiSalida.Text = rema.GetCantidadSalida(de).ToString("N0");
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            ShowGrupoInventario();
            SumaEntradas();
            SumaSalidas();
            SumaStock();
            SumaCantidad();
            
        }

      
    }
}
