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
        public TimeSpan HoraI { get; set; }
        public TimeSpan HoraF { get; set; }
        public string Dias { get; set; }
        public int IDEmpleado { get; set; }
        public char Estatus { get; set; }
        public bool Eliminar; //Parametro para saber si se va a eliminar logicamente o no
        public Horario(int id, TimeSpan horaI, TimeSpan horaF, string dias, int idempleado, char estatus)
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
