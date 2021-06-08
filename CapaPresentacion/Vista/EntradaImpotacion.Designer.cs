
namespace CapaPresentacion.Vista
{
    partial class FrmEntradaImpotacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntradaImpotacion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lblruta = new System.Windows.Forms.Label();
            this.Btn_importExcel = new Guna.UI2.WinForms.Guna2Button();
            this.Dgv_Importar = new System.Windows.Forms.DataGridView();
            this.Dgv_txtid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lbl_cantidad = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Importar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 497);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(901, 117);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(58, 215);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.panel2.Controls.Add(this.Lbl_cantidad);
            this.panel2.Controls.Add(this.Lblruta);
            this.panel2.Controls.Add(this.Btn_importExcel);
            this.panel2.Controls.Add(this.Dgv_Importar);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(848, 497);
            this.panel2.TabIndex = 0;
            // 
            // Lblruta
            // 
            this.Lblruta.AutoSize = true;
            this.Lblruta.Location = new System.Drawing.Point(12, 17);
            this.Lblruta.Name = "Lblruta";
            this.Lblruta.Size = new System.Drawing.Size(53, 13);
            this.Lblruta.TabIndex = 6;
            this.Lblruta.Text = "C:\\\\Excel";
            // 
            // Btn_importExcel
            // 
            this.Btn_importExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_importExcel.BorderRadius = 3;
            this.Btn_importExcel.CheckedState.Parent = this.Btn_importExcel;
            this.Btn_importExcel.CustomImages.Parent = this.Btn_importExcel;
            this.Btn_importExcel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(190)))), ((int)(((byte)(128)))));
            this.Btn_importExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Btn_importExcel.ForeColor = System.Drawing.Color.White;
            this.Btn_importExcel.HoverState.Parent = this.Btn_importExcel;
            this.Btn_importExcel.Image = ((System.Drawing.Image)(resources.GetObject("Btn_importExcel.Image")));
            this.Btn_importExcel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_importExcel.Location = new System.Drawing.Point(608, 8);
            this.Btn_importExcel.Name = "Btn_importExcel";
            this.Btn_importExcel.ShadowDecoration.Parent = this.Btn_importExcel;
            this.Btn_importExcel.Size = new System.Drawing.Size(223, 30);
            this.Btn_importExcel.TabIndex = 5;
            this.Btn_importExcel.Text = "Importar Excel";
            this.Btn_importExcel.Click += new System.EventHandler(this.Btn_importExcel_Click);
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
            this.Dgv_Importar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Importar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.Dgv_Importar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
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
            this.Dgv_Importar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dgv_txtid});
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
            this.Dgv_Importar.Location = new System.Drawing.Point(2, 44);
            this.Dgv_Importar.MultiSelect = false;
            this.Dgv_Importar.Name = "Dgv_Importar";
            this.Dgv_Importar.ReadOnly = true;
            this.Dgv_Importar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Dgv_Importar.RowHeadersVisible = false;
            this.Dgv_Importar.RowHeadersWidth = 25;
            this.Dgv_Importar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Dgv_Importar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgv_Importar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Importar.Size = new System.Drawing.Size(843, 393);
            this.Dgv_Importar.TabIndex = 4;
            // 
            // Dgv_txtid
            // 
            this.Dgv_txtid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Dgv_txtid.DataPropertyName = "id";
            this.Dgv_txtid.HeaderText = "CODIGO";
            this.Dgv_txtid.Name = "Dgv_txtid";
            this.Dgv_txtid.ReadOnly = true;
            this.Dgv_txtid.Width = 83;
            // 
            // Lbl_cantidad
            // 
            this.Lbl_cantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_cantidad.AutoSize = true;
            this.Lbl_cantidad.Location = new System.Drawing.Point(58, 457);
            this.Lbl_cantidad.Name = "Lbl_cantidad";
            this.Lbl_cantidad.Size = new System.Drawing.Size(27, 13);
            this.Lbl_cantidad.TabIndex = 7;
            this.Lbl_cantidad.Text = "Nro.";
            // 
            // FrmEntradaImpotacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 497);
            this.Controls.Add(this.panel1);
            this.Name = "FrmEntradaImpotacion";
            this.Text = "EntradaImpotacion";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Importar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView Dgv_Importar;
        private System.Windows.Forms.Label Lblruta;
        private Guna.UI2.WinForms.Guna2Button Btn_importExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dgv_txtid;
        private System.Windows.Forms.Label Lbl_cantidad;
    }
}