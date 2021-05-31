
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.Panel_contenedor = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_entrada = new System.Windows.Forms.Button();
            this.Btn_salida = new System.Windows.Forms.Button();
            this.Btn_iv_fisico = new System.Windows.Forms.Button();
            this.Btn_iv_valorizado = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_empresa = new System.Windows.Forms.Button();
            this.Btn_cliente_pro = new System.Windows.Forms.Button();
            this.Btn_tipooperacion = new System.Windows.Forms.Button();
            this.Btn_moneda = new System.Windows.Forms.Button();
            this.Btn_tipdocumento = new System.Windows.Forms.Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.PanelMenu.SuspendLayout();
            this.Panel_contenedor.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.PanelMenu.Controls.Add(this.Panel_contenedor);
            this.PanelMenu.Controls.Add(this.tabControl1);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(912, 558);
            this.PanelMenu.TabIndex = 1;
            // 
            // Panel_contenedor
            // 
            this.Panel_contenedor.AutoScroll = true;
            this.Panel_contenedor.Controls.Add(this.guna2TextBox1);
            this.Panel_contenedor.Controls.Add(this.textBox1);
            this.Panel_contenedor.Controls.Add(this.guna2Button1);
            this.Panel_contenedor.Controls.Add(this.statusStrip1);
            this.Panel_contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_contenedor.Location = new System.Drawing.Point(0, 118);
            this.Panel_contenedor.Name = "Panel_contenedor";
            this.Panel_contenedor.Size = new System.Drawing.Size(912, 440);
            this.Panel_contenedor.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 418);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(912, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(128, 17);
            this.toolStripStatusLabel1.Text = "  Tecnología 2050 S.A.C";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(115, 28);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(15, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(912, 118);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(253)))));
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(904, 82);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Control de Inventarios";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66543F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66543F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66543F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66543F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66543F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.67286F));
            this.tableLayoutPanel1.Controls.Add(this.Btn_entrada, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Btn_salida, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Btn_iv_fisico, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Btn_iv_valorizado, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.button6, 5, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(470, 76);
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
            this.Btn_entrada.Size = new System.Drawing.Size(72, 70);
            this.Btn_entrada.TabIndex = 1;
            this.Btn_entrada.Text = "Entrada";
            this.Btn_entrada.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_entrada.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_entrada.UseVisualStyleBackColor = true;
            this.Btn_entrada.Click += new System.EventHandler(this.Btn_entrada_Click);
            // 
            // Btn_salida
            // 
            this.Btn_salida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_salida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_salida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_salida.Image = ((System.Drawing.Image)(resources.GetObject("Btn_salida.Image")));
            this.Btn_salida.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_salida.Location = new System.Drawing.Point(81, 3);
            this.Btn_salida.Name = "Btn_salida";
            this.Btn_salida.Size = new System.Drawing.Size(72, 70);
            this.Btn_salida.TabIndex = 2;
            this.Btn_salida.Text = "Salida";
            this.Btn_salida.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_salida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_salida.UseVisualStyleBackColor = true;
            this.Btn_salida.Click += new System.EventHandler(this.Btn_salida_Click);
            // 
            // Btn_iv_fisico
            // 
            this.Btn_iv_fisico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_iv_fisico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_iv_fisico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_iv_fisico.Location = new System.Drawing.Point(159, 3);
            this.Btn_iv_fisico.Name = "Btn_iv_fisico";
            this.Btn_iv_fisico.Size = new System.Drawing.Size(72, 70);
            this.Btn_iv_fisico.TabIndex = 2;
            this.Btn_iv_fisico.Text = "Inv. Unidades Fisica";
            this.Btn_iv_fisico.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_iv_fisico.UseVisualStyleBackColor = true;
            this.Btn_iv_fisico.Click += new System.EventHandler(this.Btn_iv_fisico_Click);
            // 
            // Btn_iv_valorizado
            // 
            this.Btn_iv_valorizado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_iv_valorizado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_iv_valorizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_iv_valorizado.Location = new System.Drawing.Point(237, 3);
            this.Btn_iv_valorizado.Name = "Btn_iv_valorizado";
            this.Btn_iv_valorizado.Size = new System.Drawing.Size(72, 70);
            this.Btn_iv_valorizado.TabIndex = 2;
            this.Btn_iv_valorizado.Text = "Inv. Unidades Permanetes";
            this.Btn_iv_valorizado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_iv_valorizado.UseVisualStyleBackColor = true;
            this.Btn_iv_valorizado.Click += new System.EventHandler(this.Btn_iv_valorizado_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(315, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(72, 70);
            this.button5.TabIndex = 3;
            this.button5.Text = "Stock Final a Fecha";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(393, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(72, 70);
            this.button6.TabIndex = 4;
            this.button6.Text = "Costo de Venta";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(253)))));
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(904, 82);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.Btn_empresa, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Btn_cliente_pro, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Btn_tipooperacion, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.Btn_moneda, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.Btn_tipdocumento, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(390, 76);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // Btn_empresa
            // 
            this.Btn_empresa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_empresa.Location = new System.Drawing.Point(3, 3);
            this.Btn_empresa.Name = "Btn_empresa";
            this.Btn_empresa.Size = new System.Drawing.Size(72, 70);
            this.Btn_empresa.TabIndex = 2;
            this.Btn_empresa.Text = "Empresa";
            this.Btn_empresa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_empresa.UseVisualStyleBackColor = true;
            this.Btn_empresa.Click += new System.EventHandler(this.Btn_empresa_Click);
            // 
            // Btn_cliente_pro
            // 
            this.Btn_cliente_pro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_cliente_pro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cliente_pro.Location = new System.Drawing.Point(81, 3);
            this.Btn_cliente_pro.Name = "Btn_cliente_pro";
            this.Btn_cliente_pro.Size = new System.Drawing.Size(72, 70);
            this.Btn_cliente_pro.TabIndex = 2;
            this.Btn_cliente_pro.Text = "Cliente y Proveedor";
            this.Btn_cliente_pro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_cliente_pro.UseVisualStyleBackColor = true;
            this.Btn_cliente_pro.Click += new System.EventHandler(this.Btn_cliente_pro_Click);
            // 
            // Btn_tipooperacion
            // 
            this.Btn_tipooperacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_tipooperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_tipooperacion.Location = new System.Drawing.Point(159, 3);
            this.Btn_tipooperacion.Name = "Btn_tipooperacion";
            this.Btn_tipooperacion.Size = new System.Drawing.Size(72, 70);
            this.Btn_tipooperacion.TabIndex = 2;
            this.Btn_tipooperacion.Text = "Tipo de Operación";
            this.Btn_tipooperacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_tipooperacion.UseVisualStyleBackColor = true;
            this.Btn_tipooperacion.Click += new System.EventHandler(this.Btn_tipooperacion_Click);
            // 
            // Btn_moneda
            // 
            this.Btn_moneda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_moneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_moneda.Location = new System.Drawing.Point(237, 3);
            this.Btn_moneda.Name = "Btn_moneda";
            this.Btn_moneda.Size = new System.Drawing.Size(72, 70);
            this.Btn_moneda.TabIndex = 2;
            this.Btn_moneda.Text = "Moneda";
            this.Btn_moneda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_moneda.UseVisualStyleBackColor = true;
            this.Btn_moneda.Click += new System.EventHandler(this.Btn_moneda_Click);
            // 
            // Btn_tipdocumento
            // 
            this.Btn_tipdocumento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_tipdocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_tipdocumento.Location = new System.Drawing.Point(315, 3);
            this.Btn_tipdocumento.Name = "Btn_tipdocumento";
            this.Btn_tipdocumento.Size = new System.Drawing.Size(72, 70);
            this.Btn_tipdocumento.TabIndex = 2;
            this.Btn_tipdocumento.Text = "Tipo Documento";
            this.Btn_tipdocumento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_tipdocumento.UseVisualStyleBackColor = true;
            this.Btn_tipdocumento.Click += new System.EventHandler(this.Btn_tipdocumento_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(158, 45);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 1;
            this.guna2Button1.Text = "guna2Button1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(195, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(391, 54);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(200, 36);
            this.guna2TextBox1.TabIndex = 3;
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 558);
            this.Controls.Add(this.PanelMenu);
            this.Name = "FrmInicio";
            this.Text = "Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmInicio_FormClosing);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel Panel_contenedor;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Btn_entrada;
        private System.Windows.Forms.Button Btn_salida;
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
        private System.Windows.Forms.Button Btn_tipdocumento;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}