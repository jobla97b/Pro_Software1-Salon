using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Cache
{
    public static class CacheLoginUser
    {
        public static Int16 IdUsuario { get; set; }
        public static Int16 IdEmpleado { get; set; }
        public static string Nombre { get; set; }
        public static string Apellido { get; set; }
        public static int IdCargo { get; set; }
        public static string Cargo { get; set; }
        public static string Usuario { get; set; }
    }
}
