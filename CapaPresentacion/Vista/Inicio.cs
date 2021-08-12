using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaDatos.Cache;

namespace CapaPresentacion.Vista
{
    public partial class FrmInicio : Form
    {
        Form formulario = null;
        private static FrmInicio instancia;
        public FrmInicio()
        {
            InitializeComponent();
        
        }

        public static FrmInicio GetInstancia(){
            if (instancia == null)
                instancia = new FrmInicio();
            return instancia;                    
        }

        private void Btn_entrada_Click(object sender, EventArgs e)
        {             
            OpenFormFill<FrmEntradaImpotacion>();
        }

        private void Btn_mante_Click(object sender, EventArgs e)
        {
            OpenFormFill<FrmMantenimiento>();
        }

        //METODO PARA ABRIR FORMULARIO DENTRO DE PANEL PERO TODO EL ANCHO FILL
        private void OpenFormFill<Myform>() where Myform : Form, new()
        {
            //Form formulario;
            formulario = Panel_contenedor.Controls.OfType<Myform>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new Myform();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                Panel_contenedor.Controls.Add(formulario);
                Panel_contenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                //formulario.FormClosed += new FormClosedEventHandler(CloseForm);

            }
            else
            {
                
               // formulario.Close();
                formulario.BringToFront();
            }
        }

       /* private void CloseForm(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["FrmEntradaImpotacion"] == null)
            {
                Close();
            }
            if (Application.OpenForms["FrmMantenimiento"] == null)
            {
                Close();
            }
        }*/

        private void Btn_empresa_Click(object sender, EventArgs e)
        {
            OpenFormFill<FrmEmpresa>();
        }

        private void Btn_cliente_pro_Click(object sender, EventArgs e)
        {
            OpenFormFill<FrmClientePro>();
        }

        private void Btn_tipooperacion_Click(object sender, EventArgs e)
        {
            OpenFormFill<FrmTipoOperacion>();
        }

        private void Btn_tipdocumento_Click(object sender, EventArgs e)
        {
            OpenFormFill<FrmTipoDocumento>();
        }

        private void Btn_iv_fisico_Click(object sender, EventArgs e)
        {
            OpenFormFill<FrmUnidadFisica>();
        }

        private void Btn_iv_valorizado_Click(object sender, EventArgs e)
        {
            OpenFormFill<FrmUnidadValorizado>();
        }

        private void Btn_moneda_Click(object sender, EventArgs e)
        {
            OpenFormFill<FrmMoneda>();
        }

        private void FrmInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
            Lblempresa.Text = "  "+ UserCache.C_periodo+" ::   "+ UserCache.C_ruc+"    "+ UserCache.C_razonSocial;
            lbluser.Text = UserCache.C_usuario;
            Lbl_idempresa.Text = "id empresa " + UserCache.C_idempresa.ToString();
            Lbl_idperiodo.Text = "id periodo " + UserCache.C_idperiodo.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToLongDateString();
            string hora = DateTime.Now.ToLongTimeString();
            tlblhora.Text = fecha + "   |   " + hora;
        }

        private void BtnUnidMed_Click(object sender, EventArgs e)
        {
            OpenFormFill<FrmUnidadMedida>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFormFill<FrmTipoExistencia>();
        }

        private void FrmInicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MessageBox.Show("cerrarndo form");
        }
    }
}
