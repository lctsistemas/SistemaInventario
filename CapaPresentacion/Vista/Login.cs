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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            CargarEmpresa();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void CargarEmpresa()
        {
            string[] Business = {"LOGISTICA CONTABLE Y TRIBUTARIA S.A.C","INVERSIONES KIZOKU S.A.C","TECNOLOGIA 2050 S.A.C","INVERSIONES LEVENE S.A.C","SEIDAI S.A.C",
                "NEGOCIACIONES E INVERSIONES K-GRAND","TRIPLE J CONTRATISTA SRL S.A.C","FISIODEPORT-T S.A.C","LUGANO S.A.C","AYUMI S.A.C","DANY CAMY CONTRATISTAS S.A.C",
            "ICHIRO S.A.C"};

            this.Cbo_empresa.Items.AddRange(Business);
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

        private void Btn_entrar_Click(object sender, EventArgs e)
        {
            FrmInicio frmini = FrmInicio.GetInstancia();
            
                frmini.Show();
                frmini.FormClosed += Logout;
                this.Hide();
            
            
           
        }
    }
}
