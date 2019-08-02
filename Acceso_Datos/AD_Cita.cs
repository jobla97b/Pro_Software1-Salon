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
                    return dt;
                }
            }
        }
        #endregion
    }
}
