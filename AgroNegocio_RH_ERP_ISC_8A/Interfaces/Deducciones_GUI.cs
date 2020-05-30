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
    public partial class Deducciones_GUI : Form
    {
        Deducciones_DAO deducciones_DAO;
        string aux1, aux2;
        public Deducciones_GUI()
        {
            InitializeComponent();
            try
            {
                deducciones_DAO = new Deducciones_DAO();
                deducciones_DAO.table = "Deducciones_Tabla";
                deducciones_DAO.order_by = "ID";
                deducciones_DAO.CalculaPaginas();
                if (deducciones_DAO.actual_page == 1 || deducciones_DAO.actual_page == 0)
                {
                    btn_anterior.Enabled = false;
                }
                else if (deducciones_DAO.actual_page == deducciones_DAO.pages)
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
            Deducciones_nuevo deducciones_Nuevo = new Deducciones_nuevo();
            deducciones_Nuevo.ShowDialog();
            actualizar();
            
        }

        private void Deducciones_GUI_Load(object sender, EventArgs e)
        {
            

        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tabla_Deducciones.SelectedRows.Count != -1)
            {
                DataGridViewRow row = Tabla_Deducciones.SelectedRows[0];

                Deduccion deduccion_editar = new Deduccion(
                    (int)row.Cells[0].Value,
                    (string)row.Cells[1].Value,
                    (string)row.Cells[2].Value,
                    (double)row.Cells[3].Value,
                    Convert.ToChar(row.Cells[4].Value)
                    );
                Deducciones_editar deducciones_Editar = new Deducciones_editar(deduccion_editar);
                this.SetVisibleCore(false);
                deducciones_Editar.ShowDialog();
                this.SetVisibleCore(true);
                actualizar();
                
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Selecciona la deducción", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tabla_Deducciones.SelectedRows.Count != -1)
            {

                try
                {
                    DialogResult resultado = MessageBox.Show("¿Estás seguro que desea eliminar la deducción?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        DataGridViewRow row = Tabla_Deducciones.SelectedRows[0];
                        int idDeduccion = (int)row.Cells[0].Value;
                        deducciones_DAO.eliminar(idDeduccion);
                        actualizar();
                        
                    }
                }
                catch (Exception ex)
                {
                    Mensajes.Error("Error al intentar eliminar la deducción");
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Selecciona la deducción", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (buscarDedTxt.Text.Equals(""))
            {
                DialogResult resultado = MessageBox.Show("No hay datos para buscar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {
                    string consulta_wh = "nombre like '%'+'" + buscarDedTxt.Text + "'+'%'";
                    Tabla_Deducciones.DataSource = deducciones_DAO.buscar(consulta_wh);
                }
                catch(Exception ex)
                {
                    Console.WriteLine("ERROR: " + ex.Message);
                    Mensajes.Error("Error en la busqueda");
                }
                

            }
        }

        private void Deducciones_GUI_Load_1(object sender, EventArgs e)
        {
            try
            {
                Tabla_Deducciones.DataSource = deducciones_DAO.getSigPagina();
                aux1 = lbl_pagina.Text;
                aux2 = lbl_total.Text;
                lbl_pagina.Text = aux1 + " " + deducciones_DAO.actual_page;
                lbl_total.Text = aux2 + " " + deducciones_DAO.pages;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void nuevoToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            Deducciones_nuevo deducciones = new Deducciones_nuevo();
            deducciones.ShowDialog();
            actualizar();
        }

        private void editarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (Tabla_Deducciones.SelectedRows.Count != -1)
            {
                DataGridViewRow row = Tabla_Deducciones.SelectedRows[0];

                Deduccion deduccion_editar = new Deduccion(
                    (int)row.Cells[0].Value,
                    (string)row.Cells[1].Value,
                    (string)row.Cells[2].Value,
                    (double)row.Cells[3].Value,
                    Convert.ToChar(row.Cells[4].Value)
                    );
                Deducciones_editar deducciones_Editar = new Deducciones_editar(deduccion_editar);
                this.SetVisibleCore(false);
                deducciones_Editar.ShowDialog();
                this.SetVisibleCore(true);
                actualizar();
                
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Selecciona la deducción", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void eliminarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (Tabla_Deducciones.SelectedRows.Count != -1)
            {

                try
                {
                    DialogResult resultado = MessageBox.Show("¿Estás seguro que desea eliminar la deducción?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        DataGridViewRow row = Tabla_Deducciones.SelectedRows[0];
                        int idDeduccion = (int)row.Cells[0].Value;
                        deducciones_DAO.eliminar(idDeduccion);
                        actualizar();
                    }
                }
                catch (Exception ex)
                {
                    Mensajes.Error("Error al intentar eliminar la deducción");
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Selecciona la deducción", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (deducciones_DAO.actual_page > 1)
            {
                Tabla_Deducciones.DataSource = deducciones_DAO.getAnteriorPagina();
            }
            if (deducciones_DAO.actual_page == 1)
            {
                btn_anterior.Enabled = false;
            }
            lbl_pagina.Text = aux1 + " " + deducciones_DAO.actual_page;
            lbl_total.Text = aux2 + " " + deducciones_DAO.pages;
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            btn_anterior.Enabled = true;
            if (deducciones_DAO.actual_page < deducciones_DAO.pages)
            {
                Tabla_Deducciones.DataSource = deducciones_DAO.getSigPagina();
            }
            if (deducciones_DAO.actual_page == deducciones_DAO.pages)
            {
                btn_siguiente.Enabled = false;
            }
            lbl_pagina.Text = aux1 + " " + deducciones_DAO.actual_page;
            lbl_total.Text = aux2 + " " + deducciones_DAO.pages;
        }

        private void Tabla_Deducciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {

                    DialogResult resultado = MessageBox.Show("¿Estás seguro que desea eliminar la deducción?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resultado == DialogResult.Yes)
                    {
                        DataGridViewRow renglon = Tabla_Deducciones.Rows[e.RowIndex];
                        int idPer = (int)renglon.Cells[0].Value;
                        deducciones_DAO.eliminar(idPer);
                        
                    }
                    actualizar();
                }
                catch (Exception ex)
                {
                   Mensajes.Error("Error al intentar eliminar la deducción.");
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Selecciona la deducción", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void actualizar()
        {
            btn_anterior.Enabled = false;
            btn_siguiente.Enabled = true;
            Tabla_Deducciones.DataSource = deducciones_DAO.actualizar();
            lbl_pagina.Text = aux1 + " " + deducciones_DAO.actual_page;
            lbl_total.Text = aux2 + " " + deducciones_DAO.pages;
        }
    }
}
