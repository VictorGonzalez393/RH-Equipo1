using AgroNegocio_RH_ERP_ISC_8A.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroNegocio_RH_ERP_ISC_8A.Datos
{
    class Departamentos_DAO : Paginacion
    {
        private readonly string cadenaconexion = "SERVER=localhost" +
                ";DATABASE=ERP2020;USER ID=sa ;Password=Hola.123";
        public List<Departamento> consultaGeneral(string consulta_where, List<string> parametros, List<object> valores)
        {
            List<Departamento> deptos = new List<Departamento>();
            using (SqlConnection conexion = new SqlConnection(cadenaconexion))
            {
                string consulta = "select * from Departamentos " + consulta_where;

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
                        Departamento depto = new Departamento(lector.GetInt32(0),
                                                            lector.GetString(1),
                                                            lector.GetString(2)[0]);
                        deptos.Add(depto);
                    }
                }
                conexion.Close();
            }
            return deptos;
        }

        public bool registrar(Departamento depto)
        {
            bool insert = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "insert into Departamentos values (@idDepartamento, @nombre, @estatus)";
                    depto.idDepto= getMaxID();
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();
                    comando.Parameters.AddWithValue("@idDepartamento", depto.idDepto);
                    comando.Parameters.AddWithValue("@nombre", depto.Nombre);
                    comando.Parameters.AddWithValue("@estatus", depto.Estatus);
                    if (comando.ExecuteNonQuery() != 0)
                        insert = true;
                    conexion.Close();

                }

            }
            catch (SqlException)
            {
                throw new Exception("Error al registrar el Departamento. " + depto.Nombre);
            }
            return insert;
        }

        public bool editar(Departamento depto)
        {
            bool editar = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "update Departamentos set nombre= @nombre where idDepartamento=@idDepartamento";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();
                    comando.Parameters.AddWithValue("@idDepartamento", depto.idDepto);
                    comando.Parameters.AddWithValue("@nombre", depto.Nombre);
                    if (comando.ExecuteNonQuery() != 0)
                        editar = true;
                    conexion.Close();
                }

            }
            catch (SqlException)
            {
                Console.WriteLine("Error al editar el departamento." );
            }
            return editar;
        }

        public bool eliminar(int idD)
        {
            bool eliminar = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "update Departamentos set estatus='I' where idDepartamento=@idDepartamento";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();
                    comando.Parameters.AddWithValue("@idDepartamento", idD);
                    if (comando.ExecuteNonQuery() != 0)
                        eliminar = true;
                    conexion.Close();
                }

            }
            catch (SqlException)
            {
                Console.WriteLine("Error al eliminar el Departamento.");
            }
            return eliminar;
        }

        public int getMaxID()
        {
            int new_ID = 0;
            using (SqlConnection conexion = new SqlConnection(cadenaconexion))
            {
                string consulta = "select max(idDepartamento)+1 from Departamentos";
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

        public bool validarDepto(Departamento depto)
        {
            bool validar = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "select idDepartamento from Departamentos where nombre=@nombre";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();
                    comando.Parameters.AddWithValue("@nombre", depto.Nombre);
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
                Console.WriteLine("Error al validar departamento.");
            }
            return validar;
        }
    }
}
