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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtcodDoc.Text) || string.IsNullOrWhiteSpace(txtDescDoc.Text))

            {
                ValidateChildren();
                return;
            }

            string result = "";
            dTipoDocumento.Iddocumento = int.Parse(txtidTipoDoc.Text.Trim());
            dTipoDocumento.Codigo = txtcodDoc.Text.Trim();
            dTipoDocumento.Descripcion = txtDescDoc.Text.Trim();


            result = rTipoDoc.Edit(dTipoDocumento);
            if (result.Contains("Se Modifico"))
                Msg.M_info(result);
            else
                Msg.M_error(result);

            Limpiar();
        }

        private void Limpiar()
        {

            foreach (dynamic item in this.panelregistro.Controls)
            {
                if (item is Guna.UI2.WinForms.Guna2TextBox || item is ComboBox)
                {
                    item.Text = null;
                }

            }
            txtcodDoc.Focus();

        }
    }
    
    
}
