using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cargo
    {
        public int Id_Cargo { get; set; }
        public string Nombre { get; set; }
        public bool Estado { get; set; }

        public Cargo()
        {
        }

        public Cargo(int Id_cargo, string Nombre, bool Estado)
        {
            this.Id_Cargo = Id_Cargo;
            this.Nombre = Nombre;
            this.Estado = Estado;
        }
    }
}
