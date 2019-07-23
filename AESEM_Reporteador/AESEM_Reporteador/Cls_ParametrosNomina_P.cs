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
        public string Nombre { get; set; }
        public string Sindicato { get; set; }
        public string NoCuenta { get; set; }
        public float Importe { get; set; }
        public string Periodo { get; set; }
        public string Lugar { get; set; }
        public byte[] Logo { get; set; }

    }
}
