
namespace CapaPresentacion.Vista
{
    partial class FrmUnidadMedida
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUnidadMedida));
            this.Panel_operacion = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lbl_ruta = new System.Windows.Forms.Label();
            this.Dgv_Unidadmedida = new System.Windows.Forms.DataGridView();
            this.Txtbuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.Panel_boton = new System.Windows.Forms.Panel();
            this.BtnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_excel = new Guna.UI2.WinForms.Guna2Button();
            this.btneliminar = new Guna.UI2.WinForms.Guna2Button();
            this.btneditar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.dgv_txtdelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.UNIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_txtdes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel_operacion.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Unidadmedida)).BeginInit();
            this.Panel_boton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_operacion
            // 
            this.Panel_operacion.Controls.Add(this.panel2);
            this.Panel_operacion.Controls.Add(this.Panel_boton);
            this.Panel_operacion.Controls.Add(this.btncerrar);
            this.Panel_operacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_operacion.Location = new System.Drawing.Point(0, 0);
            this.Panel_operacion.Name = "Panel_operacion";
            this.Panel_operacion.Size = new System.Drawing.Size(758, 475);
            this.Panel_operacion.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Lbl_ruta);
            this.panel2.Controls.Add(this.Dgv_Unidadmedida);
            this.panel2.Controls.Add(this.Txtbuscar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(635, 475);
            this.panel2.TabIndex = 108;
            // 
            // Lbl_ruta
            // 
            this.Lbl_ruta.AutoSize = true;
            this.Lbl_ruta.Location = new System.Drawing.Point(22, 60);
            this.Lbl_ruta.Name = "Lbl_ruta";
            this.Lbl_ruta.Size = new System.Drawing.Size(35, 13);
            this.Lbl_ruta.TabIndex = 109;
            this.Lbl_ruta.Text = "label1";
            this.Lbl_ruta.Visible = false;
            // 
            // Dgv_Unidadmedida
            // 
            this.Dgv_Unidadmedida.AllowUserToAddRows = false;
            this.Dgv_Unidadmedida.AllowUserToDeleteRows = false;
            this.Dgv_Unidadmedida.AllowUserToResizeColumns = false;
            this.Dgv_Unidadmedida.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.Dgv_Unidadmedida.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Unidadmedida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Unidadmedida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Unidadmedida.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.Dgv_Unidadmedida.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.Dgv_Unidadmedida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_Unidadmedida.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dgv_Unidadmedida.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Unidadmedida.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_Unidadmedida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Unidadmedida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_txtdelete,
            this.UNIDAD,
            this.txtcod,
            this.dgv_txtdes});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Unidadmedida.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_Unidadmedida.EnableHeadersVisualStyles = false;
            this.Dgv_Unidadmedida.GridColor = System.Drawing.Color.Silver;
            this.Dgv_Unidadmedida.Location = new System.Drawing.Point(3, 76);
            this.Dgv_Unidadmedida.MultiSelect = false;
            this.Dgv_Unidadmedida.Name = "Dgv_Unidadmedida";
            this.Dgv_Unidadmedida.ReadOnly = true;
            this.Dgv_Unidadmedida.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Dgv_Unidadmedida.RowHeadersVisible = false;
            this.Dgv_Unidadmedida.RowHeadersWidth = 25;
            this.Dgv_Unidadmedida.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Dgv_Unidadmedida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Unidadmedida.Size = new System.Drawing.Size(619, 399);
            this.Dgv_Unidadmedida.TabIndex = 9;
            this.Dgv_Unidadmedida.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Unidadmedida_CellContentClick);
            // 
            // Txtbuscar
            // 
            this.Txtbuscar.Animated = true;
            this.Txtbuscar.BorderColor = System.Drawing.Color.Silver;
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
            this.Txtbuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Txtbuscar.ForeColor = System.Drawing.Color.Black;
            this.Txtbuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txtbuscar.HoverState.Parent = this.Txtbuscar;
            this.Txtbuscar.Location = new System.Drawing.Point(12, 20);
            this.Txtbuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txtbuscar.Name = "Txtbuscar";
            this.Txtbuscar.PasswordChar = '\0';
            this.Txtbuscar.PlaceholderText = "Buscar";
            this.Txtbuscar.SelectedText = "";
            this.Txtbuscar.ShadowDecoration.Parent = this.Txtbuscar;
            this.Txtbuscar.Size = new System.Drawing.Size(578, 28);
            this.Txtbuscar.TabIndex = 8;
            this.Txtbuscar.TextChanged += new System.EventHandler(this.Txtbuscar_TextChanged);
            // 
            // Panel_boton
            // 
            this.Panel_boton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_boton.Controls.Add(this.BtnGuardar);
            this.Panel_boton.Controls.Add(this.Btn_excel);
            this.Panel_boton.Controls.Add(this.btneliminar);
            this.Panel_boton.Controls.Add(this.btneditar);
            this.Panel_boton.Controls.Add(this.guna2Button1);
            this.Panel_boton.Location = new System.Drawing.Point(668, 115);
            this.Panel_boton.Name = "Panel_boton";
            this.Panel_boton.Size = new System.Drawing.Size(89, 270);
            this.Panel_boton.TabIndex = 107;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.BtnGuardar.BorderRadius = 3;
            this.BtnGuardar.CheckedState.Parent = this.BtnGuardar;
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.CustomImages.Parent = this.BtnGuardar;
            this.BtnGuardar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnGuardar.FillColor = System.Drawing.Color.Green;
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.HoverState.Parent = this.BtnGuardar;
            this.BtnGuardar.Location = new System.Drawing.Point(0, 180);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.ShadowDecoration.Parent = this.BtnGuardar;
            this.BtnGuardar.Size = new System.Drawing.Size(89, 45);
            this.BtnGuardar.TabIndex = 2;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.Visible = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // Btn_excel
            // 
            this.Btn_excel.BorderRadius = 3;
            this.Btn_excel.CheckedState.Parent = this.Btn_excel;
            this.Btn_excel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_excel.CustomImages.Parent = this.Btn_excel;
            this.Btn_excel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_excel.FillColor = System.Drawing.Color.IndianRed;
            this.Btn_excel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Btn_excel.ForeColor = System.Drawing.Color.White;
            this.Btn_excel.HoverState.Parent = this.Btn_excel;
            this.Btn_excel.Location = new System.Drawing.Point(0, 135);
            this.Btn_excel.Name = "Btn_excel";
            this.Btn_excel.ShadowDecoration.Parent = this.Btn_excel;
            this.Btn_excel.Size = new System.Drawing.Size(89, 45);
            this.Btn_excel.TabIndex = 1;
            this.Btn_excel.Text = "Importar Excel";
            this.Btn_excel.Click += new System.EventHandler(this.Btn_excel_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BorderRadius = 3;
            this.btneliminar.CheckedState.Parent = this.btneliminar;
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.CustomImages.Parent = this.btneliminar;
            this.btneliminar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btneliminar.FillColor = System.Drawing.Color.LightBlue;
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btneliminar.ForeColor = System.Drawing.Color.White;
            this.btneliminar.HoverState.Parent = this.btneliminar;
            this.btneliminar.Location = new System.Drawing.Point(0, 90);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.ShadowDecoration.Parent = this.btneliminar;
            this.btneliminar.Size = new System.Drawing.Size(89, 45);
            this.btneliminar.TabIndex = 0;
            this.btneliminar.Text = "Eliminar";
            // 
            // btneditar
            // 
            this.btneditar.BorderRadius = 3;
            this.btneditar.CheckedState.Parent = this.btneditar;
            this.btneditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneditar.CustomImages.Parent = this.btneditar;
            this.btneditar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btneditar.FillColor = System.Drawing.Color.DarkGray;
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
            this.guna2Button1.FillColor = System.Drawing.Color.DimGray;
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
            this.btncerrar.Location = new System.Drawing.Point(722, 0);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(35, 35);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btncerrar.TabIndex = 106;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // dgv_txtdelete
            // 
            this.dgv_txtdelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgv_txtdelete.FillWeight = 40F;
            this.dgv_txtdelete.Frozen = true;
            this.dgv_txtdelete.HeaderText = "             ";
            this.dgv_txtdelete.Image = ((System.Drawing.Image)(resources.GetObject("dgv_txtdelete.Image")));
            this.dgv_txtdelete.Name = "dgv_txtdelete";
            this.dgv_txtdelete.ReadOnly = true;
            this.dgv_txtdelete.ToolTipText = "Eliminar";
            this.dgv_txtdelete.Width = 63;
            // 
            // UNIDAD
            // 
            this.UNIDAD.DataPropertyName = "IdUnidadMedida";
            this.UNIDAD.HeaderText = "ID";
            this.UNIDAD.Name = "UNIDAD";
            this.UNIDAD.ReadOnly = true;
            this.UNIDAD.Visible = false;
            // 
            // txtcod
            // 
            this.txtcod.DataPropertyName = "Abrev";
            this.txtcod.HeaderText = "ABREVIATURA";
            this.txtcod.Name = "txtcod";
            this.txtcod.ReadOnly = true;
            // 
            // dgv_txtdes
            // 
            this.dgv_txtdes.DataPropertyName = "Descripcion";
            this.dgv_txtdes.HeaderText = "DESCRIPCION";
            this.dgv_txtdes.Name = "dgv_txtdes";
            this.dgv_txtdes.ReadOnly = true;
            // 
            // FrmUnidadMedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 475);
            this.Controls.Add(this.Panel_operacion);
            this.Name = "FrmUnidadMedida";
            this.Text = "UnidadMedida";
            this.Panel_operacion.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Unidadmedida)).EndInit();
            this.Panel_boton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_operacion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Lbl_ruta;
        private System.Windows.Forms.DataGridView Dgv_Unidadmedida;
        private Guna.UI2.WinForms.Guna2TextBox Txtbuscar;
        private System.Windows.Forms.Panel Panel_boton;
        private Guna.UI2.WinForms.Guna2Button Btn_excel;
        private Guna.UI2.WinForms.Guna2Button btneliminar;
        private Guna.UI2.WinForms.Guna2Button btneditar;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        public System.Windows.Forms.PictureBox btncerrar;
        private Guna.UI2.WinForms.Guna2Button BtnGuardar;
        private System.Windows.Forms.DataGridViewImageColumn dgv_txtdelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtcod;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_txtdes;
    }
}