using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgroNegocio_RH_ERP_ISC_8A.Modelo;

namespace AgroNegocio_RH_ERP_ISC_8A.Datos
{
    class FormasPago_DAO
    {
        private string cadenaconexion = "SERVER=localhost" +
               ";DATABASE=ERP2020;USER ID=sa ;Password=Hola.123";
        public List<FormasPago> consultaGeneral(string consulta_wh, List<string> parametros, List<object> valores)
        {
            List<FormasPago> formas = new List<FormasPago>();
            using (SqlConnection conexion = new SqlConnection(cadenaconexion))
            {
                string consulta = "select * from FormasPago " + consulta_wh;
                SqlCommand comando = new SqlCommand(consulta, conexion);
                for (int i = 0; i < parametros.Count; i++)
                {
                    comando.Parameters.AddWithValue(parametros[i], valores[i]);
                }

                conexion.Open();
                SqlDataReader lector = comando.ExecuteReader();
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                       FormasPago f_temp = new FormasPago(lector.GetInt32(0),
                                                           lector.GetString(1),
                                                           lector.GetString(2)[0]);
                        formas.Add(f_temp);
                    }
                }
                conexion.Close();
            }
            return formas;
        }
    }
}
