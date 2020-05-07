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
    public partial class NominasPercepciones_GUI : Form
    {
        NominasPercepciones_DAO nominaspercepciones_DAO;
        string aux1, aux2;

       
        public NominasPercepciones_GUI()
        {
            InitializeComponent();
            try
            {
                nominaspercepciones_DAO = new NominasPercepciones_DAO();
                nominaspercepciones_DAO.table = "tabla_nominasp";
                nominaspercepciones_DAO.order_by = "ID";
                nominaspercepciones_DAO.CalculaPaginas();
                if (nominaspercepciones_DAO.actual_page == 1 || nominaspercepciones_DAO.actual_page == 0)
                {
                    btn_anterior.Enabled = false;
                }
                else if (nominaspercepciones_DAO.actual_page == nominaspercepciones_DAO.pages)
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

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabla_nominasp.SelectedRows.Count != -1)
            {

                try
                {
                    DialogResult resultado = MessageBox.Show("¿Estás seguro que desea eliminar la percepción?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        DataGridViewRow row = tabla_nominasp.SelectedRows[0];
                        int idPercepcion = (int)row.Cells[0].Value;
                        nominaspercepciones_DAO.eliminar(idPercepcion);

                    }
                    actualizar();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar eliminar la percepción");
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Selecciona la percepción", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (buscar_nominasp.Text.Equals(""))
            {
                DialogResult resultado = MessageBox.Show("No hay datos para buscar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {
                    string consulta_wh = "Nombre like '%'+'" + buscar_nominasp.Text + "'+'%'";
                    tabla_nominasp.DataSource = nominaspercepciones_DAO.buscar(consulta_wh);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR: " + ex.Message);
                    MessageBox.Show("Error en la busqueda");
                }
            }
        }

        private void tabla_nominasp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {

                    DialogResult resultado = MessageBox.Show("¿Estás seguro que desea eliminar la Percepción?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resultado == DialogResult.Yes)
                    {
                        DataGridViewRow renglon = tabla_nominasp.Rows[e.RowIndex];
                        int idPer = (int)renglon.Cells[0].Value;
                        nominaspercepciones_DAO.eliminar(idPer);

                    }
                    actualizar();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar eliminar la percepción");
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Selecciona el dato a eliminar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tabla_nominasp_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn i in tabla_nominasp.Columns)
            {
                i.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            tabla_nominasp.AutoResizeColumns();
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            btn_anterior.Enabled = true;
            if (nominaspercepciones_DAO.actual_page < nominaspercepciones_DAO.pages)
            {
                tabla_nominasp.DataSource = nominaspercepciones_DAO.getSigPagina();
            }
            if (nominaspercepciones_DAO.actual_page == nominaspercepciones_DAO.pages)
            {
                btn_siguiente.Enabled = false;
            }
            lbl_pagina.Text = aux1 + " " + nominaspercepciones_DAO.actual_page;
            lbl_total.Text = aux2 + " " + nominaspercepciones_DAO.pages;
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            btn_siguiente.Enabled = true;
            if (nominaspercepciones_DAO.actual_page > 1)
            {
                tabla_nominasp.DataSource = nominaspercepciones_DAO.getAnteriorPagina();
            }
            if (nominaspercepciones_DAO.actual_page == 1)
            {
                btn_anterior.Enabled = false;
            }
            lbl_pagina.Text = aux1 + " " + nominaspercepciones_DAO.actual_page;
            lbl_total.Text = aux2 + " " + nominaspercepciones_DAO.pages;
        }

        private void NominasPercepciones_GUI_Load(object sender, EventArgs e)
        {
            try
            {
                tabla_nominasp.DataSource = nominaspercepciones_DAO.getSigPagina();
                aux1 = lbl_pagina.Text;
                aux2 = lbl_total.Text;
                lbl_pagina.Text = aux1 + " " + nominaspercepciones_DAO.actual_page;
                lbl_total.Text = aux2 + " " + nominaspercepciones_DAO.pages;

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
            tabla_nominasp.DataSource = nominaspercepciones_DAO.actualizar();
            lbl_pagina.Text = aux1 + " " + nominaspercepciones_DAO.actual_page;
            lbl_total.Text = aux2 + " " + nominaspercepciones_DAO.pages;
        }


    }

}
