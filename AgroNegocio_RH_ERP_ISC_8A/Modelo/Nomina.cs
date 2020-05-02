using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroNegocio_RH_ERP_ISC_8A.Modelo
{
    class Nomina
    {
        public int idNomina { get; set; }
        public string fechaPago { get; set; }
        public decimal totalP { get; set; }
        public decimal totalD { get; set; }
        public decimal cantidadNeta { get; set; }
        public int diasTrabajados { get; set; } 
        public int faltas { get; set; }
        public string fechaInicio { get; set; }
        public string fechaFin { get; set; }
        public int idEmpleado { get; set; }
        public int idFormaPago { get; set; }

        public Nomina(int idNomina, string fechaPago, decimal totalP, decimal totalD, decimal cantidadNeta, int diasTrabajados, int faltas, string fechaInicio, string fechaFin, int idEmpleado, int idFormaPago)
        {
            this.idNomina = idNomina;
            this.fechaPago = fechaPago;
            this.totalP = totalP;
            this.totalD = totalD;
            this.cantidadNeta = cantidadNeta;
            this.diasTrabajados = diasTrabajados;
            this.faltas = faltas;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            this.idEmpleado = idEmpleado;
            this.idFormaPago = idFormaPago;
        } 

    }
}
