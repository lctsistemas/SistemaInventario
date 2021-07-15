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
    public partial class FrmV_UnidadMedida : Form
    {
        readonly DUnidadMedida dUnidadMedida;
        readonly RUnidadMedida rUnidadMedida;
        public FrmV_UnidadMedida()
        {
            InitializeComponent();
            dUnidadMedida = new DUnidadMedida();
            rUnidadMedida = new RUnidadMedida();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string result = "";
            dUnidadMedida.Abrev = txtAbrev.Text.Trim();
            dUnidadMedida.Descripcion = txtDesc.Text.Trim();

            result = rUnidadMedida.Add(dUnidadMedida);

            txtAbrev.Text = string.Empty;
            txtDesc.Text = string.Empty;

            Msg.M_info(result);
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAbrev.Text) || 
                string.IsNullOrWhiteSpace(txtDesc.Text))
            {
                ValidateChildren();
                return;
            }

            string result = "";
            dUnidadMedida.IdUnidadMedida = int.Parse(txtidUnidMed.Text.Trim());
            dUnidadMedida.Abrev = txtAbrev.Text.Trim();
            dUnidadMedida.Descripcion = txtDesc.Text.Trim();



            result = rUnidadMedida.Edit(dUnidadMedida);
            if (result.Contains("Se Modifico"))
                Msg.M_info(result);
            else
                Msg.M_error(result);

            Limpiar();
        }

        private void Limpiar()
        {
            //Control x;

            foreach (dynamic item in this.panelregistro.Controls)
            {
                if (item is Guna.UI2.WinForms.Guna2TextBox || item is ComboBox)
                {
                    item.Text = null;
                }

            }
            txtAbrev.Focus();

        }

    
        private void txtAbrev_Validating(object sender, CancelEventArgs e)
        {
            ValidateError.Validate_text(txtAbrev, "¡Campo Requerido!");
        }

        private void txtDesc_Validating(object sender, CancelEventArgs e)
        {
            ValidateError.Validate_text(txtDesc, "¡Campo Requerido!");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
