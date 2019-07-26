using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public  class Categoria_Servicio
    {
        public Int16 Id_Categoria { get; set; }
        public string Nombre { get; set; }
        public char Moneda { get; set; }
        public decimal Cambio_Oficial { get; set; }
        public bool Estado { get; set; }

        public Categoria_Servicio()
        {

        }

        public Categoria_Servicio(Int16 Id_Categoria, string Nombre, char Moneda, decimal Cambio_Oficial, bool Estado)
        {
            this.Id_Categoria = Id_Categoria;
            this.Nombre = Nombre;
            this.Moneda = Moneda;
            this.Cambio_Oficial = Cambio_Oficial;
            this.Estado = Estado;
        }
    }
}
