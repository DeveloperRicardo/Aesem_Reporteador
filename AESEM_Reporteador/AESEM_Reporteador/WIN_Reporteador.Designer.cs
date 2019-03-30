namespace AESEM_Reporteador
{
    partial class WIN_Reporteador
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
            this.IMG_Logo = new System.Windows.Forms.PictureBox();
            this.LBL_Titulo = new System.Windows.Forms.Label();
            this.BTN_Adjuntar = new System.Windows.Forms.Button();
            this.EDT_Ruta = new System.Windows.Forms.TextBox();
            this.TablaInfo = new System.Windows.Forms.DataGridView();
            this.COL_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_Sueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_Periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTN_Modificar = new System.Windows.Forms.Button();
            this.BTN_Cerrar = new System.Windows.Forms.Button();
            this.BTN_ExportarXLS = new System.Windows.Forms.Button();
            this.BTN_ExportarPDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // IMG_Logo
            // 
            this.IMG_Logo.Image = global::AESEM_Reporteador.Properties.Resources.Logo_AESEM;
            this.IMG_Logo.Location = new System.Drawing.Point(657, 12);
            this.IMG_Logo.Name = "IMG_Logo";
            this.IMG_Logo.Size = new System.Drawing.Size(89, 71);
            this.IMG_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IMG_Logo.TabIndex = 1;
            this.IMG_Logo.TabStop = false;
            // 
            // LBL_Titulo
            // 
            this.LBL_Titulo.AutoSize = true;
            this.LBL_Titulo.Font = new System.Drawing.Font("Leelawadee", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Titulo.Location = new System.Drawing.Point(12, 9);
            this.LBL_Titulo.Name = "LBL_Titulo";
            this.LBL_Titulo.Size = new System.Drawing.Size(112, 23);
            this.LBL_Titulo.TabIndex = 2;
            this.LBL_Titulo.Text = "Exportador";
            // 
            // BTN_Adjuntar
            // 
            this.BTN_Adjuntar.Location = new System.Drawing.Point(345, 86);
            this.BTN_Adjuntar.Name = "BTN_Adjuntar";
            this.BTN_Adjuntar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Adjuntar.TabIndex = 3;
            this.BTN_Adjuntar.Text = "Adjuntar";
            this.BTN_Adjuntar.UseVisualStyleBackColor = true;
            // 
            // EDT_Ruta
            // 
            this.EDT_Ruta.Location = new System.Drawing.Point(16, 86);
            this.EDT_Ruta.Name = "EDT_Ruta";
            this.EDT_Ruta.ReadOnly = true;
            this.EDT_Ruta.Size = new System.Drawing.Size(323, 20);
            this.EDT_Ruta.TabIndex = 4;
            // 
            // TablaInfo
            // 
            this.TablaInfo.AllowUserToAddRows = false;
            this.TablaInfo.AllowUserToDeleteRows = false;
            this.TablaInfo.AllowUserToOrderColumns = true;
            this.TablaInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COL_Nombre,
            this.COL_Sueldo,
            this.COL_Periodo});
            this.TablaInfo.Location = new System.Drawing.Point(16, 127);
            this.TablaInfo.Name = "TablaInfo";
            this.TablaInfo.ReadOnly = true;
            this.TablaInfo.Size = new System.Drawing.Size(620, 282);
            this.TablaInfo.TabIndex = 5;
            // 
            // COL_Nombre
            // 
            this.COL_Nombre.HeaderText = "Nombre";
            this.COL_Nombre.Name = "COL_Nombre";
            this.COL_Nombre.ReadOnly = true;
            this.COL_Nombre.Width = 200;
            // 
            // COL_Sueldo
            // 
            this.COL_Sueldo.HeaderText = "Sueldo";
            this.COL_Sueldo.Name = "COL_Sueldo";
            this.COL_Sueldo.ReadOnly = true;
            // 
            // COL_Periodo
            // 
            this.COL_Periodo.HeaderText = "Periodo";
            this.COL_Periodo.Name = "COL_Periodo";
            this.COL_Periodo.ReadOnly = true;
            // 
            // BTN_Modificar
            // 
            this.BTN_Modificar.Location = new System.Drawing.Point(642, 127);
            this.BTN_Modificar.Name = "BTN_Modificar";
            this.BTN_Modificar.Size = new System.Drawing.Size(104, 23);
            this.BTN_Modificar.TabIndex = 6;
            this.BTN_Modificar.Text = "Modificar";
            this.BTN_Modificar.UseVisualStyleBackColor = true;
            // 
            // BTN_Cerrar
            // 
            this.BTN_Cerrar.Location = new System.Drawing.Point(642, 386);
            this.BTN_Cerrar.Name = "BTN_Cerrar";
            this.BTN_Cerrar.Size = new System.Drawing.Size(104, 23);
            this.BTN_Cerrar.TabIndex = 7;
            this.BTN_Cerrar.Text = "Cerrar";
            this.BTN_Cerrar.UseVisualStyleBackColor = true;
            this.BTN_Cerrar.Click += new System.EventHandler(this.BTN_Cerrar_Click);
            // 
            // BTN_ExportarXLS
            // 
            this.BTN_ExportarXLS.Location = new System.Drawing.Point(642, 156);
            this.BTN_ExportarXLS.Name = "BTN_ExportarXLS";
            this.BTN_ExportarXLS.Size = new System.Drawing.Size(104, 23);
            this.BTN_ExportarXLS.TabIndex = 8;
            this.BTN_ExportarXLS.Text = "Exportar Excel";
            this.BTN_ExportarXLS.UseVisualStyleBackColor = true;
            // 
            // BTN_ExportarPDF
            // 
            this.BTN_ExportarPDF.Location = new System.Drawing.Point(642, 185);
            this.BTN_ExportarPDF.Name = "BTN_ExportarPDF";
            this.BTN_ExportarPDF.Size = new System.Drawing.Size(104, 23);
            this.BTN_ExportarPDF.TabIndex = 9;
            this.BTN_ExportarPDF.Text = "Exportar PDF";
            this.BTN_ExportarPDF.UseVisualStyleBackColor = true;
            // 
            // WIN_Reporteador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 421);
            this.Controls.Add(this.BTN_ExportarPDF);
            this.Controls.Add(this.BTN_ExportarXLS);
            this.Controls.Add(this.BTN_Cerrar);
            this.Controls.Add(this.BTN_Modificar);
            this.Controls.Add(this.TablaInfo);
            this.Controls.Add(this.EDT_Ruta);
            this.Controls.Add(this.BTN_Adjuntar);
            this.Controls.Add(this.LBL_Titulo);
            this.Controls.Add(this.IMG_Logo);
            this.Name = "WIN_Reporteador";
            this.Text = "Exportador";
            ((System.ComponentModel.ISupportInitialize)(this.IMG_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox IMG_Logo;
        private System.Windows.Forms.Label LBL_Titulo;
        private System.Windows.Forms.Button BTN_Adjuntar;
        private System.Windows.Forms.TextBox EDT_Ruta;
        private System.Windows.Forms.DataGridView TablaInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_Sueldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_Periodo;
        private System.Windows.Forms.Button BTN_Modificar;
        private System.Windows.Forms.Button BTN_Cerrar;
        private System.Windows.Forms.Button BTN_ExportarXLS;
        private System.Windows.Forms.Button BTN_ExportarPDF;
    }
}