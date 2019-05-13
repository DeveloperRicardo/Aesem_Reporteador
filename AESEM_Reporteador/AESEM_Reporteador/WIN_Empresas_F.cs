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
using System.Data.SqlClient; // Librería para conexión con la BD

namespace AESEM_Reporteador
{
    public partial class WIN_Empresas_F : Form
    {
        // Se instancia un SqlConnection
        ConexionSQL BD = new ConexionSQL();

        // Variables globales
        static private int gnIdEmpresa;

        // Método constructor
        public WIN_Empresas_F(int pIdEmpresa = 0)
        {
            InitializeComponent();
            gnIdEmpresa = pIdEmpresa;
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
                Archivo.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|All Files (*.*)|*.*";
                Archivo.Title = "Seleccione logo de la empresa";

                // Verifica que se haya clickeado el botón OK
                if (Archivo.ShowDialog() == DialogResult.OK)
                {
                    // Se muestra la imagen
                    sRutaImagen = Archivo.FileName.ToString();
                    EDT_Ruta.Text = sRutaImagen;
                    IMG_Logo.ImageLocation = sRutaImagen;
                }
            }
            catch (Exception ex)
            {
                // Se muestra el error en caso de
                MessageBox.Show(ex.Message, "Empresas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTN_Aceptar_Click(object sender, EventArgs e)
        {
            // Se verifica que no ocurra ningún error
            try
            {
                // Verifica que todos los campos tengan información
                if (ValidarCampos() == true)
                {
                    // Variables
                    byte[] btImagen = null;
                    int nTipoOpcion = 0;

                    // Objetos
                    FileStream fs = new FileStream(EDT_Ruta.Text, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);

                    // Se guarda la imagen en bytes
                    btImagen = br.ReadBytes((int)fs.Length);

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
                        // Se verifica si existe el registro
                        SqlCommand cmd = BD.conexion.CreateCommand();
                        cmd.CommandText = "Select * From EMPRESAS Where Sindicato = '" + EDT_Sindicato.Text + "'";
                        SqlDataReader Reader = cmd.ExecuteReader();
                        Reader.Read();

                        if (Reader.HasRows)
                        {
                            MessageBox.Show("La empresa ya existe.", "Empresas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        cmd.CommandText = "Insert Into EMPRESAS(Sindicato, Lugar, TipoPago, Ruta, Logo) " +
                            "Values('" + EDT_Sindicato.Text + "', '" + EDT_Lugar.Text + "', " + nTipoOpcion + ", '" + EDT_Ruta.Text + "', @img)";
                        cmd.Parameters.Add(new SqlParameter("@img", btImagen));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registro agregado con éxito.", "Empresas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else // Registro ya existente, se modifica
                    {
                        // Se abre conexión y se estructura el query para modificar el registro
                        SqlCommand cmd = BD.conexion.CreateCommand();
                        cmd.CommandText = "Update EMPRESAS " +
                            "Set Sindicato = '" + EDT_Sindicato.Text + "', Lugar = '" + EDT_Lugar.Text + "', TipoPago = " + nTipoOpcion + ", Ruta = '" + EDT_Ruta.Text + "', Logo = @img " +
                            "WHERE Id_Empresas = " + gnIdEmpresa;
                        cmd.Parameters.Add(new SqlParameter("@img", btImagen));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registro modificado con éxito.", "Empresas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    this.Close(); // Se cierra la ventana
                }
            }
            catch (Exception ex)
            {
                // Se muestra el error en caso de
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTN_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close(); // Se cierra la ventana
        }

        private void WIN_Empresas_F_Load(object sender, EventArgs e)
        {
            if (BD.Conexion(true))
            {
                // Se verifica si el registro existe
                if (gnIdEmpresa != 0)
                {
                    // Obtiene el registro de la empresa
                    SqlCommand cmd = BD.conexion.CreateCommand();
                    cmd.CommandText = "Select Sindicato, Lugar, TipoPago, Ruta, Logo From EMPRESAS Where Id_Empresas = " + gnIdEmpresa;
                    SqlDataReader Reader = cmd.ExecuteReader();
                    Reader.Read();

                    // Verifica si se recuperó la información
                    if (Reader.HasRows)
                    {
                        // Inserta la información en los controles
                        EDT_Sindicato.Text = Reader[0].ToString();
                        EDT_Lugar.Text = Reader[1].ToString();
                        EDT_Ruta.Text = Reader[3].ToString();
                        byte[] btImg = (byte[])(Reader[4]);

                        // Verifica que opción de radio fue la seleccionada
                        switch (Reader[2])
                        {
                            case 1: RADIO_Semanal.Checked = true; break;
                            case 2: RADIO_Catorcenal.Checked = true; break;
                            case 3: RADIO_Quincenal.Checked = true; break;
                            case 4: RADIO_Mensual.Checked = true; break;
                        }

                        // Verifica si la información de la imagen se pudo recuperar
                        if (btImg == null)
                            IMG_Logo.Image = null;
                        else
                        {
                            MemoryStream ms = new MemoryStream(btImg);
                            IMG_Logo.Image = Image.FromStream(ms);
                        }
                    }
                    Reader.Close();
                }
                else // Registro nuevo
                    RADIO_Semanal.Checked = true;
            }
        }

        // Método que verifica que los campos tengan información
        private bool ValidarCampos()
        {
            // Verifica que el campo de "Sindicato" tenga información
            if (EDT_Sindicato.TextLength == 0)
            {
                MessageBox.Show("Favor de capturar el sindicato de la empresa.", "Empresas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EDT_Sindicato.Focus();
                return false;
            }

            // Verifica que el campo de "Lugar" tenga información
            if (EDT_Lugar.TextLength == 0)
            {
                MessageBox.Show("Favor de capturar el lugar de la empresa.", "Empresas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EDT_Lugar.Focus();
                return false;
            }

            // Verifica que se haya cargado una imagen
            if (EDT_Ruta.TextLength == 0 || IMG_Logo.Image == null)
            {
                MessageBox.Show("Favor de insertar el logo de la empresa.", "Empresas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
