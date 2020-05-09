using AgroNegocio_RH_ERP_ISC_8A.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroNegocio_RH_ERP_ISC_8A.Datos
{
    class NominaDeduccion_DAO
    {
        private string cadenaconexion = "SERVER=localhost" +
                ";DATABASE=ERP2020;USER ID=sa ;Password=Hola.123";

        public List<NominaDeduccion> consultaGeneral(string consulta_wh, List<string> parametros, List<object> valores)
        {
            List<NominaDeduccion> deducciones = new List<NominaDeduccion>();
            using (SqlConnection conexion = new SqlConnection(cadenaconexion))
            {
                string consulta = "select nd.idNomina, nd.idDeduccion, nd.importe, nd.estatus, d.Nombre, d.Descripcion from Deducciones d join NominasDeducciones nd on d.idDeduccion = nd.idDeduccion" + consulta_wh;
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

                        NominaDeduccion ded_temp = new NominaDeduccion(lector.GetInt32(0),
                                                           lector.GetInt32(1),
                                                           lector.GetFloat(2),
                                                           lector.GetString(3)[0],
                                                           lector.GetString(4),
                                                           lector.GetString(5));
                        deducciones.Add(ded_temp);
                    }
                }
                conexion.Close();
            }
            return deducciones;
        }


        public bool registrar(NominaDeduccion deduccion, double totalD, double cantNeta)
        {
            bool insert = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "insert into NominasDeducciones values (@idNomina, @idDeduccion, @importe, @estatus)";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();
                    comando.Parameters.AddWithValue("@idNomina", deduccion.idNomina);
                    comando.Parameters.AddWithValue("@idDeduccion", deduccion.idDeduccion);
                    comando.Parameters.AddWithValue("@importe", deduccion.importe);
                    comando.Parameters.AddWithValue("@estatus", deduccion.estatus);
                    if (comando.ExecuteNonQuery() != 0)
                    {
                        insert = true;
                        consulta = "";
                        consulta = "update Nominas set totalD=@totalD and cantidadNeta=@cantNeta where idNomina=@idNomina";
                        comando = new SqlCommand(consulta, conexion);
                        comando.Parameters.AddWithValue("@totalD",totalD);
                        comando.Parameters.AddWithValue("@cantidadNeta", cantNeta);
                        comando.Parameters.AddWithValue("@idNomina", deduccion.idNomina);
                        comando.ExecuteNonQuery();
                    }   
                    conexion.Close();
                }

            }
            catch (SqlException)
            {
                throw new Exception("Error al agregar Deducción a Nómina");
            }
            return insert;
        }

        public bool eliminar(int idNomina, int idDeduccion, double totalD, double cantNeta)
        {
            bool eliminar = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "update NominasDeducciones set estatus='I' where idNomina=@idNomina and idDeduccion=@idDeduccion";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();
                    comando.Parameters.AddWithValue("@idNomina", idNomina);
                    comando.Parameters.AddWithValue("@idDeduccion", idDeduccion);
                    if (comando.ExecuteNonQuery() != 0)
                    {
                        eliminar = true;
                        consulta = "";
                        consulta = "update Nominas set totalD=@totalD and cantidadNeta=@cantNeta where idNomina=@idNomina";
                        comando = new SqlCommand(consulta, conexion);
                        comando.Parameters.AddWithValue("@totalD", totalD);
                        comando.Parameters.AddWithValue("@cantidadNeta", cantNeta);
                        comando.Parameters.AddWithValue("@idNomina", idNomina);
                        comando.ExecuteNonQuery();
                    }
                    conexion.Close();
                }

            }
            catch (SqlException)
            {
                Console.WriteLine("Error al eliminar Deduccion de Nomina.");
            }
            return eliminar;
        }

    }
}
