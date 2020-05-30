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
    public partial class Departamentos_GUI : Form
    {
        Departamentos_DAO depto_DAO;
        string aux1, aux2;

        public Departamentos_GUI()
        {
            InitializeComponent();
            try
            {
                depto_DAO = new Departamentos_DAO();
                depto_DAO.table = "Departamentos_Tabla";
                depto_DAO.order_by = "ID";
                depto_DAO.CalculaPaginas();
                if (depto_DAO.actual_page == 1 || depto_DAO.actual_page == 0)
                {
                    btn_anterior.Enabled = false;
                }
                else if (depto_DAO.actual_page == depto_DAO.pages)
                {
                    btn_siguiente.Enabled = false;
                }

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

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Departamentos_nuevo nuevo = new Departamentos_nuevo();
            nuevo.ShowDialog();
            actualizar();
        }

        private void actualizar()
        {
            btn_anterior.Enabled = false;
            btn_siguiente.Enabled = true;
            tabla_Deptos.DataSource = depto_DAO.actualizar();
            lbl_pagina.Text = aux1 + " " + depto_DAO.actual_page;
            lbl_total.Text = aux2 + " " + depto_DAO.pages;
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabla_Deptos.SelectedRows.Count != -1)
            {
                DataGridViewRow row = tabla_Deptos.SelectedRows[0];

                Departamento depto = new Departamento(
                    (int)row.Cells[0].Value,
                    (string)row.Cells[1].Value,
                    Convert.ToChar(row.Cells[2].Value)
                    );
                Departamentos_editar depto_editar = new Departamentos_editar(depto);
                this.SetVisibleCore(false);
                depto_editar.ShowDialog();
                this.SetVisibleCore(true);
                actualizar();
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Selecciona el departamento.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabla_Deptos.SelectedRows.Count != -1)
            {

                try
                {
                    DialogResult resultado = MessageBox.Show("¿Estás seguro que desea eliminar el Departamento?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        DataGridViewRow row = tabla_Deptos.SelectedRows[0];
                        int idDepto = (int)row.Cells[0].Value;
                        depto_DAO.eliminar(idDepto);
                        actualizar();
                    }
                }
                catch (Exception ex)
                {
                    Mensajes.Error("Error al intentar eliminar el departamento.");
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Selecciona el Deparatmento a eliminar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (buscarDeptoTxt.Text.Equals(" "))
            {
                DialogResult resultado = MessageBox.Show("No hay datos para buscar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                string consulta_wh = "nombre like '%'+'" + buscarDeptoTxt.Text + "'+'%'";
                tabla_Deptos.DataSource = depto_DAO.buscar(consulta_wh);

            }
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            btn_siguiente.Enabled = true;
            if (depto_DAO.actual_page > 1)
            {
                tabla_Deptos.DataSource = depto_DAO.getAnteriorPagina();
            }
            if (depto_DAO.actual_page == 1)
            {
                btn_anterior.Enabled = false;
            }
            lbl_pagina.Text = aux1 + " " + depto_DAO.actual_page;
            lbl_total.Text = aux2 + " " + depto_DAO.pages;
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            btn_anterior.Enabled = true;
            if (depto_DAO.actual_page < depto_DAO.pages)
            {
                tabla_Deptos.DataSource = depto_DAO.getSigPagina();
            }
            if (depto_DAO.actual_page == depto_DAO.pages)
            {
                btn_siguiente.Enabled = false;
            }
            lbl_pagina.Text = aux1 + " " + depto_DAO.actual_page;
            lbl_total.Text = aux2 + " " + depto_DAO.pages;
        }

        private void Departamentos_GUI_Load(object sender, EventArgs e)
        {
            try
            {
                tabla_Deptos.DataSource = depto_DAO.getSigPagina();
                aux1 = lbl_pagina.Text;
                aux2 = lbl_total.Text;
                lbl_pagina.Text = aux1 + " " + depto_DAO.actual_page;
                lbl_total.Text = aux2 + " " + depto_DAO.pages;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
