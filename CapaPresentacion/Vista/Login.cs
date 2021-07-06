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
using CapaDatos.Cache;
using System.Threading;
using CapaPresentacion.Helps;
using CapaPresentacion.SubVista;

namespace CapaPresentacion.Vista
{
    public partial class FrmLogin : Form
    {

        private const string pass_admin = "admin";
        private const string pass_auxi = "123";

        readonly Dempresa dem = null;
        AutoCompleteStringCollection datos = null;
        List<Dempresa> list_emp;
        public FrmLogin()
        {
            InitializeComponent();
            dem = new Dempresa();
            
            CargarEmpresas();
            Cboempresa.Text = null;
            Cboempresa.Text = "EMPRESA";
            this.toolTip1.SetToolTip(Pict_minimizar,"Minimize");
            this.toolTip1.SetToolTip(lblcerrar,"Close");

        }

        private void Login_Load(object sender, EventArgs e)
        {
            Cbo_user.Items.Add("ADMINISTRADOR");
            Cbo_user.Items.Add("AUXILIAR");          

        }

        //CARGAR EMPRESAS AL COMBO
        private void CargarEmpresas()
        {
            using (Rempresa rem = new Rempresa())
            {
                dem.Estado = "ACTIVO";
                Cboempresa.DataSource = rem.Getdata(dem);
                Cboempresa.DisplayMember = "Razon_social";
                Cboempresa.ValueMember = "Id_empresa";
            }

            Cboempresa.AutoCompleteCustomSource = FilterEmpresas();
            Cboempresa.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Cboempresa.AutoCompleteSource = AutoCompleteSource.CustomSource;            
        }      

        //METODO PARA AUTOCOMPLETADO DE EMPRESAS.
        private AutoCompleteStringCollection FilterEmpresas()
        {
            
            if (datos == null) 
                  datos = new AutoCompleteStringCollection();
            datos.Clear();
            
            dem.Estado = "ACTIVO";
            using (Rempresa rem = new Rempresa())
            {
                list_emp = rem.Getdata(dem);
                for (int i = 0; i < list_emp.Count; i++)
                {
                    datos.Add(list_emp[i].Razon_social.ToString());
                }
            }
            return datos;
        }

        //VALIDACION SI ESTA SELECCIONANDO LA EMPRESA.
        public bool Existe(string bussines)
        {
            //MessageBox.Show("canti "+ list_emp.Count);
            foreach (Dempresa item in list_emp)
            {
                if (item.Razon_social == bussines)
                {                    
                    return true;
                }
            }
            return false;
        }

        private void lblcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //cerrar sesion
        private void Logout(object sender, FormClosedEventArgs e)
        {            
            this.Show();
        }

        //BOTON ENTRAR EL SISITEMA
        private void Btn_entrar_Click(object sender, EventArgs e)
        {
            if (Cbo_user.Text.Equals("USUARIO") || string.IsNullOrWhiteSpace(Cbo_user.Text))
            {
                ValidateChildren();
                Cbo_user.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(Txt_acceso.Text))
            {
                ValidateChildren();
                Txt_acceso.Focus();
                return;
            }

            if (Cboempresa.Text.Equals("EMPRESA") || string.IsNullOrWhiteSpace(Cboempresa.Text))
            {
                ValidateChildren();
                Cboempresa.Focus();
                return;
            }

            if((Cbo_user.Text.Trim().Equals("ADMINISTRADOR") && Txt_acceso.Text.Trim() == pass_admin) || 
                    (Cbo_user.Text.Trim().Equals("AUXILIAR") && Txt_acceso.Text.Trim() == pass_auxi))
            {
                if (Existe(Cboempresa.Text.Trim()))
                {
                    //MessageBox.Show("BIENVENIDO");
                    if (list_emp != null)
                    {
                        foreach (Dempresa item in list_emp.Where(x => x.Id_empresa == Convert.ToInt32(Cboempresa.SelectedValue)).ToList())
                        {
                            UserCache.C_idempresa = item.Id_empresa;
                            UserCache.C_razonSocial = item.Razon_social;
                            UserCache.C_ruc = item.Ruc;
                        }
                        UserCache.C_usuario = Cbo_user.SelectedItem.ToString();
                        EnviarPeriodo();

                        FrmInicio frmini = FrmInicio.GetInstancia();
                        frmini.Show();
                        frmini.FormClosed += Logout;
                        this.Hide();

                    }
                }
                else
                    Lbl_mensaje.Text = "Empresa no existe";

            }
            else
            {
                Lbl_mensaje.Text = "El Usuario o Contraseña son Incorrectos";
            }
    
           
        }
       

        //INICIO DE PLACEHOLDER
        private void Cbo_user_Enter(object sender, EventArgs e)
        {

            Panel_lineaUsuario.BackColor = Color.FromArgb(94, 148, 255);
            Panel_lineaUsuario.Size = new Size(379, 2);

            if (Cbo_user.Text.Equals("USUARIO"))
            {
                Cbo_user.Text = String.Empty;
                Cbo_user.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void Cbo_user_Leave(object sender, EventArgs e)
        {
            Panel_lineaUsuario.BackColor = Color.FromArgb(217, 221, 226);
            Panel_lineaUsuario.Size = new Size(379, 1);

            //cuando sale del foco
            if (String.IsNullOrWhiteSpace(Cbo_user.Text))
            {
                Cbo_user.Text = "USUARIO";
                Cbo_user.ForeColor = Color.FromArgb(217, 221, 226);
            }
        }

        private void Cboempresa_Enter(object sender, EventArgs e)
        {
            Panel_lineaEmpresa.BackColor = Color.FromArgb(94, 148, 255);
            Panel_lineaEmpresa.Size = new Size(379, 2);


            if (Cboempresa.Text.Equals("EMPRESA"))
            {
                Cboempresa.Text = String.Empty;
                Cboempresa.ForeColor = Color.FromArgb(64, 64, 64);
            }

        }

        private void Cboempresa_Leave(object sender, EventArgs e)
        {
            Panel_lineaEmpresa.BackColor = Color.FromArgb(217, 221, 226);
            Panel_lineaEmpresa.Size = new Size(379, 1);

            if (String.IsNullOrWhiteSpace(Cboempresa.Text))
            {
                Cboempresa.Text = "EMPRESA";
                Cboempresa.ForeColor = Color.FromArgb(217, 221, 226);
            }
        }


        //VALIDAR SI ESTA VACIO
        private void Cbo_user_Validating(object sender, CancelEventArgs e)
        {
            if (Cbo_user.Text.Equals("USUARIO") || string.IsNullOrWhiteSpace(Cbo_user.Text))
            {
                Lbl_mensaje.Text = "Digite o Seleccione su Usuario";
              
            }
            else
                Lbl_mensaje.Text = "";
        }

        private void Txt_acceso_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_acceso.Text))
            {
                Lbl_mensaje.Text = "Ingrese su Contraseña";
               
            }
            else
                Lbl_mensaje.Text = "";
        }

        private void Cboempresa_Validating(object sender, CancelEventArgs e)
        {
            if (Cboempresa.Text.Equals("EMPRESA") || string.IsNullOrWhiteSpace(Cboempresa.Text))
            {
                Lbl_mensaje.Text = "Digite o Seleccione una Empresa";            
            }
            else
                Lbl_mensaje.Text = "";
        }

        private void EnviarPeriodo()
        {
            using (RLogin rem = new RLogin())
            {
                UserCache.C_idperiodo = rem.GetIdPeriodo(Convert.ToInt32(Num_periodo.Value));
                UserCache.C_periodo = Num_periodo.Value.ToString();
            }
               
        }

        //METODO PARA MOVER VENTANA
        private void MoverVentana()
        {
            WindowsMove.ReleaseCapture();
            WindowsMove.Move(this.Handle);
        }

        private void panel_boton_MouseDown(object sender, MouseEventArgs e)
        {
            MoverVentana();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MoverVentana();
        }

        private void Pict_minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

       
    }
}
