using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AgroNegocio_RH_ERP_ISC_8A.Datos
{
    class LoginDAO : Conexion
    {
       

        /*Verificacion del login
*/
        public bool Login(string usuario, string password)
        {
 
            try
            {
                SqlConnection conexion = new SqlConnection("SERVER =189.135.27.179 ; DATABASE=ERP2020; USER ID=" + usuario + "; Password=" + password + ";");
                conexion.Open();
                return true;


            }
            catch(SqlException ex)
            {
                Console.WriteLine("Error al conectarse en la BD. Error: " + ex.Message);
                return false;
            }
        }
    }

}