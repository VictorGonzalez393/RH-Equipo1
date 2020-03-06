using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroNegocio_RH_ERP_ISC_8A.Modelo
{
    class Departamento
    {
        public int idDepto { get; set; }
        public string Nombre { get; set; }
        public char Estatus { get; set; }

        public Departamento(int id, string nombre, char estatus)
        {
            this.idDepto = id;
            this.Nombre = nombre;
            this.Estatus = estatus;

        }
    }
}
