﻿
namespace CapaPresentacion.Vista
{
    partial class FrmClientePro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientePro));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Panel_boton = new System.Windows.Forms.Panel();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.btneliminar = new Guna.UI2.WinForms.Guna2Button();
            this.btneditar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Txtbuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.Dgv_cliente = new System.Windows.Forms.DataGridView();
            this.beliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.Panel_boton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.Panel_boton);
            this.panel1.Controls.Add(this.btncerrar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 491);
            this.panel1.TabIndex = 1;
            // 
            // Panel_boton
            // 
            this.Panel_boton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_boton.Controls.Add(this.guna2Button4);
            this.Panel_boton.Controls.Add(this.btneliminar);
            this.Panel_boton.Controls.Add(this.btneditar);
            this.Panel_boton.Controls.Add(this.guna2Button1);
            this.Panel_boton.Location = new System.Drawing.Point(710, 115);
            this.Panel_boton.Name = "Panel_boton";
            this.Panel_boton.Size = new System.Drawing.Size(89, 270);
            this.Panel_boton.TabIndex = 103;
            // 
            // guna2Button4
            // 
            this.guna2Button4.BorderRadius = 3;
            this.guna2Button4.CheckedState.Parent = this.guna2Button4;
            this.guna2Button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button4.CustomImages.Parent = this.guna2Button4;
            this.guna2Button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Button4.FillColor = System.Drawing.Color.CadetBlue;
            this.guna2Button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.HoverState.Parent = this.guna2Button4;
            this.guna2Button4.Location = new System.Drawing.Point(0, 135);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
            this.guna2Button4.Size = new System.Drawing.Size(89, 45);
            this.guna2Button4.TabIndex = 1;
            this.guna2Button4.Text = "Otros";
            // 
            // btneliminar
            // 
            this.btneliminar.BorderRadius = 3;
            this.btneliminar.CheckedState.Parent = this.btneliminar;
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.CustomImages.Parent = this.btneliminar;
            this.btneliminar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btneliminar.FillColor = System.Drawing.Color.DarkKhaki;
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btneliminar.ForeColor = System.Drawing.Color.White;
            this.btneliminar.HoverState.Parent = this.btneliminar;
            this.btneliminar.Location = new System.Drawing.Point(0, 90);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.ShadowDecoration.Parent = this.btneliminar;
            this.btneliminar.Size = new System.Drawing.Size(89, 45);
            this.btneliminar.TabIndex = 0;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btneditar
            // 
            this.btneditar.BorderRadius = 3;
            this.btneditar.CheckedState.Parent = this.btneditar;
            this.btneditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneditar.CustomImages.Parent = this.btneditar;
            this.btneditar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btneditar.FillColor = System.Drawing.Color.Tomato;
            this.btneditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btneditar.ForeColor = System.Drawing.Color.White;
            this.btneditar.HoverState.Parent = this.btneditar;
            this.btneditar.Location = new System.Drawing.Point(0, 45);
            this.btneditar.Name = "btneditar";
            this.btneditar.ShadowDecoration.Parent = this.btneditar;
            this.btneditar.Size = new System.Drawing.Size(89, 45);
            this.btneditar.TabIndex = 0;
            this.btneditar.Text = "Editar";
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 3;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(0, 0);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(89, 45);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "Nuevo";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(764, 0);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(35, 35);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btncerrar.TabIndex = 102;
            this.btncerrar.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Txtbuscar);
            this.panel2.Controls.Add(this.Dgv_cliente);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(635, 491);
            this.panel2.TabIndex = 1;
            // 
            // Txtbuscar
            // 
            this.Txtbuscar.BorderRadius = 3;
            this.Txtbuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txtbuscar.DefaultText = "";
            this.Txtbuscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txtbuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txtbuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txtbuscar.DisabledState.Parent = this.Txtbuscar;
            this.Txtbuscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txtbuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txtbuscar.FocusedState.Parent = this.Txtbuscar;
            this.Txtbuscar.ForeColor = System.Drawing.Color.Black;
            this.Txtbuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txtbuscar.HoverState.Parent = this.Txtbuscar;
            this.Txtbuscar.Location = new System.Drawing.Point(12, 43);
            this.Txtbuscar.Name = "Txtbuscar";
            this.Txtbuscar.PasswordChar = '\0';
            this.Txtbuscar.PlaceholderText = "Buscar";
            this.Txtbuscar.SelectedText = "";
            this.Txtbuscar.ShadowDecoration.Parent = this.Txtbuscar;
            this.Txtbuscar.Size = new System.Drawing.Size(606, 28);
            this.Txtbuscar.TabIndex = 1;
            this.Txtbuscar.TextChanged += new System.EventHandler(this.Txtbuscar_TextChanged);
            // 
            // Dgv_cliente
            // 
            this.Dgv_cliente.AllowUserToAddRows = false;
            this.Dgv_cliente.AllowUserToDeleteRows = false;
            this.Dgv_cliente.AllowUserToResizeColumns = false;
            this.Dgv_cliente.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Dgv_cliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_cliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_cliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_cliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.Dgv_cliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Dgv_cliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_cliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dgv_cliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_cliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_cliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.beliminar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_cliente.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_cliente.EnableHeadersVisualStyles = false;
            this.Dgv_cliente.GridColor = System.Drawing.Color.Silver;
            this.Dgv_cliente.Location = new System.Drawing.Point(3, 77);
            this.Dgv_cliente.Name = "Dgv_cliente";
            this.Dgv_cliente.ReadOnly = true;
            this.Dgv_cliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Dgv_cliente.RowHeadersWidth = 25;
            this.Dgv_cliente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Dgv_cliente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Dgv_cliente.Size = new System.Drawing.Size(629, 411);
            this.Dgv_cliente.TabIndex = 3;
            // 
            // beliminar
            // 
            this.beliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.beliminar.FillWeight = 40F;
            this.beliminar.Frozen = true;
            this.beliminar.HeaderText = "";
            this.beliminar.Image = ((System.Drawing.Image)(resources.GetObject("beliminar.Image")));
            this.beliminar.Name = "beliminar";
            this.beliminar.ReadOnly = true;
            this.beliminar.Width = 5;
            // 
            // FrmClientePro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.panel1);
            this.Name = "FrmClientePro";
            this.Text = "ClientePro";
            this.panel1.ResumeLayout(false);
            this.Panel_boton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_cliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Panel_boton;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button btneliminar;
        private Guna.UI2.WinForms.Guna2Button btneditar;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        public System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox Txtbuscar;
        private System.Windows.Forms.DataGridView Dgv_cliente;
        private System.Windows.Forms.DataGridViewImageColumn beliminar;
    }
}