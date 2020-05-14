using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroNegocio_RH_ERP_ISC_8A.Modelo
{
    class NominaPercepcion
    {
        public int idNomina { get; set; }
        public int idPercepcion { get; set; }
        public double importe { get; set; }
        public char estatus { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }

        public NominaPercepcion(int nomina, int percepcion, double importe, char estatus, string nombre, string descripcion)
        {
            this.idNomina = nomina;
            this.idPercepcion = percepcion;
            this.importe = importe;
            this.estatus = estatus;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

    }
}

