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
    public partial class HistorialPuestos_GUI : Form
    {
        HistorialPuestos_DAO historialdao;
        string aux1, aux2;

        public HistorialPuestos_GUI()
        {
            InitializeComponent();
            try
            {
                historialdao = new HistorialPuestos_DAO();
                historialdao.table = "HistorialPuestos_Tabla";
                historialdao.order_by = "Nombre";
                historialdao.CalculaPaginas();
                if (historialdao.actual_page == 1 || historialdao.actual_page == 0)
                {
                    btn_anterior.Enabled = false;
                }
                else if (historialdao.actual_page == historialdao.pages)
                {
                    btn_siguiente.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void editarCiudadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabla_historial.SelectedRows.Count > 0)
            {
                DataGridViewRow row = tabla_historial.SelectedRows[0];

                HistorialPuesto historial_editar = new HistorialPuesto(
                    historialdao.getidEmpleado((string)row.Cells[1].Value),
                    historialdao.getidPuesto((string)row.Cells[2].Value),
                    historialdao.getidDepartamento((string)row.Cells[3].Value),
                    (DateTime)row.Cells[4].Value,
                    (string)row.Cells[5].Value,
                    (double)row.Cells[6].Value);

                HistorialPuestos_editar historial_EditarGUI = new HistorialPuestos_editar(historial_editar);
                historial_EditarGUI.ShowDialog();
                actualizar();

            }
            else
            {
                MessageBox.Show("Selecciona una ciudad");
            }
        }

        private void HistorialPuestos_GUI_Load(object sender, EventArgs e)
        {
            try
            {
                tabla_historial.DataSource = historialdao.getSigPagina();
                aux1 = lbl_pagina.Text;
                aux2 = lbl_total.Text;
                lbl_pagina.Text = aux1 + " " + historialdao.actual_page;
                lbl_total.Text = aux2 + " " + historialdao.pages;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            btn_anterior.Enabled = true;
            if (historialdao.actual_page < historialdao.pages)
            {
                tabla_historial.DataSource = historialdao.getSigPagina();
            }
            if (historialdao.actual_page == historialdao.pages)
            {
                btn_siguiente.Enabled = false;
            }
            lbl_pagina.Text = aux1 + " " + historialdao.actual_page;
            lbl_total.Text = aux2 + " " + historialdao.pages;
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            btn_siguiente.Enabled = true;
            if (historialdao.actual_page > 1)
            {
                tabla_historial.DataSource = historialdao.getAnteriorPagina();
            }
            if (historialdao.actual_page == 1)
            {
                btn_anterior.Enabled = false;
            }
            lbl_pagina.Text = aux1 + " " + historialdao.actual_page;
            lbl_total.Text = aux2 + " " + historialdao.pages;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string consulta_where = "nombre like '%'+'" + buscar_historial.Text + "'+ '%'";
            tabla_historial.DataSource = historialdao.buscar(consulta_where);
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void agregarCiudadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistorialPuestos_nuevo historial = new HistorialPuestos_nuevo();
            this.SetVisibleCore(false);
            historial.ShowDialog();
            this.SetVisibleCore(true);
        }

        private void actualizar()
        {
            btn_anterior.Enabled = false;
            btn_siguiente.Enabled = true;
            tabla_historial.DataSource = historialdao.actualizar();
            lbl_pagina.Text = aux1 + " " + historialdao.actual_page;
            lbl_total.Text = aux2 + " " + historialdao.pages;
        }


    }
    
}
