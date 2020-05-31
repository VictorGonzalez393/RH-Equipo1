using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroNegocio_RH_ERP_ISC_8A.Modelo
{
    public class DocumentacionEmpleado
    {
        internal int IDDoc { get; set; }
        internal int IDDocTmp { get; set; }
        public string ID { get { return IDDoc == 0 ? "No asignado" : IDDoc.ToString(); } }
        public string NombreDocumento { get; set; }
        public DateTime Fecha { get; set; }
        internal byte[] Documento { get; set; }
        public char Estatus { get; set; }
        internal int IDEmpleado { get; set; }
        public DocumentacionEmpleado(int iddoc, string nombredocumento, DateTime fechaentrega, byte[] documento, char estatus, int idempleado)
        {
            IDDoc = iddoc;
            NombreDocumento = nombredocumento;
            Fecha = fechaentrega;
            Documento = documento;
            Estatus = estatus;
            IDEmpleado = idempleado;
        }

        public DocumentacionEmpleado(string nombredocumento, byte[] documento, int idempleado)
        {
            IDDoc = 0;
            Estatus = 'A';
            Fecha = DateTime.Now;

            IDEmpleado = idempleado;
            NombreDocumento = nombredocumento;
            Documento = documento;
        }
    }
}
