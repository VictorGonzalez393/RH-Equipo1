using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroNegocio_RH_ERP_ISC_8A.Modelo
{

    public class Empleado
    {
        public string NombreCompleto { get { return string.Format("{0} {1} {2}", Nombre, Apaterno, Amaterno); } }
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apaterno { get; set; }
        public string Amaterno { get; set; }
        public string Sexo { get; set; }
        public string FechaContratacion { get; set; }
        public string FechaNacimiento { get; set; }
        public double Salario { get; set; }
        public string Nss { get; set; }
        public string EstadoCivil { get; set; }
        public int DiasVacaciones { get; set; }
        public int DiasPermiso { get; set; }
        //public byte Fotografia { get; set; 
        public Image img { get; set; }
        public byte[] img_bt {
            get {
                ImageConverter _img = new ImageConverter();
                byte[] bytes = (byte[])_img.ConvertTo(img, typeof(byte[]));
                return bytes;

            }
        }
        public byte[] bt{get; set;}
        public string Direccion { get; set; }
        public string Colonia { get; set; }
        public string CodigoPostal { get; set; }
        public string Escolaridad { get; set; }
        public double PorcentajeComision { get; set; }
        public char Estatus { get; set; }
        public int IdDepartamento { get; set; }
        public int IdPuesto { get; set; }
        public int IdCiudad { get; set; }
        public int IdSucursal { get; set; }

        public Empleado(int idEmpleado, string nombre, string apaterno, string amaterno, string sexo, string fechaContratacion,
       string fechaNacimiento, double salario, string nss, string estadoCivil, int diasVacaciones, int diasPermiso, string direccion, string colonia, string codigoPostal, string escolaridad, double porcentajeComision, char estatus, int idDepartamento,
       int idPuesto, int idCiudad, int idSucursal)
        {
            IdEmpleado = idEmpleado;
            Nombre = nombre;
            Apaterno = apaterno;
            Amaterno = amaterno;
            Sexo = sexo;
            FechaContratacion = fechaContratacion;
            FechaNacimiento = fechaNacimiento;
            Salario = salario;
            Nss = nss;
            EstadoCivil = estadoCivil;
            DiasVacaciones = diasVacaciones;
            DiasPermiso = diasPermiso;
            // Fotografia = fotografia;
            Direccion = direccion;
            Colonia = colonia;
            CodigoPostal = codigoPostal;
            Escolaridad = escolaridad;
            PorcentajeComision = porcentajeComision;
            Estatus = estatus;
            IdDepartamento = idDepartamento;
            IdPuesto = idPuesto;
            IdCiudad = idCiudad;
            IdSucursal = idSucursal;

        }
        public Empleado(int idEmpleado, string nombre, string apaterno, string amaterno, string sexo, string fechaContratacion,
       string fechaNacimiento, double salario, string nss, string estadoCivil, int diasVacaciones, int diasPermiso, //byte fotografia,
       string direccion, string colonia, string codigoPostal, string escolaridad, double porcentajeComision, char estatus, int idDepartamento,
       int idPuesto, int idCiudad, int idSucursal, Image imga)
        {
            IdEmpleado = idEmpleado;
            Nombre = nombre;
            Apaterno = apaterno;
            Amaterno = amaterno;
            Sexo = sexo;
            FechaContratacion = fechaContratacion;
            FechaNacimiento = fechaNacimiento;
            Salario = salario;
            Nss = nss;
            EstadoCivil = estadoCivil;
            DiasVacaciones = diasVacaciones;
            DiasPermiso = diasPermiso;
            // Fotografia = fotografia;
            Direccion = direccion;
            Colonia = colonia;
            CodigoPostal = codigoPostal;
            Escolaridad = escolaridad;
            PorcentajeComision = porcentajeComision;
            Estatus = estatus;
            IdDepartamento = idDepartamento;
            IdPuesto = idPuesto;
            IdCiudad = idCiudad;
            IdSucursal = idSucursal;
            img = imga;

        }
        public Empleado(int idEmpleado, string nombre, string apaterno, string amaterno, string sexo, string fechaContratacion,
       string fechaNacimiento, double salario, string nss, string estadoCivil, int diasVacaciones, int diasPermiso, //byte fotografia,
       string direccion, string colonia, string codigoPostal, string escolaridad, double porcentajeComision, char estatus, int idDepartamento,
       int idPuesto, int idCiudad, int idSucursal, byte[] imB)
        {
            IdEmpleado = idEmpleado;
            Nombre = nombre;
            Apaterno = apaterno;
            Amaterno = amaterno;
            Sexo = sexo;
            FechaContratacion = fechaContratacion;
            FechaNacimiento = fechaNacimiento;
            Salario = salario;
            Nss = nss;
            EstadoCivil = estadoCivil;
            DiasVacaciones = diasVacaciones;
            DiasPermiso = diasPermiso;
            // Fotografia = fotografia;
            Direccion = direccion;
            Colonia = colonia;
            CodigoPostal = codigoPostal;
            Escolaridad = escolaridad;
            PorcentajeComision = porcentajeComision;
            Estatus = estatus;
            IdDepartamento = idDepartamento;
            IdPuesto = idPuesto;
            IdCiudad = idCiudad;
            IdSucursal = idSucursal;
            bt = imB;
           
            img=new Bitmap(new Bitmap(new MemoryStream(imB)), new Size(120, 134));

        }

        public Empleado(int idEmpleado, string nombre, string apaterno, string amaterno, char estatus) 
        {
            IdEmpleado = idEmpleado;
            Nombre = nombre;
            Apaterno = apaterno;
            Amaterno = amaterno;
            Estatus = estatus;
        }


        /// <summary>
        /// Constructor empleado en pruebas de horarios
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        public Empleado(int id, string nombre, string v)
        {

        } 
        override
        public string ToString()
        {
            return this.Nombre+" "+this.Apaterno+" "+this.Amaterno;
        }
    }

}
