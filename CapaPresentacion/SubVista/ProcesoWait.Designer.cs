
namespace CapaPresentacion.SubVista
{
    partial class FrmProcesoWait
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProcesoWait));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Pict_carga = new System.Windows.Forms.PictureBox();
            this.Lbl_descrip = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pict_carga)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 4;
            this.guna2Elipse1.TargetControl = this;
            // 
            // Pict_carga
            // 
            this.Pict_carga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pict_carga.Image = ((System.Drawing.Image)(resources.GetObject("Pict_carga.Image")));
            this.Pict_carga.Location = new System.Drawing.Point(0, 0);
            this.Pict_carga.Name = "Pict_carga";
            this.Pict_carga.Size = new System.Drawing.Size(120, 79);
            this.Pict_carga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pict_carga.TabIndex = 0;
            this.Pict_carga.TabStop = false;
            // 
            // Lbl_descrip
            // 
            this.Lbl_descrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Lbl_descrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Lbl_descrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_descrip.ForeColor = System.Drawing.Color.White;
            this.Lbl_descrip.Location = new System.Drawing.Point(0, 61);
            this.Lbl_descrip.Name = "Lbl_descrip";
            this.Lbl_descrip.Size = new System.Drawing.Size(120, 18);
            this.Lbl_descrip.TabIndex = 2;
            this.Lbl_descrip.Text = "En proceso...";
            this.Lbl_descrip.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmProcesoWait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(120, 79);
            this.Controls.Add(this.Lbl_descrip);
            this.Controls.Add(this.Pict_carga);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProcesoWait";
            this.Opacity = 0.9D;
            this.ShowInTaskbar = false;
            this.Text = "ProcesoWait";
            ((System.ComponentModel.ISupportInitialize)(this.Pict_carga)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label Lbl_descrip;
        private System.Windows.Forms.PictureBox Pict_carga;
    }
}