using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        public Int16 Id_Cliente { get; set; }
        public string Cedula { get; set; }
        public string Nombre1 { get; set; }
        public string Nombre2 { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public bool Estado { get; set; }

        public Cliente()
        {

        }

        public Cliente(Int16 Id_Cliente, string Cedula, string Nombre1, string Nombre2, string Apellido1, string Apellido2, string Telefono, string Correo, string Direccion, bool Estado)
        {
            this.Id_Cliente = Id_Cliente;
            this.Cedula = Cedula;
            this.Nombre1 = Nombre1;
            this.Nombre2 = Nombre2;
            this.Apellido1 = Apellido1;
            this.Apellido2 = Apellido2;
            this.Telefono = Telefono;
            this.Correo = Correo;
            this.Direccion = Direccion;
            this.Estado = Estado;
        }
    }
}
