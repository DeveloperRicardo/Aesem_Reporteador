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
    public partial class WIN_Usuarios_T : Form
    {
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
            WIN_Usuarios_F Window = new WIN_Usuarios_F();
            Window.Show();
        }

        private void BTN_Modificar_Click(object sender, EventArgs e)
        {
            WIN_Usuarios_F Window = new WIN_Usuarios_F();
            Window.Show();
        }
    }
}
