using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroNegocio_RH_ERP_ISC_8A.Modelo
{
    public class Estado
    {
        public int IdEstado { get; set; }
        public string Nombre { get; set; }
        public string Siglas { get; set; }
        public char Estatus { get; set; }
        public Estado(int id, string nombre, string siglas, char estatus)
        {
            IdEstado = id;
            Nombre = nombre;
            Siglas = siglas;
            Estatus = estatus;
        }
    }
}
