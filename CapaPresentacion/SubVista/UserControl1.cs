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
    public partial class UserControl_mes : UserControl
    {
        public UserControl_mes()
        {
            InitializeComponent();
            
        }

       /*private void ShowMes()
        {
            using (REntrada re = new REntrada())
            {
                Cbomes.DataSource = re.Get_mes();
                Cbomes.DisplayMember = "nombre_mes";
                Cbomes.ValueMember = "idmes";
            }
        }*/

        private void UserControl_mes_Load(object sender, EventArgs e)
        {
            //ShowMes();
        }
    }
}
