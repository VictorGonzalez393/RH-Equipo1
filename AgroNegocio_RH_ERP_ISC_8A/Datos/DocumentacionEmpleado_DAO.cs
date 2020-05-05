using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgroNegocio_RH_ERP_ISC_8A.Modelo;
using System.Data.SqlClient;

namespace AgroNegocio_RH_ERP_ISC_8A.Datos
{
    class DocumentacionEmpleado_DAO
    {
        private string cadenaconexion = "SERVER=localhost" +
               ";DATABASE=ERP2020;Persist Security Info=True;USER ID=sa ;Password=Hola.123";

        public List<DocumentacionEmpleado> consultaGeneral(string consulta_where_h, List<string> parametros, List<object> valores)
        {
            List<DocumentacionEmpleado> DocumentacionEmpleados = new List<DocumentacionEmpleado>();
            using (SqlConnection con = new SqlConnection(cadenaconexion))
            {
                string consulta = "select * from DocumentacionEmpleado" + consulta_where_h;
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
                        DocumentacionEmpleado documento_temporal = new DocumentacionEmpleado(lector.GetInt32(0),
                                                                                             lector.GetString(1),
                                                                                             lector.GetTimeSpan(2),
                                                                                             new byte[3],//lector.GetBytes(3),
                                                                                             lector.GetString(4)[0],
                                                                                             lector.GetInt32(5)
                                                                                             );
                        DocumentacionEmpleados.Add(documento_temporal);
                    }
                }
                con.Close();
            }
            return DocumentacionEmpleados;
        }
        public bool registrar(DocumentacionEmpleado documentacionEmpleados)
        {
            bool insert = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "insert into DocumentacionEmpleado values (@id, @nombre,@fechaE,@documento," +
                        " @estatus, @idempleado)";

                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id", documentacionEmpleados.ID);
                    comando.Parameters.AddWithValue("@nombre", documentacionEmpleados.nombreDocumento);
                    comando.Parameters.AddWithValue("@fechaE", documentacionEmpleados.fechaEntrega);
                    comando.Parameters.AddWithValue("@documento", documentacionEmpleados.Documento);
                    comando.Parameters.AddWithValue("@estatus", documentacionEmpleados.Estatus);
                    comando.Parameters.AddWithValue("@idempleado", documentacionEmpleados.idEmpleado);

                    if (comando.ExecuteNonQuery() != 0)
                        insert = true;

                    conexion.Close();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al registrar horario. Error: " + ex.Message);
            }

            return insert;
        }
    }
}
