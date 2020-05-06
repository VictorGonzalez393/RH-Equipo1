using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroNegocio_RH_ERP_ISC_8A.Modelo
{
    class NominasPercepcion
    {
        public int  IdNomina { get; set; }
        public int IdPercepcion { get; set; }
        public double Importe { get; set; }
        public char Estatus { get; set; }
        public NominasPercepcion(int idNomina, int idPercepcion, double importe, char estatus)
        {
            IdNomina = idNomina;
            IdPercepcion = idPercepcion;
            Importe = importe;
            Estatus = estatus;
        }
       
    }
}
