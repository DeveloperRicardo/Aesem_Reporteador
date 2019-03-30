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
            this.IMG_Logo = new System.Windows.Forms.PictureBox();
            this.LBL_Usuario = new System.Windows.Forms.Label();
            this.EDT_Usuario = new System.Windows.Forms.TextBox();
            this.LBL_Contrasena = new System.Windows.Forms.Label();
            this.EDT_Contrasena = new System.Windows.Forms.TextBox();
            this.BTN_Acceder = new System.Windows.Forms.Button();
            this.BTN_Registrar = new System.Windows.Forms.Button();
            this.BTN_Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // IMG_Logo
            // 
            this.IMG_Logo.Image = global::AESEM_Reporteador.Properties.Resources.Logo_AESEM;
            this.IMG_Logo.Location = new System.Drawing.Point(12, 12);
            this.IMG_Logo.Name = "IMG_Logo";
            this.IMG_Logo.Size = new System.Drawing.Size(333, 268);
            this.IMG_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IMG_Logo.TabIndex = 0;
            this.IMG_Logo.TabStop = false;
            // 
            // LBL_Usuario
            // 
            this.LBL_Usuario.AutoSize = true;
            this.LBL_Usuario.Font = new System.Drawing.Font("Leelawadee", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Usuario.Location = new System.Drawing.Point(370, 55);
            this.LBL_Usuario.Name = "LBL_Usuario";
            this.LBL_Usuario.Size = new System.Drawing.Size(85, 23);
            this.LBL_Usuario.TabIndex = 1;
            this.LBL_Usuario.Text = "Usuario:";
            // 
            // EDT_Usuario
            // 
            this.EDT_Usuario.Font = new System.Drawing.Font("Leelawadee", 14F);
            this.EDT_Usuario.Location = new System.Drawing.Point(374, 81);
            this.EDT_Usuario.Name = "EDT_Usuario";
            this.EDT_Usuario.Size = new System.Drawing.Size(253, 30);
            this.EDT_Usuario.TabIndex = 2;
            // 
            // LBL_Contrasena
            // 
            this.LBL_Contrasena.AutoSize = true;
            this.LBL_Contrasena.Font = new System.Drawing.Font("Leelawadee", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Contrasena.Location = new System.Drawing.Point(370, 140);
            this.LBL_Contrasena.Name = "LBL_Contrasena";
            this.LBL_Contrasena.Size = new System.Drawing.Size(116, 23);
            this.LBL_Contrasena.TabIndex = 3;
            this.LBL_Contrasena.Text = "Contraseña:";
            // 
            // EDT_Contrasena
            // 
            this.EDT_Contrasena.Font = new System.Drawing.Font("Leelawadee", 14F);
            this.EDT_Contrasena.Location = new System.Drawing.Point(374, 166);
            this.EDT_Contrasena.Name = "EDT_Contrasena";
            this.EDT_Contrasena.Size = new System.Drawing.Size(253, 30);
            this.EDT_Contrasena.TabIndex = 4;
            this.EDT_Contrasena.UseSystemPasswordChar = true;
            // 
            // BTN_Acceder
            // 
            this.BTN_Acceder.Location = new System.Drawing.Point(471, 241);
            this.BTN_Acceder.Name = "BTN_Acceder";
            this.BTN_Acceder.Size = new System.Drawing.Size(75, 23);
            this.BTN_Acceder.TabIndex = 5;
            this.BTN_Acceder.Text = "Acceder";
            this.BTN_Acceder.UseVisualStyleBackColor = true;
            this.BTN_Acceder.Click += new System.EventHandler(this.BTN_Acceder_Click);
            // 
            // BTN_Registrar
            // 
            this.BTN_Registrar.Location = new System.Drawing.Point(390, 241);
            this.BTN_Registrar.Name = "BTN_Registrar";
            this.BTN_Registrar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Registrar.TabIndex = 6;
            this.BTN_Registrar.Text = "Registrar";
            this.BTN_Registrar.UseVisualStyleBackColor = true;
            this.BTN_Registrar.Click += new System.EventHandler(this.BTN_Registrar_Click);
            // 
            // BTN_Salir
            // 
            this.BTN_Salir.Location = new System.Drawing.Point(552, 241);
            this.BTN_Salir.Name = "BTN_Salir";
            this.BTN_Salir.Size = new System.Drawing.Size(75, 23);
            this.BTN_Salir.TabIndex = 7;
            this.BTN_Salir.Text = "Salir";
            this.BTN_Salir.UseVisualStyleBackColor = true;
            this.BTN_Salir.Click += new System.EventHandler(this.BTN_Salir_Click);
            // 
            // WIN_LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 292);
            this.Controls.Add(this.BTN_Salir);
            this.Controls.Add(this.BTN_Registrar);
            this.Controls.Add(this.BTN_Acceder);
            this.Controls.Add(this.EDT_Contrasena);
            this.Controls.Add(this.LBL_Contrasena);
            this.Controls.Add(this.EDT_Usuario);
            this.Controls.Add(this.LBL_Usuario);
            this.Controls.Add(this.IMG_Logo);
            this.Name = "WIN_LogIn";
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.WIN_LogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IMG_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox IMG_Logo;
        private System.Windows.Forms.Label LBL_Usuario;
        private System.Windows.Forms.TextBox EDT_Usuario;
        private System.Windows.Forms.Label LBL_Contrasena;
        private System.Windows.Forms.TextBox EDT_Contrasena;
        private System.Windows.Forms.Button BTN_Acceder;
        private System.Windows.Forms.Button BTN_Registrar;
        private System.Windows.Forms.Button BTN_Salir;
    }
}

