
namespace CapaPresentacion.Vista
{
    partial class FrmTipoOperacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTipoOperacion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel_operacion = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Dgv_tipoOper = new System.Windows.Forms.DataGridView();
            this.txtbuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.Panel_boton = new System.Windows.Forms.Panel();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.btneliminar = new Guna.UI2.WinForms.Guna2Button();
            this.btneditar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.dgv_txtdelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.Panel_operacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_tipoOper)).BeginInit();
            this.Panel_boton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_operacion
            // 
            this.Panel_operacion.Controls.Add(this.pictureBox1);
            this.Panel_operacion.Controls.Add(this.panel2);
            this.Panel_operacion.Controls.Add(this.Panel_boton);
            this.Panel_operacion.Controls.Add(this.btncerrar);
            this.Panel_operacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_operacion.Location = new System.Drawing.Point(0, 0);
            this.Panel_operacion.Name = "Panel_operacion";
            this.Panel_operacion.Size = new System.Drawing.Size(758, 508);
            this.Panel_operacion.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(641, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 21);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Dgv_tipoOper);
            this.panel2.Controls.Add(this.txtbuscar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(635, 508);
            this.panel2.TabIndex = 108;
            // 
            // Dgv_tipoOper
            // 
            this.Dgv_tipoOper.AllowUserToAddRows = false;
            this.Dgv_tipoOper.AllowUserToDeleteRows = false;
            this.Dgv_tipoOper.AllowUserToResizeColumns = false;
            this.Dgv_tipoOper.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Dgv_tipoOper.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_tipoOper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_tipoOper.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_tipoOper.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.Dgv_tipoOper.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Dgv_tipoOper.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_tipoOper.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dgv_tipoOper.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_tipoOper.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_tipoOper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_tipoOper.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_txtdelete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_tipoOper.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_tipoOper.EnableHeadersVisualStyles = false;
            this.Dgv_tipoOper.GridColor = System.Drawing.Color.Silver;
            this.Dgv_tipoOper.Location = new System.Drawing.Point(6, 94);
            this.Dgv_tipoOper.Name = "Dgv_tipoOper";
            this.Dgv_tipoOper.ReadOnly = true;
            this.Dgv_tipoOper.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Dgv_tipoOper.RowHeadersWidth = 25;
            this.Dgv_tipoOper.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Dgv_tipoOper.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Dgv_tipoOper.Size = new System.Drawing.Size(629, 411);
            this.Dgv_tipoOper.TabIndex = 4;
            this.Dgv_tipoOper.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_tipoOper_CellContentClick);
            // 
            // txtbuscar
            // 
            this.txtbuscar.BorderRadius = 3;
            this.txtbuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbuscar.DefaultText = "";
            this.txtbuscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbuscar.DisabledState.Parent = this.txtbuscar;
            this.txtbuscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbuscar.FocusedState.Parent = this.txtbuscar;
            this.txtbuscar.ForeColor = System.Drawing.Color.Black;
            this.txtbuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbuscar.HoverState.Parent = this.txtbuscar;
            this.txtbuscar.Location = new System.Drawing.Point(12, 43);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.PasswordChar = '\0';
            this.txtbuscar.PlaceholderText = "Buscar";
            this.txtbuscar.SelectedText = "";
            this.txtbuscar.ShadowDecoration.Parent = this.txtbuscar;
            this.txtbuscar.Size = new System.Drawing.Size(606, 28);
            this.txtbuscar.TabIndex = 1;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // Panel_boton
            // 
            this.Panel_boton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_boton.Controls.Add(this.guna2Button4);
            this.Panel_boton.Controls.Add(this.btneliminar);
            this.Panel_boton.Controls.Add(this.btneditar);
            this.Panel_boton.Controls.Add(this.guna2Button1);
            this.Panel_boton.Location = new System.Drawing.Point(668, 115);
            this.Panel_boton.Name = "Panel_boton";
            this.Panel_boton.Size = new System.Drawing.Size(89, 270);
            this.Panel_boton.TabIndex = 107;
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
            this.btneliminar.FillColor = System.Drawing.Color.LightGray;
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
            this.dgv_txtdelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_txtdelete.FillWeight = 40F;
            this.dgv_txtdelete.Frozen = true;
            this.dgv_txtdelete.HeaderText = "                        ";
            this.dgv_txtdelete.Image = ((System.Drawing.Image)(resources.GetObject("dgv_txtdelete.Image")));
            this.dgv_txtdelete.Name = "dgv_txtdelete";
            this.dgv_txtdelete.ReadOnly = true;
            this.dgv_txtdelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_txtdelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgv_txtdelete.ToolTipText = "Eliminar";
            this.dgv_txtdelete.Width = 79;
            // 
            // FrmTipoOperacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 508);
            this.Controls.Add(this.Panel_operacion);
            this.Name = "FrmTipoOperacion";
            this.Text = "TipoOperacion";
            this.Panel_operacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_tipoOper)).EndInit();
            this.Panel_boton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_operacion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtbuscar;
        private System.Windows.Forms.Panel Panel_boton;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button btneliminar;
        private Guna.UI2.WinForms.Guna2Button btneditar;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        public System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.DataGridView Dgv_tipoOper;
        private System.Windows.Forms.DataGridViewImageColumn dgv_txtdelete;
    }
}