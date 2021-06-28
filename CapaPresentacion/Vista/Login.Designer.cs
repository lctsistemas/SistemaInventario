
namespace CapaPresentacion.Vista
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Txt_acceso = new Guna.UI2.WinForms.Guna2TextBox();
            this.Btn_entrar = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_boton = new System.Windows.Forms.Panel();
            this.lblcerrar = new System.Windows.Forms.PictureBox();
            this.Panel_contenedor = new Guna.UI2.WinForms.Guna2Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_mensaje = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Panelcombo2 = new System.Windows.Forms.Panel();
            this.Panelcombo1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Panel_lineaUsuario = new System.Windows.Forms.Panel();
            this.Cbo_user = new System.Windows.Forms.ComboBox();
            this.Num_periodo = new System.Windows.Forms.NumericUpDown();
            this.Panel_lineaEmpresa = new System.Windows.Forms.Panel();
            this.Cboempresa = new System.Windows.Forms.ComboBox();
            this.Pict_minimizar = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.panel_boton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblcerrar)).BeginInit();
            this.Panel_contenedor.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_periodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pict_minimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 4;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.BorderRadius = 5;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(54, 74);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(342, 362);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // Txt_acceso
            // 
            this.Txt_acceso.AutoCompleteCustomSource.AddRange(new string[] {
            "ADMIN",
            "USUARIO"});
            this.Txt_acceso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.Txt_acceso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Txt_acceso.BorderRadius = 5;
            this.Txt_acceso.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_acceso.DefaultText = "";
            this.Txt_acceso.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_acceso.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_acceso.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_acceso.DisabledState.Parent = this.Txt_acceso;
            this.Txt_acceso.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_acceso.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_acceso.FocusedState.Parent = this.Txt_acceso;
            this.Txt_acceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Txt_acceso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Txt_acceso.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_acceso.HoverState.Parent = this.Txt_acceso;
            this.Txt_acceso.Location = new System.Drawing.Point(31, 205);
            this.Txt_acceso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_acceso.Name = "Txt_acceso";
            this.Txt_acceso.PasswordChar = '•';
            this.Txt_acceso.PlaceholderText = "CLAVE";
            this.Txt_acceso.SelectedText = "";
            this.Txt_acceso.ShadowDecoration.Parent = this.Txt_acceso;
            this.Txt_acceso.Size = new System.Drawing.Size(391, 36);
            this.Txt_acceso.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Txt_acceso.TabIndex = 2;
            this.Txt_acceso.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_acceso_Validating);
            // 
            // Btn_entrar
            // 
            this.Btn_entrar.BorderColor = System.Drawing.Color.SlateGray;
            this.Btn_entrar.BorderRadius = 4;
            this.Btn_entrar.BorderThickness = 1;
            this.Btn_entrar.CheckedState.Parent = this.Btn_entrar;
            this.Btn_entrar.CustomImages.Parent = this.Btn_entrar;
            this.Btn_entrar.FillColor = System.Drawing.Color.SkyBlue;
            this.Btn_entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_entrar.ForeColor = System.Drawing.Color.White;
            this.Btn_entrar.HoverState.Parent = this.Btn_entrar;
            this.Btn_entrar.Location = new System.Drawing.Point(110, 441);
            this.Btn_entrar.Name = "Btn_entrar";
            this.Btn_entrar.ShadowDecoration.Parent = this.Btn_entrar;
            this.Btn_entrar.Size = new System.Drawing.Size(239, 45);
            this.Btn_entrar.TabIndex = 5;
            this.Btn_entrar.Text = "ENTRAR";
            this.Btn_entrar.Click += new System.EventHandler(this.Btn_entrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(90, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "INICIO DE SESION";
            // 
            // panel_boton
            // 
            this.panel_boton.Controls.Add(this.Pict_minimizar);
            this.panel_boton.Controls.Add(this.lblcerrar);
            this.panel_boton.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_boton.Location = new System.Drawing.Point(0, 0);
            this.panel_boton.Name = "panel_boton";
            this.panel_boton.Size = new System.Drawing.Size(450, 28);
            this.panel_boton.TabIndex = 15;
            this.panel_boton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_boton_MouseDown);
            // 
            // lblcerrar
            // 
            this.lblcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblcerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblcerrar.Image = ((System.Drawing.Image)(resources.GetObject("lblcerrar.Image")));
            this.lblcerrar.Location = new System.Drawing.Point(425, 0);
            this.lblcerrar.Name = "lblcerrar";
            this.lblcerrar.Size = new System.Drawing.Size(25, 28);
            this.lblcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.lblcerrar.TabIndex = 12;
            this.lblcerrar.TabStop = false;
            this.lblcerrar.Click += new System.EventHandler(this.lblcerrar_Click);
            // 
            // Panel_contenedor
            // 
            this.Panel_contenedor.BackColor = System.Drawing.Color.Transparent;
            this.Panel_contenedor.BorderColor = System.Drawing.Color.DarkGray;
            this.Panel_contenedor.BorderRadius = 2;
            this.Panel_contenedor.BorderThickness = 1;
            this.Panel_contenedor.Controls.Add(this.panel2);
            this.Panel_contenedor.Controls.Add(this.panel1);
            this.Panel_contenedor.Location = new System.Drawing.Point(0, 0);
            this.Panel_contenedor.Name = "Panel_contenedor";
            this.Panel_contenedor.ShadowDecoration.BorderRadius = 3;
            this.Panel_contenedor.ShadowDecoration.Depth = 5;
            this.Panel_contenedor.ShadowDecoration.Parent = this.Panel_contenedor;
            this.Panel_contenedor.Size = new System.Drawing.Size(899, 511);
            this.Panel_contenedor.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.guna2PictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 511);
            this.panel2.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Lbl_mensaje);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.Panelcombo2);
            this.panel1.Controls.Add(this.Panelcombo1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.Panel_lineaUsuario);
            this.panel1.Controls.Add(this.Cbo_user);
            this.panel1.Controls.Add(this.Num_periodo);
            this.panel1.Controls.Add(this.Panel_lineaEmpresa);
            this.panel1.Controls.Add(this.Cboempresa);
            this.panel1.Controls.Add(this.panel_boton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Btn_entrar);
            this.panel1.Controls.Add(this.Txt_acceso);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(449, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 511);
            this.panel1.TabIndex = 16;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // Lbl_mensaje
            // 
            this.Lbl_mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_mensaje.ForeColor = System.Drawing.Color.Crimson;
            this.Lbl_mensaje.Location = new System.Drawing.Point(107, 372);
            this.Lbl_mensaje.Name = "Lbl_mensaje";
            this.Lbl_mensaje.Size = new System.Drawing.Size(242, 45);
            this.Lbl_mensaje.TabIndex = 38;
            this.Lbl_mensaje.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(28, 172);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(375, 3);
            this.panel4.TabIndex = 36;
            // 
            // Panelcombo2
            // 
            this.Panelcombo2.BackColor = System.Drawing.Color.White;
            this.Panelcombo2.Location = new System.Drawing.Point(28, 293);
            this.Panelcombo2.Name = "Panelcombo2";
            this.Panelcombo2.Size = new System.Drawing.Size(375, 3);
            this.Panelcombo2.TabIndex = 30;
            // 
            // Panelcombo1
            // 
            this.Panelcombo1.BackColor = System.Drawing.Color.White;
            this.Panelcombo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Panelcombo1.Location = new System.Drawing.Point(31, 261);
            this.Panelcombo1.Name = "Panelcombo1";
            this.Panelcombo1.Size = new System.Drawing.Size(372, 10);
            this.Panelcombo1.TabIndex = 29;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel5.Location = new System.Drawing.Point(31, 140);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(372, 10);
            this.panel5.TabIndex = 35;
            // 
            // Panel_lineaUsuario
            // 
            this.Panel_lineaUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.Panel_lineaUsuario.Location = new System.Drawing.Point(31, 179);
            this.Panel_lineaUsuario.Name = "Panel_lineaUsuario";
            this.Panel_lineaUsuario.Size = new System.Drawing.Size(391, 1);
            this.Panel_lineaUsuario.TabIndex = 37;
            // 
            // Cbo_user
            // 
            this.Cbo_user.AutoCompleteCustomSource.AddRange(new string[] {
            "ADMINISTRADOR",
            "AUXILIAR"});
            this.Cbo_user.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.Cbo_user.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Cbo_user.BackColor = System.Drawing.Color.White;
            this.Cbo_user.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cbo_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbo_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.Cbo_user.FormattingEnabled = true;
            this.Cbo_user.ItemHeight = 18;
            this.Cbo_user.Location = new System.Drawing.Point(31, 147);
            this.Cbo_user.Name = "Cbo_user";
            this.Cbo_user.Size = new System.Drawing.Size(391, 26);
            this.Cbo_user.TabIndex = 1;
            this.Cbo_user.Text = "USUARIO";
            this.Cbo_user.Enter += new System.EventHandler(this.Cbo_user_Enter);
            this.Cbo_user.Leave += new System.EventHandler(this.Cbo_user_Leave);
            this.Cbo_user.Validating += new System.ComponentModel.CancelEventHandler(this.Cbo_user_Validating);
            // 
            // Num_periodo
            // 
            this.Num_periodo.BackColor = System.Drawing.Color.White;
            this.Num_periodo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Num_periodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num_periodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Num_periodo.Location = new System.Drawing.Point(31, 330);
            this.Num_periodo.Maximum = new decimal(new int[] {
            2032,
            0,
            0,
            0});
            this.Num_periodo.Minimum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.Num_periodo.Name = "Num_periodo";
            this.Num_periodo.ReadOnly = true;
            this.Num_periodo.Size = new System.Drawing.Size(107, 20);
            this.Num_periodo.TabIndex = 4;
            this.Num_periodo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Num_periodo.Value = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            // 
            // Panel_lineaEmpresa
            // 
            this.Panel_lineaEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.Panel_lineaEmpresa.Location = new System.Drawing.Point(31, 300);
            this.Panel_lineaEmpresa.Name = "Panel_lineaEmpresa";
            this.Panel_lineaEmpresa.Size = new System.Drawing.Size(391, 1);
            this.Panel_lineaEmpresa.TabIndex = 32;
            // 
            // Cboempresa
            // 
            this.Cboempresa.BackColor = System.Drawing.Color.White;
            this.Cboempresa.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cboempresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cboempresa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cboempresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.Cboempresa.FormattingEnabled = true;
            this.Cboempresa.ItemHeight = 20;
            this.Cboempresa.Location = new System.Drawing.Point(31, 268);
            this.Cboempresa.Name = "Cboempresa";
            this.Cboempresa.Size = new System.Drawing.Size(391, 28);
            this.Cboempresa.TabIndex = 3;
            this.Cboempresa.Text = "EMPRESAS";
            this.Cboempresa.Enter += new System.EventHandler(this.Cboempresa_Enter);
            this.Cboempresa.Leave += new System.EventHandler(this.Cboempresa_Leave);
            this.Cboempresa.Validating += new System.ComponentModel.CancelEventHandler(this.Cboempresa_Validating);
            // 
            // Pict_minimizar
            // 
            this.Pict_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pict_minimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.Pict_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Pict_minimizar.Image")));
            this.Pict_minimizar.Location = new System.Drawing.Point(400, 0);
            this.Pict_minimizar.Name = "Pict_minimizar";
            this.Pict_minimizar.Size = new System.Drawing.Size(25, 28);
            this.Pict_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Pict_minimizar.TabIndex = 13;
            this.Pict_minimizar.TabStop = false;
            this.Pict_minimizar.Click += new System.EventHandler(this.Pict_minimizar_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 512);
            this.Controls.Add(this.Panel_contenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.panel_boton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lblcerrar)).EndInit();
            this.Panel_contenedor.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_periodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pict_minimizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button Btn_entrar;
        private Guna.UI2.WinForms.Guna2TextBox Txt_acceso;
        private System.Windows.Forms.Panel panel_boton;
        private System.Windows.Forms.PictureBox lblcerrar;
        private Guna.UI2.WinForms.Guna2Panel Panel_contenedor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Panelcombo2;
        private System.Windows.Forms.Panel Panelcombo1;
        private System.Windows.Forms.ComboBox Cboempresa;
        private System.Windows.Forms.Panel Panel_lineaEmpresa;
        private System.Windows.Forms.NumericUpDown Num_periodo;
        private System.Windows.Forms.Panel Panel_lineaUsuario;
        private System.Windows.Forms.ComboBox Cbo_user;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label Lbl_mensaje;
        private System.Windows.Forms.PictureBox Pict_minimizar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}