using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroNegocio_RH_ERP_ISC_8A.Modelo
{
    class HistorialPuesto
    {
        public int IDEmpleado { get; set; }
        public int IDPuesto { get; set; }
        public int IDDepartamento { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }
        public double Salario { get; set; }

        public HistorialPuesto(int idEmpleado, int idPuesto, int idDepartamento, string fechaInicio, string fechaFin, double salario)
        {
            IDEmpleado = idEmpleado;
            IDPuesto = idPuesto;
            IDDepartamento = idDepartamento;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            Salario = salario;
        }
    }
}
