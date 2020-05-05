using AgroNegocio_RH_ERP_ISC_8A.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroNegocio_RH_ERP_ISC_8A.Datos
{
    class Nomina_DAO
    {
        private string cadenaconexion = "SERVER=localhost" +
                ";DATABASE=ERP2020;Persist Security Info=True;USER ID=sa ;Password=Hola.123";
        public List<Nomina> consultaGeneral(string consulta_wh, List<string> parametros, List<object> valores)
        {
            List<Nomina> nominas = new List<Nomina>();
            using (SqlConnection conexion = new SqlConnection(cadenaconexion))
            {
                string consulta = "select * from Nominas_Tabla " + consulta_wh;
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
                        Nomina nomina_temp = new Nomina(lector.GetInt32(0),
                                                           lector.GetInt32(1),
                                                           lector.GetString(2),
                                                           lector.GetDecimal(3),
                                                           lector.GetDecimal(4),
                                                           lector.GetDecimal(5),
                                                           lector.GetInt32(6),
                                                           lector.GetInt32(7),
                                                           lector.GetString(8),
                                                           lector.GetString(9),
                                                           lector.GetString(10),
                                                           lector.GetString(11)[0]);
                        nominas.Add(nomina_temp);
                    }
                }
                conexion.Close();
            }
            return nominas;
        } 
        
        public bool insertar(Nomina nomina)
        {
            bool insert = false;
            try
            {
                using(SqlConnection conexion=new SqlConnection(cadenaconexion))
                {
                    string consulta = "sp_agrega_nomina";
                    SqlCommand comando= new SqlCommand(consulta, conexion);
                    conexion.Open();
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@fPago", nomina.fechaPago);
                    comando.Parameters.AddWithValue("@tP", nomina.totalP);
                    comando.Parameters.AddWithValue("@tD", nomina.totalD);
                    comando.Parameters.AddWithValue("@diasT", nomina.diasTrabajados);
                    comando.Parameters.AddWithValue("@fal", nomina.faltas);
                    comando.Parameters.AddWithValue("@fInicio", nomina.fechaInicio);
                    comando.Parameters.AddWithValue("@fFin", nomina.fechaFin);
                    comando.Parameters.AddWithValue("@idEmp", nomina.idEmpleado);
                    comando.Parameters.AddWithValue("@idForP", getIdFormaPago(nomina.formaPago));
                    comando.Parameters.Add("@msg", SqlDbType.VarChar, -1);
                    comando.Parameters["@msg"].Direction = System.Data.ParameterDirection.Output;
                    if (comando.ExecuteNonQuery() != 0)
                        insert = true;
                    conexion.Close();
                }

            }catch(SqlException ex)
            {
                Console.WriteLine("Error al registrar nomina. Error: " + ex.Message);
            }
            return insert;
        }

        public bool editar(Nomina nomina)
        {
            bool editar = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "sp_editar_nomina";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id", nomina.idNomina);
                    comando.Parameters.AddWithValue("@fPago", nomina.fechaPago);
                    comando.Parameters.AddWithValue("@tP", nomina.totalP);
                    comando.Parameters.AddWithValue("@tD", nomina.totalD);
                    comando.Parameters.AddWithValue("@diasT", nomina.diasTrabajados);
                    comando.Parameters.AddWithValue("@fal", nomina.faltas);
                    comando.Parameters.AddWithValue("@fInicio", nomina.fechaInicio);
                    comando.Parameters.AddWithValue("@fFin", nomina.fechaFin);
                    comando.Parameters.AddWithValue("@idEmp", nomina.idEmpleado);
                    comando.Parameters.AddWithValue("@idForP", getIdFormaPago(nomina.formaPago));
                    comando.Parameters.AddWithValue("@est", 'A');
                    comando.Parameters.Add("@msg", SqlDbType.VarChar, -1);
                    comando.Parameters["@msg"].Direction = System.Data.ParameterDirection.Output;
                    if (comando.ExecuteNonQuery() != 0)
                        editar = true;
                    conexion.Close();
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al editar la nómina. Error: " + ex.Message);
            }
            return editar;
        } 
        public bool eliminar(int idNomina)
        {
            bool eliminar = false;
            try
            {
                using(SqlConnection conexion=new SqlConnection(cadenaconexion))
                {
                    string consulta = "update Nominas set estatus = 'I' where idNomina=@id";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();
                    comando.Parameters.AddWithValue("@id", idNomina);
                    if (comando.ExecuteNonQuery() != 0)
                    {
                        eliminar = true;
                        consulta = "update NominasPercepciones set estatus='I' where idNomina=@id";
                        comando = new SqlCommand(consulta, conexion);
                        comando.Parameters.AddWithValue("@id", idNomina);
                        comando.ExecuteNonQuery();
                        consulta = "update NominasDeducciones set estatus='I' where idNomina=@id";
                        comando = new SqlCommand(consulta, conexion);
                        comando.Parameters.AddWithValue("@id", idNomina);
                        comando.ExecuteNonQuery();
                    } 
                    conexion.Close();
                }

            }catch(SqlException ex)
            {
                Console.WriteLine("Error al eliminar la nómina. Error: " + ex.Message);
            }
            return eliminar;
        }

        private int getIdFormaPago(string formaPago)
        {
            int idF=1;
            using(SqlConnection conexion=new SqlConnection(cadenaconexion))
            {
                string consulta = "select idFormaPago from FormasPago where nombre='" + formaPago + "'";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                conexion.Open();
                var id = comando.ExecuteScalar();
                if (id.GetType().Equals(typeof(DBNull)))
                {
                    idF = 1;
                }
                else
                {
                    idF = (int)id;
                }
                conexion.Close();
            }
            return idF;
        }



    }
}
