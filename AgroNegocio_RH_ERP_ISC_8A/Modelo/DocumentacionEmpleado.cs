using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroNegocio_RH_ERP_ISC_8A.Modelo
{
    public class DocumentacionEmpleado
    {
        public int ID { get; set; }
        public string nombreDocumento { get; set; }
        public TimeSpan fechaEntrega { get; set; }
        public byte[] Documento { get; set; }
        public char Estatus { get; set; }
        public int idEmpleado { get; set; }
        public DocumentacionEmpleado(int id, string nombredocumento, TimeSpan fechaentrega, 
            byte [] documento,char estatus, int idempleado)
        {
            ID = id;
            nombreDocumento = nombredocumento;
            fechaEntrega = fechaentrega;
            Documento = documento;
            Estatus = estatus;
            idEmpleado = idempleado;
        }
        }
}
