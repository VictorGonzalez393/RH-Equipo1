using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgroNegocio_RH_ERP_ISC_8A.Modelo;

namespace AgroNegocio_RH_ERP_ISC_8A.Datos
{
    class Ciudades_DAO
    {

        private string cadenaconexion = "SERVER=localhost" +
                ";DATABASE=ERP2020;USER ID=sa ;Password=Hola.123";

        //
        /*
         * 
         * */
        public List<Ciudad> consultaGeneral(string consulta_where, List<string> parametros, List<object> valores)
        {
            List<Ciudad> ciudades = new List<Ciudad>();
            using (SqlConnection conexion = new SqlConnection(cadenaconexion))
            {
                string consulta = "select * from ciudades "+consulta_where;
                //idCiudad	nombre	idEstado	estatus
                //0         1       2           3
                SqlCommand comando = new SqlCommand(consulta, conexion);
                for(int i =0; i< parametros.Count; i++)
                {
                    comando.Parameters.AddWithValue(parametros[i], valores[i]);
                }

                conexion.Open();
                SqlDataReader lector = comando.ExecuteReader();
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        Ciudad ciudad_temporal = new Ciudad(lector.GetInt32(0),
                                                            lector.GetString(1),
                                                            lector.GetInt32(2),
                                                            lector.GetString(3)[0]);
                        ciudades.Add(ciudad_temporal);
                    }
                }
                conexion.Close();
            }
            return ciudades;
        }


        public bool registrar(Ciudad ciudad)
        {
            bool insert = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "insert into ciudades values (@id, @nombre, @idestado, @estatus)";
                    ciudad.ID = getMaxID();

                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();

                    comando.Parameters.AddWithValue("@id", ciudad.ID);
                    comando.Parameters.AddWithValue("@nombre", ciudad.Nombre);
                    comando.Parameters.AddWithValue("@idestado", ciudad.IDEstado);
                    comando.Parameters.AddWithValue("@estatus", ciudad.Estatus);
                    if (comando.ExecuteNonQuery() != 0)
                        insert = true;

                    conexion.Close();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al registrar ciudad. Error: " + ex.Message);
            }

            return insert;
        }

        public bool editar(Ciudad ciudad)
        {
            bool insert = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "update ciudades set nombre= @nombre, idestado=@idestado, estatus = @estatus " +
                        "where idciudad=@id";

                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();

                    comando.Parameters.AddWithValue("@id", ciudad.ID);
                    comando.Parameters.AddWithValue("@nombre", ciudad.Nombre);
                    comando.Parameters.AddWithValue("@idestado", ciudad.IDEstado);
                    comando.Parameters.AddWithValue("@estatus", ciudad.Estatus);
                    if (comando.ExecuteNonQuery() != 0)
                        insert = true;

                    conexion.Close();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al editar ciudad. ");
            }
            return insert;
        }

        public bool eliminar(int idciudad)
        {
            bool insert = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "update ciudades set estatus = 'I' " +
                        "where idciudad=@id";

                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();

                    comando.Parameters.AddWithValue("@id", idciudad);
                    if (comando.ExecuteNonQuery() != 0)
                        insert = true;

                    conexion.Close();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al eliminar la ciudad.Error: " + ex.Message);
            }
            return insert;
        }


        private int getMaxID()
        {
            int nuevo_ID = 0;
            using (SqlConnection conexion = new SqlConnection(cadenaconexion))
            {
                string consulta = "select max(idciudad)+1 from ciudades";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                conexion.Open();
                
                var ID = comando.ExecuteScalar();
                if (ID.GetType().Equals(typeof(DBNull))){
                    nuevo_ID = 1;
                }
                else
                {
                    nuevo_ID = (int)ID;
                }
                conexion.Close();
            }
            return nuevo_ID;
        }

        /*
         * Metodo que valida si la ciudad ya existe o no
         */
        public bool validarCiudad(Ciudad ciudad)
        {
            bool disponible = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "select idciudad from ciudades where nombre= @NOMBRE " +
                        "and idestado= @idestado";

                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();

                    comando.Parameters.AddWithValue("@nombre", ciudad.Nombre);
                    comando.Parameters.AddWithValue("@idestado", ciudad.IDEstado);
                    SqlDataReader lector = comando.ExecuteReader();

                    if (lector.HasRows)
                        disponible = false;
                    else
                        disponible = true;

                    conexion.Close();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al validar ciudad. Error: " + ex.Message);
            }
            return disponible;
        }

        public bool validarCiudadEditar(Ciudad ciudad)
        {
            bool disponible = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "select idciudad from ciudades where nombre= @NOMBRE " +
                        "and idestado= @idestado and idCiudad != @idciudad";

                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();

                    comando.Parameters.AddWithValue("@nombre", ciudad.Nombre);
                    comando.Parameters.AddWithValue("@idciudad", ciudad.ID);
                    comando.Parameters.AddWithValue("@idestado", ciudad.IDEstado);
                    SqlDataReader lector = comando.ExecuteReader();

                    if (lector.HasRows)
                        disponible = false;
                    else
                        disponible = true;

                    conexion.Close();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al validar ciudad. Error: " + ex.Message);
            }
            return disponible;
        }

    }
}
