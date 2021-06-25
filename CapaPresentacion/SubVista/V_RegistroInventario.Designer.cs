
namespace CapaPresentacion.SubVista
{
    partial class FrmV_RegistroInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmV_RegistroInventario));
            this.PanelContenedor = new Guna.UI2.WinForms.Guna2Panel();
            this.PanelDatos = new System.Windows.Forms.Panel();
            this.tableLayout_botones = new System.Windows.Forms.TableLayoutPanel();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_procesaSalida = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_procesaEntrada = new Guna.UI2.WinForms.Guna2Button();
            this.Dgv_Importar = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PanelContenedor.SuspendLayout();
            this.PanelDatos.SuspendLayout();
            this.tableLayout_botones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Importar)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.PanelContenedor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.PanelContenedor.BorderThickness = 1;
            this.PanelContenedor.Controls.Add(this.button1);
            this.PanelContenedor.Controls.Add(this.tableLayout_botones);
            this.PanelContenedor.Controls.Add(this.PanelDatos);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(0, 0);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.ShadowDecoration.Parent = this.PanelContenedor;
            this.PanelContenedor.Size = new System.Drawing.Size(952, 482);
            this.PanelContenedor.TabIndex = 0;
            // 
            // PanelDatos
            // 
            this.PanelDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelDatos.Controls.Add(this.label1);
            this.PanelDatos.Controls.Add(this.groupBox1);
            this.PanelDatos.Controls.Add(this.comboBox1);
            this.PanelDatos.Controls.Add(this.Dgv_Importar);
            this.PanelDatos.Location = new System.Drawing.Point(1, 1);
            this.PanelDatos.Name = "PanelDatos";
            this.PanelDatos.Size = new System.Drawing.Size(850, 478);
            this.PanelDatos.TabIndex = 0;
            // 
            // tableLayout_botones
            // 
            this.tableLayout_botones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayout_botones.ColumnCount = 1;
            this.tableLayout_botones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout_botones.Controls.Add(this.guna2Button3, 0, 2);
            this.tableLayout_botones.Controls.Add(this.Btn_procesaSalida, 0, 1);
            this.tableLayout_botones.Controls.Add(this.Btn_procesaEntrada, 0, 0);
            this.tableLayout_botones.Location = new System.Drawing.Point(872, 97);
            this.tableLayout_botones.Name = "tableLayout_botones";
            this.tableLayout_botones.RowCount = 3;
            this.tableLayout_botones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.48837F));
            this.tableLayout_botones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.55814F));
            this.tableLayout_botones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayout_botones.Size = new System.Drawing.Size(80, 161);
            this.tableLayout_botones.TabIndex = 2;
            // 
            // guna2Button3
            // 
            this.guna2Button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Button3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.guna2Button3.BorderRadius = 2;
            this.guna2Button3.BorderThickness = 1;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Button3.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.Black;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Location = new System.Drawing.Point(3, 109);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(74, 49);
            this.guna2Button3.TabIndex = 0;
            this.guna2Button3.Text = "excel";
            // 
            // Btn_procesaSalida
            // 
            this.Btn_procesaSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_procesaSalida.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.Btn_procesaSalida.BorderRadius = 2;
            this.Btn_procesaSalida.BorderThickness = 1;
            this.Btn_procesaSalida.CheckedState.Parent = this.Btn_procesaSalida;
            this.Btn_procesaSalida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_procesaSalida.CustomImages.Parent = this.Btn_procesaSalida;
            this.Btn_procesaSalida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_procesaSalida.FillColor = System.Drawing.Color.Gainsboro;
            this.Btn_procesaSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Btn_procesaSalida.ForeColor = System.Drawing.Color.Black;
            this.Btn_procesaSalida.HoverState.Parent = this.Btn_procesaSalida;
            this.Btn_procesaSalida.Location = new System.Drawing.Point(3, 57);
            this.Btn_procesaSalida.Name = "Btn_procesaSalida";
            this.Btn_procesaSalida.ShadowDecoration.Parent = this.Btn_procesaSalida;
            this.Btn_procesaSalida.Size = new System.Drawing.Size(74, 46);
            this.Btn_procesaSalida.TabIndex = 0;
            this.Btn_procesaSalida.Text = "Salidas";
            // 
            // Btn_procesaEntrada
            // 
            this.Btn_procesaEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_procesaEntrada.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.Btn_procesaEntrada.BorderRadius = 2;
            this.Btn_procesaEntrada.BorderThickness = 1;
            this.Btn_procesaEntrada.CheckedState.Parent = this.Btn_procesaEntrada;
            this.Btn_procesaEntrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_procesaEntrada.CustomImages.Parent = this.Btn_procesaEntrada;
            this.Btn_procesaEntrada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_procesaEntrada.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_procesaEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Btn_procesaEntrada.ForeColor = System.Drawing.Color.Black;
            this.Btn_procesaEntrada.HoverState.Parent = this.Btn_procesaEntrada;
            this.Btn_procesaEntrada.Location = new System.Drawing.Point(3, 3);
            this.Btn_procesaEntrada.Name = "Btn_procesaEntrada";
            this.Btn_procesaEntrada.ShadowDecoration.Parent = this.Btn_procesaEntrada;
            this.Btn_procesaEntrada.Size = new System.Drawing.Size(74, 48);
            this.Btn_procesaEntrada.TabIndex = 0;
            this.Btn_procesaEntrada.Text = "Registrar";
            // 
            // Dgv_Importar
            // 
            this.Dgv_Importar.AllowUserToAddRows = false;
            this.Dgv_Importar.AllowUserToDeleteRows = false;
            this.Dgv_Importar.AllowUserToResizeColumns = false;
            this.Dgv_Importar.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.Dgv_Importar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Importar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Importar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.Dgv_Importar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Dgv_Importar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_Importar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dgv_Importar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Importar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_Importar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Importar.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_Importar.EnableHeadersVisualStyles = false;
            this.Dgv_Importar.GridColor = System.Drawing.Color.Silver;
            this.Dgv_Importar.Location = new System.Drawing.Point(3, 97);
            this.Dgv_Importar.MultiSelect = false;
            this.Dgv_Importar.Name = "Dgv_Importar";
            this.Dgv_Importar.ReadOnly = true;
            this.Dgv_Importar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Dgv_Importar.RowHeadersVisible = false;
            this.Dgv_Importar.RowHeadersWidth = 25;
            this.Dgv_Importar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Dgv_Importar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Importar.Size = new System.Drawing.Size(844, 378);
            this.Dgv_Importar.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(11, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(127, 23);
            this.comboBox1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(577, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 75);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Selecciones Mes : ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(190)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(872, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 64);
            this.button1.TabIndex = 10;
            this.button1.Text = "Exportar excel";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FrmV_RegistroInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(952, 482);
            this.Controls.Add(this.PanelContenedor);
            this.Name = "FrmV_RegistroInventario";
            this.Text = "V_RegistroInventario";
            this.PanelContenedor.ResumeLayout(false);
            this.PanelDatos.ResumeLayout(false);
            this.PanelDatos.PerformLayout();
            this.tableLayout_botones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Importar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelContenedor;
        private System.Windows.Forms.Panel PanelDatos;
        private System.Windows.Forms.TableLayoutPanel tableLayout_botones;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button Btn_procesaSalida;
        private Guna.UI2.WinForms.Guna2Button Btn_procesaEntrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView Dgv_Importar;
        private System.Windows.Forms.Button button1;
    }
}