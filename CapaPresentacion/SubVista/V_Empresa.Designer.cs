
namespace CapaPresentacion.SubVista
{
    partial class FrmV_Empresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmV_Empresa));
            this.Panel_registro = new System.Windows.Forms.Panel();
            this.Txt_idempresa = new System.Windows.Forms.TextBox();
            this.Panel_boton = new System.Windows.Forms.Panel();
            this.Btn_modificar = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_guardar = new Guna.UI2.WinForms.Guna2Button();
            this.Cboregimen = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Txtfiscal = new Guna.UI2.WinForms.Guna2TextBox();
            this.Txtdireccion = new Guna.UI2.WinForms.Guna2TextBox();
            this.Txtnombre_comercial = new Guna.UI2.WinForms.Guna2TextBox();
            this.Txtruc = new Guna.UI2.WinForms.Guna2TextBox();
            this.Txtrazon = new Guna.UI2.WinForms.Guna2TextBox();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.Panel_empresa = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Panel_registro.SuspendLayout();
            this.Panel_boton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            this.Panel_empresa.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_registro
            // 
            this.Panel_registro.BackColor = System.Drawing.Color.White;
            this.Panel_registro.Controls.Add(this.Txt_idempresa);
            this.Panel_registro.Controls.Add(this.Panel_boton);
            this.Panel_registro.Controls.Add(this.Cboregimen);
            this.Panel_registro.Controls.Add(this.label9);
            this.Panel_registro.Controls.Add(this.label7);
            this.Panel_registro.Controls.Add(this.label5);
            this.Panel_registro.Controls.Add(this.label6);
            this.Panel_registro.Controls.Add(this.label8);
            this.Panel_registro.Controls.Add(this.label10);
            this.Panel_registro.Controls.Add(this.Txtfiscal);
            this.Panel_registro.Controls.Add(this.Txtdireccion);
            this.Panel_registro.Controls.Add(this.Txtnombre_comercial);
            this.Panel_registro.Controls.Add(this.Txtruc);
            this.Panel_registro.Controls.Add(this.Txtrazon);
            this.Panel_registro.Location = new System.Drawing.Point(52, 74);
            this.Panel_registro.Name = "Panel_registro";
            this.Panel_registro.Size = new System.Drawing.Size(908, 375);
            this.Panel_registro.TabIndex = 1;
            // 
            // Txt_idempresa
            // 
            this.Txt_idempresa.Location = new System.Drawing.Point(199, 15);
            this.Txt_idempresa.Name = "Txt_idempresa";
            this.Txt_idempresa.Size = new System.Drawing.Size(57, 20);
            this.Txt_idempresa.TabIndex = 102;
            this.Txt_idempresa.Visible = false;
            // 
            // Panel_boton
            // 
            this.Panel_boton.Controls.Add(this.Btn_modificar);
            this.Panel_boton.Controls.Add(this.Btn_guardar);
            this.Panel_boton.Location = new System.Drawing.Point(199, 277);
            this.Panel_boton.Name = "Panel_boton";
            this.Panel_boton.Size = new System.Drawing.Size(399, 79);
            this.Panel_boton.TabIndex = 101;
            // 
            // Btn_modificar
            // 
            this.Btn_modificar.BorderRadius = 3;
            this.Btn_modificar.CheckedState.Parent = this.Btn_modificar;
            this.Btn_modificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_modificar.CustomImages.Parent = this.Btn_modificar;
            this.Btn_modificar.FillColor = System.Drawing.Color.DarkRed;
            this.Btn_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Btn_modificar.ForeColor = System.Drawing.Color.White;
            this.Btn_modificar.HoverState.Parent = this.Btn_modificar;
            this.Btn_modificar.Location = new System.Drawing.Point(0, 0);
            this.Btn_modificar.Name = "Btn_modificar";
            this.Btn_modificar.ShadowDecoration.Parent = this.Btn_modificar;
            this.Btn_modificar.Size = new System.Drawing.Size(399, 45);
            this.Btn_modificar.TabIndex = 8;
            this.Btn_modificar.Text = "Modificar";
            this.Btn_modificar.Click += new System.EventHandler(this.Btn_modificar_Click);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BorderRadius = 3;
            this.Btn_guardar.CheckedState.Parent = this.Btn_guardar;
            this.Btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_guardar.CustomImages.Parent = this.Btn_guardar;
            this.Btn_guardar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_guardar.FillColor = System.Drawing.Color.Coral;
            this.Btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_guardar.ForeColor = System.Drawing.Color.White;
            this.Btn_guardar.HoverState.Parent = this.Btn_guardar;
            this.Btn_guardar.Location = new System.Drawing.Point(0, 0);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.ShadowDecoration.Parent = this.Btn_guardar;
            this.Btn_guardar.Size = new System.Drawing.Size(399, 45);
            this.Btn_guardar.TabIndex = 7;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Cboregimen
            // 
            this.Cboregimen.BackColor = System.Drawing.Color.Transparent;
            this.Cboregimen.BorderRadius = 3;
            this.Cboregimen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cboregimen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cboregimen.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cboregimen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cboregimen.FocusedState.Parent = this.Cboregimen;
            this.Cboregimen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Cboregimen.ForeColor = System.Drawing.Color.Black;
            this.Cboregimen.HoverState.Parent = this.Cboregimen;
            this.Cboregimen.ItemHeight = 24;
            this.Cboregimen.ItemsAppearance.Parent = this.Cboregimen;
            this.Cboregimen.Location = new System.Drawing.Point(199, 211);
            this.Cboregimen.Name = "Cboregimen";
            this.Cboregimen.ShadowDecoration.Parent = this.Cboregimen;
            this.Cboregimen.Size = new System.Drawing.Size(399, 30);
            this.Cboregimen.TabIndex = 6;
            this.Cboregimen.Validating += new System.ComponentModel.CancelEventHandler(this.Cboregimen_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(35, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "NOMBRE COMERCIAL";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(35, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 43);
            this.label7.TabIndex = 12;
            this.label7.Text = "RAZON SOCIAL O DENOMINACION";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(35, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "DIRECCION";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(35, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "REGIMEN";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(35, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "DOMICILIO FISCAL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(35, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "RUC";
            // 
            // Txtfiscal
            // 
            this.Txtfiscal.BorderRadius = 3;
            this.Txtfiscal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txtfiscal.DefaultText = "";
            this.Txtfiscal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txtfiscal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txtfiscal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txtfiscal.DisabledState.Parent = this.Txtfiscal;
            this.Txtfiscal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txtfiscal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txtfiscal.FocusedState.Parent = this.Txtfiscal;
            this.Txtfiscal.ForeColor = System.Drawing.Color.Black;
            this.Txtfiscal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txtfiscal.HoverState.Parent = this.Txtfiscal;
            this.Txtfiscal.Location = new System.Drawing.Point(199, 177);
            this.Txtfiscal.Name = "Txtfiscal";
            this.Txtfiscal.PasswordChar = '\0';
            this.Txtfiscal.PlaceholderText = "";
            this.Txtfiscal.SelectedText = "";
            this.Txtfiscal.ShadowDecoration.Parent = this.Txtfiscal;
            this.Txtfiscal.Size = new System.Drawing.Size(675, 28);
            this.Txtfiscal.TabIndex = 5;
            // 
            // Txtdireccion
            // 
            this.Txtdireccion.BorderRadius = 3;
            this.Txtdireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txtdireccion.DefaultText = "";
            this.Txtdireccion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txtdireccion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txtdireccion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txtdireccion.DisabledState.Parent = this.Txtdireccion;
            this.Txtdireccion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txtdireccion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txtdireccion.FocusedState.Parent = this.Txtdireccion;
            this.Txtdireccion.ForeColor = System.Drawing.Color.Black;
            this.Txtdireccion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txtdireccion.HoverState.Parent = this.Txtdireccion;
            this.Txtdireccion.Location = new System.Drawing.Point(199, 143);
            this.Txtdireccion.Name = "Txtdireccion";
            this.Txtdireccion.PasswordChar = '\0';
            this.Txtdireccion.PlaceholderText = "";
            this.Txtdireccion.SelectedText = "";
            this.Txtdireccion.ShadowDecoration.Parent = this.Txtdireccion;
            this.Txtdireccion.Size = new System.Drawing.Size(675, 28);
            this.Txtdireccion.TabIndex = 4;
            this.Txtdireccion.Validating += new System.ComponentModel.CancelEventHandler(this.Txtdireccion_Validating);
            // 
            // Txtnombre_comercial
            // 
            this.Txtnombre_comercial.BorderRadius = 3;
            this.Txtnombre_comercial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txtnombre_comercial.DefaultText = "";
            this.Txtnombre_comercial.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txtnombre_comercial.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txtnombre_comercial.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txtnombre_comercial.DisabledState.Parent = this.Txtnombre_comercial;
            this.Txtnombre_comercial.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txtnombre_comercial.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txtnombre_comercial.FocusedState.Parent = this.Txtnombre_comercial;
            this.Txtnombre_comercial.ForeColor = System.Drawing.Color.Black;
            this.Txtnombre_comercial.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txtnombre_comercial.HoverState.Parent = this.Txtnombre_comercial;
            this.Txtnombre_comercial.Location = new System.Drawing.Point(199, 109);
            this.Txtnombre_comercial.Name = "Txtnombre_comercial";
            this.Txtnombre_comercial.PasswordChar = '\0';
            this.Txtnombre_comercial.PlaceholderText = "";
            this.Txtnombre_comercial.SelectedText = "";
            this.Txtnombre_comercial.ShadowDecoration.Parent = this.Txtnombre_comercial;
            this.Txtnombre_comercial.Size = new System.Drawing.Size(399, 28);
            this.Txtnombre_comercial.TabIndex = 3;
            // 
            // Txtruc
            // 
            this.Txtruc.BorderRadius = 3;
            this.Txtruc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txtruc.DefaultText = "";
            this.Txtruc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txtruc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txtruc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txtruc.DisabledState.Parent = this.Txtruc;
            this.Txtruc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txtruc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txtruc.FocusedState.Parent = this.Txtruc;
            this.Txtruc.ForeColor = System.Drawing.Color.Black;
            this.Txtruc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txtruc.HoverState.Parent = this.Txtruc;
            this.Txtruc.Location = new System.Drawing.Point(199, 41);
            this.Txtruc.Name = "Txtruc";
            this.Txtruc.PasswordChar = '\0';
            this.Txtruc.PlaceholderText = "INGRESE RUC";
            this.Txtruc.SelectedText = "";
            this.Txtruc.ShadowDecoration.Parent = this.Txtruc;
            this.Txtruc.Size = new System.Drawing.Size(191, 28);
            this.Txtruc.TabIndex = 1;
            this.Txtruc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txtruc.Validating += new System.ComponentModel.CancelEventHandler(this.Txtrazon_Validating);
            // 
            // Txtrazon
            // 
            this.Txtrazon.BorderRadius = 3;
            this.Txtrazon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txtrazon.DefaultText = "";
            this.Txtrazon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txtrazon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txtrazon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txtrazon.DisabledState.Parent = this.Txtrazon;
            this.Txtrazon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txtrazon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txtrazon.FocusedState.Parent = this.Txtrazon;
            this.Txtrazon.ForeColor = System.Drawing.Color.Black;
            this.Txtrazon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txtrazon.HoverState.Parent = this.Txtrazon;
            this.Txtrazon.Location = new System.Drawing.Point(199, 75);
            this.Txtrazon.Name = "Txtrazon";
            this.Txtrazon.PasswordChar = '\0';
            this.Txtrazon.PlaceholderText = "";
            this.Txtrazon.SelectedText = "";
            this.Txtrazon.ShadowDecoration.Parent = this.Txtrazon;
            this.Txtrazon.Size = new System.Drawing.Size(399, 28);
            this.Txtrazon.TabIndex = 2;
            this.Txtrazon.Validating += new System.ComponentModel.CancelEventHandler(this.Txtrazon_Validating);
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(973, 0);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(38, 35);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btncerrar.TabIndex = 100;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // Panel_empresa
            // 
            this.Panel_empresa.BackColor = System.Drawing.Color.Gray;
            this.Panel_empresa.Controls.Add(this.Panel_registro);
            this.Panel_empresa.Controls.Add(this.btncerrar);
            this.Panel_empresa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_empresa.Location = new System.Drawing.Point(0, 0);
            this.Panel_empresa.Name = "Panel_empresa";
            this.Panel_empresa.Size = new System.Drawing.Size(1012, 522);
            this.Panel_empresa.TabIndex = 2;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 5;
            this.guna2Elipse1.TargetControl = this;
            // 
            // FrmV_Empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 522);
            this.Controls.Add(this.Panel_empresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmV_Empresa";
            this.Text = "Empresa";
            this.Load += new System.EventHandler(this.FrmEmpresa_Load);
            this.Panel_registro.ResumeLayout(false);
            this.Panel_registro.PerformLayout();
            this.Panel_boton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            this.Panel_empresa.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_registro;
        private System.Windows.Forms.Panel Panel_boton;
        public System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel Panel_empresa;
        public Guna.UI2.WinForms.Guna2Button Btn_modificar;
        public Guna.UI2.WinForms.Guna2Button Btn_guardar;
        public Guna.UI2.WinForms.Guna2ComboBox Cboregimen;
        public Guna.UI2.WinForms.Guna2TextBox Txtfiscal;
        public Guna.UI2.WinForms.Guna2TextBox Txtdireccion;
        public Guna.UI2.WinForms.Guna2TextBox Txtnombre_comercial;
        public Guna.UI2.WinForms.Guna2TextBox Txtrazon;
        public Guna.UI2.WinForms.Guna2TextBox Txtruc;
        public System.Windows.Forms.TextBox Txt_idempresa;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}