using AgroNegocio_RH_ERP_ISC_8A.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
//using Microsoft.VisualBasic;


namespace AgroNegocio_RH_ERP_ISC_8A.Datos
{
    class ReportePDF
    {
        int num;
        string nom;
        string fecha;
        string puesto;
        string nss;
        string fI;
        string fF;
        string periodo;
        int diasT;
        string nomArch;
        string ruta;
        double cantN;
        double totalP;
        double totalD;
         List< NominaDeduccion> nd;
        List<NominaPercepcion> np;

        public ReportePDF(int num, string nom, string fecha, string puesto,string nss, string fI, string fF,
            int diasT, string ruta, double cantN, List<NominaDeduccion> nd, List<NominaPercepcion> np, double totalP, double totalD)
        {
            this.num = num;
            this.nom = nom;
            this.fecha = fecha;
            this.puesto = puesto;
            this.nss = nss;
            this.fI = fI;
            this.fF = fF;
            this.periodo = fI+" - "+fF;
            this.diasT = diasT;
            this.nomArch = "Nomina#" + num + "_Empleado_" + nom +".pdf";
            this.ruta = ruta;
            this.cantN = cantN;

            this.nd = nd;
            this.np = np;
            this.totalP = totalP;
            this.totalD = totalD;
        }

        public void generarPDF()
        {
            try
            {
                Document doc = new Document(PageSize.LETTER);
                // Indicamos donde vamos a guardar el documento
                PdfWriter writer = PdfWriter.GetInstance(doc,
                                            new FileStream(@"" + ruta +"\\"+nomArch, FileMode.Create));


                // Le colocamos el título y el autor
                // **Nota: Esto no será visible en el documento
                doc.AddTitle(@"Nomina#" + num + "_Empleado_" + nom + "_Periodo_" + periodo);
                doc.AddCreator("Equipo1_Agronegocio");
                // Creamos la imagen y le ajustamos el tamaño
                iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance(@"..\\..\\Iconos\\logo.png"); 
                imagen.BorderWidth = 0;
                imagen.Alignment = Element.ALIGN_LEFT;
                float percentage = 0.0f;
                percentage = 40 / imagen.Width;
                imagen.ScalePercent(percentage * 100);
                imagen.SetAbsolutePosition(30, 750);
                var parrafo2 = new Paragraph("AGRONEGOCIO");
                parrafo2.SpacingBefore = 0;
                parrafo2.SpacingAfter = 0;
                parrafo2.Alignment = 1;
                var parrafo3 = new Paragraph("NÓMINA PARA EL EMPLEADO");
                parrafo3.SpacingBefore = 0;
                parrafo3.SpacingAfter = 0;
                parrafo3.Alignment = 1;
                // Abrimos el archivo
                doc.Open();
                // Insertamos la imagen en el documento
                doc.Add(imagen);
                // Escribimos el encabezamiento en el documento
                doc.Add(parrafo2);
                doc.Add(parrafo3);
                doc.Add(Chunk.NEWLINE);
               
                iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                iTextSharp.text.Font _standardFont_2 = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.NORMAL, BaseColor.DARK_GRAY);
                // Creamos una tabla de datos
                PdfPTable principal = new PdfPTable(6);
                principal.WidthPercentage = 100;
                PdfPCell cl1 = new PdfPCell(new Phrase("N°Nómina:", _standardFont_2));
                cl1.BorderWidth = 0;
                PdfPCell cl2 = new PdfPCell(new Phrase(""+num, _standardFont));
                cl2.BorderWidth = 0;
                PdfPCell cl5 = new PdfPCell(new Phrase(" ", _standardFont_2));
                cl5.BorderWidth = 0;
                PdfPCell cl6 = new PdfPCell(new Phrase(" ", _standardFont));
                cl6.BorderWidth = 0;
                PdfPCell cl3 = new PdfPCell(new Phrase("Fecha Pago:", _standardFont_2));
                cl3.BorderWidth = 0;
                PdfPCell cl4 = new PdfPCell(new Phrase(fecha, _standardFont));
                cl4.BorderWidth = 0;
                principal.AddCell(cl1);
                principal.AddCell(cl2);
                principal.AddCell(cl5);
                principal.AddCell(cl6);
                principal.AddCell(cl3);
                principal.AddCell(cl4);
               

                PdfPTable principal2 = new PdfPTable(6);
                principal2.WidthPercentage = 100;
                cl1 = new PdfPCell(new Phrase("Empleado:", _standardFont_2));
                cl1.BorderWidth = 0;
                cl2 = new PdfPCell(new Phrase(nom, _standardFont));
                cl2.BorderWidth = 0;
                cl3 = new PdfPCell(new Phrase("NSS:", _standardFont_2));
                cl3.BorderWidth = 0;
                cl4 = new PdfPCell(new Phrase(nss, _standardFont));
                cl4.BorderWidth = 0;
                cl5 = new PdfPCell(new Phrase("Puesto:", _standardFont_2));
                cl5.BorderWidth = 0;
                cl6 = new PdfPCell(new Phrase(puesto, _standardFont));
                cl6.BorderWidth = 0;
                principal2.AddCell(cl1);
                principal2.AddCell(cl2);
                principal2.AddCell(cl3);
                principal2.AddCell(cl4);
                principal2.AddCell(cl5);
                principal2.AddCell(cl6);

                PdfPTable principal3 = new PdfPTable(6);
                principal3.WidthPercentage = 100;
                cl1 = new PdfPCell(new Phrase("Periodo:", _standardFont_2));
                cl1.BorderWidth = 0;
                cl2 = new PdfPCell(new Phrase(fI+" - ", _standardFont));
                cl2.BorderWidth = 0;
                 cl5 = new PdfPCell(new Phrase(fF, _standardFont));
                cl5.BorderWidth = 0;
                 cl6 = new PdfPCell(new Phrase(" ", _standardFont));
                cl6.BorderWidth = 0;
                cl3 = new PdfPCell(new Phrase("Días trabajados:", _standardFont_2));
                cl3.BorderWidth = 0;
                cl4 = new PdfPCell(new Phrase(""+diasT, _standardFont));
                cl4.BorderWidth = 0;
                principal3.AddCell(cl1);
                principal3.AddCell(cl2);
                principal3.AddCell(cl5);
                principal3.AddCell(cl6);
                principal3.AddCell(cl3);
                principal3.AddCell(cl4);

                PdfPTable tblCon = new PdfPTable(3);
                tblCon.WidthPercentage = 100;
                PdfPCell clConcepto = new PdfPCell(new Phrase("Concepto", _standardFont_2));
                clConcepto.BorderWidth = 1;
                PdfPCell clPercepcion = new PdfPCell(new Phrase("Percepciones", _standardFont_2));
                clPercepcion.BorderWidth = 1;
                PdfPCell clDeduccion = new PdfPCell(new Phrase("Deducciones", _standardFont_2));
                clDeduccion.BorderWidth = 1;

                // Añadimos las celdas a la tabla
                tblCon.AddCell(clConcepto);
                tblCon.AddCell(clPercepcion);
                tblCon.AddCell(clDeduccion);

                // Para las percepciones
                for(int i=0; i < np.Count; i++)
                {
                    clConcepto = new PdfPCell(new Phrase(np[i].nombre, _standardFont));
                    clConcepto.BorderWidth = 0;
                    clConcepto.BorderWidthRight = 1;
                    clConcepto.BorderWidthLeft = 1;

                    clPercepcion = new PdfPCell(new Phrase("$ "+np[i].importe, _standardFont));
                    clPercepcion.BorderWidth = 0;
                    clPercepcion.BorderWidthRight = 1;

                    clDeduccion = new PdfPCell(new Phrase("", _standardFont));
                    clDeduccion.BorderWidth = 0;
                    clDeduccion.BorderWidthRight = 1;

                    // Añadimos las celdas a la tabla
                    tblCon.AddCell(clConcepto);
                    tblCon.AddCell(clPercepcion);
                    tblCon.AddCell(clDeduccion);
                }

                for(int i=0; i < nd.Count; i++)
                {
                    //Va ser lo de deducciones
                    clConcepto = new PdfPCell(new Phrase(nd[i].nombre, _standardFont));
                    clConcepto.BorderWidth = 0;
                    clConcepto.BorderWidthRight = 1;
                    clConcepto.BorderWidthLeft = 1;

                    clPercepcion = new PdfPCell(new Phrase("", _standardFont));
                    clPercepcion.BorderWidth = 0;
                    clPercepcion.BorderWidthRight = 1;

                    clDeduccion = new PdfPCell(new Phrase("$ "+nd[i].importe, _standardFont));
                    clDeduccion.BorderWidth = 0;
                    clDeduccion.BorderWidthRight = 1;

                    tblCon.AddCell(clConcepto);
                    tblCon.AddCell(clPercepcion);
                    tblCon.AddCell(clDeduccion);
                }


                PdfPTable tblTotal = new PdfPTable(3);
                tblTotal.WidthPercentage = 100;
                PdfPCell clTotal = new PdfPCell(new Phrase("Total", _standardFont_2));
                clConcepto.BorderWidth = 1;
                PdfPCell clTPercepcion = new PdfPCell(new Phrase("$ " + totalP, _standardFont));
                clPercepcion.BorderWidth = 1;
                PdfPCell clTDeduccion = new PdfPCell(new Phrase("$ " + totalD, _standardFont));
                clDeduccion.BorderWidth = 1;
                // Añadimos las celdas a la tabla
                tblCon.AddCell(clTotal);
                tblCon.AddCell(clTPercepcion);
                tblCon.AddCell(clTDeduccion);

                // Finalmente, añadimos la tabla al documento PDF y cerramos el documento
                doc.Add(principal);
                doc.Add(principal2);
                doc.Add(principal3);
                doc.Add(Chunk.NEWLINE);
                doc.Add(Chunk.NEWLINE);
                doc.Add(tblTotal);
                doc.Add(tblCon);
                doc.Add(tblTotal);
                doc.Add(Chunk.NEWLINE);

                var parrafo7 = new Paragraph("Sello de la empresa" + "                                                         Cantidad neta: $ " + cantN);
                parrafo7.SpacingBefore = 0;
                parrafo7.SpacingAfter = 0;
                parrafo7.Alignment = 0;
                doc.Add(parrafo7);
                doc.Add(Chunk.NEWLINE);
                doc.Add(Chunk.NEWLINE);
                var parrafo8 = new Paragraph("                                                                                                                   Recibi");
                parrafo8.SpacingBefore = 0;
                parrafo8.SpacingAfter = 0;
                parrafo8.Alignment = 0;
                var parrafo9 = new Paragraph("                                                                                                      ____________________");
                parrafo9.SpacingBefore = 0;
                parrafo9.SpacingAfter = 0;
                parrafo9.Alignment = 0;
                var parrafo10 = new Paragraph("                                                                                                             Firma empleado");
                parrafo10.SpacingBefore = 0;
                parrafo10.SpacingAfter = 0;
                parrafo10.Alignment = 0;
                doc.Add(parrafo8);
                doc.Add(Chunk.NEWLINE);
                doc.Add(parrafo9);
                doc.Add(parrafo10);
                doc.Close();
                writer.Close();
                Mensajes.Info("EL PDF se guardo satisfactoriamente");

                
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error del PDF" + ex.Message);
                Mensajes.Error("Error al generar PDF");
            }
        }

    }
}
