using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AgroNegocio_RH_ERP_ISC_8A.Modelo;
namespace AgroNegocio_RH_ERP_ISC_8A.Datos
{
    class Percepciones_DAO : Paginacion
    {
        private string cadenaconexion = "SERVER=localhost" +
                ";DATABASE=ERP2020;USER ID=sa ;Password=Hola.123";


        /**
         * Consulta General
         * Recibe:
         * Clausula where
         * Parametros
         * Valores
         */
        public List<Percepcion> consultaGeneral(string consulta_wh, List<string> parametros, List<object> valores)
        {
            List<Percepcion> percepciones = new List<Percepcion>();
            using (SqlConnection conexion = new SqlConnection(cadenaconexion))
            {
                string consulta = "select * from Percepciones_Tabla " + consulta_wh;
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
                        Percepcion per_temp = new Percepcion(lector.GetInt32(0),
                                                           lector.GetString(1),
                                                           lector.GetString(2),
                                                           lector.GetInt32(3),
                                                           lector.GetString(4)[0]);
                        percepciones.Add(per_temp);
                    }
                }
                conexion.Close();
            }
            return percepciones;
        }


        /**
         * Registrar
         * Método para registrar los valores en la BD.
         * Recibe un objeto de tipo percepcion
         * retorna verdadero si el insert se realiza de manera correcta, falso 
         * si hay un error en la inserción 
         */
        public bool registrar(Percepcion percepcion)
        {
            bool insert = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "insert into Percepciones values (@idPercepcion, @nombre, @descripcion, @diasPagar,@estatus)";
                    percepcion.IdPercepcion = getMaxID();
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();
                    comando.Parameters.AddWithValue("@idPercepcion", percepcion.IdPercepcion);
                    comando.Parameters.AddWithValue("@nombre", percepcion.Nombre);
                    comando.Parameters.AddWithValue("@descripcion", percepcion.Descripcion);
                    comando.Parameters.AddWithValue("@diasPagar", percepcion.DiasPagar);
                    comando.Parameters.AddWithValue("@estatus", percepcion.Estatus);
                    if (comando.ExecuteNonQuery() != 0)
                        insert = true;
                    conexion.Close();

                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al registrar percepción. "+ex.Message);
            }
            return insert;
        }

        public bool editar(Percepcion percepcion)
        {
            bool editar = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "update Percepciones set nombre= @nombre, descripcion = @descripcion, diasPagar=@diasPagar where idPercepcion=@idPercepcion";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();
                    comando.Parameters.AddWithValue("@idPercepcion", percepcion.IdPercepcion);
                    comando.Parameters.AddWithValue("@nombre", percepcion.Nombre);
                    comando.Parameters.AddWithValue("@descripcion", percepcion.Descripcion);
                    comando.Parameters.AddWithValue("@diasPagar", percepcion.DiasPagar);
                    if (comando.ExecuteNonQuery() != 0)
                        editar = true;
                    conexion.Close();

                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al editar la percepcion. Error: " + ex.Message);
            }
            return editar;
        }

        /**
         * Eliminar
         * Método para eliminar logicamente la percepción
         */
        public bool eliminar(int idP)
        {
            bool eliminar = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "update Percepciones set estatus='I' where idPercepcion=@idPercepcion";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();
                    comando.Parameters.AddWithValue("@idPercepcion", idP);
                    if (comando.ExecuteNonQuery() != 0)
                        eliminar = true;
                    conexion.Close();
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al eliminar la percepcion. Error: " + ex.Message);
            }
            return eliminar;
        }

        /**
         * getMaxID
         * Método para obtener el último ID
         */
        public int getMaxID()
        {
            int new_ID = 0;
            using (SqlConnection conexion = new SqlConnection(cadenaconexion))
            {
                string consulta = "select max(idPercepcion)+1 from Percepciones";
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

        /**
         * ValidarPercepcion
         * Método para validar si la percepcion existe o no en la BD
         */
        public bool validarPercepcion(Percepcion percepcion)
        {
            bool validar = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "select idPercepcion from Percepciones where nombre=@nombre and estatus='A'";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();
                    comando.Parameters.AddWithValue("@nombre", percepcion.Nombre);
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
               Console.WriteLine("Error al validar percepción. Error: "+ex.Message);
            }
            return validar;
        }

    }
}
