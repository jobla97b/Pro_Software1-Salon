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
    public class D_Cita
    {
        #region Metodo Listado de Citas
        public static DataTable D_Listado(string Fecha, char estado) {
            AD_Cita citas = new AD_Cita();
            Cita cit = new Cita();
            cit.Fecha = Fecha;
            cit.Estado = estado;
            return citas.ListadoCitas(cit);
        }
        #endregion
    }
}
