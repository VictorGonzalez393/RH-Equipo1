using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AgroNegocio_RH_ERP_ISC_8A.Modelo;
namespace AgroNegocio_RH_ERP_ISC_8A.Datos
{
    class Deducciones_DAO : Paginacion
    {
        private string cadenaconexion = "SERVER=189.135.27.179" +
                ";DATABASE=ERP2020;USER ID=sa ;Password=Hola.123";

        /**
         * Consulta General
         * Recibe:
         * Clausula where
         * Parametros
         * Valores
         */
        public List<Deduccion> consultaGeneral(string consulta_wh, List<string> parametros, List<object> valores)
        {
            List<Deduccion> deducciones = new List<Deduccion>();
            using (SqlConnection conexion = new SqlConnection(cadenaconexion))
            {
                string consulta = "select * from Deducciones " + consulta_wh;
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
                        
                        Deduccion ded_temp = new Deduccion(lector.GetInt32(0),
                                                           lector.GetString(1),
                                                           lector.GetString(2),
                                                           lector.GetDouble(3),
                                                           lector.GetString(4)[0]);
                        deducciones.Add(ded_temp);
                    }
                }
                conexion.Close();
            }
            return deducciones;
        }


        /**
         * Registrar
         * Método para registrar los valores en la BD.
         * Recibe un objeto de tipo deduccion
         * retorna verdadero si el insert se realiza de manera correcta, falso 
         * si hay un error en la inserción 
         */
        public bool registrar(Deduccion deduccion)
        {
            bool insert = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "insert into Deducciones values (@idDeduccion, @nombre, @descripcion, @porcentaje, @estatus)";
                    deduccion.IdDeduccion = getMaxID();
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();
                    comando.Parameters.AddWithValue("@idDeduccion", deduccion.IdDeduccion);
                    comando.Parameters.AddWithValue("@nombre", deduccion.Nombre);
                    comando.Parameters.AddWithValue("@descripcion", deduccion.Descripcion);
                    comando.Parameters.AddWithValue("@porcentaje", deduccion.Porcentaje);
                    comando.Parameters.AddWithValue("@estatus", deduccion.Estatus);
                    if (comando.ExecuteNonQuery() != 0)
                        insert = true;
                    conexion.Close();

                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al registrar deducción. Error: " + ex.Message);
            }
            return insert;
        }

        public bool editar(Deduccion deduccion)
        {
            bool editar = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "update Deducciones set nombre= @nombre, descripcion = @descripcion, porcentaje=@porcentaje where idDeduccion=@idDeduccion";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();
                    comando.Parameters.AddWithValue("@idDeduccion", deduccion.IdDeduccion);
                    comando.Parameters.AddWithValue("@nombre", deduccion.Nombre);
                    comando.Parameters.AddWithValue("@descripcion", deduccion.Descripcion);
                    comando.Parameters.AddWithValue("@porcentaje", deduccion.Porcentaje);
                    if (comando.ExecuteNonQuery() != 0)
                        editar = true;
                    conexion.Close();
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al editar la deduccion. Error: " + ex.Message);
            }
            return editar;
        }

        /**
         * Eliminar
         * Método para eliminar logicamente la deducción
         */
        public bool eliminar(int idP)
        {
            bool eliminar = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "update Deducciones set estatus='I' where idDeduccion=@idDeduccion";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();
                    comando.Parameters.AddWithValue("@idDeduccion", idP);
                    if (comando.ExecuteNonQuery() != 0)
                        eliminar = true;
                    conexion.Close();
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al eliminar la deduccion. Error: " + ex.Message);
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
                
                string consulta = "select max(idDeduccion)+1 from Deducciones";
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

        public double getPorcentaje(string idD)
        {
            double p = 0;
            using (SqlConnection conexion = new SqlConnection(cadenaconexion))
            {
                string consulta = "select porcentaje from Deducciones where nombre='" +idD+"'";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                conexion.Open();
                var sa = comando.ExecuteScalar();
                if (sa.GetType().Equals(typeof(DBNull)))
                {
                    p = 0;
                }
                else
                {
                    p = (double)sa;
                }
                conexion.Close();
            }
            return p;
        }
        public int getIdD(string idD)
        {
            int p = 0;
            using (SqlConnection conexion = new SqlConnection(cadenaconexion))
            {
                string consulta = "select idDeduccion from Deducciones where nombre='" + idD + "'";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                conexion.Open();
                var sa = comando.ExecuteScalar();
                if (sa.GetType().Equals(typeof(DBNull)))
                {
                    p = 0;
                }
                else
                {
                    p = (int)sa;
                }
                conexion.Close();
            }
            return p;
        }

        /**
         * ValidarDeduccion
         * Método para validar si la deduccion existe o no en la BD
         */
        public bool validarDeduccion(Deduccion deduccion)
        {
            bool validar = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "select idDeduccion from Deducciones where nombre=@nombre and estatus='A'";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();
                    comando.Parameters.AddWithValue("@nombre", deduccion.Nombre);
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
                Console.WriteLine("Error al validar deducción. Error: " + ex.Message);
            }
            return validar;
        }
    }
}
