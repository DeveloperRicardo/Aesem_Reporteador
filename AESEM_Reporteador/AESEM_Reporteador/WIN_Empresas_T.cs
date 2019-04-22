using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Librería para conexiones SQL

namespace AESEM_Reporteador
{
    public partial class WIN_Empresas_T : Form
    {
        // Variables y objetos globales
        ConexionSQL BD = new ConexionSQL();

        // Método constructor
        public WIN_Empresas_T()
        {
            InitializeComponent();
        }

        private void BTN_Agregar_Click(object sender, EventArgs e)
        {
            // Instanciamos objeto de la ventana para poder abrirla
            WIN_Empresas_F Window = new WIN_Empresas_F();
            Window.Show();
            Refrescar();
        }

        private void BTN_Modificar_Click(object sender, EventArgs e)
        {
            // Instanciamos objeto de la ventana para poder abrirla
            WIN_Empresas_F Window = new WIN_Empresas_F((int)DGV_Tabla.CurrentRow.Cells[0].Value);
            Window.Show();
            Refrescar();
        }

        private void BTN_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra la ventana
        }

        private void WIN_Empresas_T_Load(object sender, EventArgs e)
        {
            // Verifica qe la conexión sea exitosa
            if (BD.Conexion(true))
                Refrescar();
        }

        // Método que refresca el data grid view
        private void Refrescar()
        {
            BD.conexion.CreateCommand();
            SqlCommand cmd = BD.conexion.CreateCommand();
            cmd.CommandText = "Select Id_Empresas, Sindicato, Lugar, Pago = \n" +
                "   Case TipoPago\n" +
                "       WHEN 1 THEN 'Semanal'\n" +
                "       WHEN 2 THEN 'Catorcenal'\n" +
                "       WHEN 3 THEN 'Quincenal'\n" +
                "       WHEN 4 THEN 'Mensual'\n" +
                "   End\n" +
                "From EMPRESAS \n" +
                "Order By Id_Empresas\n";

            cmd.ExecuteNonQuery();
            SqlDataAdapter Adaptador = new SqlDataAdapter();
            Adaptador.SelectCommand = cmd;
            var Data = new DataTable();
            Adaptador.Fill(Data);
            DGV_Tabla.DataSource = Data;

            //Data.Clear();
        }

        private void DGV_Tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void BTN_Eliminar_Click(object sender, EventArgs e)
        {
            // Se verifica la respuesta
            if (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Se estructura el query para eliminar el registro
                SqlCommand cmd = BD.conexion.CreateCommand();
                cmd.CommandText = "Delete From EMPRESAS Where Id_Empresas = " + (int)DGV_Tabla.CurrentRow.Cells[0].Value;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro eliminado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Refrescar();
            }
        }
    }
}
