using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using AESEM_Reporteador.Properties;

namespace AESEM_Reporteador
{
    public partial class WIN_LogIn : Form
    {
        MetodosGlobales Glo = new MetodosGlobales();
        ConexionSQL BD = new ConexionSQL();
        public WIN_LogIn()
        {
            InitializeComponent();
        }

        private void WIN_LogIn_Load(object sender, EventArgs e)
        {
            
            if (BD.Conexion(true))
            {
                BD.conexion.CreateCommand();
                SqlCommand comando = BD.conexion.CreateCommand();
                comando.CommandText = "SELECT Id_Usuarios, Nickname FROM USUARIOS";
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                var ds = new DataTable();
                adaptador.Fill(ds);
                CBOX_Usuario.DataSource = ds;
                CBOX_Usuario.ValueMember = "Id_Usuarios";
                CBOX_Usuario.DisplayMember = "Nickname";
            }          
        }

        private void BTN_Salir_Click(object sender, EventArgs e)
        {
            this.Close(); // Se cierra el sistema.
        }

        private void BTN_Acceder_Click(object sender, EventArgs e)
        {
            // Verifica que los campos tengan información
            if (ValidarCampos())
            {
                bool ExisteUsuario = false;
                // Se busca en la base de datos
                BD.conexion.CreateCommand();
                SqlCommand comando = BD.conexion.CreateCommand();
                comando.CommandText = "IF EXISTS(SELECT * FROM USUARIOS WHERE Id_Usuarios = '" + CBOX_Usuario.SelectedValue + "' AND Password = '" + EDT_Contrasena.Text + "') SELECT 'true' ELSE SELECT 'false'";
                ExisteUsuario = Convert.ToBoolean(comando.ExecuteScalar());
                if (ExisteUsuario)
                {
                    WIN_Principal Window = new WIN_Principal();
                    Window.Show();
                    this.Close();
                }
                else
                    Glo.Mensajes(8);
            }
            else
            {
                // Muestra un mensaje donde indica que hay un error
                Glo.Mensajes(3);
            }
        }

        // Método que verifica que los campos tengan información
        private bool ValidarCampos()
        {
            // Verifica que los campos tengan información en ellos
            if (CBOX_Usuario.Text == null || EDT_Contrasena.Text == "")
                return false;
            else
                return true;
        }

        private void BTN_Registrar_Click(object sender, EventArgs e)
        {
            // Verifica que los campos tengan información
            if (ValidarCampos())
            {

            }
            else
            {
                // Muestra un mensaje donde indica que hay un error
                Glo.Mensajes(3);
            }
        }

        private void BTN_ProbarConexion_Click(object sender, EventArgs e)
        {
            WIN_Login_F Login = new WIN_Login_F(true);
            Login.Show();
        }
    }
}
