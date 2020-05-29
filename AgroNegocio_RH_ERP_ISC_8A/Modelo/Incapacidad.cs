using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroNegocio_RH_ERP_ISC_8A.Modelo
{
   public class Incapacidad
    {
        public string NombreCompleto { get { return string.Format("{0} {1} {2}", Nombre, Apaterno, Amaterno); } }
        public int IdIncapacidad { get; set; } 
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; } 
        public string Apaterno { get; set; } 
        public string Amaterno { get; set; }
        public string Enfermedad { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }
        public Image Evidencia { get; set; }
        public byte[] img_bt
        {
            get
            {
                ImageConverter _img = new ImageConverter();
                byte[] bytes = (byte[])_img.ConvertTo(Evidencia, typeof(byte[]));
                return bytes;

            }
        } 
        public byte[] bt { get; set; }

        public Incapacidad(int idIncapacidad, int idEmpleado, string nombre, string apaterno, string amaterno, string enfermedad, string fechaInicio, string fechaFin, byte[] bt)
        {
            IdIncapacidad = idIncapacidad;
            IdEmpleado = idEmpleado;
            Nombre = nombre;
            Apaterno = apaterno;
            Amaterno = amaterno;
            Enfermedad = enfermedad;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            this.bt = bt;
            Evidencia= new Bitmap(new Bitmap(new MemoryStream(bt)), new Size(120, 134));
        }

        public Incapacidad(int idIncapacidad, int idEmpleado,string nombre, string apaterno, string amaterno, string enfermedad, string fechaInicio, string fechaFin, Image evidencia)
        {
            IdIncapacidad = idIncapacidad;
            IdEmpleado = idEmpleado;
            Nombre = nombre;
            Apaterno = apaterno;
            Amaterno = amaterno;
            Enfermedad = enfermedad;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            Evidencia = evidencia;
        }
    }
}
