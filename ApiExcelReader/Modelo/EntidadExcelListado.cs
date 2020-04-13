using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiExcelReader.Modelo
{
    public class EntidadExcelListado
    {
        public string CODIGO_INASA { get; set; }
        public string CODIGO_ORIGINAL { get; set; }
        public string IMAGEN { get; set; }
        public string IMAGEN_BASE64 { get; set; }
        public string COSTO_MXN { get; set; }
        public string ITEM_ALMACEN_FORD { get; set; }
        public string CODIGO_FORD { get; set; }
        public string DESCRIP { get; set; }
        public string BLANKET { get; set; }
        public string PRECIO_VENTA { get; set; }
        public string sustituto { get; set; }
        public string imagen_sustituto { get; set; }
        public string costo_sustituto { get; set; }
        public string existtencia { get; set; }
        public string error { get; set; }
        public string descripcionError { get; set; }

    }
}
