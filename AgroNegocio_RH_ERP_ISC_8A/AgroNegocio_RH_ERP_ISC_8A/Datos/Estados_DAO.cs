using AgroNegocio_RH_ERP_ISC_8A.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroNegocio_RH_ERP_ISC_8A.Datos
{
    class Estados_DAO
    {
        private string cadenaconexion = "SERVER=localhost" +
                ";DATABASE=ERP2020;USER ID=sa ;Password=Hola.123";

        /*
         * Método para la consulta General de estados 
         */
        public List<Estado> consultaGeneral(string consulta_where, List<string> parametros, List<object> valores)
        {
            List<Estado> estados = new List<Estado>();
            using (SqlConnection conexion = new SqlConnection(cadenaconexion))
            {
                string consulta = "select * from Estados " + consulta_where;

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
                        Estado estado_temporal = new Estado(lector.GetInt32(0),
                                                            lector.GetString(1),
                                                            lector.GetString(2),
                                                            lector.GetString(3)[0]);
                        parametros.Clear();
                        valores.Clear();
                        parametros.Add("@id");
                        valores.Add(estado_temporal.IdEstado);
                        estado_temporal.Ciudades = new Ciudades_DAO().consultaGeneral(" where idEstado=@id", parametros, valores);
                        estados.Add(estado_temporal);
                    }
                }
                conexion.Close();
            }
            return estados;
        }

        /*
         * Método para registrar un estado
         */
        public bool registrar(Estado estado)
        {
            bool insert = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "insert into Estados values (@idEstado, @nombre, @siglas, @estatus)";
                    estado.IdEstado = getMaxID();
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();
                    comando.Parameters.AddWithValue("@idEstado", estado.IdEstado);
                    comando.Parameters.AddWithValue("@nombre", estado.Nombre);
                    comando.Parameters.AddWithValue("@siglas", estado.Siglas);
                    comando.Parameters.AddWithValue("@estatus", estado.Estatus);
                    if (comando.ExecuteNonQuery() != 0)
                        insert = true;
                    conexion.Close();

                }

            }
            catch (SqlException ex)
            {
                throw new Exception("Error al registrar estado. Error: " + ex.Message);
            }
            return insert;
        }

        /*
        *Método para editar
         */

        public bool editar(Estado estado)
        {
            bool editar = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "update Estados set nombre= @nombre, siglas = @siglas where idEstado=@idEstado";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();
                    comando.Parameters.AddWithValue("@idEstado", estado.IdEstado);
                    comando.Parameters.AddWithValue("@nombre", estado.Nombre);
                    comando.Parameters.AddWithValue("@siglas", estado.Siglas);
                    if (comando.ExecuteNonQuery() != 0)
                        editar = true;
                    conexion.Close();
                }

            }
            catch (SqlException ex)
            {
                throw new Exception("Error al editar el estado. Error: " + ex.Message);
            }
            return editar;
        }

        /*
         * Método para eliminar
         */

        public bool eliminar(int idE)
        {
            bool eliminar = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "update Estados set estatus='I' where idEstado=@idEstado";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();
                    comando.Parameters.AddWithValue("@idEstado", idE);
                    if (comando.ExecuteNonQuery() != 0)
                        eliminar = true;
                    conexion.Close();
                }

            }
            catch (SqlException ex)
            {
                throw new Exception("Error al eliminar el estado. Error: " + ex.Message);
            }
            return eliminar;
        }

        /*
         * Obetener el siguiente ID
         */

        public int getMaxID()
        {
            int new_ID = 0;
            using (SqlConnection conexion = new SqlConnection(cadenaconexion))
            {
                string consulta = "select max(idEstado)+1 from Estados";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                conexion.Open();
                var ID = comando.ExecuteScalar();
                if (ID.GetType().Equals(typeof(DBNull)))
                {
                    new_ID = 1;
                }
                else
                {
                    new_ID = (int)ID;
                }
                conexion.Close();
            }
            return new_ID;
        }

        /*
         * Validar el Estado
         */

        public bool validarEstado(Estado estado)
        {
            bool validar = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "select idEstado from Estados where nombre=@nombre";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();
                    comando.Parameters.AddWithValue("@nombre", estado.Nombre);
                    SqlDataReader lector = comando.ExecuteReader();
                    if (lector.HasRows)
                    {
                        validar = false;
                    }
                    else
                    {
                        validar = true;
                    }
                    conexion.Close();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al validar Estado. Error: " + ex.Message);
            }
            return validar;
        }
    }
}
