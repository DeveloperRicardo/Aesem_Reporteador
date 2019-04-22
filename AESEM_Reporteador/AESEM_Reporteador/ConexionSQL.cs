using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using AESEM_Reporteador.Properties;

namespace AESEM_Reporteador
{
    class ConexionSQL
    {
        bool Exito = false;
        MetodosGlobales Glo = new MetodosGlobales();
        public SqlConnection conexion = new SqlConnection(File.ReadAllText(Environment.CurrentDirectory + @"\Conexion.ini"));

        #region Iniciar y Cerrar Conexion
        public bool Conexion(bool Iniciar)
        {
            Exito = false;
            switch (Iniciar)
            {
                case true:
                    try
                    {                        
                        conexion.Open();
                        Exito = true;
                        Settings.Default.ConexionValida = true;

                    }
                    catch (Exception)
                    {
                        Glo.Mensajes(2);
                        Exito = false;
                        Settings.Default.ConexionValida = false;
                    }
                    break;

                case false:
                    try
                    {
                        conexion.Close();
                        Exito = true;
                    }
                    catch (Exception)
                    {
                        Glo.Mensajes(7);
                        Exito = false;
                    }
                    break;
            }
            return Exito;                      
        }
        #endregion

    }
}
