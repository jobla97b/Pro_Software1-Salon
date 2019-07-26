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
   public class AD_Usuario: Conexion //Aqui tienen que ir todo los procedimientos vinculados al ususario(Ingresar,Buscar,Modificar,Borrar y Cualquier otra accion)
    {

        #region Metodo Login
        //Metodo
        public DataTable Login(Users Usuario)
        {
            using (var connection = GetConnection())
            {//Abre la conexion una vez terminado la ejecucion dentro del bloque using se liberan los recursos. Ya que using implementa los metodos desechables            
                DataTable dt = new DataTable("Usuario");
                connection.Open();//Abro la conexion
                using (var command = new SqlCommand())//utilizo nuevamente los metodos desechables using; para no estar limpiando los parametros.
                {
                    command.Connection = connection;
                    command.CommandText = "Login";
                    command.CommandType = CommandType.StoredProcedure;

                    //Paso los parametros
                    SqlParameter ParUser = new SqlParameter();
                    ParUser.ParameterName = "@Usuario";
                    ParUser.SqlDbType = SqlDbType.NVarChar;
                    ParUser.Size = 12;
                    ParUser.Value = Usuario.Usuario;
                    command.Parameters.Add(ParUser);

                    SqlParameter ParPass = new SqlParameter();
                    ParPass.ParameterName = "@Contraseña";
                    ParPass.SqlDbType = SqlDbType.NVarChar;
                    ParPass.Size = 64;
                    ParPass.Value = Usuario.Contraseña;
                    command.Parameters.Add(ParPass);

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
