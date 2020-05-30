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
    public partial class Percepciones_GUI : Form
    {
        Percepciones_DAO percepciones_DAO;
        string aux1, aux2;
        public Percepciones_GUI()
        {
            InitializeComponent();
            try
            {
                percepciones_DAO = new Percepciones_DAO();
                percepciones_DAO.table = "Percepciones_Tabla";
                percepciones_DAO.order_by = "ID";
                percepciones_DAO.CalculaPaginas();
                if(percepciones_DAO.actual_page==1 || percepciones_DAO.actual_page == 0)
                {
                    btn_anterior.Enabled = false;
                }
                else if(percepciones_DAO.actual_page== percepciones_DAO.pages)
                {
                    btn_siguiente.Enabled = false;
                }
               
            }catch(Exception ex)
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
            Percepciones_nuevo percepciones_Nuevo = new Percepciones_nuevo();
            percepciones_Nuevo.ShowDialog();
            actualizar();
        }

        private void Percepciones_GUI_Load(object sender, EventArgs e)
        {   
            try
            {
                tabla_Percepciones.DataSource = percepciones_DAO.getSigPagina();
                aux1 = lbl_pagina.Text;
                aux2 = lbl_total.Text;   
                lbl_pagina.Text = aux1 + " " + percepciones_DAO.actual_page; 
                lbl_total.Text = aux2 + " " + percepciones_DAO.pages;

            }
            catch(Exception ex)
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
            if (tabla_Percepciones.SelectedRows.Count != 0)
            {
                DataGridViewRow row = tabla_Percepciones.SelectedRows[0];

               
                Percepcion percepciones_editar = new Percepcion(
                    (int)row.Cells[0].Value,
                    (string)row.Cells[1].Value,
                    (string)row.Cells[2].Value,
                    (int)row.Cells[3].Value,
                    Convert.ToChar(row.Cells[4].Value)
                    );
                Percepciones_editar percepciones_Editar = new Percepciones_editar(percepciones_editar);
                this.SetVisibleCore(false);
                percepciones_Editar.ShowDialog();
                this.SetVisibleCore(true);
                actualizar();
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Selecciona la percepción", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabla_Percepciones.SelectedRows.Count != -1) { 

                try
                {
                    DialogResult resultado = MessageBox.Show("¿Estás seguro que desea eliminar la percepción?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        DataGridViewRow row = tabla_Percepciones.SelectedRows[0];
                        int idPercepcion = (int)row.Cells[0].Value;
                        percepciones_DAO.eliminar(idPercepcion);
                        
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
            if(buscarPerTxt.Text.Equals(""))
            {
                DialogResult resultado = MessageBox.Show("No hay datos para buscar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); 

            }
            else
            {
                try
                {
                    string consulta_wh = "Nombre like '%'+'" + buscarPerTxt.Text + "'+'%'";
                    tabla_Percepciones.DataSource = percepciones_DAO.buscar(consulta_wh);
                }
                catch(Exception ex)
                {
                    Console.WriteLine("ERROR: " + ex.Message);
                    Mensajes.Error("Error en la busqueda");
                }
                
            }
        }

        private void buscarPerTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabla_Percepciones_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn i in tabla_Percepciones.Columns)
            {
                i.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            tabla_Percepciones.AutoResizeColumns();
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            
            btn_anterior.Enabled = true;
            if (percepciones_DAO.actual_page < percepciones_DAO.pages)
            {
                tabla_Percepciones.DataSource = percepciones_DAO.getSigPagina();
            }
            if (percepciones_DAO.actual_page == percepciones_DAO.pages)
            {
                btn_siguiente.Enabled = false;
            }
            lbl_pagina.Text = aux1 + " " + percepciones_DAO.actual_page;
            lbl_total.Text = aux2 + " " + percepciones_DAO.pages;
        }

        private void tabla_Percepciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {

                    DialogResult resultado = MessageBox.Show("¿Estás seguro que desea eliminar la percepción?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resultado == DialogResult.Yes)
                    {
                        DataGridViewRow renglon = tabla_Percepciones.Rows[e.RowIndex];
                        int idPer = (int)renglon.Cells[0].Value;
                        percepciones_DAO.eliminar(idPer);
                        
                    }
                    actualizar();

                }
                catch (Exception ex)
                {
                   Mensajes.Error("Error al intentar eliminar la percepción");
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Selecciona la percepción", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            btn_siguiente.Enabled = true;
            if (percepciones_DAO.actual_page > 1)
            {
                tabla_Percepciones.DataSource = percepciones_DAO.getAnteriorPagina();
            }
            if (percepciones_DAO.actual_page == 1)
            {
                btn_anterior.Enabled = false;
            }
            lbl_pagina.Text = aux1 +" "+percepciones_DAO.actual_page;
            lbl_total.Text = aux2+ " "+ percepciones_DAO.pages;
        }
        private void actualizar()
        {
            btn_anterior.Enabled = false;
            btn_siguiente.Enabled = true;
            tabla_Percepciones.DataSource = percepciones_DAO.actualizar();
            lbl_pagina.Text = aux1 + " " + percepciones_DAO.actual_page;
            lbl_total.Text = aux2 + " " + percepciones_DAO.pages;
        }
    }
}
