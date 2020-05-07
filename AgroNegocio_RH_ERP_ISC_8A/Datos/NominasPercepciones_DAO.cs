using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgroNegocio_RH_ERP_ISC_8A.Modelo;

namespace AgroNegocio_RH_ERP_ISC_8A.Datos
{
    class NominasPercepciones_DAO : Paginacion
    {
        private string cadenaconexion = "SERVER=localhost" +
               ";DATABASE=ERP2020;Persist Security Info=True;USER ID=sa ;Password=Hola.123";
        public List<NominasPercepcion> consultaGeneral(string consulta_where_h, List<string> parametros, List<object> valores)
        {
            List<NominasPercepcion> Nominasp = new List<NominasPercepcion>();
            using (SqlConnection con = new SqlConnection(cadenaconexion))
            {
                string consulta = "select * from NominasPercepciones " + consulta_where_h;

                SqlCommand comando = new SqlCommand(consulta, con);
                for (int i = 0; i < parametros.Count; i++)
                {
                    comando.Parameters.AddWithValue(parametros[i], valores[i]);
                }

                con.Open();
                SqlDataReader lector = comando.ExecuteReader();
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        NominasPercepcion nominas_temporal = new NominasPercepcion(lector.GetInt32(0),
                                                            lector.GetInt32(1),
                                                            lector.GetDouble(2),
                                                            lector.GetChar(3));
                        Nominasp.Add(nominas_temporal);
                    }
                }
                con.Close();
            }
            return Nominasp;
        }
        //Desde aqui
        public bool registrar(NominasPercepcion nominasp)
        {
            bool insert = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "insert into NominasPercepciones values (@idNomina, @idPercepcion, @importe, @estatus)";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();
                    comando.Parameters.AddWithValue("@idNomina", nominasp.IdNomina);
                    comando.Parameters.AddWithValue("@idPercepcion", nominasp.IdPercepcion);
                    comando.Parameters.AddWithValue("@importe", nominasp.Importe);
                    comando.Parameters.AddWithValue("@estatus", nominasp.Estatus);

                    if (comando.ExecuteNonQuery() != 0)
                        insert = true;
                    conexion.Close();

                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al registrar la Nomina Percepcion. " + ex.Message);
            }
            return insert;
        }
        
        public bool eliminar(int idPercepcion)
        {
            bool eliminar = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "update NominasPercepciones set estatus='I' where idPercepcion=@idPercepcion and idNomina=@idNomina";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();
                    comando.Parameters.AddWithValue("@idPercepcion", idPercepcion);
                    if (comando.ExecuteNonQuery() != 0)
                        eliminar = true;
                    conexion.Close();
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al eliminar la Nomina percepcion. Error: " + ex.Message);
            }
            return eliminar;


        }
    }
}
