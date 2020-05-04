using AgroNegocio_RH_ERP_ISC_8A.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroNegocio_RH_ERP_ISC_8A.Datos
{
    class Nomina_DAO
    {
        private string cadenaconexion = "SERVER=localhost" +
                ";DATABASE=ERP2020;Persist Security Info=True;USER ID=sa ;Password=Hola.123";
        public List<Nomina> consultaGeneral(string consulta_wh, List<string> parametros, List<object> valores)
        {
            List<Nomina> nominas = new List<Nomina>();
            using (SqlConnection conexion = new SqlConnection(cadenaconexion))
            {
                string consulta = "select * from Nominas_Tabla " + consulta_wh;
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
                        Nomina nomina_temp = new Nomina(lector.GetInt32(0),
                                                           lector.GetInt32(1),
                                                           lector.GetString(2),
                                                           lector.GetDecimal(3),
                                                           lector.GetDecimal(4),
                                                           lector.GetDecimal(5),
                                                           lector.GetInt32(6),
                                                           lector.GetInt32(7),
                                                           lector.GetString(8),
                                                           lector.GetString(9),
                                                           lector.GetString(10),
                                                           lector.GetString(11)[0]);
                        nominas.Add(nomina_temp);
                    }
                }
                conexion.Close();
            }
            return nominas;
        } 




    }
}
