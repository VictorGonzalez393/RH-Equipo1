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
    public partial class Ciudades_GUI : Form
    {
        Ciudades_DAO ciudadesDAO;
        string aux1, aux2;
        public Ciudades_GUI()
        {
            InitializeComponent();
            try
            {
                ciudadesDAO = new Ciudades_DAO();
                ciudadesDAO.table = "Ciudades_Tabla";
                ciudadesDAO.order_by = "ID";
                ciudadesDAO.CalculaPaginas();
                if (ciudadesDAO.actual_page == 1 || ciudadesDAO.actual_page == 0)
                {
                    btn_anterior.Enabled = false;
                }
                else if (ciudadesDAO.actual_page == ciudadesDAO.pages)
                {
                    btn_siguiente.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                tabla_Ciudades.DataSource = ciudadesDAO.getSigPagina();
                aux1 = lbl_pagina.Text;
                aux2 = lbl_total.Text;
                lbl_pagina.Text = aux1 + " " + ciudadesDAO.actual_page;
                lbl_total.Text = aux2 + " " + ciudadesDAO.pages;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void agregarCiudadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ciudades_nuevo ciudades_Nuevo = new Ciudades_nuevo();
            ciudades_Nuevo.ShowDialog();
            actualizar();
            
        }

       

        private void editarCiudadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabla_Ciudades.SelectedRows.Count >0)
            {
                DataGridViewRow row = tabla_Ciudades.SelectedRows[0];

                Ciudad ciudad_editar = new Ciudad(
                    (int)row.Cells[0].Value,
                    (string)row.Cells[1].Value,
                    ciudadesDAO.getIDEstado((string)row.Cells[2].Value),
                    Convert.ToChar(row.Cells[3].Value)
                    );

                Ciudades_editar ciudades_EditarGUI = new Ciudades_editar(ciudad_editar);
                ciudades_EditarGUI.ShowDialog();
                actualizar();
                
            }
            else
            {
                MessageBox.Show("Selecciona una ciudad");
            }
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

       

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string consulta_where = "nombre like '%'+'"+buscar_ciudad.Text +"'+ '%'";
            tabla_Ciudades.DataSource = ciudadesDAO.buscar(consulta_where);
            
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabla_Ciudades.SelectedRows.Count != -1)
            {

                try
                {
                    DialogResult resultado = MessageBox.Show("¿Estás seguro que desea eliminar la ciudad?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        DataGridViewRow row = tabla_Ciudades.SelectedRows[0];
                        int idCiudad = (int)row.Cells[0].Value;
                        ciudadesDAO.eliminar(idCiudad);
                        actualizar();
                        
                    }
                }
                catch (Exception ex)
                {
                    Mensajes.Error("Error al intentar eliminar la ciudad");
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Selecciona la ciudad", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tabla_Ciudades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {

                    DialogResult resultado = MessageBox.Show("Seguro que desea eliminar una ciudad?", "alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resultado == DialogResult.Yes)
                    {
                        DataGridViewRow renglon = tabla_Ciudades.Rows[e.RowIndex];
                        int idciudad = (int)renglon.Cells[0].Value;
                        ciudadesDAO.eliminar(idciudad);
                        actualizar();
                       
                    }

                }
                catch (Exception ex)
                {
                   Mensajes.Error("Error al intentar eliminar la ciudad");
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            else
                Mensajes.Error("Selecciona una ciudad");
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            btn_siguiente.Enabled = true;
            if (ciudadesDAO.actual_page > 1)
            {
                tabla_Ciudades.DataSource = ciudadesDAO.getAnteriorPagina();
            }
            if (ciudadesDAO.actual_page == 1)
            {
                btn_anterior.Enabled = false;
            }
            lbl_pagina.Text = aux1 + " " + ciudadesDAO.actual_page;
            lbl_total.Text = aux2 + " " + ciudadesDAO.pages;
        }

        private void lbl_pagina_Click(object sender, EventArgs e)
        {

        }

        private void lbl_total_Click(object sender, EventArgs e)
        {

        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            btn_anterior.Enabled = true;
            if (ciudadesDAO.actual_page < ciudadesDAO.pages)
            {
                tabla_Ciudades.DataSource = ciudadesDAO.getSigPagina();
            }
            if (ciudadesDAO.actual_page == ciudadesDAO.pages)
            {
                btn_siguiente.Enabled = false;
            }
            lbl_pagina.Text = aux1 + " " + ciudadesDAO.actual_page;
            lbl_total.Text = aux2 + " " + ciudadesDAO.pages;
        }
        private void actualizar()
        {
            btn_anterior.Enabled = false;
            btn_siguiente.Enabled = true;
            tabla_Ciudades.DataSource = ciudadesDAO.actualizar();
            lbl_pagina.Text = aux1 + " " + ciudadesDAO.actual_page;
            lbl_total.Text = aux2 + " " + ciudadesDAO.pages;
        }
    }
}
