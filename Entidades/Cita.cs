using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cita
    {
        public Int16 Id_Cita { get; set; }
        public Int16 Id_Cliente { get; set; }
        public DateTime Fecha { get; set; }//Revisar
        public string Hora { get; set; }
        public string Hora_fin { get; set; }
        public char Estado { get; set; }

        public Cita()
        {
        }

        public Cita(Int16 Id_Cita, Int16 Id_Cliente, DateTime Fecha, string Hora, string Hora_fin, char Estado)
        {
            this.Id_Cita = Id_Cita;
            this.Id_Cliente = Id_Cliente;
            this.Fecha = Fecha;
            this.Hora = Hora;
            this.Hora_fin = Hora_fin;
            this.Estado = Estado;
        }
    }
}
