using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgroNegocio_RH_ERP_ISC_8A.Modelo;
using AgroNegocio_RH_ERP_ISC_8A.Datos;

namespace AgroNegocio_RH_ERP_ISC_8A.Interfaces
{
    public partial class Puestos_GUI : Form
    {
        Puestos_DAO puestos_DAO;
        string aux1, aux2;
        public Puestos_GUI()
        {
            InitializeComponent();
            try
            {
                puestos_DAO = new Puestos_DAO();
                puestos_DAO.table = "Puestos_Tabla";
                puestos_DAO.order_by = "ID";
                puestos_DAO.CalculaPaginas();
                if (puestos_DAO.actual_page == 1 || puestos_DAO.actual_page == 0)
                {
                    btn_anterior.Enabled = false;
                }
                else if (puestos_DAO.actual_page == puestos_DAO.pages)
                {
                    btn_siguiente.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Puestos_nuevo puestos_Nuevo = new Puestos_nuevo();
            puestos_Nuevo.ShowDialog();
            actualizar();
        }

        private void buscarPerTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Puestos_GUI_Load(object sender, EventArgs e)
        {
            try
            {
                tabla_Puestos.DataSource = puestos_DAO.getSigPagina();
                aux1 = lbl_pagina.Text;
                aux2 = lbl_total.Text;
                lbl_pagina.Text = aux1 + " " + puestos_DAO.actual_page;
                lbl_total.Text = aux2 + " " + puestos_DAO.pages;

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
           
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (buscarPerTxt.Text.Equals(""))
            {
                DialogResult resultado = MessageBox.Show("No hay datos para buscar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {
                    string consulta_wh = "Nombre like '%'+'" + buscarPerTxt.Text + "'+'%'";
                    tabla_Puestos.DataSource = puestos_DAO.buscar(consulta_wh);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR: " + ex.Message);
                    MessageBox.Show("Error en la busqueda");
                }

            }
        }

        private void tabla_Puestos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn i in tabla_Puestos.Columns)
            {
                i.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            tabla_Puestos.AutoResizeColumns();
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {

        }

        private void tabla_Puestos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {

                    DialogResult resultado = MessageBox.Show("¿Estás seguro que desea eliminar el puesto?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resultado == DialogResult.Yes)
                    {
                        DataGridViewRow renglon = tabla_Puestos.Rows[e.RowIndex];
                        int idPer = (int)renglon.Cells[0].Value;
                        puestos_DAO.eliminar(idPer);

                    }
                    actualizar();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar eliminar el puesto");
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Selecciona el puesto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {

        }

        private void lbl_pagina_Click(object sender, EventArgs e)
        {

        }

        private void btn_anterior_Click_1(object sender, EventArgs e)
        {

        }

        private void lbl_total_Click(object sender, EventArgs e)
        {

        }

        private void btn_siguiente_Click_1(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            Puestos_nuevo puestos_Nuevo = new Puestos_nuevo();
            puestos_Nuevo.ShowDialog();
            actualizar();
        }

        private void editarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (tabla_Puestos.SelectedRows.Count != 0)
            {
                DataGridViewRow row = tabla_Puestos.SelectedRows[0];


                Puesto puestos_editar = new Puesto(
                    (int)row.Cells[0].Value,
                    (string)row.Cells[1].Value,
                    Convert.ToDecimal(row.Cells[2].Value),
                    Convert.ToDecimal(row.Cells[3].Value),
                    Convert.ToChar(row.Cells[4].Value)
                    );
                Puestos_editar puestos_Editar = new Puestos_editar(puestos_editar);
                this.SetVisibleCore(false);
                puestos_Editar.ShowDialog();
                this.SetVisibleCore(true);
                actualizar();
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Selecciona el puesto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void eliminarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (tabla_Puestos.SelectedRows.Count != -1)
            {

                try
                {
                    DialogResult resultado = MessageBox.Show("¿Estás seguro que desea eliminar el puesto?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        DataGridViewRow row = tabla_Puestos.SelectedRows[0];
                        int idPuesto = (int)row.Cells[0].Value;
                        puestos_DAO.eliminar(idPuesto);

                    }
                    actualizar();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar eliminar el puesto");
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Selecciona el puesto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void inicioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void actualizar()
        {
            btn_anterior.Enabled = false;
            btn_siguiente.Enabled = true;
            tabla_Puestos.DataSource = puestos_DAO.actualizar();
            lbl_pagina.Text = aux1 + " " + puestos_DAO.actual_page;
            lbl_total.Text = aux2 + " " + puestos_DAO.pages;
        }
    }
}
   
