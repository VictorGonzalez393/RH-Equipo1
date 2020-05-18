using AgroNegocio_RH_ERP_ISC_8A.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroNegocio_RH_ERP_ISC_8A.Datos
{
    class NominaPercepcion_DAO
    {
        private string cadenaconexion = "SERVER=localhost" +
               ";DATABASE=ERP2020;USER ID=sa ;Password=Hola.123";

        public List<NominaPercepcion> consultaGeneral(string consulta_wh, List<string> parametros, List<object> valores)
        {
            List<NominaPercepcion> percepciones = new List<NominaPercepcion>();
            using (SqlConnection conexion = new SqlConnection(cadenaconexion))
            {
                string consulta = "select * from NominasPercepciones_Tabla" + consulta_wh;
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

                        NominaPercepcion per_temp = new NominaPercepcion(lector.GetInt32(0),
                                                           lector.GetInt32(1),
                                                           lector.GetDouble(2),
                                                           Convert.ToChar(lector.GetString(3)),
                                                           lector.GetString(4),
                                                           lector.GetString(5));
                        percepciones.Add(per_temp);
                    }
                }
                conexion.Close();
            }
            return percepciones;
        }


        public bool registrar(NominaPercepcion percepcion, double totalP, double cantNeta)
        {
            bool insert = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "insert into NominasPercepciones values (@idNomina, @idPercepcion, @importe, @estatus)";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();
                    comando.Parameters.AddWithValue("@idNomina", percepcion.idNomina);
                    comando.Parameters.AddWithValue("@idPercepcion", percepcion.idPercepcion);
                    comando.Parameters.AddWithValue("@importe", percepcion.importe);
                    comando.Parameters.AddWithValue("@estatus", percepcion.estatus);
                    if (comando.ExecuteNonQuery() != 0)
                    {

                        consulta = "";
                        consulta = "update Nominas set totalP=@totalP, cantidadNeta=@cantNeta where idNomina=@idNomina";
                        comando = new SqlCommand(consulta, conexion);
                        comando.Parameters.AddWithValue("@totalP", totalP);
                        comando.Parameters.AddWithValue("@cantNeta", cantNeta);
                        comando.Parameters.AddWithValue("@idNomina", percepcion.idNomina);
                        comando.ExecuteNonQuery();
                        insert = true;
                    }
                    conexion.Close();
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al agregar Percepción a Nómina" + ex.Message);
            }
            return insert;
        }

        public bool eliminar(int idNomina, int idPercepcion, double totalP, double cantNeta)
        {
            bool eliminar = false;
            Console.WriteLine(idNomina + " " + idPercepcion + " " + totalP + " " + cantNeta);
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {

                    string consulta = "Delete from NominasPercepciones where idNomina=@idnom and idPercepcion=@idper";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();
                    comando.Parameters.AddWithValue("@idnom", idNomina);
                    comando.Parameters.AddWithValue("@idper", idPercepcion);
                    //Mensajes.Info("Com: "+comando.ExecuteNonQuery());
                    if (comando.ExecuteNonQuery() != 0)
                    {
                        Console.WriteLine(idNomina + " " + idPercepcion + " - " + totalP + " " + cantNeta);
                        consulta = "";
                        consulta = "update Nominas set totalP=@totalP, cantidadNeta=@cantNeta where idNomina=@idn";
                        comando = new SqlCommand(consulta, conexion);
                        comando.Parameters.AddWithValue("@totalP", totalP);
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
                Console.WriteLine("Error al eliminar Percepcion de Nomina." + ex.Message);
            }
            return eliminar;
        }
        public bool eliminar2(int idNomina, int idPercepcion)
        {
            bool eliminar = false;
            //Console.WriteLine(idNomina + " " + idPercepcion + " " + totalP + " " + cantNeta);
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {

                    string consulta = "Delete from NominasPercepciones where idNomina=@idnom and idPercepcion=@idper";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();
                    comando.Parameters.AddWithValue("@idnom", idNomina);
                    comando.Parameters.AddWithValue("@idper", idPercepcion);
                    
                    if (comando.ExecuteNonQuery() != 0)
                    {                        
                        eliminar = true;
                    }
                    conexion.Close();
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al eliminar Percepcion de Nomina." + ex.Message);
            }
            return eliminar;
        }
        public bool editar(int idNomina, int idPercepcion, double imp)
        {
            bool editar = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {

                    string consulta = "update NominasPercepciones set importe=@imp where idNomina=@idnom and idPercepcion=@idper";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();
                    comando.Parameters.AddWithValue("@idnom", idNomina);
                    comando.Parameters.AddWithValue("@idper", idPercepcion);
                    comando.Parameters.AddWithValue("@imp", imp);
                    if (comando.ExecuteNonQuery() != 0)
                    {
                        editar = true;
                    }
                    conexion.Close();
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al eliminar Deduccion de Nomina." + ex.Message);
            }
            return editar;
        }
    }
}
