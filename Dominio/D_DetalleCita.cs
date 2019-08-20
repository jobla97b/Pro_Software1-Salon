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

        #region Metodo de Eliminacion de DetalleCita
        public string ElimacionDetalleCit(Int16 Idcita, Int16 IdServicio)
        {
            Detalle_Cita dtcita = new Detalle_Cita();
            AD_DetalleCita dt = new AD_DetalleCita();
            dtcita.Id_Cita = Idcita;
            dtcita.Id_Servicio = IdServicio;
            return dt.ElimDetalleCita(dtcita);
        }
        #endregion

        #region Metodo de Actualizacion de Cita
        public string ActualizacionDetalleCit(Int16 Idcita, Int16 Idservicio, Int16 Idempleado, decimal Costo)
        {
            Detalle_Cita dtcita = new Detalle_Cita();
            AD_DetalleCita dt = new AD_DetalleCita();
            dtcita.Id_Cita = Idcita;
            dtcita.Id_Servicio = Idservicio;
            dtcita.Id_Empleado = Idempleado;
            dtcita.Costo_Serv = Costo;
            return dt.ActualizacionDetalleCita(dtcita);
        }
        #endregion
    }
}
