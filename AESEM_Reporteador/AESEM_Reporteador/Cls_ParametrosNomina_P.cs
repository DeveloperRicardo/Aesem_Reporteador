using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AESEM_Reporteador
{
    public class Cls_ParametrosNomina_P
    {
        //Parametros que utilizo para mostrar los campos de la Tabla "EMPLEADOS"
        
        public string sNombreEmpleado { get; set; }
        public int nNoCuenta { get; set; }
        public float fImporte { get; set; }
        public string sPeriodo { get; set; }

        //Parametros que utilizo para mostrar los campos de la Tabla "SUCURSALES"
        public string sNombreSucursal { get; set; }
        public string sDireccionSucursal { get; set; }

        //Parametros que utilizo para mostrar los campos de la Tabla "EMPRESAS"
        string sLugar { get; set; }
        string nTipoPago { get; set; }
        string sSindicato { get; set; }
        string sConcepto { get; set; }
        string sRuta { get; set; }
    }
}
