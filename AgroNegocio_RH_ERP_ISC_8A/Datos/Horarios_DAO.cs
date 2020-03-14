using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgroNegocio_RH_ERP_ISC_8A.Modelo;

namespace AgroNegocio_RH_ERP_ISC_8A.Datos
{
    class Horarios_DAO
    {
        private string cadenaconexion = "SERVER=localhost" +
                ";DATABASE=ERP2020;USER ID=sa ;Password=Hola.123";
        public List<Horario> consultaGeneral(string consulta_where_h, List<string> parametros, List<object> valores)
        {
            List<Horario> horarios = new List<Horario>();
            using (SqlConnection con = new SqlConnection(cadenaconexion))
            {
                string consulta = "select * from horarios " + consulta_where_h;
                
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
                        Horario horario_temporal = new Horario(lector.GetInt32(0),
                                                            lector.GetString(1),
                                                            lector.GetString(2),
                                                            lector.GetString(3),
                                                            lector.GetInt32(4),
                                                            lector.GetString(5)[0]);
                        horarios.Add(horario_temporal);
                    }
                }
                con.Close();
            }
            return horarios;
        }
        public bool registrar(Horario horario)
        {
            bool insert = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "sp_agregar_horarios";

                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@idEmp", horario.IDEmpleado);
                    comando.Parameters.AddWithValue("@dia", horario.Dias);
                    comando.Parameters.AddWithValue("@horaI", horario.HoraI);
                    comando.Parameters.AddWithValue("@horaF", horario.HoraF);
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
        public bool editar(Horario horario)
        {
            bool insert = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "sp_editar_horarios";

                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@idEmp", horario.IDEmpleado);
                    comando.Parameters.AddWithValue("@dia", horario.Dias);
                    comando.Parameters.AddWithValue("@horaI", horario.HoraI);
                    comando.Parameters.AddWithValue("@horaF", horario.HoraF);
                    if (comando.ExecuteNonQuery() != 0)
                        insert = true;

                    conexion.Close();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al editar horario. Error: " + ex.Message);
            }

            return insert;
        }
        public bool eliminar(int idHorario)
        {
            bool insert = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                { 
                    string consulta = "update Horarios set estatus = 'I' where idhorario=@id";

                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();

                    comando.Parameters.AddWithValue("@id", idHorario);
                    if (comando.ExecuteNonQuery() != 0)
                        insert = true;

                    conexion.Close();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al eliminar el horario.Error: " + ex.Message);
            }
            return insert;
        }


    }
}
