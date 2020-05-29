using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgroNegocio_RH_ERP_ISC_8A.Datos;
using AgroNegocio_RH_ERP_ISC_8A.Modelo;
using System.Diagnostics;
using SpreadsheetLight;
using DocumentFormat;
using DocumentFormat.OpenXml.Math;

namespace AgroNegocio_RH_ERP_ISC_8A.Interfaces
{
    public partial class Nomina_GUI : Form
    {
        public int idEmp { get; set; }
        Nomina_DAO nominas_DAO;
        string aux1, aux2;
        double salarioE = 0;
        double salarioMin = 123.22;
        Empleados_DAO em_dao = new Empleados_DAO();
        NominaDeduccion_DAO nd = new NominaDeduccion_DAO();
        NominaPercepcion_DAO np = new NominaPercepcion_DAO();
        
        public Nomina_GUI()
        {
            InitializeComponent();
            try
            {
                nominas_DAO = new Nomina_DAO();
                salarioE= em_dao.getSalario(this.idEmp);
                nominas_DAO.table = "Nominas_Tabla";
                nominas_DAO.order_by = "ID";
                nominas_DAO.where = "ID_Empleado=" + idEmp;
                nominas_DAO.CalculaPaginas();
                if (nominas_DAO.actual_page == 1 || nominas_DAO.pages == 0)
                {
                    btn_anterior.Enabled = false;
                }
                else if (nominas_DAO.actual_page == nominas_DAO.pages)
                {
                    btn_siguiente.Enabled = false;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        public Nomina_GUI(int idEmp, string empleado)
        {
            InitializeComponent();
            nombre.Text=empleado;
            this.idEmp = idEmp;
            salarioE = em_dao.getSalario(this.idEmp);
            try { 
                nominas_DAO = new Nomina_DAO();
                nominas_DAO.table = "Nominas_Tabla";
                nominas_DAO.order_by = "ID";
                nominas_DAO.where = "ID_Empleado='" + idEmp+"'";
                nominas_DAO.CalculaPaginas();
                if (nominas_DAO.actual_page==1 || nominas_DAO.pages == 0)
                {
                    btn_anterior.Enabled = false;
                }else if (nominas_DAO.actual_page == nominas_DAO.pages)
                {
                    btn_siguiente.Enabled = false;

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }

        private void Nomina_GUI_Load(object sender, EventArgs e)
        {
            if (salarioE > salarioMin)
            {
                nóminaDeduccionesToolStripMenuItem.Enabled = true;
                
            }
            else
            {
                nóminaDeduccionesToolStripMenuItem.Enabled = false;
            }
            try
            {
                tablaNomina.DataSource = nominas_DAO.getSigPagina();
                aux1 = lbl_pagina.Text;
                aux2 = lbl_total.Text;
                salarioE = em_dao.getSalario(this.idEmp);
                lbl_pagina.Text = aux1 + " " + nominas_DAO.actual_page;
                lbl_total.Text = aux2 + " " + nominas_DAO.pages;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            btn_siguiente.Enabled = true;
            if (nominas_DAO.actual_page > 1)
            {
                tablaNomina.DataSource = nominas_DAO.getAnteriorPagina();
            }
            if (nominas_DAO.actual_page == 1)
            {
                btn_anterior.Enabled = false;
            }
            lbl_pagina.Text = aux1 + " " + nominas_DAO.actual_page;
            lbl_total.Text = aux2 + " " + nominas_DAO.pages;
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            btn_anterior.Enabled = true;
            if (nominas_DAO.actual_page < nominas_DAO.pages)
            {
                tablaNomina.DataSource = nominas_DAO.getSigPagina();
            }
            if (nominas_DAO.actual_page == nominas_DAO.pages)
            {
                btn_siguiente.Enabled = false;
            }
            lbl_pagina.Text = aux1 + " " + nominas_DAO.actual_page;
            lbl_total.Text = aux2 + " " + nominas_DAO.pages;
        }

        private void btn_buscarNomina_Click(object sender, EventArgs e)
        {
            if (buscarNominaTXT.Text.Equals(""))
            {
                DialogResult resultado = MessageBox.Show("No hay datos para buscar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {
                    string consulta_wh = "Fecha_pago like '%'+'" + buscarNominaTXT.Text + "'+'%' and ID_Empleado="+idEmp;
                    tablaNomina.DataSource = nominas_DAO.buscar(consulta_wh);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR: " + ex.Message);
                    MessageBox.Show("Error en la busqueda");
                }

            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tablaNomina.SelectedRows.Count != -1)
            {

                try
                {
                    DialogResult resultado = MessageBox.Show("¿Estás seguro que desea eliminar la nómina?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        DataGridViewRow row = tablaNomina.SelectedRows[0];
                        int idNomina = (int)row.Cells[1].Value;
                        if ((string)row.Cells[11].Value != "P")
                        {
                            nominas_DAO.eliminar(idNomina);
                            Mensajes.Info("La nómino se elimino correctamente");
                        }
                        else
                        {
                            Mensajes.Error("La nómina ya ha sido pagada");
                        }

                    }
                    actualizar();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar eliminar la nómina");
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Selecciona la nómina", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void actualizar()
        {
            btn_anterior.Enabled = false;
            btn_siguiente.Enabled = true;
            tablaNomina.DataSource = nominas_DAO.actualizar();
            lbl_pagina.Text = aux1 + " " + nominas_DAO.actual_page;
            lbl_total.Text = aux2 + " " + nominas_DAO.pages;
        }

        private void nóminaPercepcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tablaNomina.SelectedRows.Count == 1)
            {

                DataGridViewRow row = tablaNomina.SelectedRows[0];
                Nomina nom = new Nomina(
                    (int)row.Cells[1].Value,
                    (int)row.Cells[0].Value,
                    (string)row.Cells[2].Value,
                    Convert.ToDecimal(row.Cells[3].Value),
                    Convert.ToDecimal(row.Cells[4].Value),
                    Convert.ToDecimal(row.Cells[5].Value),
                    (int)row.Cells[6].Value,
                    (int)row.Cells[7].Value,
                    (string)row.Cells[8].Value,
                    (string)row.Cells[9].Value,
                    (string)row.Cells[10].Value,
                    Convert.ToChar(row.Cells[11].Value));
                if (salarioE <= salarioMin)
                {

                }
                else
                {

                }
                NominasPercepciones_GUI np = new NominasPercepciones_GUI(nom, this.idEmp, this.nombre.Text, salarioE); /*Mandar el GUI con esos valores*/
                this.SetVisibleCore(false);
                np.ShowDialog();
                this.SetVisibleCore(true);
                actualizar();

            }
            else
            {
                DialogResult resultado = MessageBox.Show("Selecciona a una nómina", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void nóminaDeduccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (tablaNomina.SelectedRows.Count == 1)
            {
               
                DataGridViewRow row = tablaNomina.SelectedRows[0];
                Nomina nom = new Nomina(
                    (int)row.Cells[1].Value,
                    (int)row.Cells[0].Value,
                    (string)row.Cells[2].Value,
                    Convert.ToDecimal(row.Cells[3].Value),
                    Convert.ToDecimal(row.Cells[4].Value),
                    Convert.ToDecimal(row.Cells[5].Value),
                    (int)row.Cells[6].Value,
                    (int)row.Cells[7].Value,
                    (string)row.Cells[8].Value,
                    (string)row.Cells[9].Value,
                    (string)row.Cells[10].Value,
                    Convert.ToChar(row.Cells[11].Value));
                if (salarioE <= salarioMin)
                {

                }
                else
                {

                }
                NominasDeducciones_GUI np = new NominasDeducciones_GUI(nom,this.idEmp,this.nombre.Text,salarioE); /*Mandar el GUI con esos valores*/
                this.SetVisibleCore(false);
                np.ShowDialog();
                this.SetVisibleCore(true);
                actualizar();

            }
            else
            {
                DialogResult resultado = MessageBox.Show("Selecciona a una nómina", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Principal p = new Principal();
            this.SetVisibleCore(false);
            p.ShowDialog();
            Close();
        }

        private void atrásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevaNóminaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Nomina_nuevo nn = new Nomina_nuevo(nombre.Text,idEmp);
            nn.ShowDialog();
            actualizar();
        }

        private void buscarNominaTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void autorizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tablaNomina.SelectedRows.Count == 1)
            {
                DataGridViewRow row = tablaNomina.SelectedRows[0];
                if ((string)row.Cells[11].Value != "P")
                {
                    int idNomina = (int)row.Cells[1].Value;
                    nominas_DAO.estatus(idNomina, 'P');
                    actualizar();
                    Mensajes.Info("Se autorizo el pago de la nómina");
                }
                else
                {
                    Mensajes.Error("La nómina ya ha sido pagada");
                }

            }
            else
            {
                Mensajes.Error("Seleccione la nómina");
            }
        }

        private void pDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportePDF reporte;
            List<Empleado> empleado;
            List<NominaDeduccion> nomD;
            List<NominaPercepcion> nomP;
            Mensajes.Info("A continuación debe seleccionar la carpeta donde desea almacenar el archivo");
            
                string ruta = "";
                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    
                if (tablaNomina.SelectedRows.Count == 1)
                {
                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        ruta = fbd.SelectedPath;
                        Mensajes.Info("La ruta seleccionada es: " + ruta);
                        DataGridViewRow row = tablaNomina.SelectedRows[0];
                            empleado = em_dao.consultaGeneral3("where id=" + (int)row.Cells[1].Value, new List<string>(), new List<object>());
                            string consulta_where = " where idNomina=@id";
                            List<string> parametros = new List<string>();
                            parametros.Add("@id");
                            List<object> valores = new List<object>();
                            valores.Add((int)row.Cells[0].Value);
                            nomD = nd.consultaGeneral(consulta_where, parametros, valores);
                            nomP = np.consultaGeneral(consulta_where, parametros, valores);

                            reporte = new ReportePDF((int)row.Cells[0].Value, empleado[0].NombreCompleto, (string)row.Cells[2].Value, empleado[0].Puesto, empleado[0].Nss, (string)row.Cells[8].Value
                                , (string)row.Cells[9].Value, (int)row.Cells[6].Value, ruta, Convert.ToDouble(row.Cells[5].Value), nomD, nomP, Convert.ToDouble(row.Cells[3].Value), Convert.ToDouble(row.Cells[4].Value));
                            reporte.generarPDF();
                        }
                        else
                        {
                            Mensajes.Error("Seleccione una carpeta");
                        }
                    }
                    else
                    {
                        Mensajes.Error("Seleccione una nómina");
                    }
                
            }
            
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mensajes.Info("A continuación debe seleccionar la carpeta donde desea almacenar el archivo");
            SLDocument sl = new SLDocument();
            SLStyle style1 = new SLStyle();
            SLStyle style2 = new SLStyle();
            style1.Font.FontSize = 14;
            style1.Font.Bold = true;
            style2.Font.FontSize = 12;
            
            style2.SetTopBorder(DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Medium,SLThemeColorIndexValues.Accent1Color, -0.5);
            style2.SetLeftBorder(DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Medium, SLThemeColorIndexValues.Accent1Color, -0.5);
            style2.SetRightBorder(DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Medium, SLThemeColorIndexValues.Accent1Color, -0.5);
            style2.SetBottomBorder(DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Medium, SLThemeColorIndexValues.Accent1Color, -0.5);
            string ruta = "";
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    ruta = fbd.SelectedPath;
                    Mensajes.Info("La ruta seleccionada es: " + ruta);
                    try
                    {
                        string consulta_wh = "ID_Empleado=" + idEmp;
                        tablaNomina.DataSource = nominas_DAO.buscar(consulta_wh);

                        sl.SetCellValue(1, 1, "Tabla de nóminas del empleado: " + nombre.Text + "          Fecha de creación:" + DateTime.Today.ToShortDateString());
                        sl.SetCellStyle(1, 1, style1);
                        style1.Font.FontSize = 12;
                        style1.SetTopBorder(DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Medium, SLThemeColorIndexValues.Accent1Color, -0.5);
                        style1.SetLeftBorder(DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Medium, SLThemeColorIndexValues.Accent1Color, -0.5);
                        style1.SetRightBorder(DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Medium, SLThemeColorIndexValues.Accent1Color, -0.5);
                        style1.SetBottomBorder(DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Medium, SLThemeColorIndexValues.Accent1Color, -0.5);
                        
                        int c = 1;
                        foreach (DataGridViewColumn col in tablaNomina.Columns)
                        {
                            sl.SetCellValue(2, c, col.HeaderText.ToString());
                            sl.SetCellStyle(2, c, style1);
                            c++;
                        }

                        int r = 3;
                        foreach (DataGridViewRow row in tablaNomina.Rows)
                        {

                            sl.SetCellValue(r, 1, row.Cells[0].Value.ToString());
                            sl.SetCellStyle(r, 1, style2);
                            sl.SetCellValue(r, 2, row.Cells[1].Value.ToString());
                            sl.SetCellStyle(r, 2, style2);
                            sl.SetCellValue(r, 3, row.Cells[2].Value.ToString());
                            sl.SetCellStyle(r, 3, style2);
                            sl.SetCellValue(r, 4, row.Cells[3].Value.ToString());
                            sl.SetCellStyle(r, 4, style2);
                            sl.SetCellValue(r, 5, row.Cells[4].Value.ToString());
                            sl.SetCellStyle(r, 5, style2);
                            sl.SetCellValue(r, 6, row.Cells[5].Value.ToString());
                            sl.SetCellStyle(r, 6, style2);
                            sl.SetCellValue(r, 7, row.Cells[6].Value.ToString());
                            sl.SetCellStyle(r, 7, style2);
                            sl.SetCellValue(r, 8, row.Cells[7].Value.ToString());
                            sl.SetCellStyle(r, 8, style2);
                            sl.SetCellValue(r, 9, row.Cells[8].Value.ToString());
                            sl.SetCellStyle(r, 9, style2);
                            sl.SetCellValue(r, 10, row.Cells[9].Value.ToString());
                            sl.SetCellStyle(r, 10, style2);
                            sl.SetCellValue(r, 11, row.Cells[10].Value.ToString());
                            sl.SetCellStyle(r, 11, style2);
                            sl.SetCellValue(r, 12, row.Cells[11].Value.ToString());
                            sl.SetCellStyle(r, 12, style2);


                            r++;
                        }
                        //tablaNomina.DataSource = nominas_DAO.getSigPagina();
                        actualizar();
                        sl.SaveAs(ruta + "\\Nominas_Empleado_" + nombre.Text + ".xlsx");
                        Mensajes.Info("El archivo de Excel se guardo satisfactoriamente");
                    }catch(Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        Mensajes.Error("Error al guardar archivo de excel");
                    }
                }
                else
                {
                    Mensajes.Error("Seleccione una carpeta");
                }
            }
        }

        private void editarNóminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tablaNomina.SelectedRows.Count == 1)
            {
                DataGridViewRow row = tablaNomina.SelectedRows[0];
                if ((string)row.Cells[11].Value != "P")
                {
                    Nomina nominas = new Nomina(
                    (int)row.Cells[1].Value,
                    (int)row.Cells[0].Value,
                    (string)row.Cells[2].Value,
                    Convert.ToDecimal(row.Cells[3].Value),
                    Convert.ToDecimal(row.Cells[4].Value),
                    Convert.ToDecimal(row.Cells[5].Value),
                    (int)row.Cells[6].Value,
                    (int)row.Cells[7].Value,
                    (string)row.Cells[8].Value,
                    (string)row.Cells[9].Value,
                    (string)row.Cells[10].Value,
                    Convert.ToChar(row.Cells[11].Value));
                    Nomina_editar ne = new Nomina_editar(nombre.Text, nominas, salarioE, salarioMin);
                    ne.ShowDialog();
                    actualizar();
                }
                else
                {
                    Mensajes.Error("La nómina ya ha sido pagada");
                }
            }
            else
            {
                Mensajes.Error("Seleccione una nómina");
            }
        }

    }
}
