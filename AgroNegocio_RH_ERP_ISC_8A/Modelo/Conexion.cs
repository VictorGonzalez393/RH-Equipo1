using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//Librerias para la conexion de la BD
using System.Data.SqlClient;//Libreria para conectar el SQLServer

namespace AgroNegocio_RH_ERP_ISC_8A.Datos
{
    class Conexion
    {
        private readonly string connectionString;
        public Conexion()
        {
            connectionString = "SERVER = localhost" + ";DATABASE=ERP2020;USER ID= sa; Password=Hola.123";

        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }


    }
}
