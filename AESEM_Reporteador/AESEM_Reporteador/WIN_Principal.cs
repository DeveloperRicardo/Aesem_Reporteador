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
    public partial class WIN_Principal : Form
    {
        public WIN_Principal()
        {
            InitializeComponent();
        }

        private void WIN_Principal_Load(object sender, EventArgs e)
        {

        }

        private void BTN_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_Empresas_Click(object sender, EventArgs e)
        {
            WIN_Empresas_T Window = new WIN_Empresas_T();
            Window.Show();
        }

        private void BTN_Nominas_Click(object sender, EventArgs e)
        {
            BTN_Modificar Window = new BTN_Modificar();
            Window.Show();
        }

        private void BTN_Usuarios_Click(object sender, EventArgs e)
        {
            WIN_Usuarios_T Window = new WIN_Usuarios_T();
            Window.Show();
        }
    }
}
