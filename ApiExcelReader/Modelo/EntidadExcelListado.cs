using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiExcelReader.Modelo
{
    public class EntidadExcelListado
    {
        public string CODIGO_ORIGINAL { get; set; }
        public string CODIGO_INASA { get; set; }
        public string CODIGO_FORD { get; set; }
        public string IMAGEN { get; set; }
        public string IMAGEN_BASE64 { get; set; }
        public string DESCRIP { get; set; }
        public string UNIDAD_DE_MEDIDA { get; set; }
        public string INVENTARIO_FORD { get; set; }
        public string INVENTARIO_INASA { get; set; }
        public string STATUS_FORD { get; set; }
        public string STATUS_INASA { get; set; }
        public string BLANKET { get; set; }
        public string PRECIO_MONEDA { get; set; }
        public string STATUS_FABRICANTE { get; set; }                
        public string sustituto { get; set; }
        public string imagen_sustituto { get; set; }
        public string costo_sustituto { get; set; }      
        public string error { get; set; }
        public string descripcionError { get; set; }

    }
}
