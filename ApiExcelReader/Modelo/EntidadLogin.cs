using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiExcelReader.Modelo
{
    public class EntidadLogin
    {
        public string Id { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public string Perfil { get; set; }
        public string Error { get; set; }
        public string DescripcionError { get; set; }
        public bool ValidarUsuario { get; set; }
    }
}
