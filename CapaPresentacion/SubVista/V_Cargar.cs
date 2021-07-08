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

namespace CapaPresentacion.SubVista
{
    public partial class FrmV_Cargar : Form
    {
        public FrmV_Cargar()
        {
            InitializeComponent();
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

        private void Btn_importExcel_Click(object sender, EventArgs e)
        {

        }
    }
}
