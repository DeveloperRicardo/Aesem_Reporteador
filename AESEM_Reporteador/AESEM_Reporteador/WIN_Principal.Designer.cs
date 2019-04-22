namespace AESEM_Reporteador
{
    partial class WIN_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WIN_Principal));
            this.PANEL_Encabezado = new System.Windows.Forms.Panel();
            this.STC_Titulo = new System.Windows.Forms.Label();
            this.TAB_General = new System.Windows.Forms.TabControl();
            this.TAB_Catalogos = new System.Windows.Forms.TabPage();
            this.BTN_Usuarios = new System.Windows.Forms.Button();
            this.BTN_Empresas = new System.Windows.Forms.Button();
            this.TAB_Reportes = new System.Windows.Forms.TabPage();
            this.BTN_Nominas = new System.Windows.Forms.Button();
            this.BTN_Cerrar = new System.Windows.Forms.Button();
            this.PANEL_Encabezado.SuspendLayout();
            this.TAB_General.SuspendLayout();
            this.TAB_Catalogos.SuspendLayout();
            this.TAB_Reportes.SuspendLayout();
            this.SuspendLayout();
            // 
            // PANEL_Encabezado
            // 
            this.PANEL_Encabezado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PANEL_Encabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PANEL_Encabezado.Controls.Add(this.STC_Titulo);
            this.PANEL_Encabezado.Location = new System.Drawing.Point(0, 0);
            this.PANEL_Encabezado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PANEL_Encabezado.Name = "PANEL_Encabezado";
            this.PANEL_Encabezado.Size = new System.Drawing.Size(588, 39);
            this.PANEL_Encabezado.TabIndex = 30;
            // 
            // STC_Titulo
            // 
            this.STC_Titulo.AutoSize = true;
            this.STC_Titulo.Font = new System.Drawing.Font("Leelawadee", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_Titulo.ForeColor = System.Drawing.Color.White;
            this.STC_Titulo.Location = new System.Drawing.Point(9, 8);
            this.STC_Titulo.Name = "STC_Titulo";
            this.STC_Titulo.Size = new System.Drawing.Size(91, 23);
            this.STC_Titulo.TabIndex = 31;
            this.STC_Titulo.Text = "Principal";
            // 
            // TAB_General
            // 
            this.TAB_General.Controls.Add(this.TAB_Catalogos);
            this.TAB_General.Controls.Add(this.TAB_Reportes);
            this.TAB_General.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TAB_General.Location = new System.Drawing.Point(13, 46);
            this.TAB_General.Name = "TAB_General";
            this.TAB_General.SelectedIndex = 0;
            this.TAB_General.Size = new System.Drawing.Size(558, 324);
            this.TAB_General.TabIndex = 31;
            // 
            // TAB_Catalogos
            // 
            this.TAB_Catalogos.Controls.Add(this.BTN_Usuarios);
            this.TAB_Catalogos.Controls.Add(this.BTN_Empresas);
            this.TAB_Catalogos.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TAB_Catalogos.Location = new System.Drawing.Point(4, 26);
            this.TAB_Catalogos.Name = "TAB_Catalogos";
            this.TAB_Catalogos.Padding = new System.Windows.Forms.Padding(3);
            this.TAB_Catalogos.Size = new System.Drawing.Size(550, 294);
            this.TAB_Catalogos.TabIndex = 0;
            this.TAB_Catalogos.Text = " Catálogos ";
            this.TAB_Catalogos.UseVisualStyleBackColor = true;
            // 
            // BTN_Usuarios
            // 
            this.BTN_Usuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_Usuarios.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Usuarios.ForeColor = System.Drawing.Color.White;
            this.BTN_Usuarios.Location = new System.Drawing.Point(20, 63);
            this.BTN_Usuarios.Name = "BTN_Usuarios";
            this.BTN_Usuarios.Size = new System.Drawing.Size(101, 34);
            this.BTN_Usuarios.TabIndex = 37;
            this.BTN_Usuarios.Text = "Usuarios";
            this.BTN_Usuarios.UseVisualStyleBackColor = false;
            this.BTN_Usuarios.Click += new System.EventHandler(this.BTN_Usuarios_Click);
            // 
            // BTN_Empresas
            // 
            this.BTN_Empresas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_Empresas.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Empresas.ForeColor = System.Drawing.Color.White;
            this.BTN_Empresas.Location = new System.Drawing.Point(20, 23);
            this.BTN_Empresas.Name = "BTN_Empresas";
            this.BTN_Empresas.Size = new System.Drawing.Size(101, 34);
            this.BTN_Empresas.TabIndex = 36;
            this.BTN_Empresas.Text = "Empresas";
            this.BTN_Empresas.UseVisualStyleBackColor = false;
            this.BTN_Empresas.Click += new System.EventHandler(this.BTN_Empresas_Click);
            // 
            // TAB_Reportes
            // 
            this.TAB_Reportes.Controls.Add(this.BTN_Nominas);
            this.TAB_Reportes.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TAB_Reportes.Location = new System.Drawing.Point(4, 26);
            this.TAB_Reportes.Name = "TAB_Reportes";
            this.TAB_Reportes.Padding = new System.Windows.Forms.Padding(3);
            this.TAB_Reportes.Size = new System.Drawing.Size(550, 294);
            this.TAB_Reportes.TabIndex = 1;
            this.TAB_Reportes.Text = " Reportes ";
            this.TAB_Reportes.UseVisualStyleBackColor = true;
            // 
            // BTN_Nominas
            // 
            this.BTN_Nominas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_Nominas.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Nominas.ForeColor = System.Drawing.Color.White;
            this.BTN_Nominas.Location = new System.Drawing.Point(20, 23);
            this.BTN_Nominas.Name = "BTN_Nominas";
            this.BTN_Nominas.Size = new System.Drawing.Size(101, 34);
            this.BTN_Nominas.TabIndex = 39;
            this.BTN_Nominas.Text = "Nóminas";
            this.BTN_Nominas.UseVisualStyleBackColor = false;
            this.BTN_Nominas.Click += new System.EventHandler(this.BTN_Nominas_Click);
            // 
            // BTN_Cerrar
            // 
            this.BTN_Cerrar.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTN_Cerrar.FlatAppearance.BorderSize = 0;
            this.BTN_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Cerrar.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Cerrar.Image")));
            this.BTN_Cerrar.Location = new System.Drawing.Point(519, 372);
            this.BTN_Cerrar.Name = "BTN_Cerrar";
            this.BTN_Cerrar.Size = new System.Drawing.Size(52, 52);
            this.BTN_Cerrar.TabIndex = 36;
            this.BTN_Cerrar.UseVisualStyleBackColor = false;
            this.BTN_Cerrar.Click += new System.EventHandler(this.BTN_Cerrar_Click);
            // 
            // WIN_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 432);
            this.Controls.Add(this.BTN_Cerrar);
            this.Controls.Add(this.TAB_General);
            this.Controls.Add(this.PANEL_Encabezado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WIN_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.WIN_Principal_Load);
            this.PANEL_Encabezado.ResumeLayout(false);
            this.PANEL_Encabezado.PerformLayout();
            this.TAB_General.ResumeLayout(false);
            this.TAB_Catalogos.ResumeLayout(false);
            this.TAB_Reportes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PANEL_Encabezado;
        private System.Windows.Forms.Label STC_Titulo;
        private System.Windows.Forms.TabControl TAB_General;
        private System.Windows.Forms.TabPage TAB_Catalogos;
        private System.Windows.Forms.TabPage TAB_Reportes;
        private System.Windows.Forms.Button BTN_Usuarios;
        private System.Windows.Forms.Button BTN_Empresas;
        private System.Windows.Forms.Button BTN_Nominas;
        private System.Windows.Forms.Button BTN_Cerrar;
    }
}