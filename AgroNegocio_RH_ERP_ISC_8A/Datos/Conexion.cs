using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//Librerias para la conexion de la BD
using System.Data.SqlClient;//Libreria para conectar el SQLServer

namespace AgroNegocio_RH_ERP_ISC_8A.Datos
{
    class Conexion
    {
        /**
         * Método conectar
         * @servername=nombre de su servidor de BD
         */
        public SqlConnection Conectar(String servername)
        {
            SqlConnection cn = new SqlConnection("SERVER=" + servername + ";DATABASE=ERP2020;Integrated security=true");
            cn.Open();
            return cn;
        }

    }
}
