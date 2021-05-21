using CapaDatos.Entities;
using CapaNegocio.Repositories;
using CapaPresentacion.Helps;
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
    public partial class FrmVTipo_Doc : Form
    {
        readonly DTipoDocumento dTipoDocumento;
        readonly RTipoDocumento rTipoDoc;

        public FrmVTipo_Doc()
        {
            InitializeComponent();
            dTipoDocumento = new DTipoDocumento();
            rTipoDoc = new RTipoDocumento();
           
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string result = "";
            dTipoDocumento.Codigo = txtcodDoc.Text.Trim();
            dTipoDocumento.Descripcion = txtDescDoc.Text.Trim();

            result = rTipoDoc.Add(dTipoDocumento);

            txtcodDoc.Text = string.Empty;
            txtDescDoc.Text = string.Empty;

            Msg.M_info(result);
        }

       

       
    }
    
    
}
