using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;
using Acceso_Datos;

namespace Dominio
{
    public class D_DetalleCita
    {
        #region Metodo de insercion de DetalleCita
        public string NuevoDetCita(Int16 IdServ, Int16 IdEmployee, decimal Costo)
        {
            Detalle_Cita dtcita = new Detalle_Cita();
            AD_DetalleCita dt = new AD_DetalleCita();
            dtcita.Id_Servicio = IdServ;
            dtcita.Id_Empleado = IdEmployee;
            dtcita.Costo_Serv = Costo;
            return dt.NuevoDetalleCita(dtcita);
        }
        #endregion

    }
}
