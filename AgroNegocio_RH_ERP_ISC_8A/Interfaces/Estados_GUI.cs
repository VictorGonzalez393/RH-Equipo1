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
    public partial class Estados_GUI : Form
    {
        Estados_DAO estados_DAO;
        string aux1, aux2;
        public Estados_GUI()
        {
            InitializeComponent();
            try
            {
                estados_DAO = new Estados_DAO();
                estados_DAO.table = "Estados_Tabla";
                estados_DAO.order_by = "ID";
                estados_DAO.CalculaPaginas();
                if (estados_DAO.actual_page == 1 || estados_DAO.actual_page == 0)
                {
                    btn_anterior.Enabled = false;
                }
                else if (estados_DAO.actual_page == estados_DAO.pages)
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
            Estados_nuevo estados_Nuevo = new Estados_nuevo();
            estados_Nuevo.ShowDialog();
            actualizar();
            
        }

        private void Estados_GUI_Load(object sender, EventArgs e)
        {
            try
            {
                tabla_Estados.DataSource = estados_DAO.getSigPagina();
                aux1 = lbl_pagina.Text;
                aux2 = lbl_total.Text;
                lbl_pagina.Text = aux1 + " " + estados_DAO.actual_page;
                lbl_total.Text = aux2 + " " + estados_DAO.pages;

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
            if (tabla_Estados.SelectedRows.Count != -1)
            {
                DataGridViewRow row = tabla_Estados.SelectedRows[0];

                Estado estado_editar = new Estado(
                    (int)row.Cells[0].Value,
                    (string)row.Cells[1].Value,
                    (string)row.Cells[2].Value,
                    Convert.ToChar(row.Cells[3].Value)
                    );
                Estados_editar estados_Editar = new Estados_editar(estado_editar);
                this.SetVisibleCore(false);
                estados_Editar.ShowDialog();
                this.SetVisibleCore(true);
                actualizar();
                
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Selecciona el estado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabla_Estados.SelectedRows.Count != -1)
            {

                try
                {
                    DialogResult resultado = MessageBox.Show("¿Estás seguro que desea eliminar el estado?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        DataGridViewRow row = tabla_Estados.SelectedRows[0];
                        int idEstado = (int)row.Cells[0].Value;
                        estados_DAO.eliminar(idEstado);
                        actualizar();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al intentar eliminar el estado");
                }
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Selecciona el Estado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (buscarEstadoTxt.Text.Equals(" "))
            {
                DialogResult resultado = MessageBox.Show("No hay datos para buscar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                string consulta_wh = "nombre like '%'+'"+buscarEstadoTxt.Text+"'+'%'";
                tabla_Estados.DataSource = estados_DAO.buscar(consulta_wh);
            }
        }

        private void tabla_Estados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           /* if (e.RowIndex != -1)
            {
                try
                {

                    DialogResult resultado = MessageBox.Show("¿Estás seguro que desea eliminar el estadp?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resultado == DialogResult.Yes)
                    {
                        DataGridViewRow renglon = tabla_Estados.Rows[e.RowIndex];
                        int idE = (int)renglon.Cells[0].Value;
                        estados_DAO.eliminar(idE);
                        actualizar();
                        
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar eliminar el estado");
                }
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Selecciona el estado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            btn_siguiente.Enabled = true;
            if (estados_DAO.actual_page > 1)
            {
                tabla_Estados.DataSource = estados_DAO.getAnteriorPagina();
            }
            if (estados_DAO.actual_page == 1)
            {
                btn_anterior.Enabled = false;
            }
            lbl_pagina.Text = aux1 + " " + estados_DAO.actual_page;
            lbl_total.Text = aux2 + " " + estados_DAO.pages;
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            btn_anterior.Enabled = true;
            if (estados_DAO.actual_page < estados_DAO.pages)
            {
                tabla_Estados.DataSource = estados_DAO.getSigPagina();
            }
            if (estados_DAO.actual_page == estados_DAO.pages)
            {
                btn_siguiente.Enabled = false;
            }
            lbl_pagina.Text = aux1 + " " + estados_DAO.actual_page;
            lbl_total.Text = aux2 + " " + estados_DAO.pages;
        }

        private void actualizar()
        {
            btn_anterior.Enabled = false;
            btn_siguiente.Enabled = true;
            tabla_Estados.DataSource = estados_DAO.actualizar();
            lbl_pagina.Text = aux1 + " " + estados_DAO.actual_page;
            lbl_total.Text = aux2 + " " + estados_DAO.pages;
        }

    }
}
