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

namespace AgroNegocio_RH_ERP_ISC_8A.Interfaces
{
    public partial class Ausencias_GUI : Form
    {
        String nombreEmpleadoPermiso="";
        int idEmpleado=0;
        Ausencias_justificadas_DAO au_dao;
        string aux1, aux2;
        int dV, dP;
        int idDepartamento;
        public Ausencias_GUI(String em, int idEm, int dVa,int dPe,int idD)
        {
            InitializeComponent();
            idDepartamento = idD;
            idEmpleado = idEm;
            nombreEmpleadoPermiso = em;
            txtEmpleado.Text = em;
            
            dV = dVa;
            dP = dPe;
            try
            {
                au_dao = new Ausencias_justificadas_DAO();
                au_dao.table = "AusenciasJustificadas_Tabla";
                au_dao.order_by = "ID";
                au_dao.where = "ID_EmpleadoS=" + idEm;
                au_dao.CalculaPaginas();
                if (au_dao.actual_page == 1 || au_dao.actual_page == 0)
                {
                    btn_anterior.Enabled = false;
                }
                else if (au_dao.actual_page == au_dao.pages)
                {
                    btn_siguiente.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                Mensajes.Error("Error al cargar la interfaz");
                Console.WriteLine("Error" + ex.Message);
            }
            
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Principal p = new Principal();
            this.SetVisibleCore(false);
            p.ShowDialog();
            
        }

        private void Ausencias_GUI_Load(object sender, EventArgs e)
        {
            try
            {
                
                tablaAusencias.DataSource = au_dao.getSigPagina();
                aux1 = lbl_pagina.Text;
                aux2 = lbl_total.Text;
                lbl_pagina.Text = aux1 + " " + au_dao.actual_page;
                lbl_total.Text = aux2 + " " + au_dao.pages;
            }
            catch(Exception ex){
                Mensajes.Error("Error al cargar a la Interfaz");
                Console.WriteLine("Error: "+ex.Message);
            }
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            btn_anterior.Enabled = true;
            if (au_dao.actual_page < au_dao.pages)
            {
                tablaAusencias.DataSource = au_dao.getSigPagina();
            }
            if (au_dao.actual_page == au_dao.pages)
            {
                btn_siguiente.Enabled = false;
            }
            lbl_pagina.Text = aux1 + " " + au_dao.actual_page;
            lbl_total.Text = aux2 + " " + au_dao.pages;
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            btn_siguiente.Enabled = true;
            if (au_dao.actual_page > 1)
            {
                tablaAusencias.DataSource = au_dao.getAnteriorPagina();
            }
            if (au_dao.actual_page == 1)
            {
                btn_anterior.Enabled = false;
            }
            lbl_pagina.Text = aux1 + " " + au_dao.actual_page;
            lbl_total.Text = aux2 + " " + au_dao.pages;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string consulta_where = "fechaSolicitud like '%'+'" + buscarAutxt.Text + "'+ '%'";
            tablaAusencias.DataSource = au_dao.buscar(consulta_where);
        }

        private void atrásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ausencias_nuevo au = new Ausencias_nuevo(this.nombreEmpleadoPermiso, this.idEmpleado,idDepartamento);
            this.SetVisibleCore(false);
            au.ShowDialog();
            this.SetVisibleCore(true);
            actualizar();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tablaAusencias.SelectedRows.Count != -1)
            {
                try
                {
                    DialogResult resultado = MessageBox.Show("¿Estás seguro que desea eliminar la ausencia?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        DataGridViewRow row = tablaAusencias.SelectedRows[0];
                        
                        if ((string) row.Cells[11].Value != "R" && (string)row.Cells[11].Value != "V")
                        {
                            int idAu = (int)row.Cells[0].Value;
                            au_dao.eliminar(idAu);
                            Mensajes.Info("La ausencia se elimino correctamente");
                            
                        }
                        else
                        {
                            if ((string)row.Cells[11].Value == "V")
                            {
                                Mensajes.Error("La ausencia se encuentra aprobada");
                            }
                            else
                            {
                                Mensajes.Error("La ausencia se encuentra rechazada");
                            }
                        }
                    }
                    actualizar();

                }
                catch (Exception ex)
                {
                    Mensajes.Error("Error al intentar eliminar la ausencia");
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            else
            {
                Mensajes.Error("Selecciona la ausencia");
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tablaAusencias.SelectedRows.Count > 0)
            {
                DataGridViewRow row = tablaAusencias.SelectedRows[0];
               
                if ((string)row.Cells[11].Value != "R" && (string)row.Cells[11].Value != "V")
                {
                    Ausencia_justificada aus = new Ausencia_justificada(
                    (int)row.Cells[0].Value,
                    (string)row.Cells[1].Value,
                    (string)row.Cells[2].Value,
                    (string)row.Cells[3].Value,
                    Convert.ToChar(row.Cells[4].Value),
                    (string)row.Cells[6].Value,
                    (int)row.Cells[8].Value,
                    (string)row.Cells[9].Value,
                    (int)row.Cells[5].Value,
                    Convert.ToChar(row.Cells[11].Value));

                    Ausencias_editar ae = new Ausencias_editar(aus, idEmpleado, txtEmpleado.Text,idDepartamento);
                    SetVisibleCore(false);
                    ae.ShowDialog();
                    SetVisibleCore(true);
                    actualizar();
                }
                else
                {
                    if ((string)row.Cells[11].Value == "V")
                    {
                        Mensajes.Error("La ausencia se encuentra aprobada");
                    }
                    else
                    {
                        Mensajes.Error("La ausencia se encuentra rechazada");
                    }
                }
            }
            else
            {
                Mensajes.Error("Selecciona una ciudad");
            }
        }

        private void autorizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tablaAusencias.SelectedRows.Count != -1)
            {
                DateTime fechaI, fechaF;
                TimeSpan tS;
                int dias;
                try
                {
                    DataGridViewRow row = tablaAusencias.SelectedRows[0];
                    fechaI = Convert.ToDateTime(row.Cells[2].Value);
                    fechaF = Convert.ToDateTime(row.Cells[3].Value);
                    tS = fechaF - fechaI;
                    dias = tS.Days;
                    if ((string)row.Cells[11].Value != "R" && (string)row.Cells[11].Value != "V")
                    {
                        int idAu = (int)row.Cells[0].Value;
                        if ((string)row.Cells[4].Value == "V")
                        {
                            if (dias <= dV)
                            {
                                au_dao.estatus(idAu, 'V');
                                Mensajes.Info("La vacaciones se autorizon correctamente");
                            }
                            else
                            {
                                au_dao.estatus(idAu, 'R');
                                Mensajes.Info("Las vacaciones se rechazon ya que excede los días de vacaciones permitidos");
                            }

                        }
                        else if ((string)row.Cells[4].Value == "P")
                        {
                            if (dias <= dP)
                            {
                                au_dao.estatus(idAu, 'V');
                                Mensajes.Info("El permiso se autorizo correctamente");
                            }
                            else
                            {
                                au_dao.estatus(idAu, 'R');
                                Mensajes.Info("El permiso se rechazo ya que excede los días de vacaciones permitidos");
                            }
                        }
                    }
                    else
                    {
                        if((string)row.Cells[11].Value == "V")
                        {
                            Mensajes.Error("La ausencia se encuentra aprobada");
                        }
                        else
                        {
                            Mensajes.Error("La ausencia se encuentra rechazada");
                        }
                    }
                    actualizar();

                }
                catch (Exception ex)
                {
                    Mensajes.Error("Error al intentar autorizar la ausencia");
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            else
            {
                Mensajes.Error("Selecciona la ausencia");
            }
        }

        private void actualizar()
        {
            btn_anterior.Enabled = false;
            btn_siguiente.Enabled = true;
            tablaAusencias.DataSource = au_dao.actualizar();
            lbl_pagina.Text = aux1 + " " + au_dao.actual_page;
            lbl_total.Text = aux2 + " " + au_dao.pages;
        }

    }
}
