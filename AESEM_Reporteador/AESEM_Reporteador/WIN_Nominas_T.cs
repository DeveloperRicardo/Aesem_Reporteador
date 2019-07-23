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
using System.Configuration;
using Dapper;
using System.IO;
using System.Reflection;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions;
using CrystalDecisions.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.ReportSource;

namespace AESEM_Reporteador
{
    public partial class BTN_Modificar : Form
    {
      
        ConexionSQL BD = new ConexionSQL();
        
        ReportDocument doc;
        public BTN_Modificar()
        {
            InitializeComponent();
        }
        
        // Se adjunta un documento excel
        private void BTN_Adjuntar_Click(object sender, EventArgs e)
        {
            
        }

        private void BTN_Cerrar_Click(object sender, EventArgs e) { this.Close(); }
      

        private void WIN_Nominas_T_Load(object sender, EventArgs e)
        {
            using (SqlConnection conexiones = new SqlConnection(File.ReadAllText(Environment.CurrentDirectory + @"\Conexion.ini")))
            {
                if (BD.conexion.State == ConnectionState.Closed)
                {
                    BD.conexion.Open();
                    string query = "select EMPLEADOS.Nombre,EMPRESAS.Sindicato,EMPLEADOS.Importe,EMPLEADOS.NoCuenta,EMPLEADOS.Periodo,EMPRESAS.Lugar from EMPLEADOS,EMPRESAS";

                    ////string query = "select EMPLEADOS.Id_Empleados,EMPLEADOS.Nombre,EMPLEADOS.Importe,EMPLEADOS.NoCuenta from EMPLEADOS";
                    clsParametrosNominaPBindingSource.DataSource = BD.conexion.Query<Cls_ParametrosNomina_P>(query, commandType: CommandType.Text);




                    BD.conexion.CreateCommand();
                    SqlCommand comando = BD.conexion.CreateCommand();
                    comando.CommandText = "SELECT Id_Empresas, Sindicato FROM EMPRESAS";
                    SqlDataAdapter adaptador = new SqlDataAdapter();
                    adaptador.SelectCommand = comando;
                    var ds = new DataTable();
                    adaptador.Fill(ds);
                    CBOX_Empresa.DataSource = ds;
                    CBOX_Empresa.ValueMember = "Id_Empresas";
                    CBOX_Empresa.DisplayMember = "Sindicato";
                }
            }
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

        private void BTN_ExportarXLS_Click(object sender, EventArgs e)
        {
            Prueba datos = GenerarFactura();

            WIN_Nomina_Repor_P frm = new WIN_Nomina_Repor_P(datos);
            frm.Show();

        }
        private Prueba GenerarFactura()
        {
            Prueba facturacion = new Prueba();

            BD.conexion.CreateCommand();
            SqlCommand comando = BD.conexion.CreateCommand();
            comando.CommandText = "SELECT EMPRESAS.Logo FROM EMPRESAS where EMPRESAS.Id_Empresas = " + CBOX_Empresa.SelectedValue;
            SqlDataReader Reader = comando.ExecuteReader();
            Reader.Read();
            byte[] variable = null;

            //Verifica si recibió la información
            if (Reader.HasRows)
            {
                //Inserta la información a los controles
                variable = (byte[])(Reader[0]);
            }
            Reader.Close();

            foreach (DataGridViewRow row in DGV_Tabla.Rows)
            {
                Prueba.PruebaRow rowprueba = facturacion._Prueba.NewPruebaRow();

                rowprueba.Nombre_Empleado = Convert.ToString(row.Cells["dataGridViewTextBoxColumn1"].Value);
                rowprueba.Sindicato = Convert.ToString(row.Cells["sindicatoDataGridViewTextBoxColumn"].Value);
                rowprueba.No_Cuenta = Convert.ToString(row.Cells["dataGridViewTextBoxColumn2"].Value);
                rowprueba.Importe = Convert.ToString(row.Cells["dataGridViewTextBoxColumn3"].Value);
                rowprueba.Periodo = Convert.ToString(row.Cells["periodoDataGridViewTextBoxColumn"].Value);
                rowprueba.Lugar_Empre = Convert.ToString(row.Cells["lugarDataGridViewTextBoxColumn"].Value);
                //rowprueba.Image = variable;
                facturacion._Prueba.AddPruebaRow(rowprueba);
            }

            return facturacion;
        }

    }
}
