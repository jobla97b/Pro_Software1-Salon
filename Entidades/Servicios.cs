using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Servicios
    {
        public Int16 Id_Servicio { get; set; }
        public Int16 Id_Categoria { get; set; }
        public string Descripcion { get; set; }
        public string Duracion { get; set; }//revisar Todos los campos Time(0)
        public decimal Costo { get; set; }
        public bool Estado { get; set; }

        public Servicios()
        {
        }

        public Servicios(Int16 Id_Servicio, Int16 Id_Categoria, string Descripcion, string Duracion, decimal Costo, bool Estado)
        {
            this.Id_Servicio = this.Id_Servicio;
            this.Id_Categoria = this.Id_Categoria;
            this.Descripcion = Descripcion;
            this.Duracion = Duracion;
            this.Costo = Costo;
            this.Estado = Estado;
        }
    }
}
