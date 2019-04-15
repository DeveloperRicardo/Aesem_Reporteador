namespace AESEM_Reporteador
{
    partial class WIN_Nominas_T
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
            this.STC_Titulo = new System.Windows.Forms.Label();
            this.BTN_Adjuntar = new System.Windows.Forms.Button();
            this.EDT_Ruta = new System.Windows.Forms.TextBox();
            this.DGV_TablaNominas = new System.Windows.Forms.DataGridView();
            this.COL_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_Periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTN_Modificar = new System.Windows.Forms.Button();
            this.BTN_Cerrar = new System.Windows.Forms.Button();
            this.BTN_ExportarXLS = new System.Windows.Forms.Button();
            this.BTN_ExportarPDF = new System.Windows.Forms.Button();
            this.STC_AdjuntarArchivo = new System.Windows.Forms.Label();
            this.EDT_Empresa = new System.Windows.Forms.TextBox();
            this.STC_Empresa = new System.Windows.Forms.Label();
            this.BTN_LupaEmpresa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TablaNominas)).BeginInit();
            this.SuspendLayout();
            // 
            // STC_Titulo
            // 
            this.STC_Titulo.AutoSize = true;
            this.STC_Titulo.Font = new System.Drawing.Font("Leelawadee", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_Titulo.Location = new System.Drawing.Point(13, 9);
            this.STC_Titulo.Name = "STC_Titulo";
            this.STC_Titulo.Size = new System.Drawing.Size(90, 23);
            this.STC_Titulo.TabIndex = 2;
            this.STC_Titulo.Text = "Nóminas";
            // 
            // BTN_Adjuntar
            // 
            this.BTN_Adjuntar.Location = new System.Drawing.Point(562, 88);
            this.BTN_Adjuntar.Name = "BTN_Adjuntar";
            this.BTN_Adjuntar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Adjuntar.TabIndex = 3;
            this.BTN_Adjuntar.Text = "Adjuntar";
            this.BTN_Adjuntar.UseVisualStyleBackColor = true;
            this.BTN_Adjuntar.Click += new System.EventHandler(this.BTN_Adjuntar_Click);
            // 
            // EDT_Ruta
            // 
            this.EDT_Ruta.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDT_Ruta.Location = new System.Drawing.Point(121, 88);
            this.EDT_Ruta.Name = "EDT_Ruta";
            this.EDT_Ruta.ReadOnly = true;
            this.EDT_Ruta.Size = new System.Drawing.Size(435, 23);
            this.EDT_Ruta.TabIndex = 4;
            // 
            // DGV_TablaNominas
            // 
            this.DGV_TablaNominas.AllowUserToAddRows = false;
            this.DGV_TablaNominas.AllowUserToDeleteRows = false;
            this.DGV_TablaNominas.AllowUserToOrderColumns = true;
            this.DGV_TablaNominas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_TablaNominas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COL_Nombre,
            this.COL_Cuenta,
            this.COL_Importe,
            this.COL_Periodo});
            this.DGV_TablaNominas.Location = new System.Drawing.Point(17, 116);
            this.DGV_TablaNominas.Name = "DGV_TablaNominas";
            this.DGV_TablaNominas.ReadOnly = true;
            this.DGV_TablaNominas.Size = new System.Drawing.Size(620, 253);
            this.DGV_TablaNominas.TabIndex = 5;
            // 
            // COL_Nombre
            // 
            this.COL_Nombre.HeaderText = "Nombre";
            this.COL_Nombre.Name = "COL_Nombre";
            this.COL_Nombre.ReadOnly = true;
            this.COL_Nombre.Width = 200;
            // 
            // COL_Cuenta
            // 
            this.COL_Cuenta.HeaderText = "Cuenta";
            this.COL_Cuenta.Name = "COL_Cuenta";
            this.COL_Cuenta.ReadOnly = true;
            // 
            // COL_Importe
            // 
            this.COL_Importe.HeaderText = "Importe";
            this.COL_Importe.Name = "COL_Importe";
            this.COL_Importe.ReadOnly = true;
            // 
            // COL_Periodo
            // 
            this.COL_Periodo.HeaderText = "Periodo";
            this.COL_Periodo.Name = "COL_Periodo";
            this.COL_Periodo.ReadOnly = true;
            // 
            // BTN_Modificar
            // 
            this.BTN_Modificar.Location = new System.Drawing.Point(642, 87);
            this.BTN_Modificar.Name = "BTN_Modificar";
            this.BTN_Modificar.Size = new System.Drawing.Size(104, 23);
            this.BTN_Modificar.TabIndex = 6;
            this.BTN_Modificar.Text = "Modificar";
            this.BTN_Modificar.UseVisualStyleBackColor = true;
            // 
            // BTN_Cerrar
            // 
            this.BTN_Cerrar.Location = new System.Drawing.Point(643, 174);
            this.BTN_Cerrar.Name = "BTN_Cerrar";
            this.BTN_Cerrar.Size = new System.Drawing.Size(104, 23);
            this.BTN_Cerrar.TabIndex = 7;
            this.BTN_Cerrar.Text = "Cerrar";
            this.BTN_Cerrar.UseVisualStyleBackColor = true;
            this.BTN_Cerrar.Click += new System.EventHandler(this.BTN_Cerrar_Click);
            // 
            // BTN_ExportarXLS
            // 
            this.BTN_ExportarXLS.Location = new System.Drawing.Point(642, 116);
            this.BTN_ExportarXLS.Name = "BTN_ExportarXLS";
            this.BTN_ExportarXLS.Size = new System.Drawing.Size(104, 23);
            this.BTN_ExportarXLS.TabIndex = 8;
            this.BTN_ExportarXLS.Text = "Exportar Excel";
            this.BTN_ExportarXLS.UseVisualStyleBackColor = true;
            // 
            // BTN_ExportarPDF
            // 
            this.BTN_ExportarPDF.Location = new System.Drawing.Point(642, 145);
            this.BTN_ExportarPDF.Name = "BTN_ExportarPDF";
            this.BTN_ExportarPDF.Size = new System.Drawing.Size(104, 23);
            this.BTN_ExportarPDF.TabIndex = 9;
            this.BTN_ExportarPDF.Text = "Exportar PDF";
            this.BTN_ExportarPDF.UseVisualStyleBackColor = true;
            // 
            // STC_AdjuntarArchivo
            // 
            this.STC_AdjuntarArchivo.AutoSize = true;
            this.STC_AdjuntarArchivo.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_AdjuntarArchivo.Location = new System.Drawing.Point(14, 91);
            this.STC_AdjuntarArchivo.Name = "STC_AdjuntarArchivo";
            this.STC_AdjuntarArchivo.Size = new System.Drawing.Size(101, 15);
            this.STC_AdjuntarArchivo.TabIndex = 10;
            this.STC_AdjuntarArchivo.Text = "Adjuntar Archivo";
            // 
            // EDT_Empresa
            // 
            this.EDT_Empresa.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDT_Empresa.Location = new System.Drawing.Point(121, 59);
            this.EDT_Empresa.Name = "EDT_Empresa";
            this.EDT_Empresa.Size = new System.Drawing.Size(269, 23);
            this.EDT_Empresa.TabIndex = 11;
            // 
            // STC_Empresa
            // 
            this.STC_Empresa.AutoSize = true;
            this.STC_Empresa.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_Empresa.Location = new System.Drawing.Point(14, 59);
            this.STC_Empresa.Name = "STC_Empresa";
            this.STC_Empresa.Size = new System.Drawing.Size(54, 15);
            this.STC_Empresa.TabIndex = 12;
            this.STC_Empresa.Text = "Empresa";
            // 
            // BTN_LupaEmpresa
            // 
            this.BTN_LupaEmpresa.Location = new System.Drawing.Point(396, 59);
            this.BTN_LupaEmpresa.Name = "BTN_LupaEmpresa";
            this.BTN_LupaEmpresa.Size = new System.Drawing.Size(24, 24);
            this.BTN_LupaEmpresa.TabIndex = 13;
            this.BTN_LupaEmpresa.UseVisualStyleBackColor = true;
            this.BTN_LupaEmpresa.Click += new System.EventHandler(this.BTN_LupaEmpresa_Click);
            // 
            // WIN_Nominas_T
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 388);
            this.Controls.Add(this.BTN_LupaEmpresa);
            this.Controls.Add(this.STC_Empresa);
            this.Controls.Add(this.EDT_Empresa);
            this.Controls.Add(this.STC_AdjuntarArchivo);
            this.Controls.Add(this.BTN_ExportarPDF);
            this.Controls.Add(this.BTN_ExportarXLS);
            this.Controls.Add(this.BTN_Cerrar);
            this.Controls.Add(this.BTN_Modificar);
            this.Controls.Add(this.DGV_TablaNominas);
            this.Controls.Add(this.EDT_Ruta);
            this.Controls.Add(this.BTN_Adjuntar);
            this.Controls.Add(this.STC_Titulo);
            this.Name = "WIN_Nominas_T";
            this.Text = "Exportador";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TablaNominas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label STC_Titulo;
        private System.Windows.Forms.Button BTN_Adjuntar;
        private System.Windows.Forms.TextBox EDT_Ruta;
        private System.Windows.Forms.DataGridView DGV_TablaNominas;
        private System.Windows.Forms.Button BTN_Modificar;
        private System.Windows.Forms.Button BTN_Cerrar;
        private System.Windows.Forms.Button BTN_ExportarXLS;
        private System.Windows.Forms.Button BTN_ExportarPDF;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_Periodo;
        private System.Windows.Forms.Label STC_AdjuntarArchivo;
        private System.Windows.Forms.TextBox EDT_Empresa;
        private System.Windows.Forms.Label STC_Empresa;
        private System.Windows.Forms.Button BTN_LupaEmpresa;
    }
}