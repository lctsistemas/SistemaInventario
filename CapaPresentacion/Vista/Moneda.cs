using CapaDatos.Entities;
using CapaNegocio.Repositories;
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
    public partial class FrmMoneda : Form
    {
        readonly DMoneda dMoneda;
        readonly RMoneda rMoneda;
        public FrmMoneda()
        {
            InitializeComponent();
            dMoneda = new DMoneda();
            rMoneda = new RMoneda();
            Show_moneda();
            Tabla();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            using (FrmV_Moneda vmon = new FrmV_Moneda())
            {
                vmon.StartPosition = FormStartPosition.CenterParent;
                vmon.btnmodificar.Visible = false;
                vmon.btnguardar.Visible = true;
                vmon.ShowDialog();
                //Show_business("ACTIVO");
            }
        }

        private void Show_moneda()
        {
            Dgv_moneda.DataSource = rMoneda.Getdata(dMoneda);

        }

        //TABLA
        private void Tabla()
        {
            Dgv_moneda.Columns[0].Visible = false;
            Dgv_moneda.Columns[1].HeaderText = "PROVEEDOR";
            Dgv_moneda.Columns[2].HeaderText = "RUC";
        }
    }
}
