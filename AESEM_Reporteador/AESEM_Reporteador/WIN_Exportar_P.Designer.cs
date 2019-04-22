namespace AESEM_Reporteador
{
    partial class WIN_Exportar_P
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WIN_Exportar_P));
            this.BTN_Cerrar = new System.Windows.Forms.Button();
            this.BTN_Aceptar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aESEMDataSet = new AESEM_Reporteador.AESEMDataSet();
            this.eMPRESASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPRESASTableAdapter = new AESEM_Reporteador.AESEMDataSetTableAdapters.EMPRESASTableAdapter();
            this.uSUARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aESEMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPRESASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Cerrar
            // 
            this.BTN_Cerrar.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTN_Cerrar.FlatAppearance.BorderSize = 0;
            this.BTN_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Cerrar.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Cerrar.Image")));
            this.BTN_Cerrar.Location = new System.Drawing.Point(809, 467);
            this.BTN_Cerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_Cerrar.Name = "BTN_Cerrar";
            this.BTN_Cerrar.Size = new System.Drawing.Size(69, 64);
            this.BTN_Cerrar.TabIndex = 25;
            this.BTN_Cerrar.UseVisualStyleBackColor = false;
            // 
            // BTN_Aceptar
            // 
            this.BTN_Aceptar.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTN_Aceptar.FlatAppearance.BorderSize = 0;
            this.BTN_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Aceptar.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_Aceptar.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Aceptar.Image")));
            this.BTN_Aceptar.Location = new System.Drawing.Point(732, 467);
            this.BTN_Aceptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_Aceptar.Name = "BTN_Aceptar";
            this.BTN_Aceptar.Size = new System.Drawing.Size(69, 64);
            this.BTN_Aceptar.TabIndex = 24;
            this.BTN_Aceptar.UseVisualStyleBackColor = false;
            this.BTN_Aceptar.Click += new System.EventHandler(this.Pdf_Exportar);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(866, 85);
            this.dataGridView1.TabIndex = 26;
            // 
            // aESEMDataSet
            // 
            this.aESEMDataSet.DataSetName = "AESEMDataSet";
            this.aESEMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eMPRESASBindingSource
            // 
            this.eMPRESASBindingSource.DataMember = "EMPRESAS";
            this.eMPRESASBindingSource.DataSource = this.aESEMDataSet;
            // 
            // eMPRESASTableAdapter
            // 
            this.eMPRESASTableAdapter.ClearBeforeFill = true;
            // 
            // uSUARIOSBindingSource
            // 
            this.uSUARIOSBindingSource.DataMember = "USUARIOS";
            this.uSUARIOSBindingSource.DataSource = this.aESEMDataSet;
            // 
            // WIN_Exportar_P
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 554);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BTN_Cerrar);
            this.Controls.Add(this.BTN_Aceptar);
            this.Name = "WIN_Exportar_P";
            this.Text = "WIN_Exportar_P";
            this.Load += new System.EventHandler(this.WIN_Exportar_P_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aESEMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPRESASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_Aceptar;
        private System.Windows.Forms.Button BTN_Cerrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AESEMDataSet aESEMDataSet;
        private System.Windows.Forms.BindingSource eMPRESASBindingSource;
        private AESEMDataSetTableAdapters.EMPRESASTableAdapter eMPRESASTableAdapter;
        private System.Windows.Forms.BindingSource uSUARIOSBindingSource;
    }
}