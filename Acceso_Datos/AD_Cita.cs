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
    public class AD_Cita : Conexion
    {
        #region Metodo de Listado de Citas
        public DataTable ListadoCitas(Cita citas)
        {
            using (var connection = GetConnection())
            {
                DataTable dt = new DataTable("Cita");
              try
              {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "ListadoCitas";
                    command.CommandType = CommandType.StoredProcedure;

                    //Paso los parametros
                    SqlParameter Parfech = new SqlParameter();
                    Parfech.ParameterName = "@Fecha";
                    Parfech.SqlDbType = SqlDbType.NVarChar;
                    Parfech.Size = 10;
                    Parfech.Value = citas.Fecha;
                    command.Parameters.Add(Parfech);

                    SqlParameter Parestado = new SqlParameter();
                    Parestado.ParameterName = "@Estado";
                    Parestado.SqlDbType = SqlDbType.Char;
                    Parestado.Size = 1;
                    Parestado.Value = citas.Estado;
                    command.Parameters.Add(Parestado);

                    //Llenamos La tabla
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    da.Fill(dt);
                    //return dt;
                }
              }
              catch (Exception e)
              {
                dt = null;
              }
              return dt;
           }
        }
        #endregion

        #region Metodo de Conteo de Citas
        public DataTable ConteoCitas(Cita citas)
        {
            using (var connection = GetConnection())
            {
                DataTable dt = new DataTable("ConteoCita");
                try { 
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "ListDetalle";
                    command.CommandType = CommandType.StoredProcedure;

                    //Paso los parametros
                    SqlParameter Parfecha = new SqlParameter();
                    Parfecha.ParameterName = "@fecha";
                    Parfecha.SqlDbType = SqlDbType.NVarChar;
                    Parfecha.Size = 10;
                    Parfecha.Value = citas.Fecha;
                    command.Parameters.Add(Parfecha);

                    //Llenamos La tabla
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    da.Fill(dt);
                    //return dt;
                }
                } catch (Exception e) {
                    dt = null;
                }
                return dt;
            }
        }
        #endregion

        #region Metodo de Insercion de Citas
        public string InsercionCita(Cita cita)
        {
            using(var connection = GetConnection())
            {
                string respuesta = "";
                try
                {
                    connection.Open();
                    using(var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "NuevaCita";
                        command.CommandType = CommandType.StoredProcedure;

                        //Paso los parametros
                        SqlParameter ParIdCliente = new SqlParameter();
                        ParIdCliente.ParameterName = "@IdCliente";
                        ParIdCliente.SqlDbType = SqlDbType.Int;
                        ParIdCliente.Value = cita.Id_Cliente;
                        command.Parameters.Add(ParIdCliente);

                        SqlParameter ParFecha = new SqlParameter();
                        ParFecha.ParameterName = "@Fecha";
                        ParFecha.SqlDbType = SqlDbType.NVarChar;
                        ParFecha.Size = 10;
                        ParFecha.Value = cita.Fecha;
                        command.Parameters.Add(ParFecha);

                        SqlParameter ParHora = new SqlParameter();
                        ParHora.ParameterName = "@Hora";
                        ParHora.SqlDbType = SqlDbType.NVarChar;
                        ParHora.Size = 5;
                        ParHora.Value = cita.Hora;
                        command.Parameters.Add(ParHora);

                        //Ejecutamos el comando 
                        respuesta = command.ExecuteNonQuery() == 1 ? "Ok" : "Error. No se Ingreso";

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

        #region Metodo Cambio de Estado de Cita
        public string CambioEstCita(Cita cita) {
            using (var connection=GetConnection() )
            {
                string respuesta = "";
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "ActualizarEstadoCita";
                        command.CommandType = CommandType.StoredProcedure;

                        //Paso los parametros
                        SqlParameter ParIdClien = new SqlParameter();
                        ParIdClien.ParameterName = "@IdCit";
                        ParIdClien.SqlDbType = SqlDbType.Int;
                        ParIdClien.Value = cita.Id_Cita;
                        command.Parameters.Add(ParIdClien);

                        SqlParameter ParEstCita = new SqlParameter();
                        ParEstCita.ParameterName = "@Estado";
                        ParEstCita.SqlDbType = SqlDbType.Char;
                        ParEstCita.Size = 1;
                        ParEstCita.Value = cita.Estado;
                        command.Parameters.Add(ParEstCita);
                 
                        //Ejecutamos el comando 
                        respuesta = command.ExecuteNonQuery() == 1 ? "Ok" : "Error. No se Actualiuzo";
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

        #region Metodo de Busqueda para modificacion
        public DataTable BuscparaModif(Cita cita) {
            using (var connection = GetConnection()) {
                DataTable BM = new DataTable("BuscModificacion");
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand()) {
                        command.Connection = connection;
                        command.CommandText = "Busqueda_Modificacion";
                        command.CommandType = CommandType.StoredProcedure;

                        //Paso los parametros
                        SqlParameter Parid = new SqlParameter();
                        Parid.ParameterName = "@IdCita";
                        Parid.SqlDbType = SqlDbType.Int;
                        Parid.Value = cita.Id_Cita;
                        command.Parameters.Add(Parid);

                        //Llenamos La tabla
                        SqlDataAdapter da = new SqlDataAdapter(command);
                        da.Fill(BM);
                    }
                }
                catch(Exception e)
                {
                    BM = null;
                }
                return BM;
            }
        }
        #endregion

        #region Metodo para cargar Servicios para modificacion
        public DataTable ServModificar(Cita cita)
        {
            using (var connection = GetConnection())
            {
                DataTable SBM = new DataTable("ServBuscModificacion");
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "BM_Servicios";
                        command.CommandType = CommandType.StoredProcedure;

                        //Paso los parametros
                        SqlParameter Parid = new SqlParameter();
                        Parid.ParameterName = "@IdCita";
                        Parid.SqlDbType = SqlDbType.Int;
                        Parid.Value = cita.Id_Cita;
                        command.Parameters.Add(Parid);

                        //Llenamos La tabla
                        SqlDataAdapter da = new SqlDataAdapter(command);
                        da.Fill(SBM);
                    }
                }
                catch (Exception e)
                {
                    SBM = null;
                }
                return SBM;
            }
        }
        #endregion

        #region Metodo de Listado de Cita para Estilista
        public DataTable ListadoEstilista(Cita cita,Detalle_Cita dtcita){
            using (var connection = GetConnection())
            {
                DataTable dt = new DataTable("ListEstilista");
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "ListadoCitasEmpleado";
                        command.CommandType = CommandType.StoredProcedure;

                        //Paso los parametros
                        SqlParameter Parfech = new SqlParameter();
                        Parfech.ParameterName = "@Fecha";
                        Parfech.SqlDbType = SqlDbType.NVarChar;
                        Parfech.Size = 10;
                        Parfech.Value = cita.Fecha;
                        command.Parameters.Add(Parfech);

                        SqlParameter Parestado = new SqlParameter();
                        Parestado.ParameterName = "@Estado";
                        Parestado.SqlDbType = SqlDbType.Char;
                        Parestado.Size = 1;
                        Parestado.Value = cita.Estado;
                        command.Parameters.Add(Parestado);

                        SqlParameter ParIdEmpleado = new SqlParameter();
                        ParIdEmpleado.ParameterName = "@IdEmpleado";
                        ParIdEmpleado.SqlDbType = SqlDbType.Int;
                        ParIdEmpleado.Value = dtcita.Id_Empleado;
                        command.Parameters.Add(ParIdEmpleado);

                        //Llenamos La tabla
                        SqlDataAdapter da = new SqlDataAdapter(command);
                        da.Fill(dt);
                        //return dt;
                    }
                }
                catch (Exception e)
                {
                    dt = null;
                }
                return dt;
            }
        }
        #endregion
    }
}
