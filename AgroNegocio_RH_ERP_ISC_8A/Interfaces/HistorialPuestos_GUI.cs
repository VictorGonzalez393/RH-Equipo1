using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        HistorialesPuestos_DAO hist_dao;
        string aux1, aux2;
        public int idEmp { get; set; }
        public HistorialPuestos_GUI(int idEmp, string empleado)
        {
            InitializeComponent();
            nombre.Text = empleado;
            this.idEmp = idEmp;
            try
            {
                hist_dao = new HistorialesPuestos_DAO();
                hist_dao.table = "HistorialPuestos_Tabla";
                hist_dao.order_by = "ID";
                hist_dao.CalculaPaginas();
                if (hist_dao.actual_page == 1 || hist_dao.actual_page == 0)
                {
                    btn_anterior.Enabled = false;
                }
                else if (hist_dao.actual_page == hist_dao.pages)
                {
                    btn_siguiente.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void actualizar()
        {
            btn_anterior.Enabled = false;
            btn_siguiente.Enabled = true;
            tablaHistorialpuestos.DataSource = hist_dao.actualizar();
            lbl_pagina.Text = aux1 + " " + hist_dao.actual_page;
            lbl_total.Text = aux2 + " " + hist_dao.pages;
        }

        private void btn_buscarEmpleado_Click(object sender, EventArgs e)
        {
            if (nombre.Text.Equals(" "))
            {
                DialogResult resultado = MessageBox.Show("No hay datos para buscar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                string consulta_wh = "nombre like '%'+'" + nombre.Text + "'+'%'";
                tablaHistorialpuestos.DataSource = hist_dao.buscar(consulta_wh);

            }
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            btn_siguiente.Enabled = true;
            if (hist_dao.actual_page > 1)
            {
                tablaHistorialpuestos.DataSource = hist_dao.getAnteriorPagina();
            }
            if (hist_dao.actual_page == 1)
            {
                btn_anterior.Enabled = false;
            }
            lbl_pagina.Text = aux1 + " " + hist_dao.actual_page;
            lbl_total.Text = aux2 + " " + hist_dao.pages;
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            btn_anterior.Enabled = true;
            if (hist_dao.actual_page < hist_dao.pages)
            {
                tablaHistorialpuestos.DataSource = hist_dao.getSigPagina();
            }
            if (hist_dao.actual_page == hist_dao.pages)
            {
                btn_siguiente.Enabled = false;
            }
            lbl_pagina.Text = aux1 + " " + hist_dao.actual_page;
            lbl_total.Text = aux2 + " " + hist_dao.pages;
        }

        private void HistorialPuestos_GUI_Load(object sender, EventArgs e)
        {
            try
            {
                tablaHistorialpuestos.DataSource = hist_dao.getSigPagina();
                aux1 = lbl_pagina.Text;
                aux2 = lbl_total.Text;
                lbl_pagina.Text = aux1 + " " + hist_dao.actual_page;
                lbl_total.Text = aux2 + " " + hist_dao.pages;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tablaHistorialpuestos.SelectedRows.Count != -1)
            {
                DataGridViewRow row = tablaHistorialpuestos.SelectedRows[0];

                HistorialPuesto historial_editar = new HistorialPuesto(
                    (int)row.Cells[0].Value,
                    hist_dao.getidPuesto((string)row.Cells[1].Value),
                    hist_dao.getidDepartamento((string)row.Cells[2].Value),
                    (string)row.Cells[3].Value,
                    (string)row.Cells[4].Value,
                    (double)row.Cells[5].Value
                    );
                HistorialPuestos_Editar historial_Editar = new HistorialPuestos_Editar(historial_editar);
                this.SetVisibleCore(false);
                historial_Editar.ShowDialog();
                this.SetVisibleCore(true);
                actualizar();

            }
            else
            {
                DialogResult resultado = MessageBox.Show("Selecciona el Historial", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tablaHistorialpuestos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
