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
    public partial class WIN_LogIn : Form
    {
        public WIN_LogIn()
        {
            InitializeComponent();
        }

        private void WIN_LogIn_Load(object sender, EventArgs e)
        {

        }

        private void BTN_Salir_Click(object sender, EventArgs e)
        {
            this.Close(); // Se cierra el sistema.
        }

        private void BTN_Acceder_Click(object sender, EventArgs e)
        {
            // Verifica que los campos tengan información
            if (ValidarCampos())
            {
                // Se busca en la base de datos
            }
            else
            {
                // Muestra un mensaje donde indica que hay un error
                MessageBox.Show("Los campos no pueden ir vacios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método que verifica que los campos tengan información
        private bool ValidarCampos()
        {
            // Verifica que los campos tengan información en ellos
            if (EDT_Usuario.Text == null || EDT_Contrasena == null)
                return false;
            else
                return true;
        }

        private void BTN_Registrar_Click(object sender, EventArgs e)
        {
            // Verifica que los campos tengan información
            if (ValidarCampos())
            {

            }
        }
    }
}
