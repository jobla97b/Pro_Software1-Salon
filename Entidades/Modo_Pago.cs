using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Modo_Pago
    {
        public int Id_Pago { get; set; }
        public int Id_Factura { get; set; }
        public char Tipo_Pago { get; set; }
        public char Moneda { get; set; }
        public decimal Importe_F { get; set; }
        public decimal Pago_Efectuado { get; set; }
        public decimal Cambio_Dolar { get; set; }

        public Modo_Pago()
        {
        }

        public Modo_Pago(int Id_Pago, int Id_Factura, char Tipo_Pago, char Moneda, decimal Importe_F, decimal Pago_Efectuado, decimal Cambio_Dolar)
        {
            this.Id_Pago = Id_Pago;
            this.Id_Factura = Id_Factura;
            this.Tipo_Pago = Tipo_Pago;
            this.Moneda = Moneda;
            this.Importe_F = Importe_F;
            this.Pago_Efectuado = Pago_Efectuado;
            this.Cambio_Dolar = Cambio_Dolar;
        }
    }
}
