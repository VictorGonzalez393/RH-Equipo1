using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroNegocio_RH_ERP_ISC_8A.Modelo
{
    public class Ausencia_justificada
    {
        public int IdAusencia { get; set; }
        public string FechaSolicitud { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }
        public string Tipo { get; set; }
        public int IdEmpleadoS { get; set; }
        public int IdEmpleadoA { get; set; }
        public char Estatus { get; set; }
        public Ausencia_justificada(int idAusencia, string fechaSolicitud, string fechaInicio, string fechaFin, string tipo, int idEmpleadoS, int idEmpleadoA, char estatus)
        {
            IdAusencia = idAusencia;
            FechaSolicitud = fechaSolicitud;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            Tipo = tipo;
            IdEmpleadoS = idEmpleadoS;
            IdEmpleadoA = idEmpleadoA;
            Estatus = estatus;
        }

        override
        public string ToString()
        {
            return this.FechaSolicitud;
        }
    }
}
