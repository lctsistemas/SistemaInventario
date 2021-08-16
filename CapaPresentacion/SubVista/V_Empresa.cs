using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaDatos.Entities;
using CapaNegocio.Repositories;
using CapaPresentacion.Helps;
using CapaDatos.Contracts;

//using Guna.UI2.WinForms;

namespace CapaPresentacion.SubVista
{
    public partial class FrmV_Empresa : Form
    {
        readonly Dempresa dempresa;
        readonly IEmpresa rempresa;

        public FrmV_Empresa()
        {
            InitializeComponent();
            dempresa = new Dempresa();
            rempresa = new Rempresa();
           
            CargarRegimen();           
            
        }

        private void CargarRegimen()
        {
            Cboregimen.Items.Add("NUEVO REGIMEN UNICO SIMPLIFICADO");
            Cboregimen.Items.Add("REGIMEN ESPECIAL DE IMPUESTO A LA RENTA");
            Cboregimen.Items.Add("REGIMEN MYPE TRIBUTARIO");
            Cboregimen.Items.Add("REGIMEN GENERAL");
        }


       

        //METODO LIMPIAR
        private void Limpiar()
        {
            //Control x;

            foreach (dynamic item in this.Panel_registro.Controls)
            {
                if (item is Guna.UI2.WinForms.Guna2TextBox || item is ComboBox)
                {
                    item.Text  = null;
                }
               
            }          
            Txtruc.Focus();

        }

        //REGISTRAR
        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(Txtruc.Text) || string.IsNullOrWhiteSpace(Txtrazon.Text)
                 || string.IsNullOrWhiteSpace(Txtdireccion.Text) || string.IsNullOrWhiteSpace(Cboregimen.Text))
            {
                ValidateChildren();
                return;
            }
           
            string result = "";
            dempresa.Ruc = Txtruc.Text.Trim();
            dempresa.Razon_social = Txtrazon.Text.Trim();
            dempresa.Nombre_comercial = Txtnombre_comercial.Text.Trim();
            dempresa.Direccion = Txtdireccion.Text.Trim();
            dempresa.Domicilio_fiscal = Txtfiscal.Text.Trim();
            dempresa.Regimen = Cboregimen.SelectedItem.ToString();
            dempresa.Estado = "ACTIVO";

            result = rempresa.Add(dempresa);
            if (result.Contains("Se Registro"))
                Msg.M_info(result);
            else if (result.Contains("El Número de RUC"))
                Msg.M_warning(result);
            else
                Msg.M_error(result);

            Limpiar();

        }

        //MODIFICAR
        private void Btn_modificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txtruc.Text) || string.IsNullOrWhiteSpace(Txtrazon.Text)
                 || string.IsNullOrWhiteSpace(Txtdireccion.Text) || string.IsNullOrWhiteSpace(Cboregimen.Text))
            {
                ValidateChildren();
                return;
            }

            string result = "";
            dempresa.Id_empresa = int.Parse(Txt_idempresa.Text.Trim());
            dempresa.Ruc = Txtruc.Text.Trim();
            dempresa.Razon_social = Txtrazon.Text.Trim();
            dempresa.Nombre_comercial = Txtnombre_comercial.Text.Trim();
            dempresa.Direccion = Txtdireccion.Text.Trim();
            dempresa.Domicilio_fiscal = Txtfiscal.Text.Trim();
            dempresa.Regimen = Cboregimen.SelectedItem.ToString();
            dempresa.Estado = "ACTIVO";

            result = rempresa.Edit(dempresa);
            if (result.Contains("Se Modifico"))
                Msg.M_info(result);         
            else
                Msg.M_error(result);

            Limpiar();
        }


        private void FrmEmpresa_Load(object sender, EventArgs e)
        {
            
          
        }

        #region VALIDACIONES CON ERROR PROVIDER
        private void Txtruc_Validating(object sender, CancelEventArgs e)
        {
            ValidateError.Validate_text(Txtruc, "¡Campo Requerido!");
        }

        private void Txtrazon_Validating(object sender, CancelEventArgs e)
        {
            ValidateError.Validate_text(Txtrazon, "¡Campo Requerido!");
        }
    
        private void Txtdireccion_Validating(object sender, CancelEventArgs e)
        {
            ValidateError.Validate_text(Txtdireccion, "¡Campo Requerido!");
        }

        private void Cboregimen_Validating(object sender, CancelEventArgs e)
        {
            ValidateError.Validate_combo(Cboregimen, "¡Campo Requerido!");
        }





        #endregion

        private void lblcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblcerrar_MouseLeave(object sender, EventArgs e)
        {
            lblcerrar.BackColor = Color.Empty;
            lblcerrar.ForeColor = Color.Empty;
        }

        private void lblcerrar_MouseMove(object sender, MouseEventArgs e)
        {
            lblcerrar.BackColor = Color.Firebrick;
            lblcerrar.ForeColor = Color.White;
        }
    }
}
