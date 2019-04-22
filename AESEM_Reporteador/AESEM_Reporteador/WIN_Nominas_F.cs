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
    public partial class WIN_Nominas_F : Form
    {
        // Variables y objetos globales
        ConexionSQL BD = new ConexionSQL();
        static int gnIdNomina;

        public WIN_Nominas_F(int pIdNomina = 0)
        {
            InitializeComponent();
            gnIdNomina = pIdNomina;
        }

        private void BTN_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WIN_Nominas_F_Load(object sender, EventArgs e)
        {
            //Amén
            if (BD.Conexion(true))
            {
                // Se verifica si el registro tiene información
                if (gnIdNomina != 0)
                {
                    // Se obtiene la información del usuario
                    SqlCommand cmd = BD.conexion.CreateCommand();
                    cmd.CommandText = "Select Nombre, NoCuenta, Importe, Periodo From EMPLEADOS Where Id_Empleados = " + gnIdNomina;
                    SqlDataReader Reader = cmd.ExecuteReader();
                    Reader.Read();

                    // Verifica si recibió la información
                    if (Reader.HasRows)
                    {
                        // Inserta la información a los controles
                        EDT_Nombre.Text = Reader[0].ToString();
                        EDT_NoCuenta.Text = Reader[1].ToString();
                        EDT_Importe.Text = Reader[2].ToString();
                        EDT_Periodo.Text = Reader[3].ToString();
                    }
                    Reader.Close();
                }
            }
        }

        // Método que verifica que los campos tengan información
        private bool ValidarCampos()
        {
            // Verifica que el campo de "Sindicato" tenga información
            if (EDT_Nombre.TextLength == 0)
            {
                MessageBox.Show("Favor de capturar el nombre del empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EDT_Nombre.Focus();
                return false;
            }

            if (EDT_NoCuenta.TextLength == 0)
            {
                MessageBox.Show("Favor de capturar el número de cuenta del empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EDT_NoCuenta.Focus();
                return false;
            }

            if (EDT_Importe.TextLength == 0)
            {
                MessageBox.Show("Favor de capturar el importe del empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EDT_Importe.Focus();
                return false;
            }

            if (EDT_Periodo.TextLength == 0)
            {
                MessageBox.Show("Favor de capturar el periodo de pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EDT_Periodo.Focus();
                return false;
            }

            return true;
        }

        private void BTN_Aceptar_Click(object sender, EventArgs e)
        {
            // Verifica que los campos tengan información
            if (ValidarCampos())
            {
                // Se abre la conexión y se estructura el query para agregar el registro
                SqlCommand cmd = BD.conexion.CreateCommand();
                cmd.CommandText = "Update EMPLEADOS " +
                    "Set Nombre = '" + EDT_Nombre.Text + "', NoCuenta = '" + EDT_NoCuenta.Text + "', Importe = " + EDT_Importe.Text + ", Periodo = '" + EDT_Periodo.Text + "' " +
                    "Where Id_Empleados = " + gnIdNomina;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro modificado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
