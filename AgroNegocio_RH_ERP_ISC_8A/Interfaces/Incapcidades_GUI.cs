using AgroNegocio_RH_ERP_ISC_8A.Datos;
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


namespace AgroNegocio_RH_ERP_ISC_8A.Interfaces
{
    public partial class Incapcidades_GUI : Form
    {
        Incapcidades_DAO inc_dao;
        string aux1, aux2;
        int idEmp;
        public Incapcidades_GUI(string nombre, int idEmp)
        {
            InitializeComponent();
            this.txtEmpleado.Text = nombre;
            this.idEmp = idEmp;
            try
            {
                inc_dao = new Incapcidades_DAO();
                inc_dao.table = "Incapacidades_Tabla";
                inc_dao.order_by = "ID";
                inc_dao.CalculaPaginas();
                if(inc_dao.actual_page==1 || inc_dao.actual_page == 0)
                {
                    btn_anterior.Enabled = false;
                }
                else if (inc_dao.actual_page == inc_dao.pages)
                {
                    btn_siguiente.Enabled = false;
                }
            }catch(Exception ex)
            {
                Mensajes.Error("Error al cargar la interfaz de incapacidades");
                Console.WriteLine("Error inicio: " + ex.Message);
            }
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Principal p = new Principal();
            SetVisibleCore(false);
            p.ShowDialog();
        }

        private void atrásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Incapacidades_nuevo incN = new Incapacidades_nuevo((string)txtEmpleado.Text, idEmp);
            SetVisibleCore(false);
            incN.ShowDialog();
            SetVisibleCore(true);
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(tablaIncapacidades.SelectedRows.Count != -1)
            {
                try {
                DataGridViewRow row = tablaIncapacidades.SelectedRows[0];
                Incapacidad i = new Incapacidad((int)row.Cells[0].Value,
                                               (int)row.Cells[1].Value,
                                               (string)row.Cells[2].Value,
                                               (string)row.Cells[3].Value,
                                               (string)row.Cells[4].Value,
                                               (string)row.Cells[5].Value,
                                               (string)row.Cells[6].Value,
                                               (string)row.Cells[7].Value,
                                               inc_dao.GetImage((int)row.Cells[0].Value));
                Incapacidades_editar incE = new Incapacidades_editar(i,idEmp,(string)txtEmpleado.Text);
                this.SetVisibleCore(false);
                incE.ShowDialog();
                this.SetVisibleCore(true);
                actualizar();
                } catch (Exception ex)
                {
                    Mensajes.Error("Error al acceder a la interfaz de editar");
                    Console.WriteLine("Error al dar clic editar:"+ex.Message);
                }
            }
            else
            {
                Mensajes.Error("Seleccione una incapacidad");
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tablaIncapacidades.SelectedRows.Count != -1)
            {
                try
                {
                    DialogResult resultado = MessageBox.Show("¿Estás seguro que desea eliminar la incapacidad?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        DataGridViewRow row = tablaIncapacidades.SelectedRows[0];
                        int idDepto = (int)row.Cells[0].Value;
                        inc_dao.eliminar(idDepto);
                        actualizar();
                        if (inc_dao.pages == 0)
                        {
                            lbl_total.Text = aux2 + " 1";
                        }
                    }
                }
                catch(Exception ex)
                {
                    Mensajes.Error("Error al eliminar");
                    Console.WriteLine("ERROR AL ELIMINAR: " + ex.Message);
                }

            }
            else
            {
                Mensajes.Error("Seleccione una incapacidad");
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (buscarIncTxt.Text.Equals(" "))
            {
                DialogResult resultado = MessageBox.Show("No hay datos para buscar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                string consulta_wh = "fechaInicio like '%'+'" + buscarIncTxt.Text + "'+'%'";
                tablaIncapacidades.DataSource = inc_dao.buscar(consulta_wh);
            }
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            btn_siguiente.Enabled = true;
            if (inc_dao.actual_page > 1)
            {
                tablaIncapacidades.DataSource = inc_dao.getAnteriorPagina();
            }
            if (inc_dao.actual_page == 1)
            {
                btn_anterior.Enabled = false;
            }
            lbl_pagina.Text = aux1 + " " + inc_dao.actual_page;
            lbl_total.Text = aux2 + " " + inc_dao.pages;
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            btn_anterior.Enabled = true;
            if (inc_dao.actual_page < inc_dao.pages)
            {
                tablaIncapacidades.DataSource = inc_dao.getSigPagina();
            }
            if (inc_dao.actual_page == inc_dao.pages)
            {
                btn_siguiente.Enabled = false;
            }
            lbl_pagina.Text = aux1 + " " + inc_dao.actual_page;
            lbl_total.Text = aux2 + " " + inc_dao.pages;
        }

        private void Incapcidades_GUI_Load(object sender, EventArgs e)
        {
            try
            {
                tablaIncapacidades.DataSource = inc_dao.getSigPagina();
                aux1 = lbl_pagina.Text;
                aux2 = lbl_total.Text;
                lbl_pagina.Text = aux1 + " " + inc_dao.actual_page;
                lbl_total.Text = aux2 + " " + inc_dao.pages;

            }
            catch (Exception ex)
            {
                Mensajes.Error("Error al cargar la interfaz de incapacidades");
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void actualizar()
        {
            btn_anterior.Enabled = false;
            btn_siguiente.Enabled = true;
            tablaIncapacidades.DataSource = inc_dao.actualizar();
            lbl_pagina.Text = aux1 + " " + inc_dao.actual_page;
            lbl_total.Text = aux2 + " " + inc_dao.pages;
        } 

    }
}
