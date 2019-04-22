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

namespace AESEM_Reporteador
{
    public partial class WIN_Usuarios_F : Form
    {
        // Globales
        static int gnIdUsuario;
        ConexionSQL BD = new ConexionSQL();

        public WIN_Usuarios_F(int pIdUsuario = 0)
        {
            InitializeComponent();
            gnIdUsuario = pIdUsuario;
        }

        private void BTN_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WIN_Usuarios_F_Load(object sender, EventArgs e)
        {
            //Amén
            if (BD.Conexion(true))
            {
                // Se verifica si el registro tiene información
                if (gnIdUsuario != 0)
                {
                    // Se obtiene la información del usuario
                    SqlCommand cmd = BD.conexion.CreateCommand();
                    cmd.CommandText = "Select Nickname, Nombre, Ape_Pat, Ape_Mat, Password From USUARIOS Where Id_Usuarios = " + gnIdUsuario;
                    SqlDataReader Reader = cmd.ExecuteReader();
                    Reader.Read();

                    // Verifica si recibió la información
                    if (Reader.HasRows)
                    {
                        // Inserta la información a los controles
                        EDT_Nickname.Text = Reader[0].ToString();
                        EDT_Nombre.Text = Reader[1].ToString();
                        EDT_aPaterno.Text = Reader[2].ToString();
                        EDT_aMaterno.Text = Reader[3].ToString();
                        EDT_Password.Text = Reader[4].ToString();
                    }
                    Reader.Close();
                }
            }
        }

        private void BTN_Aceptar_Click(object sender, EventArgs e)
        {
            // Se verifica que no ocurran errores
            try
            {
                // Verifica que los campos tengan información
                if (ValidarCampos())
                {
                    // Verifica si el registro se creará o se modificará
                    if (gnIdUsuario == 0)
                    {
                        // Se abre la conexión y se estructura el query para agregar el registro
                        SqlCommand cmd = BD.conexion.CreateCommand();
                        cmd.CommandText = "Insert Into USUARIOS(Nickname, Nombre, Ape_Pat, Ape_Mat, Password) " +
                            "Values('" + EDT_Nickname.Text + "', '" + EDT_Nombre.Text + "', '" + EDT_aPaterno.Text + "', '" + EDT_aMaterno.Text + "', '" + EDT_Password.Text + "')";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registro agregado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else // Registro existente, se modificará
                    {
                        // Se abre la conexión y se estructura el query para agregar el registro
                        SqlCommand cmd = BD.conexion.CreateCommand();
                        cmd.CommandText = "Update USUARIOS " +
                            "Set Nickname = '" + EDT_Nickname.Text + "', Nombre = '" + EDT_Nombre.Text + "', Ape_Pat = '" + EDT_aPaterno.Text + "', Ape_Mat = '" + EDT_aMaterno.Text + "', Password = '" + EDT_Password.Text + "' " +
                            "Where Id_Usuarios = " + gnIdUsuario;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registro modificado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                // Se muestra el error en caso de
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método que valida que los campos tengan inforamción
        private bool ValidarCampos()
        {
            // Verifica que el campo de "Sindicato" tenga información
            if (EDT_Nickname.TextLength == 0)
            {
                MessageBox.Show("Favor de capturar un nickname/apodo para el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EDT_Nickname.Focus();
                return false;
            }

            // Verifica que el campo de "Sindicato" tenga información
            if (EDT_Nombre.TextLength == 0)
            {
                MessageBox.Show("Favor de capturar el nombre del usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EDT_Nombre.Focus();
                return false;
            }

            // Verifica que el campo de "Sindicato" tenga información
            if (EDT_aPaterno.TextLength == 0)
            {
                MessageBox.Show("Favor de capturar el apellido paterno del usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EDT_aPaterno.Focus();
                return false;
            }

            // Verifica que el campo de "Sindicato" tenga información
            if (EDT_aMaterno.TextLength == 0)
            {
                MessageBox.Show("Favor de capturar el apellido materno del usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EDT_aMaterno.Focus();
                return false;
            }

            return true;
        }
    }
}
