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
    }
}
