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
            this.EDT_Comentarios = new System.Windows.Forms.TextBox();
            this.EDT_Concepto = new System.Windows.Forms.TextBox();
            this.EDT_Sindicato = new System.Windows.Forms.TextBox();
            this.EDT_Direccion = new System.Windows.Forms.TextBox();
            this.EDT_Nombre = new System.Windows.Forms.TextBox();
            this.EDT_Logo = new System.Windows.Forms.TextBox();
            this.STC_Comentarios = new System.Windows.Forms.Label();
            this.STC_Concepto = new System.Windows.Forms.Label();
            this.STC_Sindicato = new System.Windows.Forms.Label();
            this.STC_Direccion = new System.Windows.Forms.Label();
            this.STC_Nombre = new System.Windows.Forms.Label();
            this.GB_Opciones = new System.Windows.Forms.GroupBox();
            this.RADIO_Mensual = new System.Windows.Forms.RadioButton();
            this.RADIO_Quincenal = new System.Windows.Forms.RadioButton();
            this.RADIO_Catorcenal = new System.Windows.Forms.RadioButton();
            this.RADIO_Semanal = new System.Windows.Forms.RadioButton();
            this.GB_Logo = new System.Windows.Forms.GroupBox();
            this.IMG_Logo = new System.Windows.Forms.PictureBox();
            this.STC_RutaImagen = new System.Windows.Forms.Label();
            this.PANEL_Encabezado.SuspendLayout();
            this.GB_Opciones.SuspendLayout();
            this.GB_Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_Logo)).BeginInit();
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
            this.PANEL_Encabezado.Size = new System.Drawing.Size(750, 39);
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
            this.BTN_Cerrar.Location = new System.Drawing.Point(680, 277);
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
            this.BTN_Aceptar.Location = new System.Drawing.Point(622, 277);
            this.BTN_Aceptar.Name = "BTN_Aceptar";
            this.BTN_Aceptar.Size = new System.Drawing.Size(52, 52);
            this.BTN_Aceptar.TabIndex = 31;
            this.BTN_Aceptar.UseVisualStyleBackColor = false;
            this.BTN_Aceptar.Click += new System.EventHandler(this.BTN_Aceptar_Click);
            // 
            // BTN_LupaEmpresa
            // 
            this.BTN_LupaEmpresa.Location = new System.Drawing.Point(323, 28);
            this.BTN_LupaEmpresa.Name = "BTN_LupaEmpresa";
            this.BTN_LupaEmpresa.Size = new System.Drawing.Size(24, 24);
            this.BTN_LupaEmpresa.TabIndex = 47;
            this.BTN_LupaEmpresa.UseVisualStyleBackColor = true;
            // 
            // EDT_Comentarios
            // 
            this.EDT_Comentarios.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDT_Comentarios.Location = new System.Drawing.Point(20, 217);
            this.EDT_Comentarios.Multiline = true;
            this.EDT_Comentarios.Name = "EDT_Comentarios";
            this.EDT_Comentarios.Size = new System.Drawing.Size(353, 54);
            this.EDT_Comentarios.TabIndex = 45;
            // 
            // EDT_Concepto
            // 
            this.EDT_Concepto.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDT_Concepto.Location = new System.Drawing.Point(379, 217);
            this.EDT_Concepto.Multiline = true;
            this.EDT_Concepto.Name = "EDT_Concepto";
            this.EDT_Concepto.Size = new System.Drawing.Size(353, 54);
            this.EDT_Concepto.TabIndex = 44;
            // 
            // EDT_Sindicato
            // 
            this.EDT_Sindicato.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDT_Sindicato.Location = new System.Drawing.Point(104, 110);
            this.EDT_Sindicato.Name = "EDT_Sindicato";
            this.EDT_Sindicato.Size = new System.Drawing.Size(269, 23);
            this.EDT_Sindicato.TabIndex = 43;
            // 
            // EDT_Direccion
            // 
            this.EDT_Direccion.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDT_Direccion.Location = new System.Drawing.Point(104, 81);
            this.EDT_Direccion.Name = "EDT_Direccion";
            this.EDT_Direccion.Size = new System.Drawing.Size(269, 23);
            this.EDT_Direccion.TabIndex = 42;
            // 
            // EDT_Nombre
            // 
            this.EDT_Nombre.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDT_Nombre.Location = new System.Drawing.Point(104, 52);
            this.EDT_Nombre.Name = "EDT_Nombre";
            this.EDT_Nombre.Size = new System.Drawing.Size(269, 23);
            this.EDT_Nombre.TabIndex = 41;
            // 
            // EDT_Logo
            // 
            this.EDT_Logo.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDT_Logo.Location = new System.Drawing.Point(48, 29);
            this.EDT_Logo.Name = "EDT_Logo";
            this.EDT_Logo.ReadOnly = true;
            this.EDT_Logo.Size = new System.Drawing.Size(268, 23);
            this.EDT_Logo.TabIndex = 40;
            // 
            // STC_Comentarios
            // 
            this.STC_Comentarios.AutoSize = true;
            this.STC_Comentarios.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_Comentarios.Location = new System.Drawing.Point(17, 199);
            this.STC_Comentarios.Name = "STC_Comentarios";
            this.STC_Comentarios.Size = new System.Drawing.Size(80, 15);
            this.STC_Comentarios.TabIndex = 39;
            this.STC_Comentarios.Text = "Comentarios:";
            // 
            // STC_Concepto
            // 
            this.STC_Concepto.AutoSize = true;
            this.STC_Concepto.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_Concepto.Location = new System.Drawing.Point(376, 199);
            this.STC_Concepto.Name = "STC_Concepto";
            this.STC_Concepto.Size = new System.Drawing.Size(63, 15);
            this.STC_Concepto.TabIndex = 38;
            this.STC_Concepto.Text = "Concepto:";
            // 
            // STC_Sindicato
            // 
            this.STC_Sindicato.AutoSize = true;
            this.STC_Sindicato.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_Sindicato.Location = new System.Drawing.Point(19, 113);
            this.STC_Sindicato.Name = "STC_Sindicato";
            this.STC_Sindicato.Size = new System.Drawing.Size(61, 15);
            this.STC_Sindicato.TabIndex = 37;
            this.STC_Sindicato.Text = "Sindicato:";
            // 
            // STC_Direccion
            // 
            this.STC_Direccion.AutoSize = true;
            this.STC_Direccion.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_Direccion.Location = new System.Drawing.Point(19, 84);
            this.STC_Direccion.Name = "STC_Direccion";
            this.STC_Direccion.Size = new System.Drawing.Size(63, 15);
            this.STC_Direccion.TabIndex = 34;
            this.STC_Direccion.Text = "Dirección:";
            // 
            // STC_Nombre
            // 
            this.STC_Nombre.AutoSize = true;
            this.STC_Nombre.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_Nombre.Location = new System.Drawing.Point(19, 52);
            this.STC_Nombre.Name = "STC_Nombre";
            this.STC_Nombre.Size = new System.Drawing.Size(56, 15);
            this.STC_Nombre.TabIndex = 33;
            this.STC_Nombre.Text = "Nombre:";
            // 
            // GB_Opciones
            // 
            this.GB_Opciones.Controls.Add(this.RADIO_Mensual);
            this.GB_Opciones.Controls.Add(this.RADIO_Quincenal);
            this.GB_Opciones.Controls.Add(this.RADIO_Catorcenal);
            this.GB_Opciones.Controls.Add(this.RADIO_Semanal);
            this.GB_Opciones.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_Opciones.Location = new System.Drawing.Point(20, 139);
            this.GB_Opciones.Name = "GB_Opciones";
            this.GB_Opciones.Size = new System.Drawing.Size(353, 57);
            this.GB_Opciones.TabIndex = 48;
            this.GB_Opciones.TabStop = false;
            this.GB_Opciones.Text = "Tipo de pago";
            // 
            // RADIO_Mensual
            // 
            this.RADIO_Mensual.AutoSize = true;
            this.RADIO_Mensual.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RADIO_Mensual.Location = new System.Drawing.Point(275, 23);
            this.RADIO_Mensual.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RADIO_Mensual.Name = "RADIO_Mensual";
            this.RADIO_Mensual.Size = new System.Drawing.Size(70, 19);
            this.RADIO_Mensual.TabIndex = 35;
            this.RADIO_Mensual.TabStop = true;
            this.RADIO_Mensual.Text = "Mensual";
            this.RADIO_Mensual.UseVisualStyleBackColor = true;
            // 
            // RADIO_Quincenal
            // 
            this.RADIO_Quincenal.AutoSize = true;
            this.RADIO_Quincenal.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RADIO_Quincenal.Location = new System.Drawing.Point(184, 23);
            this.RADIO_Quincenal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RADIO_Quincenal.Name = "RADIO_Quincenal";
            this.RADIO_Quincenal.Size = new System.Drawing.Size(79, 19);
            this.RADIO_Quincenal.TabIndex = 34;
            this.RADIO_Quincenal.TabStop = true;
            this.RADIO_Quincenal.Text = "Quincenal";
            this.RADIO_Quincenal.UseVisualStyleBackColor = true;
            // 
            // RADIO_Catorcenal
            // 
            this.RADIO_Catorcenal.AutoSize = true;
            this.RADIO_Catorcenal.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RADIO_Catorcenal.Location = new System.Drawing.Point(90, 23);
            this.RADIO_Catorcenal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RADIO_Catorcenal.Name = "RADIO_Catorcenal";
            this.RADIO_Catorcenal.Size = new System.Drawing.Size(82, 19);
            this.RADIO_Catorcenal.TabIndex = 33;
            this.RADIO_Catorcenal.TabStop = true;
            this.RADIO_Catorcenal.Text = "Catorcenal";
            this.RADIO_Catorcenal.UseVisualStyleBackColor = true;
            // 
            // RADIO_Semanal
            // 
            this.RADIO_Semanal.AutoSize = true;
            this.RADIO_Semanal.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RADIO_Semanal.Location = new System.Drawing.Point(8, 23);
            this.RADIO_Semanal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RADIO_Semanal.Name = "RADIO_Semanal";
            this.RADIO_Semanal.Size = new System.Drawing.Size(70, 19);
            this.RADIO_Semanal.TabIndex = 32;
            this.RADIO_Semanal.TabStop = true;
            this.RADIO_Semanal.Text = "Semanal";
            this.RADIO_Semanal.UseVisualStyleBackColor = true;
            // 
            // GB_Logo
            // 
            this.GB_Logo.Controls.Add(this.IMG_Logo);
            this.GB_Logo.Controls.Add(this.STC_RutaImagen);
            this.GB_Logo.Controls.Add(this.EDT_Logo);
            this.GB_Logo.Controls.Add(this.BTN_LupaEmpresa);
            this.GB_Logo.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_Logo.Location = new System.Drawing.Point(379, 52);
            this.GB_Logo.Name = "GB_Logo";
            this.GB_Logo.Size = new System.Drawing.Size(353, 144);
            this.GB_Logo.TabIndex = 49;
            this.GB_Logo.TabStop = false;
            this.GB_Logo.Text = "Logo";
            // 
            // IMG_Logo
            // 
            this.IMG_Logo.Location = new System.Drawing.Point(138, 59);
            this.IMG_Logo.Name = "IMG_Logo";
            this.IMG_Logo.Size = new System.Drawing.Size(77, 77);
            this.IMG_Logo.TabIndex = 51;
            this.IMG_Logo.TabStop = false;
            // 
            // STC_RutaImagen
            // 
            this.STC_RutaImagen.AutoSize = true;
            this.STC_RutaImagen.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_RutaImagen.Location = new System.Drawing.Point(6, 32);
            this.STC_RutaImagen.Name = "STC_RutaImagen";
            this.STC_RutaImagen.Size = new System.Drawing.Size(36, 15);
            this.STC_RutaImagen.TabIndex = 50;
            this.STC_RutaImagen.Text = "Ruta:";
            // 
            // WIN_Empresas_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 336);
            this.Controls.Add(this.GB_Logo);
            this.Controls.Add(this.GB_Opciones);
            this.Controls.Add(this.EDT_Comentarios);
            this.Controls.Add(this.EDT_Concepto);
            this.Controls.Add(this.EDT_Sindicato);
            this.Controls.Add(this.EDT_Direccion);
            this.Controls.Add(this.EDT_Nombre);
            this.Controls.Add(this.STC_Comentarios);
            this.Controls.Add(this.STC_Concepto);
            this.Controls.Add(this.STC_Sindicato);
            this.Controls.Add(this.STC_Direccion);
            this.Controls.Add(this.STC_Nombre);
            this.Controls.Add(this.BTN_Cerrar);
            this.Controls.Add(this.BTN_Aceptar);
            this.Controls.Add(this.PANEL_Encabezado);
            this.Name = "WIN_Empresas_F";
            this.Text = "WIN_Empresas_F";
            this.PANEL_Encabezado.ResumeLayout(false);
            this.PANEL_Encabezado.PerformLayout();
            this.GB_Opciones.ResumeLayout(false);
            this.GB_Opciones.PerformLayout();
            this.GB_Logo.ResumeLayout(false);
            this.GB_Logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PANEL_Encabezado;
        private System.Windows.Forms.Label STC_Titulo;
        private System.Windows.Forms.Button BTN_Cerrar;
        private System.Windows.Forms.Button BTN_Aceptar;
        private System.Windows.Forms.Button BTN_LupaEmpresa;
        private System.Windows.Forms.TextBox EDT_Comentarios;
        private System.Windows.Forms.TextBox EDT_Concepto;
        private System.Windows.Forms.TextBox EDT_Sindicato;
        private System.Windows.Forms.TextBox EDT_Direccion;
        private System.Windows.Forms.TextBox EDT_Nombre;
        private System.Windows.Forms.TextBox EDT_Logo;
        private System.Windows.Forms.Label STC_Comentarios;
        private System.Windows.Forms.Label STC_Concepto;
        private System.Windows.Forms.Label STC_Sindicato;
        private System.Windows.Forms.Label STC_Direccion;
        private System.Windows.Forms.Label STC_Nombre;
        private System.Windows.Forms.GroupBox GB_Opciones;
        private System.Windows.Forms.RadioButton RADIO_Mensual;
        private System.Windows.Forms.RadioButton RADIO_Quincenal;
        private System.Windows.Forms.RadioButton RADIO_Catorcenal;
        private System.Windows.Forms.RadioButton RADIO_Semanal;
        private System.Windows.Forms.GroupBox GB_Logo;
        private System.Windows.Forms.PictureBox IMG_Logo;
        private System.Windows.Forms.Label STC_RutaImagen;
    }
}