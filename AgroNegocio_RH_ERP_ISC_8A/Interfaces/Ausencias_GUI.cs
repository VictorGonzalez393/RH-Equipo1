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
        public Ausencias_GUI(String em, int idEm)
        {
            InitializeComponent();
            idEmpleado = idEm;
            nombreEmpleadoPermiso = em;
            txtEmpleado.Text = em;
            try
            {
                au_dao = new Ausencias_justificadas_DAO();
                au_dao.table = "AusenciasJustificadas_Tabla";
                au_dao.order_by = "ID";
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
            SetVisibleCore(false);
            p.ShowDialog();
            this.Close();
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
            Ausencias_nuevo au = new Ausencias_nuevo(this.nombreEmpleadoPermiso, this.idEmpleado);
            this.SetVisibleCore(false);
            au.ShowDialog();
            this.SetVisibleCore(true);
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
