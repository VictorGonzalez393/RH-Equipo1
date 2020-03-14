using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroNegocio_RH_ERP_ISC_8A.Modelo
{
    public class Ciudad
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int IDEstado { get; set; }
        public char Estatus { get; set; }

        public Ciudad (int id, string nombre, int idestado, char estatus)
        {
            ID = id;
            Nombre = nombre;
            IDEstado = idestado;
            Estatus = estatus;
        }
        override
            public string ToString()
        {
            return Nombre;
        }
    }
}
