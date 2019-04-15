namespace AESEM_Reporteador
{
    partial class WIN_Empresas_F
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WIN_Empresas_F));
            this.PANEL_Encabezado = new System.Windows.Forms.Panel();
            this.STC_Titulo = new System.Windows.Forms.Label();
            this.BTN_Cerrar = new System.Windows.Forms.Button();
            this.BTN_Aceptar = new System.Windows.Forms.Button();
            this.BTN_LupaEmpresa = new System.Windows.Forms.Button();
            this.COMBO_TipoPago = new System.Windows.Forms.ComboBox();
            this.EDT_Comentarios = new System.Windows.Forms.TextBox();
            this.EDT_Concepto = new System.Windows.Forms.TextBox();
            this.EDT_Sindicato = new System.Windows.Forms.TextBox();
            this.EDT_Direccion = new System.Windows.Forms.TextBox();
            this.EDT_Nombre = new System.Windows.Forms.TextBox();
            this.EDT_Logo = new System.Windows.Forms.TextBox();
            this.STC_Comentarios = new System.Windows.Forms.Label();
            this.STC_Concepto = new System.Windows.Forms.Label();
            this.STC_Sindicato = new System.Windows.Forms.Label();
            this.STC_TipoPago = new System.Windows.Forms.Label();
            this.STC_Logo = new System.Windows.Forms.Label();
            this.STC_Direccion = new System.Windows.Forms.Label();
            this.STC_Nombre = new System.Windows.Forms.Label();
            this.PANEL_Encabezado.SuspendLayout();
            this.SuspendLayout();
            // 
            // PANEL_Encabezado
            // 
            this.PANEL_Encabezado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PANEL_Encabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PANEL_Encabezado.Controls.Add(this.STC_Titulo);
            this.PANEL_Encabezado.Location = new System.Drawing.Point(0, 0);
            this.PANEL_Encabezado.Name = "PANEL_Encabezado";
            this.PANEL_Encabezado.Size = new System.Drawing.Size(451, 39);
            this.PANEL_Encabezado.TabIndex = 30;
            // 
            // STC_Titulo
            // 
            this.STC_Titulo.AutoSize = true;
            this.STC_Titulo.Font = new System.Drawing.Font("Leelawadee", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_Titulo.ForeColor = System.Drawing.Color.White;
            this.STC_Titulo.Location = new System.Drawing.Point(9, 8);
            this.STC_Titulo.Name = "STC_Titulo";
            this.STC_Titulo.Size = new System.Drawing.Size(93, 23);
            this.STC_Titulo.TabIndex = 31;
            this.STC_Titulo.Text = "Empresas";
            // 
            // BTN_Cerrar
            // 
            this.BTN_Cerrar.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTN_Cerrar.FlatAppearance.BorderSize = 0;
            this.BTN_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Cerrar.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Cerrar.Image")));
            this.BTN_Cerrar.Location = new System.Drawing.Point(370, 272);
            this.BTN_Cerrar.Name = "BTN_Cerrar";
            this.BTN_Cerrar.Size = new System.Drawing.Size(52, 52);
            this.BTN_Cerrar.TabIndex = 32;
            this.BTN_Cerrar.UseVisualStyleBackColor = false;
            this.BTN_Cerrar.Click += new System.EventHandler(this.BTN_Cerrar_Click);
            // 
            // BTN_Aceptar
            // 
            this.BTN_Aceptar.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTN_Aceptar.FlatAppearance.BorderSize = 0;
            this.BTN_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Aceptar.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_Aceptar.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Aceptar.Image")));
            this.BTN_Aceptar.Location = new System.Drawing.Point(312, 272);
            this.BTN_Aceptar.Name = "BTN_Aceptar";
            this.BTN_Aceptar.Size = new System.Drawing.Size(52, 52);
            this.BTN_Aceptar.TabIndex = 31;
            this.BTN_Aceptar.UseVisualStyleBackColor = false;
            // 
            // BTN_LupaEmpresa
            // 
            this.BTN_LupaEmpresa.Location = new System.Drawing.Point(398, 58);
            this.BTN_LupaEmpresa.Name = "BTN_LupaEmpresa";
            this.BTN_LupaEmpresa.Size = new System.Drawing.Size(24, 24);
            this.BTN_LupaEmpresa.TabIndex = 47;
            this.BTN_LupaEmpresa.UseVisualStyleBackColor = true;
            // 
            // COMBO_TipoPago
            // 
            this.COMBO_TipoPago.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMBO_TipoPago.FormattingEnabled = true;
            this.COMBO_TipoPago.Location = new System.Drawing.Point(153, 145);
            this.COMBO_TipoPago.Name = "COMBO_TipoPago";
            this.COMBO_TipoPago.Size = new System.Drawing.Size(269, 23);
            this.COMBO_TipoPago.TabIndex = 46;
            // 
            // EDT_Comentarios
            // 
            this.EDT_Comentarios.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDT_Comentarios.Location = new System.Drawing.Point(153, 232);
            this.EDT_Comentarios.Name = "EDT_Comentarios";
            this.EDT_Comentarios.Size = new System.Drawing.Size(269, 23);
            this.EDT_Comentarios.TabIndex = 45;
            // 
            // EDT_Concepto
            // 
            this.EDT_Concepto.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDT_Concepto.Location = new System.Drawing.Point(153, 203);
            this.EDT_Concepto.Name = "EDT_Concepto";
            this.EDT_Concepto.Size = new System.Drawing.Size(269, 23);
            this.EDT_Concepto.TabIndex = 44;
            // 
            // EDT_Sindicato
            // 
            this.EDT_Sindicato.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDT_Sindicato.Location = new System.Drawing.Point(153, 174);
            this.EDT_Sindicato.Name = "EDT_Sindicato";
            this.EDT_Sindicato.Size = new System.Drawing.Size(269, 23);
            this.EDT_Sindicato.TabIndex = 43;
            // 
            // EDT_Direccion
            // 
            this.EDT_Direccion.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDT_Direccion.Location = new System.Drawing.Point(153, 116);
            this.EDT_Direccion.Name = "EDT_Direccion";
            this.EDT_Direccion.Size = new System.Drawing.Size(269, 23);
            this.EDT_Direccion.TabIndex = 42;
            // 
            // EDT_Nombre
            // 
            this.EDT_Nombre.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDT_Nombre.Location = new System.Drawing.Point(153, 87);
            this.EDT_Nombre.Name = "EDT_Nombre";
            this.EDT_Nombre.Size = new System.Drawing.Size(269, 23);
            this.EDT_Nombre.TabIndex = 41;
            // 
            // EDT_Logo
            // 
            this.EDT_Logo.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDT_Logo.Location = new System.Drawing.Point(153, 58);
            this.EDT_Logo.Name = "EDT_Logo";
            this.EDT_Logo.Size = new System.Drawing.Size(239, 23);
            this.EDT_Logo.TabIndex = 40;
            // 
            // STC_Comentarios
            // 
            this.STC_Comentarios.AutoSize = true;
            this.STC_Comentarios.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_Comentarios.Location = new System.Drawing.Point(30, 235);
            this.STC_Comentarios.Name = "STC_Comentarios";
            this.STC_Comentarios.Size = new System.Drawing.Size(80, 15);
            this.STC_Comentarios.TabIndex = 39;
            this.STC_Comentarios.Text = "Comentarios:";
            // 
            // STC_Concepto
            // 
            this.STC_Concepto.AutoSize = true;
            this.STC_Concepto.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_Concepto.Location = new System.Drawing.Point(29, 206);
            this.STC_Concepto.Name = "STC_Concepto";
            this.STC_Concepto.Size = new System.Drawing.Size(63, 15);
            this.STC_Concepto.TabIndex = 38;
            this.STC_Concepto.Text = "Concepto:";
            // 
            // STC_Sindicato
            // 
            this.STC_Sindicato.AutoSize = true;
            this.STC_Sindicato.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_Sindicato.Location = new System.Drawing.Point(29, 177);
            this.STC_Sindicato.Name = "STC_Sindicato";
            this.STC_Sindicato.Size = new System.Drawing.Size(61, 15);
            this.STC_Sindicato.TabIndex = 37;
            this.STC_Sindicato.Text = "Sindicato:";
            // 
            // STC_TipoPago
            // 
            this.STC_TipoPago.AutoSize = true;
            this.STC_TipoPago.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_TipoPago.Location = new System.Drawing.Point(30, 148);
            this.STC_TipoPago.Name = "STC_TipoPago";
            this.STC_TipoPago.Size = new System.Drawing.Size(81, 15);
            this.STC_TipoPago.TabIndex = 36;
            this.STC_TipoPago.Text = "Tipo de Pago:";
            // 
            // STC_Logo
            // 
            this.STC_Logo.AutoSize = true;
            this.STC_Logo.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_Logo.Location = new System.Drawing.Point(29, 58);
            this.STC_Logo.Name = "STC_Logo";
            this.STC_Logo.Size = new System.Drawing.Size(37, 15);
            this.STC_Logo.TabIndex = 35;
            this.STC_Logo.Text = "Logo:";
            // 
            // STC_Direccion
            // 
            this.STC_Direccion.AutoSize = true;
            this.STC_Direccion.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_Direccion.Location = new System.Drawing.Point(29, 119);
            this.STC_Direccion.Name = "STC_Direccion";
            this.STC_Direccion.Size = new System.Drawing.Size(63, 15);
            this.STC_Direccion.TabIndex = 34;
            this.STC_Direccion.Text = "Dirección:";
            // 
            // STC_Nombre
            // 
            this.STC_Nombre.AutoSize = true;
            this.STC_Nombre.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_Nombre.Location = new System.Drawing.Point(29, 87);
            this.STC_Nombre.Name = "STC_Nombre";
            this.STC_Nombre.Size = new System.Drawing.Size(56, 15);
            this.STC_Nombre.TabIndex = 33;
            this.STC_Nombre.Text = "Nombre:";
            // 
            // WIN_Empresas_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 348);
            this.Controls.Add(this.BTN_LupaEmpresa);
            this.Controls.Add(this.COMBO_TipoPago);
            this.Controls.Add(this.EDT_Comentarios);
            this.Controls.Add(this.EDT_Concepto);
            this.Controls.Add(this.EDT_Sindicato);
            this.Controls.Add(this.EDT_Direccion);
            this.Controls.Add(this.EDT_Nombre);
            this.Controls.Add(this.EDT_Logo);
            this.Controls.Add(this.STC_Comentarios);
            this.Controls.Add(this.STC_Concepto);
            this.Controls.Add(this.STC_Sindicato);
            this.Controls.Add(this.STC_TipoPago);
            this.Controls.Add(this.STC_Logo);
            this.Controls.Add(this.STC_Direccion);
            this.Controls.Add(this.STC_Nombre);
            this.Controls.Add(this.BTN_Cerrar);
            this.Controls.Add(this.BTN_Aceptar);
            this.Controls.Add(this.PANEL_Encabezado);
            this.Name = "WIN_Empresas_F";
            this.Text = "WIN_Empresas_F";
            this.PANEL_Encabezado.ResumeLayout(false);
            this.PANEL_Encabezado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PANEL_Encabezado;
        private System.Windows.Forms.Label STC_Titulo;
        private System.Windows.Forms.Button BTN_Cerrar;
        private System.Windows.Forms.Button BTN_Aceptar;
        private System.Windows.Forms.Button BTN_LupaEmpresa;
        private System.Windows.Forms.ComboBox COMBO_TipoPago;
        private System.Windows.Forms.TextBox EDT_Comentarios;
        private System.Windows.Forms.TextBox EDT_Concepto;
        private System.Windows.Forms.TextBox EDT_Sindicato;
        private System.Windows.Forms.TextBox EDT_Direccion;
        private System.Windows.Forms.TextBox EDT_Nombre;
        private System.Windows.Forms.TextBox EDT_Logo;
        private System.Windows.Forms.Label STC_Comentarios;
        private System.Windows.Forms.Label STC_Concepto;
        private System.Windows.Forms.Label STC_Sindicato;
        private System.Windows.Forms.Label STC_TipoPago;
        private System.Windows.Forms.Label STC_Logo;
        private System.Windows.Forms.Label STC_Direccion;
        private System.Windows.Forms.Label STC_Nombre;
    }
}