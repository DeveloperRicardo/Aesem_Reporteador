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
    public partial class BTN_Modificar : Form
    {
        // globales
        ConexionSQL BD = new ConexionSQL();

        // Método constructor
        public BTN_Modificar()
        {
            InitializeComponent();
        }

        // Se adjunta un documento excel
        private void BTN_Adjuntar_Click(object sender, EventArgs e)
        {
            
        }

        // Se cierra la ventana
        private void BTN_Cerrar_Click(object sender, EventArgs e) { this.Close(); }

        private void WIN_Nominas_T_Load(object sender, EventArgs e)
        {
            // Amén
            if (BD.Conexion(true))
                Refrescar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CBOX_Empresa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DGV_Tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Verifica que la tabla tenga información
            if (DGV_Tabla.RowCount == 0)
                return;

            // Abre la ventana
            WIN_Nominas_F Window = new WIN_Nominas_F((int)DGV_Tabla.CurrentRow.Cells[0].Value);
            Window.ShowDialog();
            Refrescar();
        }

        private void BTN_LupaEmpresa_Click(object sender, EventArgs e)
        {
            // Verificador de errores
            try
            {
                // Variables y objetos
                string sRutaArchivo;
                OpenFileDialog Archivo = new OpenFileDialog();

                // Filtramos el tipo de archivos que se pueden mostrar y cargar
                Archivo.Filter = "Excel Files |*.xlsx*";
                Archivo.Title = "Seleccione archivo xls";

                // Verifica que se haya clickeado el botón OK
                if (Archivo.ShowDialog() == DialogResult.OK)
                {
                    // Se muestra la imagen
                    sRutaArchivo = Archivo.FileName.ToString();
                    EDT_Ruta.Text = sRutaArchivo;
                }
            }
            catch (Exception ex)
            {
                // Se muestra el error en caso de
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método que refresca el data grid view
        private void Refrescar()
        {
            // Se llena el combo box
            BD.conexion.CreateCommand();
            SqlCommand comando = BD.conexion.CreateCommand();
            comando.CommandText = "Select Id_Empresas, Sindicato From EMPRESAS";
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            var ds = new DataTable();
            adaptador.Fill(ds);
            CBOX_Empresa.DataSource = ds;
            CBOX_Empresa.ValueMember = "Id_Empresas";
            CBOX_Empresa.DisplayMember = "Sindicato";

            // Se ejecuta el método que refresca el data grid view
            BD.conexion.CreateCommand();
            SqlCommand cmd = BD.conexion.CreateCommand();
            cmd.CommandText = "Select Id_Empleados, Nombre, NoCuenta, Importe, Periodo From EMPLEADOS";
            cmd.ExecuteNonQuery();
            SqlDataAdapter Adaptador = new SqlDataAdapter();
            Adaptador.SelectCommand = cmd;
            var Data = new DataTable();
            Adaptador.Fill(Data);
            DGV_Tabla.DataSource = Data;
        }
    }
}
