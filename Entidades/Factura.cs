using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura
    {
        public int Id_Factura { get; set; }
        public Int16 Id_cita { get; set; }
        public Int16 Id_Empleado { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Iva { get; set; }
        public decimal Total { get; set; }
        public bool Estado { get; set; }

        public Factura()
        {
        }

        public Factura(int Id_Factura, Int16 Id_cita, Int16 Id_Empleado, DateTime Fecha, decimal Iva, decimal Total, bool Estado)
        {
            this.Id_Factura = Id_Factura;
            this.Id_cita = Id_cita;
            this.Id_Empleado = Id_Empleado;
            this.Fecha = Fecha;
            this.Iva = Iva;
            this.Total = Total;
            this.Estado = Estado;
        }
    }
}
