
namespace CapaPresentacion.Vista
{
    partial class FrmMoneda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMoneda));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Panel_boton = new System.Windows.Forms.Panel();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.btneditar = new Guna.UI2.WinForms.Guna2Button();
            this.btnnuevo = new Guna.UI2.WinForms.Guna2Button();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.Dgv_moneda = new System.Windows.Forms.DataGridView();
            this.dgv_txtdelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.Txtbuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Panel_boton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_moneda)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Panel_boton);
            this.panel1.Controls.Add(this.btncerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 522);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Dgv_moneda);
            this.panel2.Controls.Add(this.Txtbuscar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(688, 522);
            this.panel2.TabIndex = 114;
            // 
            // Panel_boton
            // 
            this.Panel_boton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_boton.Controls.Add(this.guna2Button4);
            this.Panel_boton.Controls.Add(this.guna2Button3);
            this.Panel_boton.Controls.Add(this.btneditar);
            this.Panel_boton.Controls.Add(this.btnnuevo);
            this.Panel_boton.Location = new System.Drawing.Point(736, 115);
            this.Panel_boton.Name = "Panel_boton";
            this.Panel_boton.Size = new System.Drawing.Size(89, 270);
            this.Panel_boton.TabIndex = 113;
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
            // guna2Button3
            // 
            this.guna2Button3.BorderRadius = 3;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Button3.FillColor = System.Drawing.Color.LightBlue;
            this.guna2Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Location = new System.Drawing.Point(0, 90);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(89, 45);
            this.guna2Button3.TabIndex = 0;
            this.guna2Button3.Text = "Eliminar";
            // 
            // btneditar
            // 
            this.btneditar.BorderRadius = 3;
            this.btneditar.CheckedState.Parent = this.btneditar;
            this.btneditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneditar.CustomImages.Parent = this.btneditar;
            this.btneditar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btneditar.FillColor = System.Drawing.Color.Peru;
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
            this.btnnuevo.FillColor = System.Drawing.Color.Olive;
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
            // btncerrar
            // 
            this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(791, 0);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(35, 35);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btncerrar.TabIndex = 112;
            this.btncerrar.TabStop = false;
            // 
            // Dgv_moneda
            // 
            this.Dgv_moneda.AllowUserToAddRows = false;
            this.Dgv_moneda.AllowUserToDeleteRows = false;
            this.Dgv_moneda.AllowUserToResizeColumns = false;
            this.Dgv_moneda.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.Dgv_moneda.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Dgv_moneda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_moneda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_moneda.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.Dgv_moneda.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.Dgv_moneda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_moneda.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dgv_moneda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_moneda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Dgv_moneda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_moneda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_txtdelete});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_moneda.DefaultCellStyle = dataGridViewCellStyle6;
            this.Dgv_moneda.EnableHeadersVisualStyles = false;
            this.Dgv_moneda.GridColor = System.Drawing.Color.Silver;
            this.Dgv_moneda.Location = new System.Drawing.Point(3, 56);
            this.Dgv_moneda.MultiSelect = false;
            this.Dgv_moneda.Name = "Dgv_moneda";
            this.Dgv_moneda.ReadOnly = true;
            this.Dgv_moneda.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Dgv_moneda.RowHeadersVisible = false;
            this.Dgv_moneda.RowHeadersWidth = 25;
            this.Dgv_moneda.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Dgv_moneda.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Dgv_moneda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_moneda.Size = new System.Drawing.Size(666, 454);
            this.Dgv_moneda.TabIndex = 5;
            this.Dgv_moneda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_moneda_CellContentClick);
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
            this.Txtbuscar.TabIndex = 4;
            this.Txtbuscar.TextChanged += new System.EventHandler(this.Txtbuscar_TextChanged);
            // 
            // FrmMoneda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 522);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMoneda";
            this.Text = "Moneda";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.Panel_boton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_moneda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Panel_boton;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button btneditar;
        private Guna.UI2.WinForms.Guna2Button btnnuevo;
        public System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.DataGridView Dgv_moneda;
        private System.Windows.Forms.DataGridViewImageColumn dgv_txtdelete;
        private Guna.UI2.WinForms.Guna2TextBox Txtbuscar;
    }
}