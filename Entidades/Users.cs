using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Users
    {
        public Int16 IdUsuario { get; set; }
        public Int16 IdEmpleado { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }

        public Users()
        {
        }

        public Users(Int16 IdUsuario, Int16 IdEmpleado, String Usuario, String Contraseña)
        {
            this.IdUsuario = IdUsuario;
            this.IdEmpleado = IdEmpleado;
            this.Usuario = Usuario;
            this.Contraseña = Contraseña;
        }
    }
}
