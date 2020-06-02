using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgroNegocio_RH_ERP_ISC_8A.Modelo;

namespace AgroNegocio_RH_ERP_ISC_8A.Datos
{
    class FormasPago_DAO : Paginacion
    {
        private string cadenaconexion = "SERVER=189.135.27.179" +
               ";DATABASE=ERP2020;USER ID=sa ;Password=Hola.123";
        public List<FormasPago> consultaGeneral(string consulta_wh, List<string> parametros, List<object> valores)
        {
            List<FormasPago> formas = new List<FormasPago>();
            using (SqlConnection conexion = new SqlConnection(cadenaconexion))
            {
                string consulta = "select * from FormasPago " + consulta_wh;
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
                       FormasPago f_temp = new FormasPago(lector.GetInt32(0),
                                                           lector.GetString(1),
                                                           lector.GetString(2)[0]);
                        formas.Add(f_temp);
                    }
                }
                conexion.Close();
            }
            return formas;
        }
        public bool registrar(FormasPago formaspago)
        {
            bool insert = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "insert into FormasPago values (@id, @nombre, @estatus)";

                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();
                    comando.Parameters.AddWithValue("@id", formaspago.idFormaPago);
                    comando.Parameters.AddWithValue("@nombre", formaspago.nombre);
                    comando.Parameters.AddWithValue("@estatus", formaspago.estatus);

                    if (comando.ExecuteNonQuery() != 0)
                        insert = true;

                    conexion.Close();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al registrar Formas de Pago. Error: " + ex.Message);
            }

            return insert;
        }

        public bool editar(FormasPago formaspago)
        {
            bool insert = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "update FormasPago set nombre= @nombre, estatus = @estatus " +
                        "where idFormaPago=@id";

                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();

                    comando.Parameters.AddWithValue("@id", formaspago.idFormaPago);
                    comando.Parameters.AddWithValue("@nombre", formaspago.nombre);
                    comando.Parameters.AddWithValue("@estatus", formaspago.estatus);

                    if (comando.ExecuteNonQuery() != 0)
                        insert = true;
                    conexion.Close();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al editar Formas de Pago. Error: " + ex.Message);
            }

            return insert;
        }
        public bool eliminar(int idFormaPago)
        {
            bool insert = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "update FormasPago set estatus = 'I' where idFormaPago=@id";

                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();

                    comando.Parameters.AddWithValue("@id", idFormaPago);
                    if (comando.ExecuteNonQuery() != 0)
                        insert = true;

                    conexion.Close();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al eliminar la Forma de Pago.Error: " + ex.Message);
            }
            return insert;
        }
        public int getMaxID()
        {
            int new_ID = 0;
            using (SqlConnection conexion = new SqlConnection(cadenaconexion))
            {
                string consulta = "select max(idFormaPago)+1 from FormasPago";
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

        public bool validarPago(FormasPago pago)
        {
            bool validar = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "select idFormaPago from FormasPago where nombre=@nombre and estatus='A'";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();
                    comando.Parameters.AddWithValue("@nombre", pago.nombre);
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
            catch (SqlException)
            {
                Console.WriteLine("Error al validar pago.");
            }
            return validar;
        }
    }
}
