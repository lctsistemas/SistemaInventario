
namespace CapaPresentacion.SubVista
{
    partial class FrmVTipo_Doc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVTipo_Doc));
            this.panelregistro = new System.Windows.Forms.Panel();
            this.txtidTipoDoc = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnmodificar = new Guna.UI2.WinForms.Guna2Button();
            this.btnguardar = new Guna.UI2.WinForms.Guna2Button();
            this.txtDescDoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtcodDoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelregistro.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelregistro
            // 
            this.panelregistro.BackColor = System.Drawing.Color.White;
            this.panelregistro.Controls.Add(this.txtidTipoDoc);
            this.panelregistro.Controls.Add(this.panel1);
            this.panelregistro.Controls.Add(this.txtDescDoc);
            this.panelregistro.Controls.Add(this.txtcodDoc);
            this.panelregistro.Controls.Add(this.label2);
            this.panelregistro.Controls.Add(this.label10);
            this.panelregistro.Controls.Add(this.label1);
            this.panelregistro.Location = new System.Drawing.Point(35, 27);
            this.panelregistro.Name = "panelregistro";
            this.panelregistro.Size = new System.Drawing.Size(629, 235);
            this.panelregistro.TabIndex = 1;
            // 
            // txtidTipoDoc
            // 
            this.txtidTipoDoc.Location = new System.Drawing.Point(114, 18);
            this.txtidTipoDoc.Name = "txtidTipoDoc";
            this.txtidTipoDoc.Size = new System.Drawing.Size(57, 20);
            this.txtidTipoDoc.TabIndex = 107;
            this.txtidTipoDoc.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnmodificar);
            this.panel1.Controls.Add(this.btnguardar);
            this.panel1.Location = new System.Drawing.Point(211, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 52);
            this.panel1.TabIndex = 28;
            // 
            // btnmodificar
            // 
            this.btnmodificar.BorderRadius = 3;
            this.btnmodificar.CheckedState.Parent = this.btnmodificar;
            this.btnmodificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmodificar.CustomImages.Parent = this.btnmodificar;
            this.btnmodificar.FillColor = System.Drawing.Color.Tomato;
            this.btnmodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnmodificar.ForeColor = System.Drawing.Color.White;
            this.btnmodificar.HoverState.Parent = this.btnmodificar;
            this.btnmodificar.Location = new System.Drawing.Point(57, 4);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.ShadowDecoration.Parent = this.btnmodificar;
            this.btnmodificar.Size = new System.Drawing.Size(89, 45);
            this.btnmodificar.TabIndex = 29;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.BorderRadius = 3;
            this.btnguardar.CheckedState.Parent = this.btnguardar;
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.CustomImages.Parent = this.btnguardar;
            this.btnguardar.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.HoverState.Parent = this.btnguardar;
            this.btnguardar.Location = new System.Drawing.Point(57, 3);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.ShadowDecoration.Parent = this.btnguardar;
            this.btnguardar.Size = new System.Drawing.Size(89, 45);
            this.btnguardar.TabIndex = 27;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtDescDoc
            // 
            this.txtDescDoc.AutoScroll = true;
            this.txtDescDoc.BorderRadius = 3;
            this.txtDescDoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescDoc.DefaultText = "";
            this.txtDescDoc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescDoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescDoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescDoc.DisabledState.Parent = this.txtDescDoc;
            this.txtDescDoc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescDoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescDoc.FocusedState.Parent = this.txtDescDoc;
            this.txtDescDoc.ForeColor = System.Drawing.Color.Black;
            this.txtDescDoc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescDoc.HoverState.Parent = this.txtDescDoc;
            this.txtDescDoc.Location = new System.Drawing.Point(276, 102);
            this.txtDescDoc.Name = "txtDescDoc";
            this.txtDescDoc.PasswordChar = '\0';
            this.txtDescDoc.PlaceholderText = "";
            this.txtDescDoc.SelectedText = "";
            this.txtDescDoc.ShadowDecoration.Parent = this.txtDescDoc;
            this.txtDescDoc.Size = new System.Drawing.Size(302, 57);
            this.txtDescDoc.TabIndex = 26;
            // 
            // txtcodDoc
            // 
            this.txtcodDoc.BorderRadius = 3;
            this.txtcodDoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcodDoc.DefaultText = "";
            this.txtcodDoc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcodDoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcodDoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcodDoc.DisabledState.Parent = this.txtcodDoc;
            this.txtcodDoc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcodDoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcodDoc.FocusedState.Parent = this.txtcodDoc;
            this.txtcodDoc.ForeColor = System.Drawing.Color.Black;
            this.txtcodDoc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcodDoc.HoverState.Parent = this.txtcodDoc;
            this.txtcodDoc.Location = new System.Drawing.Point(276, 51);
            this.txtcodDoc.Name = "txtcodDoc";
            this.txtcodDoc.PasswordChar = '\0';
            this.txtcodDoc.PlaceholderText = "Codigo";
            this.txtcodDoc.SelectedText = "";
            this.txtcodDoc.ShadowDecoration.Parent = this.txtcodDoc;
            this.txtcodDoc.Size = new System.Drawing.Size(71, 28);
            this.txtcodDoc.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(111, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Descripcion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(111, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Codigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(206, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "TIPO DE DOCUMENTO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(665, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 103;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmVTipo_Doc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 289);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelregistro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVTipo_Doc";
            this.Text = "VTipo_Documento";
            this.panelregistro.ResumeLayout(false);
            this.panelregistro.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelregistro;
        public Guna.UI2.WinForms.Guna2TextBox txtDescDoc;
        public Guna.UI2.WinForms.Guna2TextBox txtcodDoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtidTipoDoc;
        public Guna.UI2.WinForms.Guna2Button btnguardar;
        public Guna.UI2.WinForms.Guna2Button btnmodificar;
    }
}