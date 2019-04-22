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
    public partial class WIN_Usuarios_T : Form
    {
        // Variables y objetos globales
        ConexionSQL BD = new ConexionSQL();
        
        public WIN_Usuarios_T()
        {
            InitializeComponent();
        }

        private void BTN_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_Agregar_Click(object sender, EventArgs e)
        {
            // Abre la ventana
            WIN_Usuarios_F Window = new WIN_Usuarios_F();
            Window.ShowDialog();
            Refrescar();
        }

        private void BTN_Modificar_Click(object sender, EventArgs e)
        {
            // Verifica que la tabla tenga información
            if (DGV_Tabla.RowCount == 0)
                return;

            // Abre la ventana
            WIN_Usuarios_F Window = new WIN_Usuarios_F((int)DGV_Tabla.CurrentRow.Cells[0].Value);
            Window.ShowDialog();
            Refrescar();
        }

        private void BTN_Eliminar_Click(object sender, EventArgs e)
        {
            // Se verifica la respuesta
            if (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Se estructura el query para eliminar el registro
                SqlCommand cmd = BD.conexion.CreateCommand();
                cmd.CommandText = "Delete From USUARIOS Where Id_Usuarios = " + (int)DGV_Tabla.CurrentRow.Cells[0].Value;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro eliminado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Refrescar();
            }
        }

        private void Refrescar()
        {
            // Se ejecuta el método que refresca el data grid view
            BD.conexion.CreateCommand();
            SqlCommand cmd = BD.conexion.CreateCommand();
            cmd.CommandText = "Select Id_Usuarios, Nickname, NombreCompleto = (Nombre + ' ' + Ape_Pat + ' ' + Ape_Mat) From USUARIOS";
            cmd.ExecuteNonQuery();
            SqlDataAdapter Adaptador = new SqlDataAdapter();
            Adaptador.SelectCommand = cmd;
            var Data = new DataTable();
            Adaptador.Fill(Data);
            DGV_Tabla.DataSource = Data;
        }

        private void WIN_Usuarios_T_Load(object sender, EventArgs e)
        {
            // Se conecta con la base de datos
            if (BD.Conexion(true))
                Refrescar();
        }
    }
}
