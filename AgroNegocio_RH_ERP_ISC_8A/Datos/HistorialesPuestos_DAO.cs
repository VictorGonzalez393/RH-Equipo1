﻿using AgroNegocio_RH_ERP_ISC_8A.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroNegocio_RH_ERP_ISC_8A.Datos
{
    class HistorialesPuestos_DAO : Paginacion
    {
        private string cadenaconexion = "SERVER=localhost" +
              ";DATABASE=ERP2020;USER ID=sa ;Password=Hola.123";

        public List<HistorialPuesto> consultaGeneral(string consulta_wh, List<string> parametros, List<object> valores)
        {
            List<HistorialPuesto> historial = new List<HistorialPuesto>();
            using (SqlConnection conexion = new SqlConnection(cadenaconexion))
            {
                string consulta = "select * from HistorialPuestos" + consulta_wh;
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
                    string consulta = "insert into HistorialPuestos values (@idEmpleado, @idPuesto, @idDepartamento, @fechaInicio, @fechaFin, @salario)";
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
                Console.WriteLine("Error al Insertar" + ex.Message);
            }
            return insert;
        }

        public bool editar(int idEmpleado, int idPuesto, int idDepartamento, string fechaInicio, string fechaFin, double salario)
        {
            bool editar = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {

                    string consulta = "update HistorialPuestos set idPuesto=@idPues, idDepartamento=@idDep, fechaInicio=@fInicio," +
                        " fechaFin=@fFin, salario=@salario where idEmpleado=@idEmp";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();
                    comando.Parameters.AddWithValue("@idEmp", idEmpleado);
                    comando.Parameters.AddWithValue("@idPues", idPuesto);
                    comando.Parameters.AddWithValue("@idDep", idDepartamento);
                    comando.Parameters.AddWithValue("@fInicio",fechaInicio);
                    comando.Parameters.AddWithValue("@fFin", fechaFin);
                    comando.Parameters.AddWithValue("@salario", salario);
                    if (comando.ExecuteNonQuery() != 0)
                    {
                        editar = true;
                    }
                    conexion.Close();
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al editar el Historial." + ex.Message);
            }
            return editar;
        }

        public bool validarHistorial(HistorialPuesto hist)
        {
            bool validar = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "select idPuesto from HistorialPuestos where idPuesto=@idPuesto";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();
                    comando.Parameters.AddWithValue("@idPuesto", hist.idPuesto);
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
                Console.WriteLine("Error al validar el Historial.");
            }
            return validar;
        }

    }
}
