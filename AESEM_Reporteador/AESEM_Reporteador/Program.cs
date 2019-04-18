﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AESEM_Reporteador.Properties;

namespace AESEM_Reporteador
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Settings.Default.ConexionGuardada == true)
            {
                Application.Run(new WIN_LogIn());
            }
            else
            {
                Application.Run(new WIN_Login_F());
            }
        }
    }
}
