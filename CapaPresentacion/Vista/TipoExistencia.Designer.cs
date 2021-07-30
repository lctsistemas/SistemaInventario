
namespace CapaPresentacion.Vista
{
    partial class FrmTipoExistencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTipoExistencia));
            this.Dgv_tipoExist = new System.Windows.Forms.DataGridView();
            this.dgv_txtdelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Txtbuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.Btn_excel = new Guna.UI2.WinForms.Guna2Button();
            this.btneliminar = new Guna.UI2.WinForms.Guna2Button();
            this.btneditar = new Guna.UI2.WinForms.Guna2Button();
            this.btnnuevo = new Guna.UI2.WinForms.Guna2Button();
            this.Panel_boton = new System.Windows.Forms.Panel();
            this.BtnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.Panel_operacion = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lbl_ruta = new System.Windows.Forms.Label();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_tipoExist)).BeginInit();
            this.Panel_boton.SuspendLayout();
            this.Panel_operacion.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_tipoExist
            // 
            this.Dgv_tipoExist.AllowUserToAddRows = false;
            this.Dgv_tipoExist.AllowUserToDeleteRows = false;
            this.Dgv_tipoExist.AllowUserToResizeColumns = false;
            this.Dgv_tipoExist.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.Dgv_tipoExist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_tipoExist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_tipoExist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_tipoExist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.Dgv_tipoExist.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.Dgv_tipoExist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_tipoExist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dgv_tipoExist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_tipoExist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_tipoExist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_tipoExist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_txtdelete,
            this.CODIGO,
            this.DESCRIPCION});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_tipoExist.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_tipoExist.EnableHeadersVisualStyles = false;
            this.Dgv_tipoExist.GridColor = System.Drawing.Color.Silver;
            this.Dgv_tipoExist.Location = new System.Drawing.Point(3, 80);
            this.Dgv_tipoExist.MultiSelect = false;
            this.Dgv_tipoExist.Name = "Dgv_tipoExist";
            this.Dgv_tipoExist.ReadOnly = true;
            this.Dgv_tipoExist.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Dgv_tipoExist.RowHeadersVisible = false;
            this.Dgv_tipoExist.RowHeadersWidth = 25;
            this.Dgv_tipoExist.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Dgv_tipoExist.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgv_tipoExist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_tipoExist.Size = new System.Drawing.Size(619, 400);
            this.Dgv_tipoExist.TabIndex = 9;
            this.Dgv_tipoExist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_tipoExist_CellContentClick);
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
            // CODIGO
            // 
            this.CODIGO.DataPropertyName = "Codigo";
            this.CODIGO.HeaderText = "CODIGO";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.DataPropertyName = "Descripcion";
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.ReadOnly = true;
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
            // 
            // Btn_excel
            // 
            this.Btn_excel.BorderRadius = 3;
            this.Btn_excel.CheckedState.Parent = this.Btn_excel;
            this.Btn_excel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_excel.CustomImages.Parent = this.Btn_excel;
            this.Btn_excel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_excel.FillColor = System.Drawing.Color.CadetBlue;
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
            this.btneliminar.FillColor = System.Drawing.Color.Brown;
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
            // btnnuevo
            // 
            this.btnnuevo.BorderRadius = 3;
            this.btnnuevo.CheckedState.Parent = this.btnnuevo;
            this.btnnuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnuevo.CustomImages.Parent = this.btnnuevo;
            this.btnnuevo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnnuevo.FillColor = System.Drawing.Color.DimGray;
            this.btnnuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnnuevo.ForeColor = System.Drawing.Color.White;
            this.btnnuevo.HoverState.Parent = this.btnnuevo;
            this.btnnuevo.Location = new System.Drawing.Point(0, 0);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.ShadowDecoration.Parent = this.btnnuevo;
            this.btnnuevo.Size = new System.Drawing.Size(89, 45);
            this.btnnuevo.TabIndex = 0;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // Panel_boton
            // 
            this.Panel_boton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_boton.Controls.Add(this.BtnGuardar);
            this.Panel_boton.Controls.Add(this.Btn_excel);
            this.Panel_boton.Controls.Add(this.btneliminar);
            this.Panel_boton.Controls.Add(this.btneditar);
            this.Panel_boton.Controls.Add(this.btnnuevo);
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
            this.BtnGuardar.TabIndex = 3;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.Visible = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // Panel_operacion
            // 
            this.Panel_operacion.Controls.Add(this.panel2);
            this.Panel_operacion.Controls.Add(this.Panel_boton);
            this.Panel_operacion.Controls.Add(this.btncerrar);
            this.Panel_operacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_operacion.Location = new System.Drawing.Point(0, 0);
            this.Panel_operacion.Name = "Panel_operacion";
            this.Panel_operacion.Size = new System.Drawing.Size(758, 483);
            this.Panel_operacion.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Lbl_ruta);
            this.panel2.Controls.Add(this.Dgv_tipoExist);
            this.panel2.Controls.Add(this.Txtbuscar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(635, 483);
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
            // 
            // FrmTipoExistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 483);
            this.Controls.Add(this.Panel_operacion);
            this.Name = "FrmTipoExistencia";
            this.Text = "TipoExistencia";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_tipoExist)).EndInit();
            this.Panel_boton.ResumeLayout(false);
            this.Panel_operacion.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_tipoExist;
        private Guna.UI2.WinForms.Guna2TextBox Txtbuscar;
        private Guna.UI2.WinForms.Guna2Button Btn_excel;
        private Guna.UI2.WinForms.Guna2Button btneliminar;
        private Guna.UI2.WinForms.Guna2Button btneditar;
        private Guna.UI2.WinForms.Guna2Button btnnuevo;
        private System.Windows.Forms.Panel Panel_boton;
        private System.Windows.Forms.Panel Panel_operacion;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label Lbl_ruta;
        public System.Windows.Forms.PictureBox btncerrar;
        private Guna.UI2.WinForms.Guna2Button BtnGuardar;
        private System.Windows.Forms.DataGridViewImageColumn dgv_txtdelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
    }
}