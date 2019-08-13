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

        #region Metodo de Conteo Citas
        public static DataTable D_ConteoCita(string fecha)
        {
            AD_Cita citas = new AD_Cita();
            Cita cit = new Cita();
            cit.Fecha = fecha;
            return citas.ConteoCitas(cit);
        }
        #endregion

        #region Metodo de insercion de Citas
        public string D_NuevaCita(Int16 Id_Cliente, string fecha, string hora)
        {
            AD_Cita citas = new AD_Cita();
            Cita c = new Cita();
            c.Id_Cliente = Id_Cliente;
            c.Fecha = fecha;
            c.Hora = hora;
            return citas.InsercionCita(c);
        }
        #endregion

        #region Metodo de Actualizacion de Cita
        public string D_ActualizaCita(Int16 Id_cliente, char Estado){
            AD_Cita ac = new AD_Cita();
            Cita cita = new Cita();
            cita.Id_Cita = Id_cliente;
            cita.Estado = Estado;
            return ac.CambioEstCita(cita);
        }
        #endregion

        #region Metodo de Busqueda para modificacion
        public static DataTable D_BuscMod(Int16 id){
            AD_Cita ac = new AD_Cita();
            Cita cita = new Cita();
            cita.Id_Cita = id;
            return ac.BuscparaModif(cita);
        }
        #endregion

        #region Metodo de busqueda de Servicio para modificacion
        public static DataTable D_ServBuscMod(Int16 id)
        {
            AD_Cita ac = new AD_Cita();
            Cita cita = new Cita();
            cita.Id_Cita = id;
            return ac.ServModificar(cita);
        }
        #endregion

        #region Metodo de Listado para Estilista
        public static DataTable D_ListEstilista(string Fecha, char Estado,Int16 id) {
            AD_Cita ac = new AD_Cita();
            Cita cita = new Cita();
            Detalle_Cita dt= new Detalle_Cita();
            cita.Fecha = Fecha;
            cita.Estado = Estado;
            dt.Id_Empleado = id;
            return ac.ListadoEstilista(cita,dt);
        }
        #endregion
    }
}
