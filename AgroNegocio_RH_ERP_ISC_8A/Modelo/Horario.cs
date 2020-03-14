using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroNegocio_RH_ERP_ISC_8A.Modelo
{
   public class Horario
    {
        public int ID { get; set; }
        public string HoraI { get; set; }
        public string HoraF { get; set; }
        public string Dias { get; set; }
        public int IDEmpleado { get; set; }
        public char Estatus { get; set; }
        public Horario(int id, string horaI, string horaF, string dias, int idempleado, char estatus)
        {
            ID = id;
            HoraI = horaI;
            HoraF = horaF;
            Dias = dias;
            IDEmpleado = idempleado;
            Estatus = estatus;
        }
    }
}
