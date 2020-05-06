using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroNegocio_RH_ERP_ISC_8A.Modelo
{
    class Sucursal
    {
        public int IdSucursal { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Colonia { get; set; }
        public string CP { get; set; }
        public double Presupuesto { get; set; }
        public char Estatus { get; set; }
        public int IdCiudad { get; set;}

        public Sucursal(int idSucursal, string nombre, string telefono, string direccion, string colonia, string cP, double presupuesto, char estatus, int idCiudad)
        {
            IdSucursal = idSucursal;
            Nombre = nombre;
            Telefono = telefono;
            Direccion = direccion;
            Colonia = colonia;
            CP = cP;
            Presupuesto = presupuesto;
            Estatus = estatus;
            IdCiudad = idCiudad;
        }
        override
        public string ToString()
        {
            return this.Nombre;
        }
    }
}
