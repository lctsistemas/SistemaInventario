﻿
namespace CapaPresentacion.SubVista
{
    partial class Frm_VTipoOper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_VTipoOper));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnguardar = new Guna.UI2.WinForms.Guna2Button();
            this.txtDesc = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtcodOper = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 289);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(664, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 102;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnguardar);
            this.panel2.Controls.Add(this.txtDesc);
            this.panel2.Controls.Add(this.txtcodOper);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(35, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(629, 235);
            this.panel2.TabIndex = 0;
            // 
            // btnguardar
            // 
            this.btnguardar.BorderRadius = 3;
            this.btnguardar.CheckedState.Parent = this.btnguardar;
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.CustomImages.Parent = this.btnguardar;
            this.btnguardar.FillColor = System.Drawing.Color.CadetBlue;
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.HoverState.Parent = this.btnguardar;
            this.btnguardar.Location = new System.Drawing.Point(264, 178);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.ShadowDecoration.Parent = this.btnguardar;
            this.btnguardar.Size = new System.Drawing.Size(89, 45);
            this.btnguardar.TabIndex = 27;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.AutoScroll = true;
            this.txtDesc.BorderRadius = 3;
            this.txtDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDesc.DefaultText = "";
            this.txtDesc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDesc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDesc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDesc.DisabledState.Parent = this.txtDesc;
            this.txtDesc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDesc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDesc.FocusedState.Parent = this.txtDesc;
            this.txtDesc.ForeColor = System.Drawing.Color.Black;
            this.txtDesc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDesc.HoverState.Parent = this.txtDesc;
            this.txtDesc.Location = new System.Drawing.Point(276, 102);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.PasswordChar = '\0';
            this.txtDesc.PlaceholderText = "";
            this.txtDesc.SelectedText = "";
            this.txtDesc.ShadowDecoration.Parent = this.txtDesc;
            this.txtDesc.Size = new System.Drawing.Size(302, 57);
            this.txtDesc.TabIndex = 26;
            // 
            // txtcodOper
            // 
            this.txtcodOper.BorderRadius = 3;
            this.txtcodOper.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcodOper.DefaultText = "";
            this.txtcodOper.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcodOper.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcodOper.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcodOper.DisabledState.Parent = this.txtcodOper;
            this.txtcodOper.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcodOper.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcodOper.FocusedState.Parent = this.txtcodOper;
            this.txtcodOper.ForeColor = System.Drawing.Color.Black;
            this.txtcodOper.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcodOper.HoverState.Parent = this.txtcodOper;
            this.txtcodOper.Location = new System.Drawing.Point(276, 51);
            this.txtcodOper.Name = "txtcodOper";
            this.txtcodOper.PasswordChar = '\0';
            this.txtcodOper.PlaceholderText = "Ingrese codigo de operacion";
            this.txtcodOper.SelectedText = "";
            this.txtcodOper.ShadowDecoration.Parent = this.txtcodOper;
            this.txtcodOper.Size = new System.Drawing.Size(191, 28);
            this.txtcodOper.TabIndex = 25;
            this.txtcodOper.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(206, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "TIPO DE OPERACION";
            // 
            // Frm_VTipoOper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 289);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_VTipoOper";
            this.Text = "V_TipoOperacion";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2TextBox txtcodOper;
        public Guna.UI2.WinForms.Guna2TextBox txtDesc;
        private Guna.UI2.WinForms.Guna2Button btnguardar;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}