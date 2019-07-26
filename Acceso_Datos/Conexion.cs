using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Acceso_Datos
{
    public abstract class Conexion
    {

        private readonly string connectionString;

        public Conexion()
        {
            connectionString = "Data Source=JOSEPH-PC;Initial Catalog=Salon; Integrated Security=True";//Esta linea debe de modificarse con el nombre de su servidor y la base si le cambian el nombre
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

    }
}
