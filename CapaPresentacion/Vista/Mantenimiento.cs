using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio.Repositories;
using CapaDatos.Entities;
using CapaDatos.Cache;

namespace CapaPresentacion.Vista
{
    public partial class FrmMantenimiento : Form
    {

        readonly DEntrada de;
        readonly RMantenimientoInventario rema;
        public FrmMantenimiento()
        {
            InitializeComponent();
            de = new DEntrada();
            rema = new RMantenimientoInventario();

            ShowMes();
        }

        private void ShowMes()
        {
            using (REntrada re = new REntrada())
            {
                Cbomes.DataSource = re.Get_mes();
                Cbomes.DisplayMember = "nombre_mes";
                Cbomes.ValueMember = "idmes";
            }
        }

        private void ShowGrupoInventario()
        {
            de.Id_empresa = UserCache.C_idempresa;
            de.Id_mes = (int)Cbomes.SelectedValue;
            de.Id_periodo = UserCache.C_idperiodo;

            Dgv_grupo_.DataSource = rema.Get_showGrupo(de);
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            ShowGrupoInventario();
        }
    }
}
