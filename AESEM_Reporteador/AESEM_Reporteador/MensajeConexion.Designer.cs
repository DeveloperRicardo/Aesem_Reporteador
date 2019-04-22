namespace AESEM_Reporteador
{
    partial class MensajeConexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MensajeConexion));
            this.IMG_Icono = new System.Windows.Forms.PictureBox();
            this.STC_MensajeConexion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_Icono)).BeginInit();
            this.SuspendLayout();
            // 
            // IMG_Icono
            // 
            this.IMG_Icono.Image = ((System.Drawing.Image)(resources.GetObject("IMG_Icono.Image")));
            this.IMG_Icono.Location = new System.Drawing.Point(17, 6);
            this.IMG_Icono.Name = "IMG_Icono";
            this.IMG_Icono.Size = new System.Drawing.Size(52, 50);
            this.IMG_Icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IMG_Icono.TabIndex = 33;
            this.IMG_Icono.TabStop = false;
            // 
            // STC_MensajeConexion
            // 
            this.STC_MensajeConexion.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold);
            this.STC_MensajeConexion.Location = new System.Drawing.Point(75, 7);
            this.STC_MensajeConexion.Name = "STC_MensajeConexion";
            this.STC_MensajeConexion.Size = new System.Drawing.Size(226, 46);
            this.STC_MensajeConexion.TabIndex = 32;
            this.STC_MensajeConexion.Text = "Verificando conexión con el servidor...";
            this.STC_MensajeConexion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MensajeConexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 62);
            this.Controls.Add(this.IMG_Icono);
            this.Controls.Add(this.STC_MensajeConexion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MensajeConexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AESEM";
            ((System.ComponentModel.ISupportInitialize)(this.IMG_Icono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox IMG_Icono;
        private System.Windows.Forms.Label STC_MensajeConexion;
    }
}