namespace AESEM_Reporteador
{
    partial class WIN_LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WIN_LogIn));
            this.LBL_Usuario = new System.Windows.Forms.Label();
            this.LBL_Contrasena = new System.Windows.Forms.Label();
            this.EDT_Contrasena = new System.Windows.Forms.TextBox();
            this.PANEL_Encabezado = new System.Windows.Forms.Panel();
            this.STC_Titulo = new System.Windows.Forms.Label();
            this.CBOX_Usuario = new System.Windows.Forms.ComboBox();
            this.BTN_ProbarConexion = new System.Windows.Forms.Button();
            this.BTN_Salir = new System.Windows.Forms.Button();
            this.BTN_Acceder = new System.Windows.Forms.Button();
            this.IMG_Logo = new System.Windows.Forms.PictureBox();
            this.IMG_Icono = new System.Windows.Forms.PictureBox();
            this.STC_MensajeConexion = new System.Windows.Forms.Label();
            this.PANEL_Encabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_Icono)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_Usuario
            // 
            this.LBL_Usuario.AutoSize = true;
            this.LBL_Usuario.Font = new System.Drawing.Font("Leelawadee", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Usuario.Location = new System.Drawing.Point(208, 51);
            this.LBL_Usuario.Name = "LBL_Usuario";
            this.LBL_Usuario.Size = new System.Drawing.Size(85, 23);
            this.LBL_Usuario.TabIndex = 1;
            this.LBL_Usuario.Text = "Usuario:";
            // 
            // LBL_Contrasena
            // 
            this.LBL_Contrasena.AutoSize = true;
            this.LBL_Contrasena.Font = new System.Drawing.Font("Leelawadee", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Contrasena.Location = new System.Drawing.Point(208, 124);
            this.LBL_Contrasena.Name = "LBL_Contrasena";
            this.LBL_Contrasena.Size = new System.Drawing.Size(116, 23);
            this.LBL_Contrasena.TabIndex = 3;
            this.LBL_Contrasena.Text = "Contraseña:";
            // 
            // EDT_Contrasena
            // 
            this.EDT_Contrasena.Font = new System.Drawing.Font("Leelawadee", 14F);
            this.EDT_Contrasena.Location = new System.Drawing.Point(212, 150);
            this.EDT_Contrasena.Name = "EDT_Contrasena";
            this.EDT_Contrasena.Size = new System.Drawing.Size(379, 30);
            this.EDT_Contrasena.TabIndex = 2;
            this.EDT_Contrasena.UseSystemPasswordChar = true;
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
            this.PANEL_Encabezado.Size = new System.Drawing.Size(604, 39);
            this.PANEL_Encabezado.TabIndex = 30;
            // 
            // STC_Titulo
            // 
            this.STC_Titulo.AutoSize = true;
            this.STC_Titulo.Font = new System.Drawing.Font("Leelawadee", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_Titulo.ForeColor = System.Drawing.Color.White;
            this.STC_Titulo.Location = new System.Drawing.Point(9, 8);
            this.STC_Titulo.Name = "STC_Titulo";
            this.STC_Titulo.Size = new System.Drawing.Size(166, 23);
            this.STC_Titulo.TabIndex = 31;
            this.STC_Titulo.Text = "Acceso al Sistema";
            // 
            // CBOX_Usuario
            // 
            this.CBOX_Usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOX_Usuario.Font = new System.Drawing.Font("Leelawadee", 14F);
            this.CBOX_Usuario.FormattingEnabled = true;
            this.CBOX_Usuario.Location = new System.Drawing.Point(212, 78);
            this.CBOX_Usuario.Name = "CBOX_Usuario";
            this.CBOX_Usuario.Size = new System.Drawing.Size(379, 31);
            this.CBOX_Usuario.TabIndex = 1;
            // 
            // BTN_ProbarConexion
            // 
            this.BTN_ProbarConexion.BackColor = System.Drawing.Color.Transparent;
            this.BTN_ProbarConexion.FlatAppearance.BorderSize = 0;
            this.BTN_ProbarConexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ProbarConexion.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ProbarConexion.Image = ((System.Drawing.Image)(resources.GetObject("BTN_ProbarConexion.Image")));
            this.BTN_ProbarConexion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_ProbarConexion.Location = new System.Drawing.Point(318, 196);
            this.BTN_ProbarConexion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_ProbarConexion.Name = "BTN_ProbarConexion";
            this.BTN_ProbarConexion.Size = new System.Drawing.Size(160, 41);
            this.BTN_ProbarConexion.TabIndex = 3;
            this.BTN_ProbarConexion.Text = "Configurar Conexión";
            this.BTN_ProbarConexion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_ProbarConexion.UseVisualStyleBackColor = false;
            this.BTN_ProbarConexion.Click += new System.EventHandler(this.BTN_ProbarConexion_Click);
            // 
            // BTN_Salir
            // 
            this.BTN_Salir.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTN_Salir.FlatAppearance.BorderSize = 0;
            this.BTN_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Salir.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_Salir.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Salir.Image")));
            this.BTN_Salir.Location = new System.Drawing.Point(540, 190);
            this.BTN_Salir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_Salir.Name = "BTN_Salir";
            this.BTN_Salir.Size = new System.Drawing.Size(52, 52);
            this.BTN_Salir.TabIndex = 5;
            this.BTN_Salir.UseVisualStyleBackColor = false;
            this.BTN_Salir.Click += new System.EventHandler(this.BTN_Salir_Click);
            // 
            // BTN_Acceder
            // 
            this.BTN_Acceder.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Acceder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTN_Acceder.FlatAppearance.BorderSize = 0;
            this.BTN_Acceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Acceder.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_Acceder.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Acceder.Image")));
            this.BTN_Acceder.Location = new System.Drawing.Point(484, 190);
            this.BTN_Acceder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_Acceder.Name = "BTN_Acceder";
            this.BTN_Acceder.Size = new System.Drawing.Size(52, 52);
            this.BTN_Acceder.TabIndex = 4;
            this.BTN_Acceder.UseVisualStyleBackColor = false;
            this.BTN_Acceder.Click += new System.EventHandler(this.BTN_Acceder_Click);
            // 
            // IMG_Logo
            // 
            this.IMG_Logo.Image = ((System.Drawing.Image)(resources.GetObject("IMG_Logo.Image")));
            this.IMG_Logo.Location = new System.Drawing.Point(21, 52);
            this.IMG_Logo.Name = "IMG_Logo";
            this.IMG_Logo.Size = new System.Drawing.Size(163, 134);
            this.IMG_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IMG_Logo.TabIndex = 0;
            this.IMG_Logo.TabStop = false;
            // 
            // IMG_Icono
            // 
            this.IMG_Icono.Image = ((System.Drawing.Image)(resources.GetObject("IMG_Icono.Image")));
            this.IMG_Icono.Location = new System.Drawing.Point(21, 192);
            this.IMG_Icono.Name = "IMG_Icono";
            this.IMG_Icono.Size = new System.Drawing.Size(52, 50);
            this.IMG_Icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IMG_Icono.TabIndex = 31;
            this.IMG_Icono.TabStop = false;
            this.IMG_Icono.Visible = false;
            // 
            // STC_MensajeConexion
            // 
            this.STC_MensajeConexion.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold);
            this.STC_MensajeConexion.Location = new System.Drawing.Point(79, 193);
            this.STC_MensajeConexion.Name = "STC_MensajeConexion";
            this.STC_MensajeConexion.Size = new System.Drawing.Size(226, 46);
            this.STC_MensajeConexion.TabIndex = 0;
            this.STC_MensajeConexion.Text = "Error en la conexión con el servidor. Favor de verificar la configuración.";
            this.STC_MensajeConexion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.STC_MensajeConexion.Visible = false;
            // 
            // WIN_LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 248);
            this.Controls.Add(this.IMG_Icono);
            this.Controls.Add(this.STC_MensajeConexion);
            this.Controls.Add(this.BTN_ProbarConexion);
            this.Controls.Add(this.CBOX_Usuario);
            this.Controls.Add(this.BTN_Salir);
            this.Controls.Add(this.BTN_Acceder);
            this.Controls.Add(this.PANEL_Encabezado);
            this.Controls.Add(this.EDT_Contrasena);
            this.Controls.Add(this.LBL_Contrasena);
            this.Controls.Add(this.LBL_Usuario);
            this.Controls.Add(this.IMG_Logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WIN_LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.WIN_LogIn_Load);
            this.PANEL_Encabezado.ResumeLayout(false);
            this.PANEL_Encabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_Icono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox IMG_Logo;
        private System.Windows.Forms.Label LBL_Usuario;
        private System.Windows.Forms.Label LBL_Contrasena;
        private System.Windows.Forms.TextBox EDT_Contrasena;
        private System.Windows.Forms.Panel PANEL_Encabezado;
        private System.Windows.Forms.Label STC_Titulo;
        private System.Windows.Forms.Button BTN_Salir;
        private System.Windows.Forms.Button BTN_Acceder;
        private System.Windows.Forms.ComboBox CBOX_Usuario;
        private System.Windows.Forms.Button BTN_ProbarConexion;
        private System.Windows.Forms.PictureBox IMG_Icono;
        private System.Windows.Forms.Label STC_MensajeConexion;
    }
}

