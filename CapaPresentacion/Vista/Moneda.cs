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
        public FrmMoneda()
        {
            InitializeComponent();
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
    }
}
