using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Librería para conexión con la BD

namespace AESEM_Reporteador
{
    public partial class WIN_Empresas_F : Form
    {
        // Se instancia un SqlConnection
        SqlConnection MiConexion = new SqlConnection();

        // Variables globales
        static private int gnIdEmpresa;

        // Método constructor
        public WIN_Empresas_F(int pIdEmpresa = 0)
        {
            gnIdEmpresa = pIdEmpresa;
            RADIO_Semanal.Checked = true;
            InitializeComponent();
        }

        private void BTN_LupaEmpresa_Click(object sender, EventArgs e)
        {
            // Verificador de errores
            try
            {
                // Variables y objetos
                string sRutaImagen;
                OpenFileDialog Archivo = new OpenFileDialog();

                // Filtramos el tipo de archivos que se pueden mostrar y cargar
                Archivo.Filter = "jpg files(*.jpg)|*.jpg";




            }
            catch (Exception)
            {
                
            }
        }

        private void BTN_Aceptar_Click(object sender, EventArgs e)
        {
            // Verifica que todos los campos tengan información
            if (ValidarCampos() == true)
            {
                // Variable
                int nTipoOpcion = 0;

                // Verifica que opción de Radio Button se seleccionó
                if (RADIO_Semanal.Checked == true)
                    nTipoOpcion = 1;
                else if (RADIO_Catorcenal.Checked == true)
                    nTipoOpcion = 2;
                else if (RADIO_Quincenal.Checked == true)
                    nTipoOpcion = 3;
                else if (RADIO_Mensual.Checked == true)
                    nTipoOpcion = 4;

                // Verifica si el registro es nuevo
                if (gnIdEmpresa == 0)
                {
                    // Se abre la conexión y se estructura el query para agregar el registro
                    MiConexion.Open();
                    SqlCommand cmd = MiConexion.CreateCommand();
                    cmd.CommandText = "Insert Into EMPRESAS(Sindicato, Lugar, TipoPago, Comentarios, Concepto, Logo)" +
                        "Values('" + EDT_Sindicato.Text + "', '" + EDT_Lugar.Text + "', " + nTipoOpcion + ", '" + EDT_Comentarios.Text + "', '" + EDT_Concepto.Text + "')";
                    cmd.ExecuteNonQuery();
                    MiConexion.Close();
                }
                else // Registro ya existente, se modifica
                {
                    // Se abre conexión y se estructura el query para modificar el registro
                    MiConexion.Open();
                    SqlCommand cmd = MiConexion.CreateCommand();
                    cmd.CommandText = "Update EMPRESAS" +
                        "Set Sindicato = '" + EDT_Sindicato.Text + "', Lugar = '" + EDT_Lugar.Text + "', TipoPago = " + nTipoOpcion + ", Comentarios = '" + EDT_Comentarios.Text + "', Concepto = '" + EDT_Concepto.Text + "'" +
                        "WHERE Id_Empresas = " + gnIdEmpresa;
                    cmd.ExecuteNonQuery();
                    MiConexion.Close();
                }
            }
        }

        private void BTN_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close(); // Se cierra la ventana
        }

        // Método que verifica que los campos tengan información
        private bool ValidarCampos()
        {
            // Verifica que el campo de "Sindicato" tenga información
            if (EDT_Sindicato.TextLength == 0)
            {
                MessageBox.Show("Favor de capturar el sindicato de la empresa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EDT_Sindicato.Focus();
                return false;
            }

            // Verifica que el campo de "Lugar" tenga información
            if (EDT_Lugar.TextLength == 0)
            {
                MessageBox.Show("Favor de capturar el lugar de la empresa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EDT_Lugar.Focus();
                return false;
            }

            // Verifica que el campo "Comentarios" tenga información
            if (EDT_Comentarios.TextLength == 0)
            {
                MessageBox.Show("Favor de capturar comentarios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EDT_Comentarios.Focus();
                return false;
            }

            // Verifica que el campo "Conceptos" tenga información
            if (EDT_Concepto.TextLength == 0)
            {
                MessageBox.Show("Favor de capturar el concepto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EDT_Concepto.Focus();
                return false;
            }

            // Verifica que se haya cargado una imagen
            if (EDT_Ruta.TextLength == 0 || IMG_Logo.Image == null)
            {
                MessageBox.Show("Favor de insertar el logo de la empresa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    
    }
}
