using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PdfiumViewer;

namespace AgroNegocio_RH_ERP_ISC_8A.Interfaces
{
    public partial class DocumentacionEmpleado_Ver : Form
    {
        private byte[] Pdf_bytes;
        public DocumentacionEmpleado_Ver(byte[] pdf_bytes)
        {
            InitializeComponent();
            Pdf_bytes = pdf_bytes;
        }

        private void DocumentacionEmpleado_Ver_Load(object sender, EventArgs e)
        {
            try
            {
                var stream = new MemoryStream(Pdf_bytes);
                PdfDocument document = PdfDocument.Load(stream);
                pdfViewer1.Document = document;

            }catch(Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }
    }
}
