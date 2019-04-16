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
    public partial class WIN_Empresas_F : Form
    {
        public WIN_Empresas_F(int gnIdEmpresa = 0)
        {
            InitializeComponent();
        }

        private void BTN_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close(); // Se cierra la ventana
        }

        private void BTN_Aceptar_Click(object sender, EventArgs e)
        {
            // Verifica que los campos tengan información
            if (EDT_Nombre.TextLength == 0)
            {
                MessageBox.Show("Los campos no pueden ir vacios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
