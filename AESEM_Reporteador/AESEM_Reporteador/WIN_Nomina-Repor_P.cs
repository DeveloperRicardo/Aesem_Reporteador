using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions;
using System.Data.SqlClient;
using CrystalDecisions.Windows.Forms;
using System.Configuration;
using Dapper;
using System.IO;
using System.Data.SqlClient;
using CrystalDecisions.ReportSource;
namespace AESEM_Reporteador
{
    public partial class WIN_Nomina_Repor_P : Form
    {
        Prueba _datosreporte;
        public WIN_Nomina_Repor_P()
        {
            InitializeComponent();
       
        }
        public WIN_Nomina_Repor_P(Prueba datos) : this()
        {
            _datosreporte = datos;
        }

        private void WIN_Nomina_Repor_P_Load(object sender, EventArgs e)
        {
            CrystalReport1 _crt = new CrystalReport1();
            _crt.SetDataSource(_datosreporte);
            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = _crt;

        }
    }
}
