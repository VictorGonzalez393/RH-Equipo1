using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroNegocio_RH_ERP_ISC_8A.Modelo
{
    public class Puesto
    {
        public int IdPuesto { get; set; }
        public string Nombre { get; set; }
        public decimal Samin { get; set; }
        public decimal Samax { get; set; }
        public char Estatus { get; set; }
        public Puesto(int idPuesto, string nombre, decimal samin, decimal samax, char estatus)
        {
            IdPuesto = idPuesto;
            Nombre = nombre;
            Samin = samin;
            Samax = samax;
            Estatus = estatus;
        }
    }
}
