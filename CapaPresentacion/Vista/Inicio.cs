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
            /*  if (entrada == null)
              {
                  entrada = new Cfrmentrada();
                  this.Panel_contenedor.Controls.Clear();
                  this.Panel_contenedor.Controls.Add(entrada);
              }
              else
              {
                  this.Panel_contenedor.Controls.Clear();
                  this.Panel_contenedor.Controls.Add(entrada);
              }*/
            OpenFormFill<FrmEntrada>();
        }

        private void Btn_salida_Click(object sender, EventArgs e)
        {
            OpenFormFill<FrmSalida>();
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

            }
            else
            {
                //formulario.Close();
                formulario.BringToFront();
            }
        }

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
    }
}
