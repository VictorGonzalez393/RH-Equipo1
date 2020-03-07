using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AgroNegocio_RH_ERP_ISC_8A.Modelo;

namespace AgroNegocio_RH_ERP_ISC_8A.Datos
{
    class UsuarioDAO
    { 
        
      /*public bool iniciarSesion(string user, string pass)
        {
            try
            {
                using(SqlConnection conexion =new SqlConnection("SERVER = localhost" +
                ";DATABASE=ERP2020;USER ID= sa; Password=Hola.123"))
                {
                    string cadena_sql = "select idUsuario from Usuarios where nombre collate Latin1_General_CS_AS= @usuario" +
                        "and contrasenia collate Latin1_General_CS_AS= @contrasenia and estatus='A'";
                    SqlCommand comando = new SqlCommand(cadena_sql, conexion);
                    conexion.Open();
                    comando.Parameters.AddWithValue("@usuario", user);
                    comando.Parameters.AddWithValue("@contrasenia", pass);
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
            catch (SqlException ex)
            {

            }
        }*/
    }
}
