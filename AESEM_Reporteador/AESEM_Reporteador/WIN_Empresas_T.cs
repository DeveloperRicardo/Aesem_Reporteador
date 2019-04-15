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
    public partial class WIN_Empresas_T : Form
    {
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
        }

        private void BTN_Modificar_Click(object sender, EventArgs e)
        {


            // Instanciamos objeto de la ventana para poder abrirla
            WIN_Empresas_F Window = new WIN_Empresas_F(1);
            Window.Show();
        }

        private void BTN_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra la ventana
        }
    }
}
