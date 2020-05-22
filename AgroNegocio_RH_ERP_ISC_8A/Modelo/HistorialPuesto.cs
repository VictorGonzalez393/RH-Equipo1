using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroNegocio_RH_ERP_ISC_8A.Modelo
{
    class HistorialPuesto
    {
        public int idEmpleado { get; set; }
        public int idPuesto { get; set; }
        public int idDepartamento { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }
        public double Salario { get; set; }

        public HistorialPuesto(int empleado, int puesto, int departamento, string fechaInicio, string fechaFin, double salario)
        {
            this.idEmpleado = empleado;
            this.idPuesto = puesto;
            this.idDepartamento = departamento;
            this.FechaInicio = fechaInicio;
            this.FechaFin = fechaFin;
            this.Salario = salario;
        }
    }
}
