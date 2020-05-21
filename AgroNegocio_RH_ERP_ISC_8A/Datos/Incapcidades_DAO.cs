using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgroNegocio_RH_ERP_ISC_8A.Modelo;
using System.IO;
using System.Drawing;

namespace AgroNegocio_RH_ERP_ISC_8A.Datos
{
    class Incapcidades_DAO : Paginacion
    {
        private string cadenaconexion = "SERVER=localhost" + ";DATABASE=ERP2020;USER ID=sa ;Password=Hola.123";

        public List<Incapacidad> consultaGeneral(string consulta_wh, List<string> parametros, List<object> valores)
        {
            List<Incapacidad> incapacidades = new List<Incapacidad>();
            using (SqlConnection conexion = new SqlConnection(cadenaconexion))
            {
                string consulta = "select * from Incapacidades_Tabla " + consulta_wh;
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
                        Incapacidad inc_temp = new Incapacidad(lector.GetInt32(0),
                                                               lector.GetInt32(1),
                                                               lector.GetString(2),
                                                               lector.GetString(3),
                                                               lector.GetString(4),
                                                               lector.GetString(5),
                                                               lector.GetString(6),
                                                               lector.GetString(7),
                                                               GetImage(lector.GetInt32(0)));
                        incapacidades.Add(inc_temp);
                    }
                }
                conexion.Close();
            }
            return incapacidades;
        } 

        public bool registrar (Incapacidad incapacidad)
        {
            bool insert = false;
            try
            {
                using(SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "insert into Incapacidades values(@idInc, @fechaI, @fechaF,@enfermedad,@evidencia,@idEmp)";
                    incapacidad.IdIncapacidad= getMaxID();
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();
                    comando.Parameters.AddWithValue("@idInc", incapacidad.IdIncapacidad);
                    comando.Parameters.AddWithValue("@fechaI", incapacidad.FechaInicio);
                    comando.Parameters.AddWithValue("@fechaF", incapacidad.FechaFin);
                    comando.Parameters.AddWithValue("@enfermedad", incapacidad.Enfermedad);
                    comando.Parameters.AddWithValue("@evidencia", incapacidad.img_bt);
                    comando.Parameters.AddWithValue("@idEmp", incapacidad.IdEmpleado);
                    if (comando.ExecuteNonQuery() != 0)
                        insert = true;
                    conexion.Close();
                }
            }
            catch(SqlException ex)
            {
                Console.WriteLine("Error al registrar la incapacidad. Error: " + ex.Message);
            }
            return insert;
        }

        public bool editar(Incapacidad incapacidad)
        {
            bool editar = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "update Incapacidades set fechaInicio=@fechaI, fechaFin=@fechaF, enfermedad=@enfermedad,evidencia=@evidencia where idIncapacidad=@idInc and idEmpleado=@idEmp";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();
                    comando.Parameters.AddWithValue("@idInc", incapacidad.IdIncapacidad);
                    comando.Parameters.AddWithValue("@idEmp", incapacidad.IdEmpleado);
                    comando.Parameters.AddWithValue("@fechaI", incapacidad.FechaInicio);
                    comando.Parameters.AddWithValue("@fechaF", incapacidad.FechaFin);
                    comando.Parameters.AddWithValue("@enfermedad", incapacidad.Enfermedad);
                    comando.Parameters.AddWithValue("@evidencia", incapacidad.img_bt);
                    if (comando.ExecuteNonQuery() != 0)
                        editar = true;
                    conexion.Close();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al editar la incapacidad. Error: " + ex.Message);
            }
            return editar;
        }
        public int getMaxID()
        {
            int new_ID = 0;
            using (SqlConnection conexion = new SqlConnection(cadenaconexion))
            {
                string consulta = "select max(idIncapacidad)+1 from Incapacidades";
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

        public bool eliminar(int idIncapacidad)
        {
            bool eliminar = true;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    string consulta = "Delete from Incapacidades where  idIncapacidad=@idInc";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();
                    comando.Parameters.AddWithValue("@idInc", idIncapacidad);
                    if (comando.ExecuteNonQuery() != 0)
                        eliminar = true;
                    conexion.Close();
                }
            }
            catch(SqlException ex)
            {
                Console.WriteLine("Error al eliminar la incapacidad. Error: " + ex.Message);
            }
            return eliminar;
        }

        public Image GetImage(int id)
        {
            Image img;
            byte[] f;
            using (SqlConnection conexion = new SqlConnection(cadenaconexion))
            {
                string consulta = "select evidencia from incapacidades where idIncapacidad='" + id + "'";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                conexion.Open();

                var foto = comando.ExecuteScalar();
                f = (byte[])foto;
                conexion.Close();
            }
            img = new Bitmap(new Bitmap(new MemoryStream(f)), new Size(120, 134));
            return img;
        }

    }
}
