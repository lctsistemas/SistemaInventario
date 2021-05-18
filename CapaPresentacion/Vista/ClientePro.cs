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
    public partial class FrmClientePro : Form
    {
        public FrmClientePro()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            using (FrmV_ClienteProv cprov = new FrmV_ClienteProv())
            {
                cprov.StartPosition = FormStartPosition.CenterParent;
                cprov.btnguardar.Visible = true;
                cprov.btnmodificar.Visible = false;
                cprov.ShowDialog();
               // Show_business("ACTIVO");
            }
        }
    }
}
