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
                string consulta = "select * from NominasDeducciones_Tabla" + consulta_wh;
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
                                                           lector.GetDouble(2),
                                                           Convert.ToChar(lector.GetString(3)),
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
                        
                        consulta = "";
                        consulta = "update Nominas set totalD=@totalD, cantidadNeta=@cantNeta where idNomina=@idNomina";
                        comando = new SqlCommand(consulta, conexion);
                        comando.Parameters.AddWithValue("@totalD",totalD);
                        comando.Parameters.AddWithValue("@cantNeta", cantNeta);
                        comando.Parameters.AddWithValue("@idNomina", deduccion.idNomina);
                        comando.ExecuteNonQuery();
                        insert = true;
                    }   
                    conexion.Close();
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al agregar Deducción a Nómina"+ex.Message);
            }
            return insert;
        }

        public bool eliminar(int idNomina, int idDeduccion, double totalD, double cantNeta)
        {
            bool eliminar = false;
            Console.WriteLine(idNomina + " " + idDeduccion + " " + totalD + " " + cantNeta);
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    
                    string consulta = "update NominasDeducciones set estatus=@est where idNomina=@idnom and idDeduccion=@iddec";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();
                    comando.Parameters.AddWithValue("@est", 'I');
                    comando.Parameters.AddWithValue("@idnom", idNomina);
                    comando.Parameters.AddWithValue("@iddec", idDeduccion);
                    
                    if (comando.ExecuteNonQuery() != 0)
                    {
                        Console.WriteLine(idNomina + " " + idDeduccion + " - " + totalD + " " + cantNeta);
                        consulta = "";
                        consulta = "update Nominas set totalD=@totalD, cantidadNeta=@cantNeta where idNomina=@idn";
                        comando = new SqlCommand(consulta, conexion);
                        comando.Parameters.AddWithValue("@totalD", totalD);
                        comando.Parameters.AddWithValue("@cantNeta", cantNeta);
                        comando.Parameters.AddWithValue("@idn", idNomina);
                        comando.ExecuteNonQuery();
                        eliminar = true;
                    }
                    else
                    {
                        Console.WriteLine("ERROR");
                    }
                    conexion.Close();
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al eliminar Deduccion de Nomina."+ ex.Message);
            }
            return eliminar;
        }

    }
}
