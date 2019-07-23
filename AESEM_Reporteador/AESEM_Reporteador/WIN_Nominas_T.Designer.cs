namespace AESEM_Reporteador
{
    partial class BTN_Modificar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTN_Modificar));
            this.EDT_Ruta = new System.Windows.Forms.TextBox();
            this.BTN_ExportarXLS = new System.Windows.Forms.Button();
            this.BTN_ExportarPDF = new System.Windows.Forms.Button();
            this.STC_AdjuntarArchivo = new System.Windows.Forms.Label();
            this.STC_Empresa = new System.Windows.Forms.Label();
            this.DGV_Tabla = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.PANEL_Encabezado = new System.Windows.Forms.Panel();
            this.STC_Titulo = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.CBOX_Empresa = new System.Windows.Forms.ComboBox();
            this.BTN_LupaArchivo = new System.Windows.Forms.Button();
            this.BTN_Aceptar = new System.Windows.Forms.Button();
            this.clsParametrosNominaPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sindicatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lugarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Tabla)).BeginInit();
            this.PANEL_Encabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clsParametrosNominaPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // EDT_Ruta
            // 
            this.EDT_Ruta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDT_Ruta.Location = new System.Drawing.Point(160, 108);
            this.EDT_Ruta.Margin = new System.Windows.Forms.Padding(4);
            this.EDT_Ruta.Name = "EDT_Ruta";
            this.EDT_Ruta.ReadOnly = true;
            this.EDT_Ruta.Size = new System.Drawing.Size(848, 24);
            this.EDT_Ruta.TabIndex = 4;
            // 
            // BTN_ExportarXLS
            // 
            this.BTN_ExportarXLS.Location = new System.Drawing.Point(1063, 224);
            this.BTN_ExportarXLS.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_ExportarXLS.Name = "BTN_ExportarXLS";
            this.BTN_ExportarXLS.Size = new System.Drawing.Size(139, 28);
            this.BTN_ExportarXLS.TabIndex = 8;
            this.BTN_ExportarXLS.Text = "Exportar Excel";
            this.BTN_ExportarXLS.UseVisualStyleBackColor = true;
            this.BTN_ExportarXLS.Click += new System.EventHandler(this.BTN_ExportarXLS_Click);
            // 
            // BTN_ExportarPDF
            // 
            this.BTN_ExportarPDF.Location = new System.Drawing.Point(1063, 260);
            this.BTN_ExportarPDF.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_ExportarPDF.Name = "BTN_ExportarPDF";
            this.BTN_ExportarPDF.Size = new System.Drawing.Size(139, 28);
            this.BTN_ExportarPDF.TabIndex = 9;
            this.BTN_ExportarPDF.Text = "Exportar PDF";
            this.BTN_ExportarPDF.UseVisualStyleBackColor = true;
            // 
            // STC_AdjuntarArchivo
            // 
            this.STC_AdjuntarArchivo.AutoSize = true;
            this.STC_AdjuntarArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_AdjuntarArchivo.Location = new System.Drawing.Point(17, 112);
            this.STC_AdjuntarArchivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.STC_AdjuntarArchivo.Name = "STC_AdjuntarArchivo";
            this.STC_AdjuntarArchivo.Size = new System.Drawing.Size(130, 18);
            this.STC_AdjuntarArchivo.TabIndex = 10;
            this.STC_AdjuntarArchivo.Text = "Adjuntar Archivo";
            // 
            // STC_Empresa
            // 
            this.STC_Empresa.AutoSize = true;
            this.STC_Empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_Empresa.Location = new System.Drawing.Point(17, 73);
            this.STC_Empresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.STC_Empresa.Name = "STC_Empresa";
            this.STC_Empresa.Size = new System.Drawing.Size(75, 18);
            this.STC_Empresa.TabIndex = 12;
            this.STC_Empresa.Text = "Empresa";
            // 
            // DGV_Tabla
            // 
            this.DGV_Tabla.AutoGenerateColumns = false;
            this.DGV_Tabla.BackgroundColor = System.Drawing.Color.DarkGray;
            this.DGV_Tabla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Tabla.ColumnHeadersHeight = 30;
            this.DGV_Tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.sindicatoDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.periodoDataGridViewTextBoxColumn,
            this.lugarDataGridViewTextBoxColumn,
            this.logoDataGridViewImageColumn});
            this.DGV_Tabla.DataSource = this.clsParametrosNominaPBindingSource;
            this.DGV_Tabla.EnableHeadersVisualStyles = false;
            this.DGV_Tabla.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DGV_Tabla.Location = new System.Drawing.Point(21, 165);
            this.DGV_Tabla.Margin = new System.Windows.Forms.Padding(4);
            this.DGV_Tabla.Name = "DGV_Tabla";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Tabla.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Tabla.RowHeadersVisible = false;
            this.DGV_Tabla.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.DGV_Tabla.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_Tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Tabla.Size = new System.Drawing.Size(1027, 238);
            this.DGV_Tabla.TabIndex = 37;
            this.DGV_Tabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Tabla_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1132, 417);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 64);
            this.button1.TabIndex = 39;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PANEL_Encabezado
            // 
            this.PANEL_Encabezado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PANEL_Encabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PANEL_Encabezado.Controls.Add(this.STC_Titulo);
            this.PANEL_Encabezado.Location = new System.Drawing.Point(0, 0);
            this.PANEL_Encabezado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PANEL_Encabezado.Name = "PANEL_Encabezado";
            this.PANEL_Encabezado.Size = new System.Drawing.Size(1224, 48);
            this.PANEL_Encabezado.TabIndex = 40;
            // 
            // STC_Titulo
            // 
            this.STC_Titulo.AutoSize = true;
            this.STC_Titulo.Font = new System.Drawing.Font("Leelawadee", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_Titulo.ForeColor = System.Drawing.Color.White;
            this.STC_Titulo.Location = new System.Drawing.Point(12, 10);
            this.STC_Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.STC_Titulo.Name = "STC_Titulo";
            this.STC_Titulo.Size = new System.Drawing.Size(116, 29);
            this.STC_Titulo.TabIndex = 31;
            this.STC_Titulo.Text = "Nóminas";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(1057, 165);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 50);
            this.button2.TabIndex = 41;
            this.button2.Text = "Modificar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CBOX_Empresa
            // 
            this.CBOX_Empresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOX_Empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CBOX_Empresa.FormattingEnabled = true;
            this.CBOX_Empresa.Location = new System.Drawing.Point(160, 69);
            this.CBOX_Empresa.Margin = new System.Windows.Forms.Padding(4);
            this.CBOX_Empresa.Name = "CBOX_Empresa";
            this.CBOX_Empresa.Size = new System.Drawing.Size(888, 26);
            this.CBOX_Empresa.TabIndex = 42;
            this.CBOX_Empresa.SelectedIndexChanged += new System.EventHandler(this.CBOX_Empresa_SelectedIndexChanged);
            // 
            // BTN_LupaArchivo
            // 
            this.BTN_LupaArchivo.Location = new System.Drawing.Point(1017, 108);
            this.BTN_LupaArchivo.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_LupaArchivo.Name = "BTN_LupaArchivo";
            this.BTN_LupaArchivo.Size = new System.Drawing.Size(32, 30);
            this.BTN_LupaArchivo.TabIndex = 43;
            this.BTN_LupaArchivo.UseVisualStyleBackColor = true;
            this.BTN_LupaArchivo.Click += new System.EventHandler(this.BTN_LupaEmpresa_Click);
            // 
            // BTN_Aceptar
            // 
            this.BTN_Aceptar.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTN_Aceptar.FlatAppearance.BorderSize = 0;
            this.BTN_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Aceptar.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_Aceptar.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Aceptar.Image")));
            this.BTN_Aceptar.Location = new System.Drawing.Point(1063, 417);
            this.BTN_Aceptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_Aceptar.Name = "BTN_Aceptar";
            this.BTN_Aceptar.Size = new System.Drawing.Size(69, 64);
            this.BTN_Aceptar.TabIndex = 44;
            this.BTN_Aceptar.UseVisualStyleBackColor = false;
            // 
            // clsParametrosNominaPBindingSource
            // 
            this.clsParametrosNominaPBindingSource.DataSource = typeof(AESEM_Reporteador.Cls_ParametrosNomina_P);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // sindicatoDataGridViewTextBoxColumn
            // 
            this.sindicatoDataGridViewTextBoxColumn.DataPropertyName = "Sindicato";
            this.sindicatoDataGridViewTextBoxColumn.HeaderText = "Sindicato";
            this.sindicatoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sindicatoDataGridViewTextBoxColumn.Name = "sindicatoDataGridViewTextBoxColumn";
            this.sindicatoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NoCuenta";
            this.dataGridViewTextBoxColumn2.HeaderText = "NoCuenta";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Importe";
            this.dataGridViewTextBoxColumn3.HeaderText = "Importe";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // periodoDataGridViewTextBoxColumn
            // 
            this.periodoDataGridViewTextBoxColumn.DataPropertyName = "Periodo";
            this.periodoDataGridViewTextBoxColumn.HeaderText = "Periodo";
            this.periodoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.periodoDataGridViewTextBoxColumn.Name = "periodoDataGridViewTextBoxColumn";
            this.periodoDataGridViewTextBoxColumn.Width = 125;
            // 
            // lugarDataGridViewTextBoxColumn
            // 
            this.lugarDataGridViewTextBoxColumn.DataPropertyName = "Lugar";
            this.lugarDataGridViewTextBoxColumn.HeaderText = "Lugar";
            this.lugarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lugarDataGridViewTextBoxColumn.Name = "lugarDataGridViewTextBoxColumn";
            this.lugarDataGridViewTextBoxColumn.Width = 125;
            // 
            // logoDataGridViewImageColumn
            // 
            this.logoDataGridViewImageColumn.DataPropertyName = "Logo";
            this.logoDataGridViewImageColumn.HeaderText = "Logo";
            this.logoDataGridViewImageColumn.MinimumWidth = 6;
            this.logoDataGridViewImageColumn.Name = "logoDataGridViewImageColumn";
            this.logoDataGridViewImageColumn.Width = 125;
            // 
            // BTN_Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 490);
            this.Controls.Add(this.BTN_Aceptar);
            this.Controls.Add(this.BTN_LupaArchivo);
            this.Controls.Add(this.CBOX_Empresa);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PANEL_Encabezado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DGV_Tabla);
            this.Controls.Add(this.STC_Empresa);
            this.Controls.Add(this.STC_AdjuntarArchivo);
            this.Controls.Add(this.BTN_ExportarPDF);
            this.Controls.Add(this.BTN_ExportarXLS);
            this.Controls.Add(this.EDT_Ruta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "BTN_Modificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nómina";
            this.Load += new System.EventHandler(this.WIN_Nominas_T_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Tabla)).EndInit();
            this.PANEL_Encabezado.ResumeLayout(false);
            this.PANEL_Encabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clsParametrosNominaPBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox EDT_Ruta;
        private System.Windows.Forms.Button BTN_ExportarXLS;
        private System.Windows.Forms.Button BTN_ExportarPDF;
        private System.Windows.Forms.Label STC_AdjuntarArchivo;
        private System.Windows.Forms.Label STC_Empresa;
        private System.Windows.Forms.DataGridView DGV_Tabla;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel PANEL_Encabezado;
        private System.Windows.Forms.Label STC_Titulo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox CBOX_Empresa;
        private System.Windows.Forms.Button BTN_LupaArchivo;
        private System.Windows.Forms.Button BTN_Aceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNombreEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNombreSucursalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDireccionSucursalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn importeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noCuentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSucursalesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreSucuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imagesDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreSucursalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Empleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sindicatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lugarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn logoDataGridViewImageColumn;
        private System.Windows.Forms.BindingSource clsParametrosNominaPBindingSource;
    }
}