using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroNegocio_RH_ERP_ISC_8A.Modelo
{
    public class Deduccion
    {
        public int IdDeduccion { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Porcentaje { get; set; }
        public char Estatus { get; set; }
        public Deduccion(int idDeduccion, string nombre, string descripcion, double porcentaje, char estatus)
        {
            IdDeduccion = idDeduccion;
            Nombre = nombre;
            Descripcion = descripcion;
            Porcentaje = porcentaje;
            Estatus = estatus;
        }
    }
}
