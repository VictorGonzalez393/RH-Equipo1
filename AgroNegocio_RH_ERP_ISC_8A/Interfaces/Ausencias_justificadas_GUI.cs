using AgroNegocio_RH_ERP_ISC_8A.Datos;
using AgroNegocio_RH_ERP_ISC_8A.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroNegocio_RH_ERP_ISC_8A.Interfaces
{
    public partial class Ausencias_justificadas_GUI : Form
    {
        Ausencias_justificadas_DAO ausencias_Justificadas_DAO;
        string aux1, aux2;
        public Ausencias_justificadas_GUI()
        {
            InitializeComponent();
            try
            {
                ausencias_Justificadas_DAO = new Ausencias_justificadas_DAO();
                ausencias_Justificadas_DAO.table = "AusenciasJustificadas_Tabla";
                ausencias_Justificadas_DAO.order_by = "ID";
                ausencias_Justificadas_DAO.CalculaPaginas();
                if (ausencias_Justificadas_DAO.actual_page == 1 || ausencias_Justificadas_DAO.actual_page == 0)
                {
                    btn_anterior.Enabled = false;
                }
                else if (ausencias_Justificadas_DAO.actual_page == ausencias_Justificadas_DAO.pages)
                {
                    btn_siguiente.Enabled = false;
                }
                aux1 = lbl_pagina.Text;
                aux2 = lbl_total.Text;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
    }
        private void nuevoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Ausencias_justificadas_nuevo ausencias_Justificadas_Nuevo = new Ausencias_justificadas_nuevo();
            ausencias_Justificadas_Nuevo.ShowDialog();
            actualizar();

        }
        private void Ausencias_justificadas_GUI_Load(object sender, EventArgs e)
        {


        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabla_Justificaciones.SelectedRows.Count != -1)
            {
                DataGridViewRow row = tabla_Justificaciones.SelectedRows[0];

                Ausencia_justificada ausencia_Justificada_editar = new Ausencia_justificada(
                    (int)row.Cells[0].Value,
                    (string)row.Cells[1].Value,
                    (string)row.Cells[2].Value,
                    (double)row.Cells[3].Value,
                    Convert.ToChar(row.Cells[4].Value)
                    );
                Ausencias_justificadas_editar ausencias_Justificadas_Editar = new Ausencias_justificadas_editar(ausencia_Justificada_editar);
                this.SetVisibleCore(false);
                ausencias_Justificadas_Editar.ShowDialog();
                this.SetVisibleCore(true);
                actualizar();

            }
            else
            {
                DialogResult resultado = MessageBox.Show("Selecciona la Ausencia", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabla_Justificaciones.SelectedRows.Count != -1)
            {

                try
                {
                    DialogResult resultado = MessageBox.Show("¿Estás seguro que desea eliminar la Justificacion?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        DataGridViewRow row = tabla_Justificaciones.SelectedRows[0];
                        int idAusenciaJustificada = (int)row.Cells[0].Value;
                        Ausencias_justificadas_DAO.eliminar(idAusenciaJustificada);
                        actualizar();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar eliminar la justificacion");
                }
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Selecciona la justificacion", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (buscarJustificacionesTxt.Text.Equals(""))
            {
                DialogResult resultado = MessageBox.Show("No hay datos para buscar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {
                    string consulta_wh = "nombre like '%'+'" + buscarJustificacionesTxt.Text + "'+'%'";
                    tabla_Justificaciones.DataSource = ausencias_Justificadas_DAO.buscar(consulta_wh);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR: " + ex.Message);
                    MessageBox.Show("Error en la busqueda");
                }


            }
        }
        private void Ausencias_justificadas_GUI_Load_1(object sender, EventArgs e)
        {
            try
            {
                tabla_Justificaciones.DataSource = ausencias_Justificadas_DAO.getSigPagina();
                aux1 = lbl_pagina.Text;
                aux2 = lbl_total.Text;
                lbl_pagina.Text = aux1 + " " + ausencias_Justificadas_DAO.actual_page;
                lbl_total.Text = aux2 + " " + ausencias_Justificadas_DAO.pages;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void nuevoToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            Ausencias_justificadas_nuevo ausencias_Justificadas = new Ausencias_justificadas_nuevo();
            ausencias_Justificadas.ShowDialog();
            actualizar();
        }

        private void editarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (tabla_Justificaciones.SelectedRows.Count != -1)
            {
                DataGridViewRow row = tabla_Justificaciones.SelectedRows[0];

                Ausencia_justificada ausencia_Justificada_editar = new Ausencia_justificada(
                    (int)row.Cells[0].Value,
                    (string)row.Cells[1].Value,
                    (string)row.Cells[2].Value,
                    (double)row.Cells[3].Value,
                    Convert.ToChar(row.Cells[4].Value)
                    );
                Ausencias_justificadas_editar ausencias_Justificadas_Editar = new Ausencias_justificadas_editar(ausencia_Justificada_editar);
                this.SetVisibleCore(false);
                ausencias_Justificadas_Editar.ShowDialog();
                this.SetVisibleCore(true);
                actualizar();

            }
            else
            {
                DialogResult resultado = MessageBox.Show("Selecciona la justificacion", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void eliminarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (tabla_Justificaciones.SelectedRows.Count != -1)
            {

                try
                {
                    DialogResult resultado = MessageBox.Show("¿Estás seguro que desea eliminar la justificacion?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        DataGridViewRow row = tabla_Justificaciones.SelectedRows[0];
                        int idAusenciaJustificacion = (int)row.Cells[0].Value;
                        ausencias_Justificadas_DAO.eliminar(idAusenciaJustificacion);
                        actualizar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar eliminar la Justificacion");
                }
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Selecciona la justificacion", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lbl_pagina_Click(object sender, EventArgs e)
        {

        }

        private void lbl_total_Click(object sender, EventArgs e)
        {

        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            btn_siguiente.Enabled = true;
            if (ausencias_Justificadas_DAO.actual_page > 1)
            {
                tabla_Justificaciones.DataSource = ausencias_Justificadas_DAO.getAnteriorPagina();
            }
            if (ausencias_Justificadas_DAO.actual_page == 1)
            {
                btn_anterior.Enabled = false;
            }
            lbl_pagina.Text = aux1 + " " + ausencias_Justificadas_DAO.actual_page;
            lbl_total.Text = aux2 + " " + ausencias_Justificadas_DAO.pages;
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            btn_anterior.Enabled = true;
            if (ausencias_Justificadas_DAO.actual_page < ausencias_Justificadas_DAO.pages)
            {
                tabla_Justificaciones.DataSource = ausencias_Justificadas_DAO.getSigPagina();
            }
            if (ausencias_Justificadas_DAO.actual_page == ausencias_Justificadas_DAO.pages)
            {
                btn_siguiente.Enabled = false;
            }
            lbl_pagina.Text = aux1 + " " + ausencias_Justificadas_DAO.actual_page;
            lbl_total.Text = aux2 + " " + ausencias_Justificadas_DAO.pages;
        }

        private void tabla_Justificaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {

                    DialogResult resultado = MessageBox.Show("¿Estás seguro que desea eliminar la justificacion?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resultado == DialogResult.Yes)
                    {
                        DataGridViewRow renglon = tabla_Justificaciones.Rows[e.RowIndex];
                        int idAusenciaJustificada = (int)renglon.Cells[0].Value;
                        ausencias_Justificadas_DAO.eliminar(idAusenciaJustificada);

                    }
                    actualizar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar eliminar la justificacion.");
                }
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Selecciona la justificacion", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void actualizar()
        {
            btn_anterior.Enabled = false;
            btn_siguiente.Enabled = true;
            Tabla_Deducciones.DataSource = ausencias_Justificadas_DAO.actualizar();
            lbl_pagina.Text = aux1 + " " + ausencias_Justificadas_DAO.actual_page;
            lbl_total.Text = aux2 + " " + ausencias_Justificadas_DAO.pages;
        }

    }
}
