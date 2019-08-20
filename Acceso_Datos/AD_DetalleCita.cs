using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Acceso_Datos
{
    public class AD_DetalleCita : Conexion
    {
        #region Metodo de Agregacion DetalleCita
        public string NuevoDetalleCita(Detalle_Cita dtcitas)
        {
            using (var connection = GetConnection())
            {
                string respuesta = "";
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "NuevoDet_Cita";
                        command.CommandType = CommandType.StoredProcedure;

                        //Paso los parametros
                        SqlParameter ParIdServ = new SqlParameter();
                        ParIdServ.ParameterName = "@Id_Servicio";
                        ParIdServ.SqlDbType = SqlDbType.Int;
                        ParIdServ.Value = dtcitas.Id_Servicio;
                        command.Parameters.Add(ParIdServ);

                        SqlParameter ParIdEmpleado = new SqlParameter();
                        ParIdEmpleado.ParameterName = "@Id_Empleado";
                        ParIdEmpleado.SqlDbType = SqlDbType.Int;
                        ParIdEmpleado.Value = dtcitas.Id_Empleado;
                        command.Parameters.Add(ParIdEmpleado);

                        SqlParameter ParCosto = new SqlParameter();
                        ParCosto.ParameterName = "@Costo";
                        ParCosto.SqlDbType = SqlDbType.SmallMoney;
                        ParCosto.Value = dtcitas.Costo_Serv;
                        command.Parameters.Add(ParCosto);

                        //ejecutamos el comando
                        respuesta = command.ExecuteNonQuery() >= 1 ? "Ok" : "Error. No se Ingreso datos";
                    }
                }
                catch(Exception e)
                {
                    respuesta = e.Message;
                }
                return respuesta;
            }
        }
        #endregion

        #region Metodo de Eliminacion de Detalle Cita
        public string ElimDetalleCita(Detalle_Cita dtcita)
        {
            using (var connection = GetConnection())
            {
                string respuesta = "";
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "EliminarDetalleCita";
                        command.CommandType = CommandType.StoredProcedure;

                        //Paso los parametros
                        SqlParameter ParIdCita = new SqlParameter();
                        ParIdCita.ParameterName = "@Id_Cita ";
                        ParIdCita.SqlDbType = SqlDbType.Int;
                        ParIdCita.Value = dtcita.Id_Cita;
                        command.Parameters.Add(ParIdCita);

                        SqlParameter ParIdServ = new SqlParameter();
                        ParIdServ.ParameterName = "@Id_servicio";
                        ParIdServ.SqlDbType = SqlDbType.Int;
                        ParIdServ.Value = dtcita.Id_Servicio;
                        command.Parameters.Add(ParIdServ);

                        //ejecutamos el comando
                        respuesta = command.ExecuteNonQuery() >= 1 ? "Ok" : "Error. No se Elimino el servicio.";
                    }
                }
                catch (Exception e)
                {
                    respuesta = e.Message;
                }
                return respuesta;
            }
        }
        #endregion

        #region Metodo de Actualizacion de Detalle Cita
        public string ActualizacionDetalleCita(Detalle_Cita dtcita)
        {
            using (var connection = GetConnection())
            {
                string respuesta = "";
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "ActualizarDetalleCita";
                        command.CommandType = CommandType.StoredProcedure;

                        //Paso los parametros
                        SqlParameter ParIdCita = new SqlParameter();
                        ParIdCita.ParameterName = "@IdCita ";
                        ParIdCita.SqlDbType = SqlDbType.Int;
                        ParIdCita.Value = dtcita.Id_Cita;
                        command.Parameters.Add(ParIdCita);

                        SqlParameter ParIdServ = new SqlParameter();
                        ParIdServ.ParameterName = "@IdServicio";
                        ParIdServ.SqlDbType = SqlDbType.Int;
                        ParIdServ.Value = dtcita.Id_Servicio;
                        command.Parameters.Add(ParIdServ);

                        SqlParameter ParIdEmpleado = new SqlParameter();
                        ParIdEmpleado.ParameterName = "@idEmpleado";
                        ParIdEmpleado.SqlDbType = SqlDbType.Int;
                        ParIdEmpleado.Value = dtcita.Id_Empleado;
                        command.Parameters.Add(ParIdEmpleado);

                        SqlParameter ParCosto = new SqlParameter();
                        ParCosto.ParameterName = "@Costo";
                        ParCosto.SqlDbType = SqlDbType.SmallMoney;
                        ParCosto.Value = dtcita.Costo_Serv;
                        command.Parameters.Add(ParCosto);

                        //ejecutamos el comando
                        respuesta = command.ExecuteNonQuery() >= 1 ? "Ok" : "Detalles ya actualizados.";
                    }
                }
                catch (Exception e)
                {
                    respuesta = e.Message;
                }
                return respuesta;
            }
        }
        #endregion

    }
}
