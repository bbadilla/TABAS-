using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Registros.Data
{
    public class User
    {
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public int Telefono { get; set; }
        public int Carne { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
        public int ID_Rol { get; set; }
        public string Universidad { get; set; }

    }
}
