using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroNegocio_RH_ERP_ISC_8A.Modelo
{
    class NominaDeduccion
    {
        public int idNomina { get; set; }
        public int idDeduccion { get; set; }
        public float importe { get; set; }
        public char estatus { get; set; }

        public NominaDeduccion(int nomina, int deduccion, float importe, char estatus)
        {
            this.idNomina = nomina;
            this.idDeduccion = deduccion;
            this.importe = importe;
            this.estatus = estatus;
        }
    }
}
