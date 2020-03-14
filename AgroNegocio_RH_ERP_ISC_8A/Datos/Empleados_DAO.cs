using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgroNegocio_RH_ERP_ISC_8A.Modelo;

namespace AgroNegocio_RH_ERP_ISC_8A.Datos
{
    class Empleados_DAO : Paginacion
    {
        private string cadenaconexion = "SERVER=localhost" +
               ";DATABASE=ERP2020;USER ID=sa ;Password=Hola.123";
        public List<Empleado> consultaGeneral(string consulta_wh, List<string> parametros, List<object> valores)
        {
            List<Empleado> empleados = new List<Empleado>();
            using (SqlConnection conexion = new SqlConnection(cadenaconexion))
            {
                string consulta = "select * from Empleados " + consulta_wh;
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

                        Empleado emp_temp = new Empleado(lector.GetInt32(0),
                                                           lector.GetString(1),
                                                           lector.GetString(2),
                                                           lector.GetString(3),
                                                           lector.GetString(4),
                                                           lector.GetString(5),
                                                           lector.GetString(6),
                                                           lector.GetFloat(7),
                                                           lector.GetString(8),
                                                           lector.GetString(9),
                                                           lector.GetInt32(10),
                                                           lector.GetInt32(11),
                                                           //lector.GetByte(12),
                                                           lector.GetString(13),
                                                           lector.GetString(14),
                                                           lector.GetInt32(15),
                                                           lector.GetString(16),
                                                           lector.GetFloat(17),
                                                           lector.GetChar(18),
                                                           lector.GetInt32(19),
                                                           lector.GetInt32(20),
                                                           lector.GetInt32(21),
                                                           lector.GetInt32(22));

                        empleados.Add(emp_temp);
                    }
                }
                conexion.Close();
            }
            return empleados;
        }

        /**
         * Registrar
         * Método para registrar los valores en la BD.
         * Recibe un objeto de tipo empleado
         * retorna verdadero si el insert se realiza de manera correcta, falso 
         * si hay un error en la inserción 
         */
        public bool registrar(Empleado empleado)
        {
            bool insert = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "insert into Empleados values (@idEmpleado, @nombre, @apaterno, @amaterno, @sexo, @fechaContratacion, " +
                        "@fechaNacimiento, @salario, @nss, @estadoCivil, @diasVacaciones, @diasPermiso, @fotografia, @direccion, @colonia, @codigoPostal" +
                        ", @escolaridad, @porcentajeComision, @estatus, @idDepartamento, @idPuesto, @idCiudad, @idSucursal)";
                    empleado.IdEmpleado = getMaxID();
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();
                    comando.Parameters.AddWithValue("@idEmpleado", empleado.IdEmpleado);
                    comando.Parameters.AddWithValue("@nombre", empleado.Nombre);
                    comando.Parameters.AddWithValue("@apaterno", empleado.Apaterno);
                    comando.Parameters.AddWithValue("@amaterno", empleado.Amaterno);
                    comando.Parameters.AddWithValue("@sexo", empleado.Sexo);
                    comando.Parameters.AddWithValue("@fechaContratacion", empleado.FechaContratacion);
                    comando.Parameters.AddWithValue("@fechaNacimiento", empleado.FechaNacimiento);
                    comando.Parameters.AddWithValue("@salario", empleado.Salario);
                    comando.Parameters.AddWithValue("@nss", empleado.Nss);
                    comando.Parameters.AddWithValue("@estadoCivil", empleado.EstadoCivil);
                    comando.Parameters.AddWithValue("@diasVacaciones", empleado.DiasVacaciones);
                    comando.Parameters.AddWithValue("@diasPermiso", empleado.DiasPermiso);
                    //comando.Parameters.AddWithValue("@fotografia", empleado.Fotografia);
                    comando.Parameters.AddWithValue("@direccion", empleado.Direccion);
                    comando.Parameters.AddWithValue("@colonia", empleado.Colonia);
                    comando.Parameters.AddWithValue("@codigoPostal", empleado.CodigoPostal);
                    comando.Parameters.AddWithValue("@escolaridad", empleado.Escolaridad);
                    comando.Parameters.AddWithValue("@porcentajeComision", empleado.PorcentajeComision);
                    comando.Parameters.AddWithValue("@estatus", empleado.Estatus);
                    comando.Parameters.AddWithValue("@idDepartamento", empleado.IdDepartamento);
                    comando.Parameters.AddWithValue("@idPuesto", empleado.IdPuesto);
                    comando.Parameters.AddWithValue("@idCiudad", empleado.IdCiudad);
                    comando.Parameters.AddWithValue("@idSucursal", empleado.IdSucursal);
                    if (comando.ExecuteNonQuery() != 0)
                        insert = true;
                    conexion.Close();
                    foreach(Horario horario in empleado.horarios)
                    {
                        horario.IDEmpleado = empleado.IdEmpleado;
                        Horarios_DAO horarios_DAO = new Horarios_DAO();
                        bool insert_horario = horarios_DAO.registrar(horario);
                        if (insert_horario == false)
                        {
                            throw new Exception("Error al registrar horario");
                        }
                    }
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al registrar Empleado. " + ex.Message);
            }
            return insert;
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
                string consulta = "select max(idEmpleado)+1 from Empleados";
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

        public bool editar(Empleado empleado)
        {
            bool editar = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "update Empleados set nombre= @nombre,apaterno= @apaterno,amaterno= @amaterno,sexo= @sexo,fechaContratacion= @fechaContratacion, " +
                        "fechaNacimiento= @fechaNacimiento,salario= @salario,nss= @nss,estadoCivil= @estadoCivil,diasVacaciones= @diasVacaciones, diasPermiso= @diasPermiso,fotografia= @fotografia,direccion= @direccion,colonia= @colonia,codigoPostal= @codigoPostal" +
                        ",escolaridad= @escolaridad,porcentajeComision= @porcentajeComision,estatus= @estatus,idDepartamento= @idDepartamento,idPuesto= @idPuesto, idCiudad= @idCiudad,idSucursal= @idSucursal where idEmpleado=@idEmpleado";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();
                    comando.Parameters.AddWithValue("@idEmpleado", empleado.IdEmpleado);
                    comando.Parameters.AddWithValue("@nombre", empleado.Nombre);
                    comando.Parameters.AddWithValue("@apaterno", empleado.Apaterno);
                    comando.Parameters.AddWithValue("@amaterno", empleado.Amaterno);
                    comando.Parameters.AddWithValue("@sexo", empleado.Sexo);
                    comando.Parameters.AddWithValue("@fechaContratacion", empleado.FechaContratacion);
                    comando.Parameters.AddWithValue("@fechaNacimiento", empleado.FechaNacimiento);
                    comando.Parameters.AddWithValue("@salario", empleado.Salario);
                    comando.Parameters.AddWithValue("@nss", empleado.Nss);
                    comando.Parameters.AddWithValue("@estadoCivil", empleado.EstadoCivil);
                    comando.Parameters.AddWithValue("@diasVacaciones", empleado.DiasVacaciones);
                    comando.Parameters.AddWithValue("@diasPermiso", empleado.DiasPermiso);
                    //comando.Parameters.AddWithValue("@fotografia", empleado.Fotografia);
                    comando.Parameters.AddWithValue("@direccion", empleado.Direccion);
                    comando.Parameters.AddWithValue("@colonia", empleado.Colonia);
                    comando.Parameters.AddWithValue("@codigoPostal", empleado.CodigoPostal);
                    comando.Parameters.AddWithValue("@escolaridad", empleado.Escolaridad);
                    comando.Parameters.AddWithValue("@porcentajeComision", empleado.PorcentajeComision);
                    comando.Parameters.AddWithValue("@estatus", empleado.Estatus);
                    comando.Parameters.AddWithValue("@idDepartamento", empleado.IdDepartamento);
                    comando.Parameters.AddWithValue("@idPuesto", empleado.IdPuesto);
                    comando.Parameters.AddWithValue("@idCiudad", empleado.IdCiudad);
                    comando.Parameters.AddWithValue("@idSucursal", empleado.IdSucursal);
                    if (comando.ExecuteNonQuery() != 0)
                        editar = true;
                    conexion.Close();

                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al editar la percepcion. Error: " + ex.Message);
            }
            return editar;
        }

        /**
         * Eliminar
         * Método para eliminar logicamente al empleado
         */
        public bool eliminar(int idEmpleado)
        {
            bool eliminar = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "update Percepciones set estatus='I' where idEmpleado=@idEmpleado";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();
                    comando.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                    if (comando.ExecuteNonQuery() != 0)
                        eliminar = true;
                    conexion.Close();
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al eliminar la percepcion. Error: " + ex.Message);
            }
            return eliminar;
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

        public int getidCiudad(string ciudad)
        {
            int id = 0;
            using (SqlConnection conexion = new SqlConnection(cadenaconexion))
            {
                string consulta = "select idCiudad from Ciudades where nombre='" + ciudad + "'";
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


        public int getidSucursal(string sucursal)
        {
            int id = 0;
            using (SqlConnection conexion = new SqlConnection(cadenaconexion))
            {
                string consulta = "select idSucursal from sucursales where nombre='" + sucursal + "'";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                conexion.Open();

                var ID = comando.ExecuteScalar();
                id = (int)ID;
                conexion.Close();
            }
            return id;

        }

        /*
         * Metodo que valida si el empleado ya existe o no
         */
        public bool validarEmpleado(Empleado empleado)
        {
            bool disponible = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "select idempleado from empleados where nombre= @NOMBRE " +
                        "and estatus='A'";

                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();

                    comando.Parameters.AddWithValue("@nombre", empleado.Nombre);
                    comando.Parameters.AddWithValue("@apaterno", empleado.Apaterno);
                    comando.Parameters.AddWithValue("@amaterno", empleado.Amaterno);
                    comando.Parameters.AddWithValue("@sexo", empleado.Sexo);
                    comando.Parameters.AddWithValue("@fechaContratacion", empleado.FechaContratacion);
                    comando.Parameters.AddWithValue("@fechaNacimiento", empleado.FechaNacimiento);
                    comando.Parameters.AddWithValue("@salario", empleado.Salario);
                    comando.Parameters.AddWithValue("@nss", empleado.Nss);
                    comando.Parameters.AddWithValue("@estadoCivil", empleado.EstadoCivil);
                    comando.Parameters.AddWithValue("@diasVacaciones", empleado.DiasVacaciones);
                    comando.Parameters.AddWithValue("@diasPermiso", empleado.DiasPermiso);
                    //comando.Parameters.AddWithValue("@fotografia", empleado.Fotografia);
                    comando.Parameters.AddWithValue("@direccion", empleado.Direccion);
                    comando.Parameters.AddWithValue("@colonia", empleado.Colonia);
                    comando.Parameters.AddWithValue("@codigoPostal", empleado.CodigoPostal);
                    comando.Parameters.AddWithValue("@escolaridad", empleado.Escolaridad);
                    comando.Parameters.AddWithValue("@porcentajeComision", empleado.PorcentajeComision);
                    comando.Parameters.AddWithValue("@idDepartamento", empleado.IdDepartamento);
                    comando.Parameters.AddWithValue("@idPuesto", empleado.IdPuesto);
                    comando.Parameters.AddWithValue("@idCiudad", empleado.IdCiudad);
                    comando.Parameters.AddWithValue("@idSucursal", empleado.IdSucursal);
                    SqlDataReader lector = comando.ExecuteReader();

                    if (lector.HasRows)
                        disponible = false;
                    else
                        disponible = true;

                    conexion.Close();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al validar al empleado. Error: " + ex.Message);
            }
            return disponible;
        }


        public bool validarEmpleadoEditar(Empleado empleado)
        {
            bool disponible = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "select idempleado from empleados where nombre= @NOMBRE " +
                        "and iddepartamento= @idDepartamento and idpuesto= @idPuesto and idciudad= @idCiudad and" +
                        "idsucursal= @idSucursal and idEmpleado != @idEmpleado";

                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();

                    comando.Parameters.AddWithValue("@idEmpleado", empleado.IdEmpleado);
                    comando.Parameters.AddWithValue("@nombre", empleado.Nombre);
                    comando.Parameters.AddWithValue("@apaterno", empleado.Apaterno);
                    comando.Parameters.AddWithValue("@amaterno", empleado.Amaterno);
                    comando.Parameters.AddWithValue("@sexo", empleado.Sexo);
                    comando.Parameters.AddWithValue("@fechaContratacion", empleado.FechaContratacion);
                    comando.Parameters.AddWithValue("@fechaNacimiento", empleado.FechaNacimiento);
                    comando.Parameters.AddWithValue("@salario", empleado.Salario);
                    comando.Parameters.AddWithValue("@nss", empleado.Nss);
                    comando.Parameters.AddWithValue("@estadoCivil", empleado.EstadoCivil);
                    comando.Parameters.AddWithValue("@diasVacaciones", empleado.DiasVacaciones);
                    comando.Parameters.AddWithValue("@diasPermiso", empleado.DiasPermiso);
                    //comando.Parameters.AddWithValue("@fotografia", empleado.Fotografia);
                    comando.Parameters.AddWithValue("@direccion", empleado.Direccion);
                    comando.Parameters.AddWithValue("@colonia", empleado.Colonia);
                    comando.Parameters.AddWithValue("@codigoPostal", empleado.CodigoPostal);
                    comando.Parameters.AddWithValue("@escolaridad", empleado.Escolaridad);
                    comando.Parameters.AddWithValue("@porcentajeComision", empleado.PorcentajeComision);
                    comando.Parameters.AddWithValue("@estatus", empleado.Estatus);
                    comando.Parameters.AddWithValue("@idDepartamento", empleado.IdDepartamento);
                    comando.Parameters.AddWithValue("@idPuesto", empleado.IdPuesto);
                    comando.Parameters.AddWithValue("@idCiudad", empleado.IdCiudad);
                    comando.Parameters.AddWithValue("@idSucursal", empleado.IdSucursal);
                    SqlDataReader lector = comando.ExecuteReader();

                    if (lector.HasRows)
                        disponible = false;
                    else
                        disponible = true;

                    conexion.Close();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al validar al empleado. Error: " + ex.Message);
            }
            return disponible;
        }
    }
}