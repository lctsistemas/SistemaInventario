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
    public partial class FrmProcesoWait : Form
    {
        private Action Proceso { get; set; }
       
        public FrmProcesoWait(Action process, string descrip)
        {
            InitializeComponent();
            this.Lbl_descrip.Text = descrip;
            Proceso = process;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(Proceso).ContinueWith(t => { this.Close(); },
                TaskScheduler.FromCurrentSynchronizationContext());
        }


    }
}
