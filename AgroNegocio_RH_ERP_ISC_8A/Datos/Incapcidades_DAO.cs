using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgroNegocio_RH_ERP_ISC_8A.Modelo;
using System.IO;

namespace AgroNegocio_RH_ERP_ISC_8A.Datos
{
    class Incapcidades_DAO:Paginacion
    {
        private string cadenaconexion = "SERVER=localhost" + ";DATABASE=ERP2020;USER ID=sa ;Password=Hola.123";
        
        public List<Incapacidad> consultaGeneral(string consulta_wh, List<string> parametros, List<object> valores)
        {
            List<Incapacidad> incapacidades = new List<Incapacidad>();
            using(SqlConnection conexion = new SqlConnection(cadenaconexion)){
                string consulta = "select * from Incapacidades_Tabla " + consulta_wh;
                SqlCommand comando = new SqlCommand(consulta, conexion);
                for(int i=0; i < parametros.Count; i++)
                {
                    comando.Parameters.AddWithValue(parametros[i], valores[i]);
                }
                conexion.Open();
                SqlDataReader lector = comando.ExecuteReader();
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        Incapacidad inc_temp = new Incapacidad(lector.GetInt32(0),
                                                               lector.GetInt32(1),
                                                               lector.GetString(2),
                                                               lector.GetString(3),
                                                               lector.GetString(4),
                                                               lector.GetString(5),
                                                               lector.GetString(6),
                                                               (byte[])lector[7]);
                        incapacidades.Add(inc_temp);
                    }
                }
                conexion.Close();
            }
            return incapacidades;
        }
}
