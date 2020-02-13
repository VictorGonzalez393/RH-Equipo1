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
         * @user=usuario creado en la BD
         * @pass=Contraseña del usuario
         */
        public SqlConnection Conectar(String servername, String user, String pass)
        {
            SqlConnection cn = new SqlConnection("SERVER=" + servername + ";DATABASE=ERP2020;USER ID="+user+";Password="+pass);
            cn.Open();
            return cn;
        }

    }
}
