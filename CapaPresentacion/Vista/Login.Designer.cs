
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
            this.Cbo_empresa = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Btn_entrar = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_boton = new System.Windows.Forms.Panel();
            this.lblcerrar = new System.Windows.Forms.PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.panel_boton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblcerrar)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 3;
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
            this.Txt_acceso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
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
            this.Txt_acceso.Location = new System.Drawing.Point(35, 230);
            this.Txt_acceso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_acceso.Name = "Txt_acceso";
            this.Txt_acceso.PasswordChar = '\0';
            this.Txt_acceso.PlaceholderText = "INGRESE ACCESO";
            this.Txt_acceso.SelectedText = "";
            this.Txt_acceso.ShadowDecoration.Parent = this.Txt_acceso;
            this.Txt_acceso.Size = new System.Drawing.Size(387, 36);
            this.Txt_acceso.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Txt_acceso.TabIndex = 2;
            // 
            // Cbo_empresa
            // 
            this.Cbo_empresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Cbo_empresa.BackColor = System.Drawing.Color.Transparent;
            this.Cbo_empresa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cbo_empresa.DropDownHeight = 300;
            this.Cbo_empresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_empresa.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Cbo_empresa.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cbo_empresa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cbo_empresa.FocusedState.Parent = this.Cbo_empresa;
            this.Cbo_empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Cbo_empresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Cbo_empresa.HoverState.Parent = this.Cbo_empresa;
            this.Cbo_empresa.IntegralHeight = false;
            this.Cbo_empresa.ItemHeight = 30;
            this.Cbo_empresa.ItemsAppearance.Parent = this.Cbo_empresa;
            this.Cbo_empresa.Location = new System.Drawing.Point(35, 136);
            this.Cbo_empresa.Name = "Cbo_empresa";
            this.Cbo_empresa.ShadowDecoration.Parent = this.Cbo_empresa;
            this.Cbo_empresa.Size = new System.Drawing.Size(387, 36);
            this.Cbo_empresa.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Cbo_empresa.TabIndex = 1;
            // 
            // Btn_entrar
            // 
            this.Btn_entrar.BorderRadius = 5;
            this.Btn_entrar.CheckedState.Parent = this.Btn_entrar;
            this.Btn_entrar.CustomImages.Parent = this.Btn_entrar;
            this.Btn_entrar.FillColor = System.Drawing.Color.LightSkyBlue;
            this.Btn_entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_entrar.ForeColor = System.Drawing.Color.White;
            this.Btn_entrar.HoverState.Parent = this.Btn_entrar;
            this.Btn_entrar.Location = new System.Drawing.Point(114, 343);
            this.Btn_entrar.Name = "Btn_entrar";
            this.Btn_entrar.ShadowDecoration.Parent = this.Btn_entrar;
            this.Btn_entrar.Size = new System.Drawing.Size(239, 45);
            this.Btn_entrar.TabIndex = 3;
            this.Btn_entrar.Text = "ENTRAR";
            this.Btn_entrar.Click += new System.EventHandler(this.Btn_entrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(83, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 33);
            this.label3.TabIndex = 13;
            this.label3.Text = "INICIO DE SESION";
            // 
            // panel_boton
            // 
            this.panel_boton.Controls.Add(this.lblcerrar);
            this.panel_boton.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_boton.Location = new System.Drawing.Point(0, 0);
            this.panel_boton.Name = "panel_boton";
            this.panel_boton.Size = new System.Drawing.Size(450, 28);
            this.panel_boton.TabIndex = 15;
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
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.guna2Panel1.BorderRadius = 2;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.panel2);
            this.guna2Panel1.Controls.Add(this.panel1);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.BorderRadius = 3;
            this.guna2Panel1.ShadowDecoration.Depth = 5;
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(899, 511);
            this.guna2Panel1.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_boton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Cbo_empresa);
            this.panel1.Controls.Add(this.Btn_entrar);
            this.panel1.Controls.Add(this.Txt_acceso);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(449, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 511);
            this.panel1.TabIndex = 16;
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
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 512);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.panel_boton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lblcerrar)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button Btn_entrar;
        private Guna.UI2.WinForms.Guna2ComboBox Cbo_empresa;
        private Guna.UI2.WinForms.Guna2TextBox Txt_acceso;
        private System.Windows.Forms.Panel panel_boton;
        private System.Windows.Forms.PictureBox lblcerrar;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}