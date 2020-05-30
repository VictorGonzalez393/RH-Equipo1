using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroNegocio_RH_ERP_ISC_8A.Modelo
{
    public class FormasPago
    { 
        public int idFormaPago { get; set; }
        public string nombre { get; set; } 
        public char estatus { get; set; }

        public FormasPago(int idFormaPago, string nombre, char estatus)
        {
            this.idFormaPago = idFormaPago;
            this.nombre = nombre;
            this.estatus = estatus;
        }
        override
            public string ToString()
            {
                return this.nombre;
            }
    }
}
