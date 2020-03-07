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
        private String connection= "SERVER = localhost; DATABASE=ERP2020; USER ID= sa; Password=Hola.123;";

        /*Verificacion del login
*/
        public bool Login(string usuario, string password)
        {
            //Console.WriteLine("Estoy aquí");
            try
            {
                using (SqlConnection conexion = new SqlConnection(connection))
                {
                    //Console.WriteLine("entre");
                    string cadena_sql = "select idUsuario from Usuarios where nombre collate Latin1_General_CS_AS=@usuario " +
                        "and contrasenia collate Latin1_General_CS_AS=@pass and estatus='A'";
                    SqlCommand comando = new SqlCommand(cadena_sql, conexion);
                    conexion.Open();
                    //Console.WriteLine("Conexion abierta");
                    comando.Parameters.AddWithValue("@usuario", usuario);
                    comando.Parameters.AddWithValue("@pass", password);
                        
                    SqlDataReader lector = comando.ExecuteReader();
                    if (lector.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch(SqlException ex)
            {
                return false;
            }
        }
    }

}