using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgroNegocio_RH_ERP_ISC_8A.Modelo;

namespace AgroNegocio_RH_ERP_ISC_8A.Datos
{
    class HistorialPuestos_DAO : Paginacion
    {
        private string cadenaconexion = "SERVER=localhost" +
               ";DATABASE=ERP2020;USER ID=sa ;Password=Hola.123";

        //
        /*
         * 
         * */
        public List<HistorialPuesto> consultaGeneral(string consulta_where, List<string> parametros, List<object> valores)
        {
            List<HistorialPuesto> historialpuestos = new List<HistorialPuesto>();
            using (SqlConnection conexion = new SqlConnection(cadenaconexion))
            {
                string consulta = "select * from HistorialPuestos " + consulta_where;
                //idCiudad	nombre	idEstado	estatus
                //0         1       2           3
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
                        HistorialPuesto historial_temporal = new HistorialPuesto(lector.GetInt32(0),
                                                            lector.GetInt32(1),
                                                            lector.GetInt32(2),
                                                            lector.GetDateTime(3),
                                                            lector.GetString(4),
                                                            lector.GetDouble(5));
                        historialpuestos.Add(historial_temporal);
                    }
                }
                conexion.Close();
            }
            return historialpuestos;
        }

        public bool registrar(HistorialPuesto historialpuesto)
        {
            bool insert = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "insert into HistorialPuestos values (@idEmpleado, @idPuesto, @idDepartamento, @fechaInicio, @fechaFin, @salario)";

                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();

                    comando.Parameters.AddWithValue("@idEmpleado", historialpuesto.IDEmpleado);
                    comando.Parameters.AddWithValue("@idPuesto", historialpuesto.IDPuesto);
                    comando.Parameters.AddWithValue("@idDepartamento", historialpuesto.IDDepartamento);
                    comando.Parameters.AddWithValue("@fechaInicio", historialpuesto.FechaInicio);
                    comando.Parameters.AddWithValue("@fechaFin", historialpuesto.FechaFin);
                    comando.Parameters.AddWithValue("@salario", historialpuesto.Salario);
                    if (comando.ExecuteNonQuery() != 0)
                        insert = true;

                    conexion.Close();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al registrar el Historial. Error: " + ex.Message);
            }

            return insert;
        }

        public bool editar(HistorialPuesto historialpuesto)
        {
            bool insert = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "update ciudades set idEmpleado = @idEmpleado,idPuesto = @idPuesto,idDepartamento = @idDepartamento,fechaInicio = @fechaInicio," +
                        "fechaFin = @fechaFin,salario = @salario ";

                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();

                    comando.Parameters.AddWithValue("@idEmpleado", historialpuesto.IDEmpleado);
                    comando.Parameters.AddWithValue("@idPuesto", historialpuesto.IDPuesto);
                    comando.Parameters.AddWithValue("@idDepartamento", historialpuesto.IDDepartamento);
                    comando.Parameters.AddWithValue("@fechaInicio", historialpuesto.FechaInicio);
                    comando.Parameters.AddWithValue("@fechaFin", historialpuesto.FechaFin);
                    comando.Parameters.AddWithValue("@salario", historialpuesto.Salario);
                    if (comando.ExecuteNonQuery() != 0)
                        insert = true;

                    conexion.Close();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al editar el Historial. Error "+ ex.Message);
            }
            return insert;
        }



        public int getidEmpleado(string empleado)
        {
            int id = 0;
            using (SqlConnection conexion = new SqlConnection(cadenaconexion))
            {
                string consulta = "select idPuesto from Empleados where nombre='" + empleado + "'";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                conexion.Open();

                var ID = comando.ExecuteScalar();
                id = (int)ID;
                conexion.Close();
            }
            return id;

        }

        public int getidPuesto(string puesto)
        {
            int id = 0;
            using (SqlConnection conexion = new SqlConnection(cadenaconexion))
            {
                string consulta = "select idPuesto from puestos where nombre='" + puesto + "'";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                conexion.Open();

                var ID = comando.ExecuteScalar();
                id = (int)ID;
                conexion.Close();
            }
            return id;

        }  

        public int getidDepartamento(string departamento)
        {
            int id = 0;
            using (SqlConnection conexion = new SqlConnection(cadenaconexion))
            {
                string consulta = "select idDepartamento from departamentos where nombre='" + departamento + "'";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                conexion.Open();

                var ID = comando.ExecuteScalar();
                id = (int)ID;
                conexion.Close();
            }
            return id;

        }

    }
}
