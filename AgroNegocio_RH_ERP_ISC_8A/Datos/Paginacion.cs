using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;



namespace AgroNegocio_RH_ERP_ISC_8A.Datos
{
    class Paginacion
    {
        public string table;               //Tabla de la cual se hará paginación
        public string order_by;            //Especifica el nombre por el cual se ordenarán los registros
        public int pages;                  //Numero total de páginas
        public int actual_page = 0;        //Página actual
        public int rows_per_page = 2;     //Cantidad de registros por página
        private string cadenaconexion = "SERVER=localhost; DATABASE=ERP2020; USER ID=sa; Password=Hola.123";
        public string where;
        public void CalculaPaginas()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    conexion.Open();
                    if (where==null)
                    {
                        SqlCommand command = new SqlCommand("select count(*) from " + table, conexion);
                        var rows = command.ExecuteScalar();
                        conexion.Close();
                        this.pages = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(rows) / rows_per_page));

                    }
                    else
                    {
                        SqlCommand command = new SqlCommand("select count(*) from " + table+" where "+where, conexion);
                        var rows = command.ExecuteScalar();
                        conexion.Close();
                        this.pages = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(rows) / rows_per_page));
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("La tabla no existe. \n" + ex.Message);
            }
        }



        public DataTable getSigPagina()
        {
            DataTable dt = new DataTable();
            if (actual_page < pages)
            {
                try
                {
                    using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                    {
                        if (where == null) { 
                            actual_page += 1;
                            string txt_sql = "select * from " + table + " order by '" + order_by + "' offset (@page-1)*@rows_per_page rows fetch next @rows_per_page rows only";
                            SqlDataAdapter adapter = new SqlDataAdapter(txt_sql, conexion);
                            adapter.SelectCommand.Parameters.AddWithValue("@page", actual_page);
                            adapter.SelectCommand.Parameters.AddWithValue("@rows_per_page", rows_per_page);
                            adapter.Fill(dt);
                        }
                        else
                        {
                            actual_page += 1;
                            string txt_sql = "select * from " + table +" where "+where+" order by '" + order_by + "' offset (@page-1)*@rows_per_page rows fetch next @rows_per_page rows only";
                            SqlDataAdapter adapter = new SqlDataAdapter(txt_sql, conexion);
                            adapter.SelectCommand.Parameters.AddWithValue("@page", actual_page);
                            adapter.SelectCommand.Parameters.AddWithValue("@rows_per_page", rows_per_page);
                            adapter.Fill(dt);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error con la BD1. \n" + ex.Message);
                }
            }
            return dt;
        }

        public DataTable getAnteriorPagina()
        {
            DataTable dt = new DataTable();
            if (actual_page > 1)
            {
                try
                {
                    using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                    {
                        if (where == null) { 
                            actual_page -= 1;
                            string txt_sql = "select * from " + table + " order by '" + order_by + "' offset (@page-1)*@rows_per_page rows fetch next @rows_per_page rows only";
                            SqlDataAdapter adapter = new SqlDataAdapter(txt_sql, conexion);
                            adapter.SelectCommand.Parameters.AddWithValue("@page", actual_page);
                            adapter.SelectCommand.Parameters.AddWithValue("@rows_per_page", rows_per_page);
                            adapter.Fill(dt);
                        }
                        else
                        {
                            actual_page -= 1;
                            string txt_sql = "select * from " + table+" where "+where+ " order by '" + order_by + "' offset (@page-1)*@rows_per_page rows fetch next @rows_per_page rows only";
                            SqlDataAdapter adapter = new SqlDataAdapter(txt_sql, conexion);
                            adapter.SelectCommand.Parameters.AddWithValue("@page", actual_page);
                            adapter.SelectCommand.Parameters.AddWithValue("@rows_per_page", rows_per_page);
                            adapter.Fill(dt);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error con la BD2. \n" + ex.Message);
                }
            }
            return dt;
        }
        public DataTable buscar(string wh_sql)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {

                    string txt_sql = "select * from " + table + " where " + wh_sql;
                    SqlDataAdapter adapter = new SqlDataAdapter(txt_sql, conexion);
                    adapter.Fill(dt);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error con la BD4. \n" + ex.Message);
            }
            return dt;
        }

        public DataTable actualizar()
        {
            CalculaPaginas();
            //actual_page = 1;
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaconexion))
                {
                    if (where == null) { 
                        actual_page = 1;
                        string txt_sql = "select * from " + table + " order by '" + order_by + "' offset (@page-1)*@rows_per_page rows fetch next @rows_per_page rows only";
                        SqlDataAdapter adapter = new SqlDataAdapter(txt_sql, conexion);
                        adapter.SelectCommand.Parameters.AddWithValue("@page", actual_page);
                        adapter.SelectCommand.Parameters.AddWithValue("@rows_per_page", rows_per_page);
                        adapter.Fill(dt);
                    }
                    else
                    {
                        actual_page = 1;
                        string txt_sql = "select * from " + table +" where "+where+ " order by '" + order_by + "' offset (@page-1)*@rows_per_page rows fetch next @rows_per_page rows only";
                        SqlDataAdapter adapter = new SqlDataAdapter(txt_sql, conexion);
                        adapter.SelectCommand.Parameters.AddWithValue("@page", actual_page);
                        adapter.SelectCommand.Parameters.AddWithValue("@rows_per_page", rows_per_page);
                        adapter.Fill(dt);
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error con la BD3. \n" + ex.Message);
            }
            return dt;



        }



    }
}
