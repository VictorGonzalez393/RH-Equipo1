using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgroNegocio_RH_ERP_ISC_8A.Datos;

namespace AgroNegocio_RH_ERP_ISC_8A.Interfaces
{
    public partial class Nomina_GUI : Form
    {
        public int idEmp { get; set; }
        Nomina_DAO nominas_DAO;
        string aux1, aux2;
        public Nomina_GUI()
        {
            InitializeComponent();
            try
            {
                nominas_DAO = new Nomina_DAO();
                nominas_DAO.table = "Nominas_Tabla";
                nominas_DAO.order_by = "ID";
                nominas_DAO.where = "ID_Empleado=" + idEmp;
                nominas_DAO.CalculaPaginas();
                if (nominas_DAO.actual_page == 1 || nominas_DAO.pages == 0)
                {
                    btn_anterior.Enabled = false;
                }
                else if (nominas_DAO.actual_page == nominas_DAO.pages)
                {
                    btn_siguiente.Enabled = false;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        public Nomina_GUI(int idEmp, string empleado)
        {
            InitializeComponent();
            nombre.Text=empleado;
            this.idEmp = idEmp;
            try { 
                nominas_DAO = new Nomina_DAO();
                nominas_DAO.table = "Nominas_Tabla";
                nominas_DAO.order_by = "ID";
                nominas_DAO.where = "ID_Empleado='" + idEmp+"'";
                nominas_DAO.CalculaPaginas();
                if (nominas_DAO.actual_page==1 || nominas_DAO.pages == 0)
                {
                    btn_anterior.Enabled = false;
                }else if (nominas_DAO.actual_page == nominas_DAO.pages)
                {
                    btn_siguiente.Enabled = false;

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }

        private void Nomina_GUI_Load(object sender, EventArgs e)
        {
            try
            {
                tablaNomina.DataSource = nominas_DAO.getSigPagina();
                aux1 = lbl_pagina.Text;
                aux2 = lbl_total.Text;
                lbl_pagina.Text = aux1 + " " + nominas_DAO.actual_page;
                lbl_total.Text = aux2 + " " + nominas_DAO.pages;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            btn_siguiente.Enabled = true;
            if (nominas_DAO.actual_page > 1)
            {
                tablaNomina.DataSource = nominas_DAO.getAnteriorPagina();
            }
            if (nominas_DAO.actual_page == 1)
            {
                btn_anterior.Enabled = false;
            }
            lbl_pagina.Text = aux1 + " " + nominas_DAO.actual_page;
            lbl_total.Text = aux2 + " " + nominas_DAO.pages;
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            btn_anterior.Enabled = true;
            if (nominas_DAO.actual_page < nominas_DAO.pages)
            {
                tablaNomina.DataSource = nominas_DAO.getSigPagina();
            }
            if (nominas_DAO.actual_page == nominas_DAO.pages)
            {
                btn_siguiente.Enabled = false;
            }
            lbl_pagina.Text = aux1 + " " + nominas_DAO.actual_page;
            lbl_total.Text = aux2 + " " + nominas_DAO.pages;
        }

        private void btn_buscarNomina_Click(object sender, EventArgs e)
        {
            if (buscarNominaTXT.Text.Equals(""))
            {
                DialogResult resultado = MessageBox.Show("No hay datos para buscar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {
                    string consulta_wh = "Fecha_pago like '%'+'" + buscarNominaTXT.Text + "'+'%' and ID_Empleado="+idEmp;
                    tablaNomina.DataSource = nominas_DAO.buscar(consulta_wh);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR: " + ex.Message);
                    MessageBox.Show("Error en la busqueda");
                }

            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tablaNomina.SelectedRows.Count != -1)
            {

                try
                {
                    DialogResult resultado = MessageBox.Show("¿Estás seguro que desea eliminar la percepción?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        DataGridViewRow row = tablaNomina.SelectedRows[0];
                        int idNomina = (int)row.Cells[0].Value;
                        nominas_DAO.eliminar(idNomina);

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
        private void actualizar()
        {
            btn_anterior.Enabled = false;
            btn_siguiente.Enabled = true;
            tablaNomina.DataSource = nominas_DAO.actualizar();
            lbl_pagina.Text = aux1 + " " + nominas_DAO.actual_page;
            lbl_total.Text = aux2 + " " + nominas_DAO.pages;
        }

        private void nóminaPercepcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tablaNomina.SelectedRows.Count == 1)
            {
                int idNom = (int)tablaNomina.SelectedRows[0].Cells[0].Value;
                NominasPercepciones_GUI np = new NominasPercepciones_GUI(idNom);
                this.SetVisibleCore(false);
                np.ShowDialog();
                this.SetVisibleCore(true);

            }
            else
            {
                DialogResult resultado = MessageBox.Show("Selecciona a una nómina", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void nóminaDeduccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tablaNomina.SelectedRows.Count == 1)
            {
                int idNom = (int)tablaNomina.SelectedRows[0].Cells[0].Value;
                NominasDeducciones_GUI np = new NominasDeducciones_GUI(idNom);
                this.SetVisibleCore(false);
                np.ShowDialog();
                this.SetVisibleCore(true);

            }
            else
            {
                DialogResult resultado = MessageBox.Show("Selecciona a una nómina", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Principal p = new Principal();
            this.SetVisibleCore(false);
            p.ShowDialog();
            Close();
        }

        private void atrásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevaNóminaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Nomina_nuevo nn = new Nomina_nuevo(nombre.Text,idEmp);
            nn.ShowDialog();
        }

        private void editarNóminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nomina_editar ne = new Nomina_editar(nombre.Text,idEmp);
            ne.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
