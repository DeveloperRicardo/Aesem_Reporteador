using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms; // Permite lanzar popups
using System.Data.OleDb; // Paquetería Excel
using System.Data; // Paquetería que permite manejar data sources

namespace AESEM_Reporteador
{
    class Cls_ClaseExcel
    {
        // Variables de otras clases
        OleDbConnection ConexionExcel;
        OleDbDataAdapter MyDataAdapter;
        DataTable TablaNominas;

        #region Importación del documento excel
        // Método manda un mensaje a pantalla
        public void ImportarExcel(DataGridView DGV_Tabla, string sNombreHoja)
        {
            // Try catch que verifica que no ocurra ningún error
            try
            {
                // Variables
                string sRuta = "";

                // Se instancia objeto de tipo AbrirArchivo
                OpenFileDialog OpenFile = new OpenFileDialog();
                OpenFile.Filter = "Excel Files |*.xlsx*";
                OpenFile.Title = "Seleccione el archivo de Excel";

                // Verifica si se clickeo el botón "OK" en el popup
                if (OpenFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    // Verifica que tenga nombre el archivo
                    if (!OpenFile.FileName.Equals(""))
                    {
                        // Se guarda la ruta del archivo
                        sRuta = OpenFile.FileName;
                    }
                }

                // Se pasa la información del documento excel al data grid view
                ConexionExcel = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=" + sRuta + ";Extended Properties='Excel 12.0 Xml;HDR=Yes'");
                MyDataAdapter = new OleDbDataAdapter("Select * From [" + sNombreHoja + "$]", ConexionExcel);
                TablaNominas = new DataTable();
                MyDataAdapter.Fill(TablaNominas);
                DGV_Tabla.DataSource = TablaNominas;
            }
            catch (Exception Fail)
            {
                // Algo se realizo mal durante el proceso, manda el error a pantalla
                MessageBox.Show(Fail.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        #endregion



    }
}
