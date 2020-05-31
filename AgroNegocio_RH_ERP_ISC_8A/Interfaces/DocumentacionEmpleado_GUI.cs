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
using AgroNegocio_RH_ERP_ISC_8A.Modelo;
using AgroNegocio_RH_ERP_ISC_8A.Datos;

namespace AgroNegocio_RH_ERP_ISC_8A.Interfaces
{
    public partial class DocumentacionEmpleado_GUI : Form
    {
        private byte[] documentoActivo;
        private DocumentacionEmpleado_DAO dAO;
        private DocumentacionEmpleado documentoSeleccionado;
        private readonly int IDEmpleado;

        public DocumentacionEmpleado_GUI(int idemp, string nombreEmp)
        {
            InitializeComponent();
            IDEmpleado = idemp;
            nombreEmpleado.Text = nombreEmp;
            idDocEmpleado.Text = idemp.ToString();
            dAO = new DocumentacionEmpleado_DAO();
        }

        private void DocumentacionEmpleado_GUI_Load(object sender, EventArgs e)
        {
            documentoActivo = null;
            documentoSeleccionado = null;
            CargarDocs();
        }

        private void CargarDocs()
        {
            try
            {
                tablaDocumentacionEmpleado.DataSource = dAO.consultaGeneral("where idEmpleado=@id", new List<string>() { "@id" }, new List<object>() { IDEmpleado });
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            if (documentoActivo != null)
            {
                if (!string.IsNullOrWhiteSpace(nombreDocumento.Text))
                {
                    DocumentacionEmpleado documento = new DocumentacionEmpleado(nombreDocumento.Text, documentoActivo, IDEmpleado);
                    agregarDocumentoTabla(documento);
                    cancelarDoc();
                }
                else
                    Mensajes.Info("Falta el nombre del documento");
            }
            else
            {
                label3.Visible = true;
                nombreDocumento.Visible = true;
                abrir.Visible = true;
                btnVer.Visible = true;
                eliminar.Visible = false;
                editar.Visible = false;
                btnCancelarDoc.Visible = true;
                agregar.Text = "Guardar";
            }

        }

        private void agregarDocumentoTabla(DocumentacionEmpleado documento)
        {
            List<DocumentacionEmpleado> docs = new List<DocumentacionEmpleado>();
            if (tablaDocumentacionEmpleado.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in tablaDocumentacionEmpleado.Rows)
                {
                    docs.Add(row.DataBoundItem as DocumentacionEmpleado);
                }
            }
            docs.Add(documento);
            tablaDocumentacionEmpleado.DataSource = docs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (documentoActivo != null)
            {
                DocumentacionEmpleado_Ver ver = new DocumentacionEmpleado_Ver(documentoActivo);
                ver.ShowDialog();
            }
            else
                Mensajes.Info("No se ha seleccionado ningún documento");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog() { ValidateNames = true, Multiselect = false, Filter = "Archivo PDF|*.pdf" })
            {
                if (open.ShowDialog() == DialogResult.OK)
                {
                    documentoActivo = File.ReadAllBytes(open.FileName);
                    btnVer.Enabled = true;
                    nombreDocumento.Text = open.FileName.Substring(open.FileName.LastIndexOf(@"\") + 1).Replace(".pdf", "");
                }
                else
                {
                    btnVer.Enabled = false;
                    nombreDocumento.Text = "";
                    documentoActivo = null;
                }
            }
        }

        private void btnCancelarDoc_Click(object sender, EventArgs e)
        {
            cancelarDoc();
        }

        private void cancelarDoc()
        {
            label3.Visible = false;
            nombreDocumento.Visible = false;
            btnVer.Enabled = false;
            btnVer.Visible = false;
            btnCancelarDoc.Visible = false;
            abrir.Visible = false;

            documentoActivo = null;
            documentoSeleccionado = null;
            agregar.Text = "Agregar";
            nombreDocumento.Text = "";


            eliminar.Visible = true;
            editar.Visible = true;
            agregar.Visible = true;
        }

        private void tablaDocumentacionEmpleado_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            tablaDocumentacionEmpleado.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            tablaDocumentacionEmpleado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void tablaDocumentacionEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cancelarDoc();
        }

        private void editar_Click(object sender, EventArgs e)
        {
            if (documentoSeleccionado != null)
            {

                if (!string.IsNullOrWhiteSpace(nombreDocumento.Text))
                {
                    documentoSeleccionado.NombreDocumento = nombreDocumento.Text;
                    documentoSeleccionado.Documento = documentoActivo;
                    cancelarDoc();
                    tablaDocumentacionEmpleado.Refresh();
                }
                else
                    Mensajes.Info("Falta el nombre del documento");

            }
            else
                Mensajes.Info("Selecciona con doble click algún documento de la lista");
        }

        private void tablaDocumentacionEmpleado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            label3.Visible = true;
            nombreDocumento.Visible = true;
            abrir.Visible = true;
            btnVer.Visible = true;
            btnVer.Enabled = true;
            eliminar.Visible = false;
            agregar.Visible = false;
            btnCancelarDoc.Visible = true;

            documentoSeleccionado = tablaDocumentacionEmpleado.SelectedRows[0].DataBoundItem as DocumentacionEmpleado;
            nombreDocumento.Text = documentoSeleccionado.NombreDocumento;
            documentoActivo = documentoSeleccionado.Documento;
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (tablaDocumentacionEmpleado.SelectedRows.Count == 1)
            {
                var row = tablaDocumentacionEmpleado.SelectedRows[0];
                var doc = row.DataBoundItem as DocumentacionEmpleado;
                if (Mensajes.PreguntaInfo(string.Format("¿Estás seguro que deseas eliminar el documento {0}?", doc.NombreDocumento)) == DialogResult.OK)
                {
                    if (doc.IDDoc == 0)
                    {
                        List<DocumentacionEmpleado> docs = new List<DocumentacionEmpleado>();
                        for (int i = 0; i < tablaDocumentacionEmpleado.Rows.Count; i++)
                        {
                            if (i != tablaDocumentacionEmpleado.SelectedRows[0].Index)
                            {
                                row = tablaDocumentacionEmpleado.Rows[i];
                                docs.Add(row.DataBoundItem as DocumentacionEmpleado);
                            }
                        }
                        tablaDocumentacionEmpleado.DataSource = docs;
                    }
                    else
                    {
                        tablaDocumentacionEmpleado.ClearSelection();
                        tablaDocumentacionEmpleado.CurrentCell = null;
                        //CurrencyManager cm = (CurrencyManager)BindingContext[tablaDocumentacionEmpleado.DataSource];
                        //cm.SuspendBinding();
                        doc.Estatus = 'I';
                        row.Visible = false;
                    }
                }
            }
            else
                Mensajes.Info("Selecciona algún documento de la lista");
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (tablaDocumentacionEmpleado.Rows.Count > 0)
                try
                {
                    List<DocumentacionEmpleado> docs = new List<DocumentacionEmpleado>();
                    foreach (DataGridViewRow row in tablaDocumentacionEmpleado.Rows)
                    {
                        docs.Add(row.DataBoundItem as DocumentacionEmpleado);
                    }
                    if (dAO.registrarDocumentos(docs))
                    {
                        Mensajes.Info("Documentos guardados con éxito");
                        FormClosing -= DocumentacionEmpleado_GUI_FormClosing;
                        Close();
                    }
                    else
                    {
                        Mensajes.Info("Ha ocurrido un error");
                    }
                }
                catch (Exception ex)
                {
                    Mensajes.Error(ex.Message);
                }
            else
                Mensajes.Info("Agrega por lo menos un documento a la lista");

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DocumentacionEmpleado_GUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = Mensajes.PreguntaAdvertencia("Estás a punto de cerrar la ventana." +
                  "\n Los cambios realizados no se guardarán. \n¿Deseas continuar?");
            if (resultado == DialogResult.Cancel)
                e.Cancel = true;
        }
    }
}

