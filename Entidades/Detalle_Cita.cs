using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Detalle_Cita
    {
        public Int16 Id_Cita { get; set; }
        public Int16 Id_Servicio { get; set; }
        public Int16 Id_Empleado { get; set; }
        public decimal Costo_Serv { get; set; }

        public Detalle_Cita()
        {
        }

        public Detalle_Cita(Int16 Id_Cita, Int16 Id_Servicio, Int16 Id_Empleado, decimal Costo_Serv)
        {
            this.Id_Cita = Id_Cita;
            this.Id_Servicio = Id_Servicio;
            this.Id_Empleado = Id_Empleado;
            this.Costo_Serv = Costo_Serv;
        }
    }
}
