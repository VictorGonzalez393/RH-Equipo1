using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AgroNegocio_RH_ERP_ISC_8A.Modelo;

namespace AgroNegocio_RH_ERP_ISC_8A.Datos
{
    class Puestos_DAO : Paginacion
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
        public List<Puesto> consultaGeneral(string consulta_wh, List<string> parametros, List<object> valores)
        {
            List<Puesto> puestos = new List<Puesto>();
            using (SqlConnection conexion = new SqlConnection(cadenaconexion))
            {
                string consulta = "select * from Puestos " + consulta_wh;
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
                        Puesto per_temp = new Puesto(lector.GetInt32(0),
                                                           lector.GetString(1),
                                                          (decimal) lector.GetDouble(2),
                                                          (decimal) lector.GetDouble(3),
                                                           lector.GetString(4)[0]);
                        puestos.Add(per_temp);
                    }
                }
                conexion.Close();
            }
            return puestos;
        }


        /**
         * Registrar
         * Método para registrar los valores en la BD.
         * Recibe un objeto de tipo puesto
         * retorna verdadero si el insert se realiza de manera correcta, falso 
         * si hay un error en la inserción 
         */
        public bool registrar(Puesto puesto)
        {
            bool insert = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "insert into Puestos values (@idPuesto, @nombre, @samin, @samax,@estatus)";
                    puesto.IdPuesto = getMaxID();
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();
                    comando.Parameters.AddWithValue("@idPuesto", puesto.IdPuesto);
                    comando.Parameters.AddWithValue("@nombre", puesto.Nombre);
                    comando.Parameters.AddWithValue("@samin", puesto.Samin);
                    comando.Parameters.AddWithValue("@samax", puesto.Samax);
                    comando.Parameters.AddWithValue("@estatus", puesto.Estatus);
                    if (comando.ExecuteNonQuery() != 0)
                        insert = true;
                    conexion.Close();

                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al registrar puesto. " + ex.Message);
            }
            return insert;
        }

        public bool editar(Puesto puesto)
        {
            bool editar = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "update Puestos set nombre= @nombre, salarioMinimo = @samin, salarioMaximo=@samax where idPuesto=@idPuesto";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();
                    comando.Parameters.AddWithValue("@idPuesto", puesto.IdPuesto);
                    comando.Parameters.AddWithValue("@nombre", puesto.Nombre);
                    comando.Parameters.AddWithValue("@samin", puesto.Samin);
                    comando.Parameters.AddWithValue("@samax", puesto.Samax);
                    if (comando.ExecuteNonQuery() != 0)
                        editar = true;
                    conexion.Close();

                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al editar la puesto. Error: " + ex.Message);
            }
            return editar;
        }

        /**
         * Eliminar
         * Método para eliminar logicamente el puesto
         */
        public bool eliminar(int idP)
        {
            bool eliminar = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "update Puestos set estatus='I' where idPuesto=@idPuesto";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();
                    comando.Parameters.AddWithValue("@idPuesto", idP);
                    if (comando.ExecuteNonQuery() != 0)
                        eliminar = true;
                    conexion.Close();
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al eliminar el puesto. Error: " + ex.Message);
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
                string consulta = "select max(idPuesto)+1 from Puestos";
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
         * ValidarPuesto
         * Método para validar si la puesto existe o no en la BD
         */
        public bool validarPuesto(Puesto puesto)
        {
            bool validar = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "select idPuesto from Puestos where nombre=@nombre and estatus='A'";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();
                    comando.Parameters.AddWithValue("@nombre", puesto.Nombre);
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
                Console.WriteLine("Error al validar puesto. Error: " + ex.Message);
            }
            return validar;
        }
    }
}
