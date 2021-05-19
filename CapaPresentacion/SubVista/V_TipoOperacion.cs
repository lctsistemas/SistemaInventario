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
    public partial class Frm_VTipoOper : Form
    {
        readonly DTipoOperacion dTipoOperacion;
        readonly RTipoOperacion rTipoOperacion;
        public Frm_VTipoOper()
        {
            InitializeComponent();
            dTipoOperacion = new DTipoOperacion();
            rTipoOperacion = new RTipoOperacion();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string result = "";
            dTipoOperacion.Codigo = txtcodOper.Text.Trim();
            dTipoOperacion.Descripcion = txtDesc.Text.Trim();

            result = rTipoOperacion.Add(dTipoOperacion);


            txtcodOper.Text = string.Empty;
            txtDesc.Text = string.Empty;
            Msg.M_info(result);
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtcodOper.Text) || string.IsNullOrWhiteSpace(txtDesc.Text)) 
            {
                ValidateChildren();
                return;
            }

            string result = "";
            dTipoOperacion.IdTipo_Oper = int.Parse(txtidTipoOper.Text.Trim());
            dTipoOperacion.Codigo = txtcodOper.Text.Trim();
            dTipoOperacion.Descripcion = txtDesc.Text.Trim();
        


            result = rTipoOperacion.Edit(dTipoOperacion);
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
            txtcodOper.Focus();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
