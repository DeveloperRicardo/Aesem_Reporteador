using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using AESEM_Reporteador.Properties;

namespace AESEM_Reporteador
{
    public partial class WIN_Login_F : Form
    {
        private bool Testing = false;
        string path = @"D:\Conexion.ini";
        #region Mensajes
        private void Mensajes(int Mensaje)
        {
            switch (Mensaje)
            {
                case 1:
                    MessageBox.Show("Conexión exitosa.", "AESEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 2:
                    MessageBox.Show("Conexión no exitosa.", "AESEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 3:
                    MessageBox.Show("Los campos no pueden estar vacios.", "AESEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
        #endregion
        public WIN_Login_F()
        {
            InitializeComponent();

        }

        private void BTN_ProbarConexion_Click(object sender, EventArgs e)
        {
            if (EDT_Usuario.Text == "")
            {
                Mensajes(3);
                return;
            }
            if (EDT_Contrasena.Text == "")
            {
                Mensajes(3);
                return;
            }
            if (EDT_Servidor.Text == "")
            {
                Mensajes(3);
                return;
            }
            if (EDT_BD.Text == "")
            {
                Mensajes(3);
                return;
            }
            try
            {
                using (SqlConnection Miconexion = new SqlConnection("user id=" + EDT_Usuario.Text +
                                                        ";password=" + EDT_Contrasena.Text +
                                                        ";server=" + EDT_Servidor.Text +
                                                        ";Trusted_Connection= true;" +
                                                        ";database=" + EDT_BD.Text + ";"))
                {
                    Miconexion.Open();
                    Mensajes(1);
                    Miconexion.Close();
                }                            
            }
            catch (Exception)
            {
                Mensajes(2);
            }
        }

        private void BTN_Guardar_Click(object sender, EventArgs e)
        {
            if (EDT_Usuario.Text == "")
            {
                Mensajes(3);
                return;
            }
            if (EDT_Contrasena.Text == "")
            {
                Mensajes(3);
                return;
            }
            if (EDT_Servidor.Text == "")
            {
                Mensajes(3);
                return;
            }
            if (EDT_BD.Text == "")
            {
                Mensajes(3);
                return;
            }
            string sCadenaConexion = "user id=" + EDT_Usuario.Text + ";password=" + EDT_Contrasena.Text + ";server=" + EDT_Servidor.Text +
                                     ";Trusted_Connection = true;database=" + EDT_BD.Text + ";";
            
            if (File.Exists(path))
            {
                File.WriteAllText(path, sCadenaConexion);
            }
            else
            {
                FileStream archivo = File.Create(path);
                Byte[] info = new UTF8Encoding(true).GetBytes(sCadenaConexion);
                archivo.Write(info, 0, info.Length);
            }
            Settings.Default.ConexionGuardada = true;
            //For testing purposes only
            if (Testing == true)
            {
                DialogResult Pregunta = MessageBox.Show("Probar conexion con ini?", "AESEM", MessageBoxButtons.YesNo);
                if (Pregunta == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection Miconexionini = new SqlConnection(File.ReadAllText(path)))
                        {
                            Miconexionini.Open();
                            Mensajes(1);
                            Miconexionini.Close();

                        }
                    }
                    catch (Exception)
                    {
                        Mensajes(2);
                    }
                }
            }           
        }

        private void BTN_Tablas_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection Miconexion = new SqlConnection(File.ReadAllText(path)))
                {
                    bool ExisteUSUARIOS = false, ExisteEMPRESAS = false, ExisteSUCURSALES = false;
                    Miconexion.Open();
                    SqlCommand Query = Miconexion.CreateCommand();
                    //Verificar si existe la tabla USUARIOS
                    Query.CommandText = "IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'USUARIOS') SELECT 'true' ELSE SELECT 'false'";
                    ExisteUSUARIOS = Convert.ToBoolean(Query.ExecuteScalar());
                    Query.CommandText = "IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'EMPRESAS') SELECT 'true' ELSE SELECT 'false'";
                    ExisteEMPRESAS = Convert.ToBoolean(Query.ExecuteScalar());
                    Query.CommandText = "IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'SUCURSALES') SELECT 'true' ELSE SELECT 'false'";
                    ExisteSUCURSALES = Convert.ToBoolean(Query.ExecuteScalar());                    
                    if (!ExisteUSUARIOS || !ExisteEMPRESAS || !ExisteSUCURSALES)
                    {
                        MessageBox.Show("Se crearan las tablas faltantes en la base de datos.", "AESEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        string QryTablas = "";
                        if (!ExisteUSUARIOS)
                        {
                            QryTablas += "CREATE TABLE USUARIOS (Id_Usuarios int primary key identity, Nickname varchar(15),Nombre varchar(20)," +
                                         "Ape_Pat varchar(12), Ape_Mat varchar(12), Password varchar(20));";

                        }
                        if (!ExisteEMPRESAS)
                        {
                            QryTablas += "CREATE TABLE EMPRESAS (Id_Empresas int primary key identity, Nombre varchar(50), Logo image," +
                                         "Lugar varchar(30),TipoPago int, Sindicato varchar(200), Concepto varchar(200), Comentarios varchar(255))";

                        }
                        if (!ExisteSUCURSALES)
                        {
                            QryTablas += "CREATE TABLE Sucursales(Id_Sucursales int primary key,Id_Empresas int foreign key references Empresas(Id_Empresas) on update cascade on delete cascade,"+
                                         "Nombre varchar(30), Direccion varchar(50))";
                        }
                        Query.CommandText = QryTablas;
                        Query.ExecuteNonQuery();
                        MessageBox.Show("Ya...", "AESEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    Miconexion.Close();
                }
            }
            catch (Exception)
            {
                Mensajes(2);
            }
        }
    }
}
