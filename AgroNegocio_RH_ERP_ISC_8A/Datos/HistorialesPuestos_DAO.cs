using AgroNegocio_RH_ERP_ISC_8A.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroNegocio_RH_ERP_ISC_8A.Datos
{
    class HistorialesPuestos_DAO
    {
        private string cadenaconexion = "SERVER=localhost" +
              ";DATABASE=ERP2020;USER ID=sa ;Password=Hola.123";

        public List<HistorialPuesto> consultaGeneral(string consulta_wh, List<string> parametros, List<object> valores)
        {
            List<HistorialPuesto> historial = new List<HistorialPuesto>();
            using (SqlConnection conexion = new SqlConnection(cadenaconexion))
            {
                string consulta = "select * from HistorialesPuestos_Tabla" + consulta_wh;
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

                        HistorialPuesto hist_temp = new HistorialPuesto(lector.GetInt32(0),
                                                           lector.GetInt32(1),
                                                           lector.GetInt32(2),
                                                           lector.GetString(3),
                                                           lector.GetString(4),
                                                           lector.GetDouble(5));
                        historial.Add(hist_temp);
                    }
                }
                conexion.Close();
            }
            return historial;
        }

        public bool registrar(HistorialPuesto empleado)
        {
            bool insert = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "insert into HistorialesPuestos values (@idEmpleado, @idPuesto, @idDepartamento, @fechaInicio, @fechaFin, @salario)";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();
                    comando.Parameters.AddWithValue("@idEmpleado", empleado.idEmpleado);
                    comando.Parameters.AddWithValue("@idPuesto", empleado.idPuesto);
                    comando.Parameters.AddWithValue("@idDepartamento", empleado.idDepartamento);
                    comando.Parameters.AddWithValue("@fechaInicio", empleado.FechaInicio);
                    comando.Parameters.AddWithValue("@fechaFin", empleado.FechaFin);
                    comando.Parameters.AddWithValue("@salario", empleado.Salario);
                    if (comando.ExecuteNonQuery() != 0)
                        insert = true;
                    conexion.Close();
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al agregar Percepción a Nómina" + ex.Message);
            }
            return insert;
        }

    }
}
