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
    public partial class Empleados_GUI : Form
    {
        Empleados_DAO empleadosDAO;
        string aux1, aux2;
        public Empleados_GUI()
        {
            InitializeComponent();
            try
            {
                empleadosDAO = new Empleados_DAO();
                empleadosDAO.table = "Empleados_Tabla"; 
                empleadosDAO.order_by = "ID";//Descomentar

                //empleadosDAO.table = "empleados"; //Pruebas en horarios
                //empleadosDAO.order_by = "IDempleado ";
                
                empleadosDAO.CalculaPaginas();
                if (empleadosDAO.actual_page == 1 || empleadosDAO.actual_page == 0)
                {
                    btn_anterior.Enabled = false;
                }
                else if (empleadosDAO.actual_page == empleadosDAO.pages)
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
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void agregarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleados_nuevo empleadosnuevo = new Empleados_nuevo();
            this.SetVisibleCore(false);
            empleadosnuevo.ShowDialog();
            this.SetVisibleCore(true);
        }

        private void tablaEmpleados1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {

                    DialogResult resultado = MessageBox.Show("Seguro que desea eliminar un Empleado?", "alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resultado == DialogResult.Yes)
                    {
                        DataGridViewRow renglon = tablaEmpleados1.Rows[e.RowIndex];
                        int idempleado = (int)renglon.Cells[0].Value;
                        empleadosDAO.eliminar(idempleado);
                        actualizar();

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar eliminar al Empleado");
                }
            }
            else
                MessageBox.Show("Selecciona un Empleado");
        }

        private void editarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tablaEmpleados1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = tablaEmpleados1.SelectedRows[0];

                Empleado empleado_editar = new Empleado(
                    (int)row.Cells[0].Value,
                    (string)row.Cells[1].Value,
                    (string)row.Cells[2].Value,
                    (string)row.Cells[3].Value,
                    (string)row.Cells[4].Value,
                    (string)row.Cells[5].Value,
                    (string)row.Cells[6].Value,
                    (double)row.Cells[7].Value,
                    (string)row.Cells[8].Value,
                    (string)row.Cells[9].Value,
                    (int)row.Cells[10].Value,
                    (int)row.Cells[11].Value,
                    (string)row.Cells[12].Value,
                    (string)row.Cells[13].Value,
                    (string)row.Cells[14].Value,
                    (string)row.Cells[15].Value,
                    (double)row.Cells[16].Value,
                    Convert.ToChar(row.Cells[17].Value),
                    empleadosDAO.getidDepartamento((string)row.Cells[18].Value),
                    empleadosDAO.getidPuesto((string)row.Cells[19].Value),
                    empleadosDAO.getidCiudad((string)row.Cells[20].Value),
                    empleadosDAO.getidSucursal((string)row.Cells[21].Value),
                    empleadosDAO.GetImage((int)row.Cells[0].Value)
                    );

                Empleados_Editar empleados_Editar = new Empleados_Editar(empleado_editar);
                this.SetVisibleCore(false);
                empleados_Editar.ShowDialog();
                this.SetVisibleCore(true);
                actualizar();

            }
            else
            {
                MessageBox.Show("Selecciona un Empleado");
            }
        }
        

        private void btn_buscarEmpleado_Click(object sender, EventArgs e)
        {
            string consulta_where = "nombre like '%'+'" + buscarEmpleado.Text + "'+ '%'";
            tablaEmpleados1.DataSource = empleadosDAO.buscar(consulta_where);
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tablaEmpleados1.SelectedRows.Count != -1)
            {

                try
                {
                    DialogResult resultado = MessageBox.Show("¿Estás seguro que desea eliminar al empleado?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        DataGridViewRow row = tablaEmpleados1.SelectedRows[0];
                        int idEmpleado = (int)row.Cells[0].Value;
                        empleadosDAO.eliminar(idEmpleado);
                        actualizar();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar eliminar al empleado");
                }
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Selecciona al Empleado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            btn_siguiente.Enabled = true;
            if (empleadosDAO.actual_page > 1)
            {
                tablaEmpleados1.DataSource = empleadosDAO.getAnteriorPagina();
            }
            if (empleadosDAO.actual_page == 1)
            {
                btn_anterior.Enabled = false;
            }
            lbl_pagina.Text = aux1 + " " + empleadosDAO.actual_page;
            lbl_total.Text = aux2 + " " + empleadosDAO.pages;
        }

        private void btn_siguiente_Click_1(object sender, EventArgs e)
        {
            btn_anterior.Enabled = true;
            if (empleadosDAO.actual_page < empleadosDAO.pages)
            {
                tablaEmpleados1.DataSource = empleadosDAO.getSigPagina();
            }
            if (empleadosDAO.actual_page == empleadosDAO.pages)
            {
                btn_siguiente.Enabled = false;
            }
            lbl_pagina.Text = aux1 + " " + empleadosDAO.actual_page;
            lbl_total.Text = aux2 + " " + empleadosDAO.pages;
        }

        private void Empleados_GUI_Load(object sender, EventArgs e)
        {
            try
            {
                tablaEmpleados1.DataSource = empleadosDAO.getSigPagina();
                aux1 = lbl_pagina.Text;
                aux2 = lbl_total.Text;
                lbl_pagina.Text = aux1 + " " + empleadosDAO.actual_page;
                lbl_total.Text = aux2 + " " + empleadosDAO.pages;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void editarHorarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tablaEmpleados1.SelectedRows.Count == 1)
            {
                int idemp = (int)tablaEmpleados1.SelectedRows[0].Cells[0].Value;
                string nombreemp = (string)tablaEmpleados1.SelectedRows[0].Cells[1].Value + " "+ tablaEmpleados1.SelectedRows[0].Cells[2].Value + " " + tablaEmpleados1.SelectedRows[0].Cells[3].Value ;
                Horarios_editar horarios_Editar = new Horarios_editar(idemp, nombreemp);
                horarios_Editar.ShowDialog();

            }
            else
            {
                DialogResult resultado = MessageBox.Show("Selecciona a un Empleado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void nóminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tablaEmpleados1.SelectedRows.Count == 1)
            {
                int idemp = (int)tablaEmpleados1.SelectedRows[0].Cells[0].Value;
                string nombreemp = (string)tablaEmpleados1.SelectedRows[0].Cells[1].Value + " " + tablaEmpleados1.SelectedRows[0].Cells[2].Value + " " + tablaEmpleados1.SelectedRows[0].Cells[3].Value;
                Nomina_GUI nomina = new Nomina_GUI(idemp, nombreemp);
                this.SetVisibleCore(false);
                nomina.ShowDialog();
                this.SetVisibleCore(true);

            }
            else
            {
                DialogResult resultado = MessageBox.Show("Selecciona a un empleado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Principal p = new Principal();
            this.SetVisibleCore(false);
            p.ShowDialog();
            this.Close();
        }

        private void ausenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tablaEmpleados1.SelectedRows.Count == 1)
            {
                string nombreemp = (string)tablaEmpleados1.SelectedRows[0].Cells[1].Value + " " + tablaEmpleados1.SelectedRows[0].Cells[2].Value + " " + tablaEmpleados1.SelectedRows[0].Cells[3].Value;
                int id = (int)tablaEmpleados1.SelectedRows[0].Cells[0].Value;
                int dV= (int)tablaEmpleados1.SelectedRows[0].Cells[10].Value;
                int dP= (int)tablaEmpleados1.SelectedRows[0].Cells[11].Value;
                Ausencias_GUI a = new Ausencias_GUI(nombreemp, id,dV,dP);
                SetVisibleCore(false);
                a.ShowDialog();
                SetVisibleCore(true);
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Selecciona a un empleado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void vacacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nombreemp = (string)tablaEmpleados1.SelectedRows[0].Cells[1].Value + " " + tablaEmpleados1.SelectedRows[0].Cells[2].Value + " " + tablaEmpleados1.SelectedRows[0].Cells[3].Value;
            int id = (int)tablaEmpleados1.SelectedRows[0].Cells[0].Value;
            Incapcidades_GUI inc = new Incapcidades_GUI(nombreemp, id);
            SetVisibleCore(false);
            inc.ShowDialog();
            SetVisibleCore(true);
        }

        private void buscarEmpleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void actualizar()
        {
            btn_anterior.Enabled = false;
            btn_siguiente.Enabled = true;
            tablaEmpleados1.DataSource = empleadosDAO.actualizar();
            lbl_pagina.Text = aux1 + " " + empleadosDAO.actual_page;
            lbl_total.Text = aux2 + " " + empleadosDAO.pages;
        }
    }
}
