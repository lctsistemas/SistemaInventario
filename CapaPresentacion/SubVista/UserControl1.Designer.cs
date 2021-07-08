
namespace CapaPresentacion.SubVista
{
    partial class UserControl_mes
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Cbomess = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Cbomess
            // 
            this.Cbomess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbomess.FormattingEnabled = true;
            this.Cbomess.Location = new System.Drawing.Point(3, 3);
            this.Cbomess.Name = "Cbomess";
            this.Cbomess.Size = new System.Drawing.Size(147, 23);
            this.Cbomess.TabIndex = 0;
            // 
            // UserControl_mes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.Controls.Add(this.Cbomess);
            this.Name = "UserControl_mes";
            this.Size = new System.Drawing.Size(153, 30);
            this.Load += new System.EventHandler(this.UserControl_mes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Cbomess;
    }
}
