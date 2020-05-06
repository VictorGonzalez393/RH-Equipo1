using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroNegocio_RH_ERP_ISC_8A.Modelo
{
    public class Percepcion
    {
        public int IdPercepcion { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int DiasPagar { get; set; }
        public char Estatus { get; set; }
        public Percepcion (int idPercepcion, string nombre, string descripcion, int diasPagar,char estatus)
        {
            IdPercepcion = idPercepcion;
            Nombre = nombre;
            Descripcion = descripcion;
            DiasPagar = diasPagar;
            Estatus = estatus;
        }
        override
        public string ToString()
        {
            return this.Nombre;
        }
    }
}
