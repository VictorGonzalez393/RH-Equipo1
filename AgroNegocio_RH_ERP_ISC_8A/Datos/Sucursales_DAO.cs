using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgroNegocio_RH_ERP_ISC_8A.Modelo;
using System.Data.SqlClient;

namespace AgroNegocio_RH_ERP_ISC_8A.Datos
{
    class Sucursales_DAO
    {
        private string cadenaconexion = "SERVER=189.135.27.179" +
               ";DATABASE=ERP2020;USER ID=sa ;Password=Hola.123";
        public List<Sucursal> consultaGeneral(string consulta_wh, List<string> parametros, List<object> valores)
        {
            List<Sucursal> sucursales = new List<Sucursal>();
            using (SqlConnection conexion = new SqlConnection(cadenaconexion))
            {
                string consulta = "select * from Sucursales " + consulta_wh;
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
                        Sucursal suc_temp = new Sucursal(lector.GetInt32(0),
                                                           lector.GetString(1),
                                                           lector.GetString(2),
                                                           lector.GetString(3),
                                                           lector.GetString(4),
                                                           lector.GetString(5),
                                                           lector.GetDouble(6),
                                                           Convert.ToChar(lector.GetString(7)),
                                                           lector.GetInt32(8));
                        sucursales.Add(suc_temp);
                    }
                }
                conexion.Close();
            }
            return sucursales;
        }
    }
}
