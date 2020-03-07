using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroNegocio_RH_ERP_ISC_8A.Modelo
{
    class Usuario
    {
        public string Nombre { get; set; }
        public string Contrasenia { get; set; }
        public char Estatus { get; set; }
        public int IdEmpleado { get; set; }
        public int IdTipoUsuario { get; set; }
        public Usuario(string nombre, string contrasenia, char estatus, int idEmpleado, int idTipoUsuario)
        {
            Nombre = nombre;
            Contrasenia = contrasenia;
            Estatus = estatus;
            IdEmpleado = idEmpleado;
            IdTipoUsuario = idTipoUsuario;
        }
    }
}
