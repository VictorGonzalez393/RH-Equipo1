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
    public partial class pago_GUI : Form
    {
        FormasPago_DAO formaPagoDAO;
        string aux1, aux2;

        public pago_GUI()
        {
            InitializeComponent();
            try
            {
                formaPagoDAO = new FormasPago_DAO();
                formaPagoDAO.table = "FP";
                formaPagoDAO.order_by = "ID";
                formaPagoDAO.CalculaPaginas();
                if (formaPagoDAO.actual_page == 1 || formaPagoDAO.actual_page == 0)
                {
                    btn_anterior.Enabled = false;
                }
                else if (formaPagoDAO.actual_page == formaPagoDAO.pages)
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

        private void agregarpagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaPago_Nuevo nuevo = new FormaPago_Nuevo();
            nuevo.ShowDialog();
            actualizar();
        }
        private void actualizar()
        {
            btn_anterior.Enabled = false;
            btn_siguiente.Enabled = true;
            tablaPagos.DataSource = formaPagoDAO.actualizar();
            lbl_pagina.Text = aux1 + " " + formaPagoDAO.actual_page;
            lbl_total.Text = aux2 + " " + formaPagoDAO.pages;
        }

        private void editarpagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tablaPagos.SelectedRows.Count == 1)
            {
                DataGridViewRow row = tablaPagos.SelectedRows[0];

                FormasPago pago = new FormasPago(
                    (int)row.Cells[0].Value,
                    (string)row.Cells[1].Value,
                    Convert.ToChar(row.Cells[2].Value)
                    );
                FormaPago_editar formapago_editar = new FormaPago_editar(pago); 
                this.SetVisibleCore(false);
                formapago_editar.ShowDialog();
                this.SetVisibleCore(true);
                actualizar();
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Selecciona la forma de pago.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tablaPagos.SelectedRows.Count != -1)
            {

                try
                {
                    DialogResult resultado = MessageBox.Show("¿Estás seguro que desea eliminar la forma de pago?",
                        "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        DataGridViewRow row = tablaPagos.SelectedRows[0];
                        int idpago = (int)row.Cells[0].Value;
                        formaPagoDAO.eliminar(idpago);
                        actualizar();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al intentar eliminar el pago.");
                }
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Selecciona el pago a eliminar.", 
                    "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (buscar_pago.Text.Equals(" "))
            {
                DialogResult resultado = MessageBox.Show("No hay datos para buscar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                string consulta_wh = "nombre like '%'+'" + buscar_pago.Text + "'+'%'";
                tablaPagos.DataSource = formaPagoDAO.buscar(consulta_wh);

            }
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            btn_siguiente.Enabled = true;
            if (formaPagoDAO.actual_page > 1)
            {
                tablaPagos.DataSource = formaPagoDAO.getAnteriorPagina();
            }
            if (formaPagoDAO.actual_page == 1)
            {
                btn_anterior.Enabled = false;
            }
            lbl_pagina.Text = aux1 + " " + formaPagoDAO.actual_page;
            lbl_total.Text = aux2 + " " + formaPagoDAO.pages;
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            btn_anterior.Enabled = true;
            if (formaPagoDAO.actual_page < formaPagoDAO.pages)
            {
                tablaPagos.DataSource = formaPagoDAO.getSigPagina();
            }
            if (formaPagoDAO.actual_page == formaPagoDAO.pages)
            {
                btn_siguiente.Enabled = false;
            }
            lbl_pagina.Text = aux1 + " " + formaPagoDAO.actual_page;
            lbl_total.Text = aux2 + " " + formaPagoDAO.pages;
        }

        private void tablaPagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                tablaPagos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                //tablaPagos.DataSource = formaPagoDAO.getSigPagina();
                tablaPagos.DataSource = formaPagoDAO.actualizar();
                aux1 = lbl_pagina.Text;
                aux2 = lbl_total.Text;
                lbl_pagina.Text = aux1 + " " + formaPagoDAO.actual_page;
                lbl_total.Text = aux2 + " " + formaPagoDAO.pages;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        }
}
