namespace AESEM_Reporteador
{
    partial class WIN_Login_F
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
            this.EDT_Servidor = new System.Windows.Forms.TextBox();
            this.LBL_Servidor = new System.Windows.Forms.Label();
            this.EDT_Usuario = new System.Windows.Forms.TextBox();
            this.LBL_Usuario = new System.Windows.Forms.Label();
            this.EDT_Contrasena = new System.Windows.Forms.TextBox();
            this.LBL_Contraseña = new System.Windows.Forms.Label();
            this.BTN_ProbarConexion = new System.Windows.Forms.Button();
            this.BTN_Guardar = new System.Windows.Forms.Button();
            this.LBL_BD = new System.Windows.Forms.Label();
            this.EDT_BD = new System.Windows.Forms.TextBox();
            this.BTN_Tablas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EDT_Servidor
            // 
            this.EDT_Servidor.Font = new System.Drawing.Font("Leelawadee", 14F);
            this.EDT_Servidor.Location = new System.Drawing.Point(16, 35);
            this.EDT_Servidor.Name = "EDT_Servidor";
            this.EDT_Servidor.Size = new System.Drawing.Size(356, 30);
            this.EDT_Servidor.TabIndex = 4;
            // 
            // LBL_Servidor
            // 
            this.LBL_Servidor.AutoSize = true;
            this.LBL_Servidor.Font = new System.Drawing.Font("Leelawadee", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Servidor.Location = new System.Drawing.Point(12, 9);
            this.LBL_Servidor.Name = "LBL_Servidor";
            this.LBL_Servidor.Size = new System.Drawing.Size(92, 23);
            this.LBL_Servidor.TabIndex = 3;
            this.LBL_Servidor.Text = "Servidor:";
            // 
            // EDT_Usuario
            // 
            this.EDT_Usuario.Font = new System.Drawing.Font("Leelawadee", 14F);
            this.EDT_Usuario.Location = new System.Drawing.Point(16, 165);
            this.EDT_Usuario.Name = "EDT_Usuario";
            this.EDT_Usuario.Size = new System.Drawing.Size(356, 30);
            this.EDT_Usuario.TabIndex = 6;
            // 
            // LBL_Usuario
            // 
            this.LBL_Usuario.AutoSize = true;
            this.LBL_Usuario.Font = new System.Drawing.Font("Leelawadee", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Usuario.Location = new System.Drawing.Point(12, 139);
            this.LBL_Usuario.Name = "LBL_Usuario";
            this.LBL_Usuario.Size = new System.Drawing.Size(85, 23);
            this.LBL_Usuario.TabIndex = 5;
            this.LBL_Usuario.Text = "Usuario:";
            // 
            // EDT_Contrasena
            // 
            this.EDT_Contrasena.Font = new System.Drawing.Font("Leelawadee", 14F);
            this.EDT_Contrasena.Location = new System.Drawing.Point(16, 233);
            this.EDT_Contrasena.Name = "EDT_Contrasena";
            this.EDT_Contrasena.PasswordChar = '*';
            this.EDT_Contrasena.Size = new System.Drawing.Size(356, 30);
            this.EDT_Contrasena.TabIndex = 8;
            // 
            // LBL_Contraseña
            // 
            this.LBL_Contraseña.AutoSize = true;
            this.LBL_Contraseña.Font = new System.Drawing.Font("Leelawadee", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Contraseña.Location = new System.Drawing.Point(12, 207);
            this.LBL_Contraseña.Name = "LBL_Contraseña";
            this.LBL_Contraseña.Size = new System.Drawing.Size(116, 23);
            this.LBL_Contraseña.TabIndex = 7;
            this.LBL_Contraseña.Text = "Contraseña:";
            // 
            // BTN_ProbarConexion
            // 
            this.BTN_ProbarConexion.Location = new System.Drawing.Point(187, 269);
            this.BTN_ProbarConexion.Name = "BTN_ProbarConexion";
            this.BTN_ProbarConexion.Size = new System.Drawing.Size(104, 23);
            this.BTN_ProbarConexion.TabIndex = 9;
            this.BTN_ProbarConexion.Text = "Probar Conexion";
            this.BTN_ProbarConexion.UseVisualStyleBackColor = true;
            this.BTN_ProbarConexion.Click += new System.EventHandler(this.BTN_ProbarConexion_Click);
            // 
            // BTN_Guardar
            // 
            this.BTN_Guardar.Location = new System.Drawing.Point(297, 269);
            this.BTN_Guardar.Name = "BTN_Guardar";
            this.BTN_Guardar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Guardar.TabIndex = 10;
            this.BTN_Guardar.Text = "Guardar";
            this.BTN_Guardar.UseVisualStyleBackColor = true;
            this.BTN_Guardar.Click += new System.EventHandler(this.BTN_Guardar_Click);
            // 
            // LBL_BD
            // 
            this.LBL_BD.AutoSize = true;
            this.LBL_BD.Font = new System.Drawing.Font("Leelawadee", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_BD.Location = new System.Drawing.Point(12, 72);
            this.LBL_BD.Name = "LBL_BD";
            this.LBL_BD.Size = new System.Drawing.Size(138, 23);
            this.LBL_BD.TabIndex = 11;
            this.LBL_BD.Text = "Base de Datos:";
            // 
            // EDT_BD
            // 
            this.EDT_BD.Font = new System.Drawing.Font("Leelawadee", 14F);
            this.EDT_BD.Location = new System.Drawing.Point(16, 98);
            this.EDT_BD.Name = "EDT_BD";
            this.EDT_BD.Size = new System.Drawing.Size(356, 30);
            this.EDT_BD.TabIndex = 12;
            // 
            // BTN_Tablas
            // 
            this.BTN_Tablas.Location = new System.Drawing.Point(106, 269);
            this.BTN_Tablas.Name = "BTN_Tablas";
            this.BTN_Tablas.Size = new System.Drawing.Size(75, 23);
            this.BTN_Tablas.TabIndex = 13;
            this.BTN_Tablas.Text = "Crear Tablas";
            this.BTN_Tablas.UseVisualStyleBackColor = true;
            this.BTN_Tablas.Click += new System.EventHandler(this.BTN_Tablas_Click);
            // 
            // WIN_Login_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 303);
            this.Controls.Add(this.BTN_Tablas);
            this.Controls.Add(this.EDT_BD);
            this.Controls.Add(this.LBL_BD);
            this.Controls.Add(this.BTN_Guardar);
            this.Controls.Add(this.BTN_ProbarConexion);
            this.Controls.Add(this.EDT_Contrasena);
            this.Controls.Add(this.LBL_Contraseña);
            this.Controls.Add(this.EDT_Usuario);
            this.Controls.Add(this.LBL_Usuario);
            this.Controls.Add(this.EDT_Servidor);
            this.Controls.Add(this.LBL_Servidor);
            this.Name = "WIN_Login_F";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EDT_Servidor;
        private System.Windows.Forms.Label LBL_Servidor;
        private System.Windows.Forms.TextBox EDT_Usuario;
        private System.Windows.Forms.Label LBL_Usuario;
        private System.Windows.Forms.TextBox EDT_Contrasena;
        private System.Windows.Forms.Label LBL_Contraseña;
        private System.Windows.Forms.Button BTN_ProbarConexion;
        private System.Windows.Forms.Button BTN_Guardar;
        private System.Windows.Forms.Label LBL_BD;
        private System.Windows.Forms.TextBox EDT_BD;
        private System.Windows.Forms.Button BTN_Tablas;
    }
}