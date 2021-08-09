
namespace CapaPresentacion.Vista
{
    partial class FrmMantenimiento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMantenimiento));
            this.Panel_content = new Guna.UI2.WinForms.Guna2Panel();
            this.Panel_entradaT = new Guna.UI2.WinForms.Guna2Panel();
            this.Lbl_cantiEntrada = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel_salidaT = new Guna.UI2.WinForms.Guna2Panel();
            this.Lbl_cantiSalida = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.Txt_totalStock = new Guna.UI2.WinForms.Guna2TextBox();
            this.Txt_totalSalida = new Guna.UI2.WinForms.Guna2TextBox();
            this.Txt_cantidad = new Guna.UI2.WinForms.Guna2TextBox();
            this.Txt_Total_entrada = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Btn_buscar = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Cbomes = new System.Windows.Forms.ComboBox();
            this.Dgv_grupo_ = new System.Windows.Forms.DataGridView();
            this.invgrupo_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invgrupo_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invgrupo_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invgrupo_4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invgrupo_5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invgrupo_6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dgv_btndetalle = new System.Windows.Forms.DataGridViewImageColumn();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.Panel_content.SuspendLayout();
            this.Panel_entradaT.SuspendLayout();
            this.Panel_salidaT.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_grupo_)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_content
            // 
            this.Panel_content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.Panel_content.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.Panel_content.BorderThickness = 1;
            this.Panel_content.Controls.Add(this.Panel_entradaT);
            this.Panel_content.Controls.Add(this.Panel_salidaT);
            this.Panel_content.Controls.Add(this.guna2Panel2);
            this.Panel_content.Controls.Add(this.guna2Panel1);
            this.Panel_content.Controls.Add(this.Dgv_grupo_);
            this.Panel_content.Controls.Add(this.shapeContainer1);
            this.Panel_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_content.Location = new System.Drawing.Point(0, 0);
            this.Panel_content.Name = "Panel_content";
            this.Panel_content.ShadowDecoration.Parent = this.Panel_content;
            this.Panel_content.Size = new System.Drawing.Size(1033, 517);
            this.Panel_content.TabIndex = 0;
            // 
            // Panel_entradaT
            // 
            this.Panel_entradaT.BorderColor = System.Drawing.Color.LightGray;
            this.Panel_entradaT.BorderRadius = 2;
            this.Panel_entradaT.BorderThickness = 1;
            this.Panel_entradaT.Controls.Add(this.Lbl_cantiEntrada);
            this.Panel_entradaT.Controls.Add(this.label1);
            this.Panel_entradaT.FillColor = System.Drawing.Color.WhiteSmoke;
            this.Panel_entradaT.Location = new System.Drawing.Point(472, 12);
            this.Panel_entradaT.Name = "Panel_entradaT";
            this.Panel_entradaT.ShadowDecoration.Parent = this.Panel_entradaT;
            this.Panel_entradaT.Size = new System.Drawing.Size(120, 63);
            this.Panel_entradaT.TabIndex = 20;
            // 
            // Lbl_cantiEntrada
            // 
            this.Lbl_cantiEntrada.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Lbl_cantiEntrada.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_cantiEntrada.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Lbl_cantiEntrada.Location = new System.Drawing.Point(12, 44);
            this.Lbl_cantiEntrada.Name = "Lbl_cantiEntrada";
            this.Lbl_cantiEntrada.Size = new System.Drawing.Size(97, 15);
            this.Lbl_cantiEntrada.TabIndex = 1;
            this.Lbl_cantiEntrada.Text = "0";
            this.Lbl_cantiEntrada.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de Entradas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel_salidaT
            // 
            this.Panel_salidaT.BorderColor = System.Drawing.Color.LightGray;
            this.Panel_salidaT.BorderRadius = 2;
            this.Panel_salidaT.BorderThickness = 1;
            this.Panel_salidaT.Controls.Add(this.Lbl_cantiSalida);
            this.Panel_salidaT.Controls.Add(this.label2);
            this.Panel_salidaT.FillColor = System.Drawing.Color.WhiteSmoke;
            this.Panel_salidaT.Location = new System.Drawing.Point(638, 12);
            this.Panel_salidaT.Name = "Panel_salidaT";
            this.Panel_salidaT.ShadowDecoration.Parent = this.Panel_salidaT;
            this.Panel_salidaT.Size = new System.Drawing.Size(117, 63);
            this.Panel_salidaT.TabIndex = 20;
            // 
            // Lbl_cantiSalida
            // 
            this.Lbl_cantiSalida.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Lbl_cantiSalida.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_cantiSalida.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Lbl_cantiSalida.Location = new System.Drawing.Point(8, 44);
            this.Lbl_cantiSalida.Name = "Lbl_cantiSalida";
            this.Lbl_cantiSalida.Size = new System.Drawing.Size(97, 15);
            this.Lbl_cantiSalida.TabIndex = 1;
            this.Lbl_cantiSalida.Text = "0";
            this.Lbl_cantiSalida.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cantidad de Salidas";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.Txt_totalStock);
            this.guna2Panel2.Controls.Add(this.Txt_totalSalida);
            this.guna2Panel2.Controls.Add(this.Txt_cantidad);
            this.guna2Panel2.Controls.Add(this.Txt_Total_entrada);
            this.guna2Panel2.Location = new System.Drawing.Point(4, 479);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(944, 37);
            this.guna2Panel2.TabIndex = 18;
            // 
            // Txt_totalStock
            // 
            this.Txt_totalStock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_totalStock.DefaultText = "";
            this.Txt_totalStock.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_totalStock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_totalStock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_totalStock.DisabledState.Parent = this.Txt_totalStock;
            this.Txt_totalStock.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_totalStock.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_totalStock.FocusedState.Parent = this.Txt_totalStock;
            this.Txt_totalStock.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_totalStock.ForeColor = System.Drawing.Color.Black;
            this.Txt_totalStock.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_totalStock.HoverState.Parent = this.Txt_totalStock;
            this.Txt_totalStock.Location = new System.Drawing.Point(815, 5);
            this.Txt_totalStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_totalStock.Name = "Txt_totalStock";
            this.Txt_totalStock.PasswordChar = '\0';
            this.Txt_totalStock.PlaceholderText = "";
            this.Txt_totalStock.ReadOnly = true;
            this.Txt_totalStock.SelectedText = "";
            this.Txt_totalStock.ShadowDecoration.Parent = this.Txt_totalStock;
            this.Txt_totalStock.Size = new System.Drawing.Size(94, 26);
            this.Txt_totalStock.TabIndex = 20;
            this.Txt_totalStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txt_totalSalida
            // 
            this.Txt_totalSalida.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_totalSalida.DefaultText = "";
            this.Txt_totalSalida.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_totalSalida.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_totalSalida.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_totalSalida.DisabledState.Parent = this.Txt_totalSalida;
            this.Txt_totalSalida.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_totalSalida.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_totalSalida.FocusedState.Parent = this.Txt_totalSalida;
            this.Txt_totalSalida.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_totalSalida.ForeColor = System.Drawing.Color.Black;
            this.Txt_totalSalida.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_totalSalida.HoverState.Parent = this.Txt_totalSalida;
            this.Txt_totalSalida.Location = new System.Drawing.Point(715, 5);
            this.Txt_totalSalida.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_totalSalida.Name = "Txt_totalSalida";
            this.Txt_totalSalida.PasswordChar = '\0';
            this.Txt_totalSalida.PlaceholderText = "";
            this.Txt_totalSalida.ReadOnly = true;
            this.Txt_totalSalida.SelectedText = "";
            this.Txt_totalSalida.ShadowDecoration.Parent = this.Txt_totalSalida;
            this.Txt_totalSalida.Size = new System.Drawing.Size(94, 26);
            this.Txt_totalSalida.TabIndex = 20;
            this.Txt_totalSalida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txt_cantidad
            // 
            this.Txt_cantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_cantidad.DefaultText = "";
            this.Txt_cantidad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_cantidad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_cantidad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_cantidad.DisabledState.Parent = this.Txt_cantidad;
            this.Txt_cantidad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_cantidad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_cantidad.FocusedState.Parent = this.Txt_cantidad;
            this.Txt_cantidad.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_cantidad.ForeColor = System.Drawing.Color.Black;
            this.Txt_cantidad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_cantidad.HoverState.Parent = this.Txt_cantidad;
            this.Txt_cantidad.Location = new System.Drawing.Point(37, 5);
            this.Txt_cantidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_cantidad.Name = "Txt_cantidad";
            this.Txt_cantidad.PasswordChar = '\0';
            this.Txt_cantidad.PlaceholderText = "";
            this.Txt_cantidad.ReadOnly = true;
            this.Txt_cantidad.SelectedText = "";
            this.Txt_cantidad.ShadowDecoration.Parent = this.Txt_cantidad;
            this.Txt_cantidad.Size = new System.Drawing.Size(85, 26);
            this.Txt_cantidad.TabIndex = 20;
            // 
            // Txt_Total_entrada
            // 
            this.Txt_Total_entrada.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Total_entrada.DefaultText = "";
            this.Txt_Total_entrada.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_Total_entrada.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_Total_entrada.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_Total_entrada.DisabledState.Parent = this.Txt_Total_entrada;
            this.Txt_Total_entrada.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_Total_entrada.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_Total_entrada.FocusedState.Parent = this.Txt_Total_entrada;
            this.Txt_Total_entrada.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Total_entrada.ForeColor = System.Drawing.Color.Black;
            this.Txt_Total_entrada.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_Total_entrada.HoverState.Parent = this.Txt_Total_entrada;
            this.Txt_Total_entrada.Location = new System.Drawing.Point(615, 5);
            this.Txt_Total_entrada.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_Total_entrada.Name = "Txt_Total_entrada";
            this.Txt_Total_entrada.PasswordChar = '\0';
            this.Txt_Total_entrada.PlaceholderText = "";
            this.Txt_Total_entrada.ReadOnly = true;
            this.Txt_Total_entrada.SelectedText = "";
            this.Txt_Total_entrada.ShadowDecoration.Parent = this.Txt_Total_entrada;
            this.Txt_Total_entrada.Size = new System.Drawing.Size(94, 26);
            this.Txt_Total_entrada.TabIndex = 20;
            this.Txt_Total_entrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.Btn_buscar);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.Cbomes);
            this.guna2Panel1.Location = new System.Drawing.Point(8, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(437, 63);
            this.guna2Panel1.TabIndex = 12;
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.BorderColor = System.Drawing.Color.Silver;
            this.Btn_buscar.BorderRadius = 2;
            this.Btn_buscar.BorderThickness = 1;
            this.Btn_buscar.CheckedState.Parent = this.Btn_buscar;
            this.Btn_buscar.CustomImages.Parent = this.Btn_buscar;
            this.Btn_buscar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.Btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_buscar.ForeColor = System.Drawing.Color.Black;
            this.Btn_buscar.HoverState.Parent = this.Btn_buscar;
            this.Btn_buscar.Location = new System.Drawing.Point(183, 15);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.ShadowDecoration.Parent = this.Btn_buscar;
            this.Btn_buscar.Size = new System.Drawing.Size(100, 30);
            this.Btn_buscar.TabIndex = 11;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Selecciones Mes : ";
            // 
            // Cbomes
            // 
            this.Cbomes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbomes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbomes.FormattingEnabled = true;
            this.Cbomes.Location = new System.Drawing.Point(11, 22);
            this.Cbomes.Name = "Cbomes";
            this.Cbomes.Size = new System.Drawing.Size(141, 23);
            this.Cbomes.TabIndex = 14;
            // 
            // Dgv_grupo_
            // 
            this.Dgv_grupo_.AllowUserToAddRows = false;
            this.Dgv_grupo_.AllowUserToDeleteRows = false;
            this.Dgv_grupo_.AllowUserToResizeColumns = false;
            this.Dgv_grupo_.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.Dgv_grupo_.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_grupo_.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_grupo_.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.Dgv_grupo_.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.Dgv_grupo_.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_grupo_.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dgv_grupo_.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_grupo_.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_grupo_.ColumnHeadersHeight = 40;
            this.Dgv_grupo_.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgv_grupo_.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invgrupo_1,
            this.invgrupo_2,
            this.invgrupo_3,
            this.invgrupo_4,
            this.invgrupo_5,
            this.invgrupo_6,
            this.Dgv_btndetalle});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_grupo_.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_grupo_.EnableHeadersVisualStyles = false;
            this.Dgv_grupo_.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.Dgv_grupo_.Location = new System.Drawing.Point(4, 81);
            this.Dgv_grupo_.MultiSelect = false;
            this.Dgv_grupo_.Name = "Dgv_grupo_";
            this.Dgv_grupo_.ReadOnly = true;
            this.Dgv_grupo_.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_grupo_.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Dgv_grupo_.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.Dgv_grupo_.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_grupo_.Size = new System.Drawing.Size(944, 395);
            this.Dgv_grupo_.TabIndex = 5;
            // 
            // invgrupo_1
            // 
            this.invgrupo_1.DataPropertyName = "Inv_cantidad";
            this.invgrupo_1.HeaderText = "CANTIDAD";
            this.invgrupo_1.Name = "invgrupo_1";
            this.invgrupo_1.ReadOnly = true;
            this.invgrupo_1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.invgrupo_1.Width = 80;
            // 
            // invgrupo_2
            // 
            this.invgrupo_2.DataPropertyName = "Inv_cod_exis";
            this.invgrupo_2.HeaderText = "COD EXIST";
            this.invgrupo_2.Name = "invgrupo_2";
            this.invgrupo_2.ReadOnly = true;
            this.invgrupo_2.Width = 110;
            // 
            // invgrupo_3
            // 
            this.invgrupo_3.DataPropertyName = "Inv_existencia";
            this.invgrupo_3.HeaderText = "EXISTENCIA";
            this.invgrupo_3.Name = "invgrupo_3";
            this.invgrupo_3.ReadOnly = true;
            this.invgrupo_3.Width = 400;
            // 
            // invgrupo_4
            // 
            this.invgrupo_4.DataPropertyName = "Inv_entrada";
            this.invgrupo_4.HeaderText = "ENTRADAS";
            this.invgrupo_4.Name = "invgrupo_4";
            this.invgrupo_4.ReadOnly = true;
            // 
            // invgrupo_5
            // 
            this.invgrupo_5.DataPropertyName = "Inv_salida";
            this.invgrupo_5.HeaderText = "SALIDAS";
            this.invgrupo_5.Name = "invgrupo_5";
            this.invgrupo_5.ReadOnly = true;
            // 
            // invgrupo_6
            // 
            this.invgrupo_6.DataPropertyName = "Inv_final";
            this.invgrupo_6.HeaderText = "STOCK";
            this.invgrupo_6.Name = "invgrupo_6";
            this.invgrupo_6.ReadOnly = true;
            // 
            // Dgv_btndetalle
            // 
            this.Dgv_btndetalle.HeaderText = "DETALLE";
            this.Dgv_btndetalle.Image = ((System.Drawing.Image)(resources.GetObject("Dgv_btndetalle.Image")));
            this.Dgv_btndetalle.Name = "Dgv_btndetalle";
            this.Dgv_btndetalle.ReadOnly = true;
            this.Dgv_btndetalle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_btndetalle.ToolTipText = "Detalle Existencia";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1033, 517);
            this.shapeContainer1.TabIndex = 19;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 954;
            this.lineShape1.X2 = 954;
            this.lineShape1.Y1 = 50;
            this.lineShape1.Y2 = 496;
            // 
            // FrmMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 517);
            this.Controls.Add(this.Panel_content);
            this.Name = "FrmMantenimiento";
            this.Text = "Mantenimiento";
            this.Panel_content.ResumeLayout(false);
            this.Panel_entradaT.ResumeLayout(false);
            this.Panel_salidaT.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_grupo_)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Panel_content;
        private System.Windows.Forms.DataGridView Dgv_grupo_;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button Btn_buscar;
        private System.Windows.Forms.ComboBox Cbomes;
        private System.Windows.Forms.Label label6;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn invgrupo_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn invgrupo_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn invgrupo_3;
        private System.Windows.Forms.DataGridViewTextBoxColumn invgrupo_4;
        private System.Windows.Forms.DataGridViewTextBoxColumn invgrupo_5;
        private System.Windows.Forms.DataGridViewTextBoxColumn invgrupo_6;
        private System.Windows.Forms.DataGridViewImageColumn Dgv_btndetalle;
        private Guna.UI2.WinForms.Guna2TextBox Txt_totalStock;
        private Guna.UI2.WinForms.Guna2TextBox Txt_totalSalida;
        private Guna.UI2.WinForms.Guna2TextBox Txt_Total_entrada;
        private Guna.UI2.WinForms.Guna2Panel Panel_salidaT;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel Panel_entradaT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_cantiEntrada;
        private System.Windows.Forms.Label Lbl_cantiSalida;
        private Guna.UI2.WinForms.Guna2TextBox Txt_cantidad;
    }
}