using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgroNegocio_RH_ERP_ISC_8A.Datos;

namespace AgroNegocio_RH_ERP_ISC_8A.Modelo
{
    public class Login_model
    {
        LoginDAO logindao = new LoginDAO();

        public bool Loginx(string usuario, string password)
        {
            return logindao.Login(usuario, password);
        }
    }
}
