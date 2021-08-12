using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.SubVista
{
    public partial class FrmV_txtUnidadFisica : Form
    {

        private static FrmV_txtUnidadFisica instance;
        public FrmV_txtUnidadFisica()
        {
            InitializeComponent();
           
        }

        public static FrmV_txtUnidadFisica Get_instance()
        {

            if (instance == null)
                instance = new FrmV_txtUnidadFisica();

            return instance;
        }

    }
}
