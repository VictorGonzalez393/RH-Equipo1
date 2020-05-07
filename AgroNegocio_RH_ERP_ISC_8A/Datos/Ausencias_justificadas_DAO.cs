using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AgroNegocio_RH_ERP_ISC_8A.Modelo;
namespace AgroNegocio_RH_ERP_ISC_8A.Datos
{
    class Ausencias_justificadas_DAO : Paginacion
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
        public List<Ausencia_justificada> consultaGeneral(string consulta_wh, List<string> parametros, List<object> valores)
        {
            List<Ausencia_justificada> ausencias_Justificadas = new List<Ausencia_justificada>();
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

                        Ausencia_justificada ausencia_temp = new Ausencia_justificada(lector.GetInt32(0),
                                                           lector.GetString(1),
                                                           lector.GetString(2),
                                                           lector.GetString(3),
                                                           lector.GetString(4),
                                                           lector.GetInt32(5),
                                                           lector.GetInt32(6),
                                                           lector.GetString(7)[0]);
                        ausencias_Justificadas.Add(ausencia_temp);
                    }
                }
                conexion.Close();
            }
            return ausencias_Justificadas;
        }
        /**
        * Registrar
        * Método para registrar los valores en la BD.
        * Recibe un objeto de tipo deduccion
        * retorna verdadero si el insert se realiza de manera correcta, falso 
        * si hay un error en la inserción 
        */
        public bool registrar(Ausencia_justificada ausencia_Justificada)
        {
            bool insert = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "insert into Deducciones values (@idAusencia, @fechaSolicitud, @fechaInicio, @fechaFin, @tipo, @idEmpleadoS, @idEempleadoA, @estatus)";
                    ausencia_Justificada.IdAusencia = getMaxID();
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();
                    comando.Parameters.AddWithValue("@idAusencia", ausencia_Justificada.IdAusencia);
                    comando.Parameters.AddWithValue("@fechaSolicitud", ausencia_Justificada.FechaSolicitud);
                    comando.Parameters.AddWithValue("@fechaInicio", ausencia_Justificada.FechaInicio);
                    comando.Parameters.AddWithValue("@fechaFin", ausencia_Justificada.FechaFin);
                    comando.Parameters.AddWithValue("@tipo", ausencia_Justificada.Tipo);
                    comando.Parameters.AddWithValue("@idEmpleadoS", ausencia_Justificada.IdEmpleadoS);
                    comando.Parameters.AddWithValue("@idEmpleadoA", ausencia_Justificada.IdEmpleadoA);
                    comando.Parameters.AddWithValue("@estatus", ausencia_Justificada.Estatus);
                    if (comando.ExecuteNonQuery() != 0)
                        insert = true;
                    conexion.Close();

                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al registrar justificacion. Error: " + ex.Message);
            }
            return insert;
        }

        public bool editar(Ausencia_justificada ausencia_Justificada)
        {
            bool editar = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "update AusenciasJustificadas set fechaSolicitud=@fechaSolicitud, fechaInicio=@fechaInicio, fechaFfin=@fechaFin, tipo=@tipo, idEmpleadoS=@idEmpleadoS, idEmpleadoA=@idEmpleadoA where idAusencia=@idAusencia";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();
                    comando.Parameters.AddWithValue("@idAusencia", ausencia_Justificada.IdAusencia);
                    comando.Parameters.AddWithValue("@fechaSolicitud", ausencia_Justificada.FechaSolicitud);
                    comando.Parameters.AddWithValue("@fechaInicio", ausencia_Justificada.FechaInicio);
                    comando.Parameters.AddWithValue("@fechaFin", ausencia_Justificada.FechaFin);
                    comando.Parameters.AddWithValue("@tipo", ausencia_Justificada.Tipo);
                    comando.Parameters.AddWithValue("@idEmpleadoS", ausencia_Justificada.IdEmpleadoS);
                    comando.Parameters.AddWithValue("@idEmpleadoA", ausencia_Justificada.IdEmpleadoA);
                    comando.Parameters.AddWithValue("@estatus", ausencia_Justificada.Estatus);
                    if (comando.ExecuteNonQuery() != 0)
                        editar = true;
                    conexion.Close();
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al editar la justificacion. Error: " + ex.Message);
            }
            return editar;
        }
        /**
        * Eliminar
        * Método para eliminar logicamente la deducción
        */
        public bool eliminar(int idA)
        {
            bool eliminar = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "update AusenciasJustificadas set estatus='I' where idAusencia=@idAusencia";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();
                    comando.Parameters.AddWithValue("@idDeduccion", idA);
                    if (comando.ExecuteNonQuery() != 0)
                        eliminar = true;
                    conexion.Close();
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al eliminar la justificacion. Error: " + ex.Message);
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

                string consulta = "select max(idAusencia)+1 from AusenciasJustificadas";
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
        * ValidarDeduccion
        * Método para validar si la deduccion existe o no en la BD
        */
        public bool validarAusencia_iustificada(Ausencia_justificada ausencia_Justificada)
        {
            bool validar = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "select idAusencia from AusenciasJustificadas where fechaSsolicitud=@fechaSolicitud and estatus='A'";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();
                    comando.Parameters.AddWithValue("@fechaSolicitud", ausencia_Justificada.FechaSolicitud);
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
                Console.WriteLine("Error al validar justificacion. Error: " + ex.Message);
            }
            return validar;
        }
    }

}
    

