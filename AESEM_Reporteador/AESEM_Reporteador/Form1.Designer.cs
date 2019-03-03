namespace AESEM_Reporteador
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.STC_Texto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // STC_Texto
            // 
            this.STC_Texto.AutoSize = true;
            this.STC_Texto.Location = new System.Drawing.Point(456, 161);
            this.STC_Texto.Name = "STC_Texto";
            this.STC_Texto.Size = new System.Drawing.Size(270, 13);
            this.STC_Texto.TabIndex = 0;
            this.STC_Texto.Text = "Pequeño Label que contiene un texto bonito y coqueto.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.STC_Texto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label STC_Texto;
    }
}

