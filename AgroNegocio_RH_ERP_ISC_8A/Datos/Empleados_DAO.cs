/*using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgroNegocio_RH_ERP_ISC_8A.Modelo;

namespace AgroNegocio_RH_ERP_ISC_8A.Datos
{
    class Empleados_DAO
    {
        private string cadenaconexion = "SERVER=localhost" +
               ";DATABASE=ERP2020;USER ID=sa ;Password=Hola.123";
        public List<Empleado> consultaGeneral(string consulta_wh, List<string> parametros, List<object> valores)
        {
            List<Empleado> deducciones = new List<Empleado>();
            using (SqlConnection conexion = new SqlConnection(cadenaconexion))
            {
                string consulta = "select * from Empleados " + consulta_wh;
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

                        Empleado emp_temp = new Empleado(lector.GetInt32(0),
                                                           lector.GetString(1),
                                                           lector.GetString(2),
                                                           lector.GetString(3),
                                                           lector.GetChar(4),
                                                           lector.GetString(5),
                                                           lector.GetString(6),
                                                           lector.GetFloat(7),
                                                           lector.GetString(8),
                                                           lector.GetString(9),
                                                           lector.GetInt32(10),
                                                           lector.GetInt32(11),
                                                           lector.GetByte(12),
                                                           lector.GetString(13),
                                                           lector.GetString(14),
                                                           lector.GetString(15),
                                                           lector.GetString(16),
                                                           lector.GetFloat(17),
                                                           lector.GetChar(18),
                                                           (lector.GetInt32(19),
                                                           (lector.GetInt32(20),
                                                           (lector.GetInt32(21),
                                                           (lector.GetInt32(22);

                        empleados.Add(emp_temp);
                    }
                }
                conexion.Close();
            }
            return deducciones;
        }





    }
}*/

