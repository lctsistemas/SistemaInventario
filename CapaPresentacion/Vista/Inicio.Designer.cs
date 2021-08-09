
namespace CapaPresentacion.Vista
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.Panel_contenedor = new System.Windows.Forms.Panel();
            this.Lbl_idperiodo = new System.Windows.Forms.Label();
            this.Lbl_idempresa = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlblhora = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_entrada = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.Btn_mante = new System.Windows.Forms.Button();
            this.Btn_iv_fisico = new System.Windows.Forms.Button();
            this.Btn_iv_valorizado = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_empresa = new System.Windows.Forms.Button();
            this.Btn_cliente_pro = new System.Windows.Forms.Button();
            this.Btn_tipooperacion = new System.Windows.Forms.Button();
            this.Btn_moneda = new System.Windows.Forms.Button();
            this.Btn_tipdocumento = new System.Windows.Forms.Button();
            this.BtnUnidMed = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Panel_titulo = new System.Windows.Forms.Panel();
            this.lbluser = new System.Windows.Forms.Label();
            this.Lblempresa = new System.Windows.Forms.Label();
            this.Picture_user = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PanelMenu.SuspendLayout();
            this.Panel_contenedor.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.Panel_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_user)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.PanelMenu.Controls.Add(this.Panel_contenedor);
            this.PanelMenu.Controls.Add(this.tabControl1);
            this.PanelMenu.Controls.Add(this.Panel_titulo);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(912, 558);
            this.PanelMenu.TabIndex = 1;
            // 
            // Panel_contenedor
            // 
            this.Panel_contenedor.AutoScroll = true;
            this.Panel_contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.Panel_contenedor.Controls.Add(this.Lbl_idperiodo);
            this.Panel_contenedor.Controls.Add(this.Lbl_idempresa);
            this.Panel_contenedor.Controls.Add(this.statusStrip1);
            this.Panel_contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_contenedor.Location = new System.Drawing.Point(0, 136);
            this.Panel_contenedor.Name = "Panel_contenedor";
            this.Panel_contenedor.Size = new System.Drawing.Size(912, 422);
            this.Panel_contenedor.TabIndex = 3;
            // 
            // Lbl_idperiodo
            // 
            this.Lbl_idperiodo.AutoSize = true;
            this.Lbl_idperiodo.Location = new System.Drawing.Point(24, 45);
            this.Lbl_idperiodo.Name = "Lbl_idperiodo";
            this.Lbl_idperiodo.Size = new System.Drawing.Size(53, 13);
            this.Lbl_idperiodo.TabIndex = 1;
            this.Lbl_idperiodo.Text = "id periodo";
            this.Lbl_idperiodo.Visible = false;
            // 
            // Lbl_idempresa
            // 
            this.Lbl_idempresa.AutoSize = true;
            this.Lbl_idempresa.Location = new System.Drawing.Point(24, 22);
            this.Lbl_idempresa.Name = "Lbl_idempresa";
            this.Lbl_idempresa.Size = new System.Drawing.Size(58, 13);
            this.Lbl_idempresa.TabIndex = 1;
            this.Lbl_idempresa.Text = "id empresa";
            this.Lbl_idempresa.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tlblhora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 398);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(912, 24);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 19);
            this.toolStripStatusLabel1.Text = "  Tecnología 2050 S.A.C ";
            // 
            // tlblhora
            // 
            this.tlblhora.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.tlblhora.Name = "tlblhora";
            this.tlblhora.Size = new System.Drawing.Size(766, 19);
            this.tlblhora.Spring = true;
            this.tlblhora.Text = "HORA";
            this.tlblhora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(115, 28);
            this.tabControl1.Location = new System.Drawing.Point(0, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(15, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(912, 101);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(904, 65);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Control de Inventarios";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.24396F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.24396F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.24396F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.24396F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.24396F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.25031F));
            this.tableLayoutPanel1.Controls.Add(this.Btn_entrada, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button6, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.Btn_mante, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Btn_iv_fisico, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Btn_iv_valorizado, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button5, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(544, 59);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Btn_entrada
            // 
            this.Btn_entrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_entrada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_entrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_entrada.Image = ((System.Drawing.Image)(resources.GetObject("Btn_entrada.Image")));
            this.Btn_entrada.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_entrada.Location = new System.Drawing.Point(3, 3);
            this.Btn_entrada.Name = "Btn_entrada";
            this.Btn_entrada.Size = new System.Drawing.Size(84, 53);
            this.Btn_entrada.TabIndex = 1;
            this.Btn_entrada.Text = "Importar";
            this.Btn_entrada.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_entrada.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_entrada.UseVisualStyleBackColor = true;
            this.Btn_entrada.Click += new System.EventHandler(this.Btn_entrada_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(241)))), ((int)(((byte)(251)))));
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(453, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(88, 53);
            this.button6.TabIndex = 4;
            this.button6.Text = "Costo de Venta";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Btn_mante
            // 
            this.Btn_mante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(241)))), ((int)(((byte)(251)))));
            this.Btn_mante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_mante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_mante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_mante.Image = ((System.Drawing.Image)(resources.GetObject("Btn_mante.Image")));
            this.Btn_mante.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_mante.Location = new System.Drawing.Point(93, 3);
            this.Btn_mante.Name = "Btn_mante";
            this.Btn_mante.Size = new System.Drawing.Size(84, 53);
            this.Btn_mante.TabIndex = 2;
            this.Btn_mante.Text = "Mantenimiento Inventario";
            this.Btn_mante.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_mante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_mante.UseVisualStyleBackColor = true;
            this.Btn_mante.Click += new System.EventHandler(this.Btn_mante_Click);
            // 
            // Btn_iv_fisico
            // 
            this.Btn_iv_fisico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(241)))), ((int)(((byte)(251)))));
            this.Btn_iv_fisico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_iv_fisico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_iv_fisico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_iv_fisico.Location = new System.Drawing.Point(183, 3);
            this.Btn_iv_fisico.Name = "Btn_iv_fisico";
            this.Btn_iv_fisico.Size = new System.Drawing.Size(84, 53);
            this.Btn_iv_fisico.TabIndex = 2;
            this.Btn_iv_fisico.Text = "Inv. Unidades Fisica";
            this.Btn_iv_fisico.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_iv_fisico.UseVisualStyleBackColor = true;
            this.Btn_iv_fisico.Click += new System.EventHandler(this.Btn_iv_fisico_Click);
            // 
            // Btn_iv_valorizado
            // 
            this.Btn_iv_valorizado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(241)))), ((int)(((byte)(251)))));
            this.Btn_iv_valorizado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_iv_valorizado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_iv_valorizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_iv_valorizado.Location = new System.Drawing.Point(273, 3);
            this.Btn_iv_valorizado.Name = "Btn_iv_valorizado";
            this.Btn_iv_valorizado.Size = new System.Drawing.Size(84, 53);
            this.Btn_iv_valorizado.TabIndex = 2;
            this.Btn_iv_valorizado.Text = "Inv. Unidades Permanetes";
            this.Btn_iv_valorizado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_iv_valorizado.UseVisualStyleBackColor = true;
            this.Btn_iv_valorizado.Click += new System.EventHandler(this.Btn_iv_valorizado_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(241)))), ((int)(((byte)(251)))));
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(363, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 53);
            this.button5.TabIndex = 3;
            this.button5.Text = "Stock Final a Fecha";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(904, 65);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.31795F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.31795F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.31795F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.31795F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.31795F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.31795F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.0923F));
            this.tableLayoutPanel2.Controls.Add(this.Btn_empresa, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Btn_cliente_pro, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Btn_tipooperacion, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.Btn_moneda, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.Btn_tipdocumento, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnUnidMed, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 6, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(557, 59);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // Btn_empresa
            // 
            this.Btn_empresa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_empresa.Location = new System.Drawing.Point(3, 3);
            this.Btn_empresa.Name = "Btn_empresa";
            this.Btn_empresa.Size = new System.Drawing.Size(73, 53);
            this.Btn_empresa.TabIndex = 2;
            this.Btn_empresa.Text = "Empresa";
            this.Btn_empresa.UseVisualStyleBackColor = true;
            this.Btn_empresa.Click += new System.EventHandler(this.Btn_empresa_Click);
            // 
            // Btn_cliente_pro
            // 
            this.Btn_cliente_pro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_cliente_pro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cliente_pro.Location = new System.Drawing.Point(82, 3);
            this.Btn_cliente_pro.Name = "Btn_cliente_pro";
            this.Btn_cliente_pro.Size = new System.Drawing.Size(73, 53);
            this.Btn_cliente_pro.TabIndex = 2;
            this.Btn_cliente_pro.Text = "Cliente y Proveedor";
            this.Btn_cliente_pro.UseVisualStyleBackColor = true;
            this.Btn_cliente_pro.Click += new System.EventHandler(this.Btn_cliente_pro_Click);
            // 
            // Btn_tipooperacion
            // 
            this.Btn_tipooperacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_tipooperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_tipooperacion.Location = new System.Drawing.Point(161, 3);
            this.Btn_tipooperacion.Name = "Btn_tipooperacion";
            this.Btn_tipooperacion.Size = new System.Drawing.Size(73, 53);
            this.Btn_tipooperacion.TabIndex = 2;
            this.Btn_tipooperacion.Text = "Tipo de Operación";
            this.Btn_tipooperacion.UseVisualStyleBackColor = true;
            this.Btn_tipooperacion.Click += new System.EventHandler(this.Btn_tipooperacion_Click);
            // 
            // Btn_moneda
            // 
            this.Btn_moneda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_moneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_moneda.Location = new System.Drawing.Point(240, 3);
            this.Btn_moneda.Name = "Btn_moneda";
            this.Btn_moneda.Size = new System.Drawing.Size(73, 53);
            this.Btn_moneda.TabIndex = 2;
            this.Btn_moneda.Text = "Moneda";
            this.Btn_moneda.UseVisualStyleBackColor = true;
            this.Btn_moneda.Click += new System.EventHandler(this.Btn_moneda_Click);
            // 
            // Btn_tipdocumento
            // 
            this.Btn_tipdocumento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_tipdocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_tipdocumento.Location = new System.Drawing.Point(319, 3);
            this.Btn_tipdocumento.Name = "Btn_tipdocumento";
            this.Btn_tipdocumento.Size = new System.Drawing.Size(73, 53);
            this.Btn_tipdocumento.TabIndex = 2;
            this.Btn_tipdocumento.Text = "Tipo Documento";
            this.Btn_tipdocumento.UseVisualStyleBackColor = true;
            this.Btn_tipdocumento.Click += new System.EventHandler(this.Btn_tipdocumento_Click);
            // 
            // BtnUnidMed
            // 
            this.BtnUnidMed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnUnidMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUnidMed.Location = new System.Drawing.Point(398, 3);
            this.BtnUnidMed.Name = "BtnUnidMed";
            this.BtnUnidMed.Size = new System.Drawing.Size(73, 53);
            this.BtnUnidMed.TabIndex = 2;
            this.BtnUnidMed.Text = "Unidad Medida";
            this.BtnUnidMed.UseVisualStyleBackColor = true;
            this.BtnUnidMed.Click += new System.EventHandler(this.BtnUnidMed_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(477, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 53);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tipo Existencia";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Panel_titulo
            // 
            this.Panel_titulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Panel_titulo.Controls.Add(this.lbluser);
            this.Panel_titulo.Controls.Add(this.Lblempresa);
            this.Panel_titulo.Controls.Add(this.Picture_user);
            this.Panel_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_titulo.Location = new System.Drawing.Point(0, 0);
            this.Panel_titulo.Name = "Panel_titulo";
            this.Panel_titulo.Size = new System.Drawing.Size(912, 35);
            this.Panel_titulo.TabIndex = 0;
            // 
            // lbluser
            // 
            this.lbluser.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.Location = new System.Drawing.Point(753, 0);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(114, 35);
            this.lbluser.TabIndex = 2;
            this.lbluser.Text = "ADMINISTRADOR ";
            this.lbluser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lblempresa
            // 
            this.Lblempresa.Dock = System.Windows.Forms.DockStyle.Left;
            this.Lblempresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblempresa.Location = new System.Drawing.Point(0, 0);
            this.Lblempresa.Name = "Lblempresa";
            this.Lblempresa.Size = new System.Drawing.Size(646, 35);
            this.Lblempresa.TabIndex = 1;
            this.Lblempresa.Text = "  2021 ::   20473859314     INVERSIONES DBPROYECT S.A.C";
            this.Lblempresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Picture_user
            // 
            this.Picture_user.Dock = System.Windows.Forms.DockStyle.Right;
            this.Picture_user.Image = ((System.Drawing.Image)(resources.GetObject("Picture_user.Image")));
            this.Picture_user.Location = new System.Drawing.Point(867, 0);
            this.Picture_user.Name = "Picture_user";
            this.Picture_user.Size = new System.Drawing.Size(45, 35);
            this.Picture_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Picture_user.TabIndex = 0;
            this.Picture_user.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(912, 558);
            this.Controls.Add(this.PanelMenu);
            this.Name = "FrmInicio";
            this.ShowIcon = false;
            this.Text = "  Sistema Inventario v1.0.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmInicio_FormClosing);
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            this.PanelMenu.ResumeLayout(false);
            this.Panel_contenedor.ResumeLayout(false);
            this.Panel_contenedor.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.Panel_titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Picture_user)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel Panel_contenedor;
        private System.Windows.Forms.Label Lbl_idempresa;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Btn_entrada;
        private System.Windows.Forms.Button Btn_mante;
        private System.Windows.Forms.Button Btn_iv_fisico;
        private System.Windows.Forms.Button Btn_iv_valorizado;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button Btn_empresa;
        private System.Windows.Forms.Button Btn_cliente_pro;
        private System.Windows.Forms.Button Btn_tipooperacion;
        private System.Windows.Forms.Button Btn_moneda;
        private System.Windows.Forms.Panel Panel_titulo;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label Lblempresa;
        private System.Windows.Forms.PictureBox Picture_user;
        private System.Windows.Forms.Label Lbl_idperiodo;
        private System.Windows.Forms.ToolStripStatusLabel tlblhora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Btn_tipdocumento;
        private System.Windows.Forms.Button BtnUnidMed;
        private System.Windows.Forms.Button button1;
    }
}