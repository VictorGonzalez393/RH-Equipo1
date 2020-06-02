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
        private string cadenaconexion = "SERVER=189.135.27.179" +
               ";DATABASE=ERP2020;USER ID=sa ;Password=Hola.123";

        public List<DocumentacionEmpleado> consultaGeneral(string consulta_where_h, List<string> parametros, List<object> valores)
        {
            List<DocumentacionEmpleado> DocumentacionEmpleados = new List<DocumentacionEmpleado>();
            using (SqlConnection con = new SqlConnection(cadenaconexion))
            {
                string consulta = "select * from DocumentacionEmpleado " + consulta_where_h;
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
                                                                                             lector.GetDateTime(2),
                                                                                             (byte[])lector[3],
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

        public bool registrarDocumentos(List<DocumentacionEmpleado> docs)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaconexion))
            {
                conexion.Open();

                SqlCommand comando = conexion.CreateCommand();
                SqlTransaction trans;

                trans = conexion.BeginTransaction("RegistrarDocumentos");

                comando.Connection = conexion;
                comando.Transaction = trans;

                try
                {
                    foreach (DocumentacionEmpleado doc in docs)
                    {
                        comando.Parameters.Clear();
                        if (doc.IDDoc != 0)//update
                        {
                            if (doc.Estatus == 'I')
                                comando.CommandText = "delete from DocumentacionEmpleado where idDocumento=@id";
                            else
                                comando.CommandText = "update DocumentacionEmpleado set nombredocumento=@nombre, fechaEntrega=@fechaE, documento=@documento," +
                                " estatus='A' where idDocumento=@id";
                        }
                        else //insert
                        {
                            comando.CommandText = "insert into DocumentacionEmpleado values (@nombre,@fechaE,@documento,'A', @idempleado)";
                        }
                        comando.Parameters.AddWithValue("@nombre", doc.NombreDocumento);
                        comando.Parameters.AddWithValue("@fechaE", doc.Fecha);
                        comando.Parameters.AddWithValue("@documento", doc.Documento);
                        comando.Parameters.AddWithValue("@id", doc.IDDoc);
                        comando.Parameters.AddWithValue("@idempleado", doc.IDEmpleado);

                        if (comando.ExecuteNonQuery() != 1)
                        {
                            trans.Rollback();
                            return false;
                        }
                    }
                    trans.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    try
                    {
                        trans.Rollback();
                        throw new Exception("Error con la BD. Anota este error y contacta al administrador.\n" + ex.Message);
                    }
                    catch (Exception ex2)
                    {
                        throw new Exception(ex2.Message);
                    }
                }
            }
        }
    }
}
