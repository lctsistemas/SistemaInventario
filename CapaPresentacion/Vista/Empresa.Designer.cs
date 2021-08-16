
namespace CapaPresentacion.Vista
{
    partial class FrmEmpresa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpresa));
            this.Panel_empresa = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Dgv_empresa = new System.Windows.Forms.DataGridView();
            this.dgv_txtdelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.Txtbuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.Panel_boton = new System.Windows.Forms.Panel();
            this.Btn_eliminar = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_guardar = new Guna.UI2.WinForms.Guna2Button();
            this.lblcerrar = new System.Windows.Forms.Label();
            this.Panel_empresa.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_empresa)).BeginInit();
            this.Panel_boton.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_empresa
            // 
            this.Panel_empresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(236)))));
            this.Panel_empresa.Controls.Add(this.lblcerrar);
            this.Panel_empresa.Controls.Add(this.panel1);
            this.Panel_empresa.Controls.Add(this.Panel_boton);
            this.Panel_empresa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_empresa.Location = new System.Drawing.Point(0, 0);
            this.Panel_empresa.Name = "Panel_empresa";
            this.Panel_empresa.Size = new System.Drawing.Size(914, 543);
            this.Panel_empresa.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(236)))));
            this.panel1.Controls.Add(this.Dgv_empresa);
            this.panel1.Controls.Add(this.Txtbuscar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 543);
            this.panel1.TabIndex = 102;
            // 
            // Dgv_empresa
            // 
            this.Dgv_empresa.AllowUserToAddRows = false;
            this.Dgv_empresa.AllowUserToDeleteRows = false;
            this.Dgv_empresa.AllowUserToResizeColumns = false;
            this.Dgv_empresa.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.Dgv_empresa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Dgv_empresa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_empresa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_empresa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.Dgv_empresa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(236)))));
            this.Dgv_empresa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_empresa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dgv_empresa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_empresa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Dgv_empresa.ColumnHeadersHeight = 30;
            this.Dgv_empresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgv_empresa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_txtdelete});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_empresa.DefaultCellStyle = dataGridViewCellStyle6;
            this.Dgv_empresa.EnableHeadersVisualStyles = false;
            this.Dgv_empresa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.Dgv_empresa.Location = new System.Drawing.Point(5, 115);
            this.Dgv_empresa.MultiSelect = false;
            this.Dgv_empresa.Name = "Dgv_empresa";
            this.Dgv_empresa.ReadOnly = true;
            this.Dgv_empresa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Dgv_empresa.RowHeadersVisible = false;
            this.Dgv_empresa.RowHeadersWidth = 25;
            this.Dgv_empresa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Dgv_empresa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Dgv_empresa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_empresa.Size = new System.Drawing.Size(786, 424);
            this.Dgv_empresa.TabIndex = 3;
            this.Dgv_empresa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_empresa_CellContentClick);
            // 
            // dgv_txtdelete
            // 
            this.dgv_txtdelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgv_txtdelete.FillWeight = 30F;
            this.dgv_txtdelete.Frozen = true;
            this.dgv_txtdelete.HeaderText = "             ";
            this.dgv_txtdelete.Image = ((System.Drawing.Image)(resources.GetObject("dgv_txtdelete.Image")));
            this.dgv_txtdelete.Name = "dgv_txtdelete";
            this.dgv_txtdelete.ReadOnly = true;
            this.dgv_txtdelete.ToolTipText = "Eliminar";
            this.dgv_txtdelete.Width = 50;
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
            this.Txtbuscar.Location = new System.Drawing.Point(13, 60);
            this.Txtbuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txtbuscar.Name = "Txtbuscar";
            this.Txtbuscar.PasswordChar = '\0';
            this.Txtbuscar.PlaceholderText = "Buscar";
            this.Txtbuscar.SelectedText = "";
            this.Txtbuscar.ShadowDecoration.Parent = this.Txtbuscar;
            this.Txtbuscar.Size = new System.Drawing.Size(578, 28);
            this.Txtbuscar.TabIndex = 2;
            this.Txtbuscar.TextChanged += new System.EventHandler(this.Txtrazon_TextChanged);
            // 
            // Panel_boton
            // 
            this.Panel_boton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_boton.Controls.Add(this.Btn_eliminar);
            this.Panel_boton.Controls.Add(this.Btn_guardar);
            this.Panel_boton.Location = new System.Drawing.Point(813, 115);
            this.Panel_boton.Name = "Panel_boton";
            this.Panel_boton.Size = new System.Drawing.Size(89, 270);
            this.Panel_boton.TabIndex = 101;
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.BorderRadius = 2;
            this.Btn_eliminar.CheckedState.Parent = this.Btn_eliminar;
            this.Btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_eliminar.CustomImages.Parent = this.Btn_eliminar;
            this.Btn_eliminar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_eliminar.FillColor = System.Drawing.Color.DarkRed;
            this.Btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Btn_eliminar.ForeColor = System.Drawing.Color.White;
            this.Btn_eliminar.HoverState.Parent = this.Btn_eliminar;
            this.Btn_eliminar.Location = new System.Drawing.Point(0, 45);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.ShadowDecoration.Parent = this.Btn_eliminar;
            this.Btn_eliminar.Size = new System.Drawing.Size(89, 45);
            this.Btn_eliminar.TabIndex = 8;
            this.Btn_eliminar.Text = "Editar";
            this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BorderRadius = 2;
            this.Btn_guardar.CheckedState.Parent = this.Btn_guardar;
            this.Btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_guardar.CustomImages.Parent = this.Btn_guardar;
            this.Btn_guardar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_guardar.FillColor = System.Drawing.Color.SteelBlue;
            this.Btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Btn_guardar.ForeColor = System.Drawing.Color.White;
            this.Btn_guardar.HoverState.Parent = this.Btn_guardar;
            this.Btn_guardar.Location = new System.Drawing.Point(0, 0);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.ShadowDecoration.Parent = this.Btn_guardar;
            this.Btn_guardar.Size = new System.Drawing.Size(89, 45);
            this.Btn_guardar.TabIndex = 7;
            this.Btn_guardar.Text = "Nuevo";
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // lblcerrar
            // 
            this.lblcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblcerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(236)))));
            this.lblcerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcerrar.ForeColor = System.Drawing.Color.Black;
            this.lblcerrar.Location = new System.Drawing.Point(877, 0);
            this.lblcerrar.Name = "lblcerrar";
            this.lblcerrar.Size = new System.Drawing.Size(35, 35);
            this.lblcerrar.TabIndex = 103;
            this.lblcerrar.Text = " X";
            this.lblcerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblcerrar.Click += new System.EventHandler(this.lblcerrar_Click);
            this.lblcerrar.MouseLeave += new System.EventHandler(this.lblcerrar_MouseLeave);
            this.lblcerrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblcerrar_MouseMove);
            // 
            // FrmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 543);
            this.Controls.Add(this.Panel_empresa);
            this.Name = "FrmEmpresa";
            this.Text = "VistaEmpresa";
            this.Panel_empresa.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_empresa)).EndInit();
            this.Panel_boton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_empresa;
        private System.Windows.Forms.Panel Panel_boton;
        private Guna.UI2.WinForms.Guna2Button Btn_eliminar;
        private Guna.UI2.WinForms.Guna2Button Btn_guardar;
        private Guna.UI2.WinForms.Guna2TextBox Txtbuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView Dgv_empresa;
        private System.Windows.Forms.DataGridViewImageColumn dgv_txtdelete;
        private System.Windows.Forms.Label lblcerrar;
    }
}