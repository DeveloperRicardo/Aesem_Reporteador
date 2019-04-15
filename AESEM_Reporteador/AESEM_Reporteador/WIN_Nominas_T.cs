using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AESEM_Reporteador
{
    public partial class WIN_Nominas_T : Form
    {
        // Variables globales
        int gnIdEmpresa;

        // Método constructor
        public WIN_Nominas_T()
        {
            InitializeComponent();
        }

        // Se adjunta un documento excel
        private void BTN_Adjuntar_Click(object sender, EventArgs e)
        {
            // Se abre una ventana donde 
            
        }

        // Botón que abre la ventana para escoger la empresa
        private void BTN_LupaEmpresa_Click(object sender, EventArgs e)
        {
            // Instanciamos objeto de la ventana
            //WIN_Empresas_T VentanaEmpresa = new WIN_Empresas_T(2);
            //gnIdEmpresa = VentanaEmpresa.Show();
        }

        // Se cierra la ventana
        private void BTN_Cerrar_Click(object sender, EventArgs e) { this.Close(); }
    }
}
