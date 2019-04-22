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
    public partial class WIN_Nominas_T : Form
    {
        // globales
        static int gnIdEmpresa = 0;
        ConexionSQL BD = new ConexionSQL();

        // Método constructor
        public WIN_Nominas_T()
        {
            InitializeComponent();
        }

        // Se adjunta un documento excel
        private void BTN_Adjuntar_Click(object sender, EventArgs e)
        {
            
        }

        // Botón que abre la ventana para escoger la empresa
        private void BTN_LupaEmpresa_Click(object sender, EventArgs e)
        {

        }

        // Se cierra la ventana
        private void BTN_Cerrar_Click(object sender, EventArgs e) { this.Close(); }

        private void WIN_Nominas_T_Load(object sender, EventArgs e)
        {
            // Amén
            if (BD.Conexion(true))
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
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CBOX_Empresa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
