using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AESEM_Reporteador.Properties;
using System.Data.SqlClient;

namespace AESEM_Reporteador
{
    public partial class WIN_Login_F : Form
    {
        bool Modificar = false;
        string conexion = "";
        string path = Environment.CurrentDirectory +  @"\Conexion.ini";
        MetodosGlobales Glo = new MetodosGlobales();
        public WIN_Login_F(bool Mod = false)
        {
            Modificar = Mod;
            InitializeComponent();
            CargarInformacion();
        }

        #region Validar Campos
        private bool ValidarCampos()
        {
            // Verifica que los campos tengan información en ellos
            if (EDT_Usuario.Text == "" || EDT_Contrasena.Text == "" || EDT_Servidor.Text == "" || EDT_BD.Text == "")
                return false;
            else
                return true;
        }
        #endregion

        #region ProbarConexion
        private void BTN_ProbarConexion_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                Glo.Mensajes(3);
                return;
            }
            try
            {
                conexion = @"user id=" + EDT_Usuario.Text +
                           ";password=" + EDT_Contrasena.Text +
                           ";server=" + EDT_Servidor.Text +                                                
                           ";database=" + EDT_BD.Text + ";";
                using (SqlConnection Miconexion = new SqlConnection(conexion))
                {
                    Miconexion.Open();
                    Glo.Mensajes(1);
                    Miconexion.Close();
                }
            }
            catch (Exception)
            {
                Glo.Mensajes(2);
            }
        }
        #endregion

        #region Guardar INI
        private void BTN_Guardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                Glo.Mensajes(3);
                return;
            }
            conexion = @"user id=" + EDT_Usuario.Text +
                       ";password=" + EDT_Contrasena.Text +
                       ";server=" + EDT_Servidor.Text +
                       ";database=" + EDT_BD.Text + ";";
            if (File.Exists(path))
            {
                File.WriteAllText(path, conexion);
            }
            else
            {
                FileStream archivo = File.Create(path);
                Byte[] info = new UTF8Encoding(true).GetBytes(conexion);
                archivo.Write(info, 0, info.Length);
            }
            Glo.Mensajes(6);
            Settings.Default.ConexionGuardada = true;
            //For testing purposes only
            if (Settings.Default.Testing == true)
            {
                DialogResult Pregunta = MessageBox.Show("Probar conexion con ini?", "FOR TESTING PURPOSES ONLY", MessageBoxButtons.YesNo);
                if (Pregunta == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection Miconexionini = new SqlConnection(File.ReadAllText(path)))
                        {
                            Miconexionini.Open();
                            Glo.Mensajes(1);
                            Miconexionini.Close();

                        }
                    }
                    catch (Exception)
                    {
                        Glo.Mensajes(2);
                    }
                }
            }
            VerificarTablas();
        }
        #endregion

        #region Verificar y Crear Tablas
        private void VerificarTablas()
        {
            try
            {
                using (SqlConnection Miconexion = new SqlConnection(File.ReadAllText(path)))
                {
                    bool ExisteUSUARIOS = false, ExisteEMPRESAS = false, ExisteSUCURSALES = false, ExisteEMPLEADOS = false;
                    int NumUsuarios = 0;
                    Miconexion.Open();
                    SqlCommand Query = Miconexion.CreateCommand();
                    //Verificar si existe la tabla USUARIOS
                    Query.CommandText = "IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'USUARIOS') SELECT 'true' ELSE SELECT 'false'";
                    ExisteUSUARIOS = Convert.ToBoolean(Query.ExecuteScalar());
                    Query.CommandText = "IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'EMPRESAS') SELECT 'true' ELSE SELECT 'false'";
                    ExisteEMPRESAS = Convert.ToBoolean(Query.ExecuteScalar());
                    Query.CommandText = "IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'SUCURSALES') SELECT 'true' ELSE SELECT 'false'";
                    ExisteSUCURSALES = Convert.ToBoolean(Query.ExecuteScalar());
                    Query.CommandText = "IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'EMPLEADOS') SELECT 'true' ELSE SELECT 'false'";
                    ExisteEMPLEADOS = Convert.ToBoolean(Query.ExecuteScalar());
                    if (!ExisteUSUARIOS || !ExisteEMPRESAS || !ExisteSUCURSALES || !ExisteEMPLEADOS)
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
                            QryTablas += "CREATE TABLE EMPRESAS (Id_Empresas int primary key identity, Logo image,"+
                                         "Lugar varchar(30),TipoPago int, Sindicato varchar(200), Concepto varchar(200), Ruta varchar(100))";

                        }
                        if (!ExisteSUCURSALES)
                        {
                            QryTablas += "CREATE TABLE SUCURSALES(Id_Sucursales int primary key,Id_Empresas int foreign key references Empresas(Id_Empresas) on update cascade on delete cascade," +
                                         "Nombre varchar(30), Direccion varchar(50))";
                        }
                        if (!ExisteEMPLEADOS)
                        {
                            QryTablas += "CREATE TABLE EMPLEADOS (Id_Empleados int primary key identity, Nombre varchar(100),"+ 
                                         "NoCuenta varchar(50), Importe float, Periodo varchar(50))";
                        }
                        Query.CommandText = QryTablas;
                        Query.ExecuteNonQuery();
                        Glo.Mensajes(5);                      
                    }
                    Query.CommandText = "SELECT COUNT(*) FROM USUARIOS";
                    NumUsuarios = Convert.ToInt32(Query.ExecuteScalar());
                    if (NumUsuarios == 0)
                    {
                        Query.CommandText = "INSERT INTO USUARIOS VALUES('admin','admin','admin','admin','admin')";
                        Query.ExecuteNonQuery();
                    }
                    Miconexion.Close();
                }
            }
            catch (Exception)
            {
                Glo.Mensajes(2);
            }
        }
        #endregion

        #region Cargar Informacion
        private void CargarInformacion()
        {
            if (File.Exists(path))
            {
                string datos = File.ReadAllText(path);
                string[] parametros = datos.Split(Convert.ToChar(";"));
                for (int i = 0; i < 4; i++)
                {
                    switch (i)
                    {
                        case 0:
                            parametros[i] = parametros[i].Remove(0, 8);
                            break;
                        case 1:
                            parametros[i] = parametros[i].Remove(0, 9);
                            break;
                        case 2:
                            parametros[i] = parametros[i].Remove(0, 7);
                            break;
                        case 3:
                            parametros[i] = parametros[i].Remove(0, 9);
                            break;
                    }                    
                }
                EDT_Usuario.Text = parametros[0];
                EDT_Contrasena.Text = parametros[1];
                EDT_Servidor.Text = parametros[2];
                EDT_BD.Text = parametros[3];
                
            }
        }
        #endregion

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            if (Settings.Default.ConexionGuardada == false)
            {
                this.Close();
            }
            else
            {
                WIN_LogIn Login = new WIN_LogIn();
                if (Modificar == false)
                    Login.Show();
                this.Close();
            }
                       
        }

        private void WIN_Login_F_Load(object sender, EventArgs e)
        {

        }
    }
}
