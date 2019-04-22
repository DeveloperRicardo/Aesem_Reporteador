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
            WIN_Empresas_F Window = new WIN_Empresas_F(1);
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
            cmd.CommandText = "Select Id_Empresas, Sindicato, Lugar, TipoPago From EMPRESAS";
            cmd.ExecuteNonQuery();
            SqlDataAdapter Adaptador = new SqlDataAdapter();
            Adaptador.SelectCommand = cmd;
            var Data = new DataTable();
            Data.Clear();
            Adaptador.Fill(Data);
            DGV_Tabla.DataSource = Data;
           


            //DGV_Tabla.BindingContext = Data;

            //if (MiConexion.State != ConnectionState.Open)
            //    MiConexion.Open();
            //SqlCommand cmd = MiConexion.CreateCommand();
            //cmd.CommandText = "Select * From EMPRESAS";

            //DataTable Tabla = new DataTable();
            //SqlDataAdapter Adaptador = new SqlDataAdapter(cmd);
            //Adaptador.Fill(Tabla);
        }
    }
}
