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
    public partial class Deducciones_editar : Form
    {
        private Deduccion deduccion;
        private Deducciones_DAO deducciones_DAO;
        public Deducciones_editar(Deduccion deduccion)
        {
            InitializeComponent();
            this.deduccion = deduccion;
            deducciones_DAO = new Deducciones_DAO();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (validarCampos() == true)
            {
                deduccion.Nombre = nombre_deduccion.Text;
                deduccion.Descripcion = descripcion_deduccion.Text;
                deduccion.Porcentaje = (double) porcentaje_deduccion.Value;
                try
                {
                    if (deducciones_DAO.editar(deduccion))
                    {
                        DialogResult result = MessageBox.Show("Los datos se han editado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (result == DialogResult.OK)
                        {
                            Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al editar");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void id_deduccion_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void nombre_deduccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void descriocion_deduccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Deducciones_editar_Load(object sender, EventArgs e)
        {
            nombre_deduccion.Text = deduccion.Nombre;
            descripcion_deduccion.Text = deduccion.Descripcion;
            porcentaje_deduccion.Value = (decimal) deduccion.Porcentaje;
            id_deduccion.Value = deduccion.IdDeduccion;
        }

        private bool validarCampos()
        {
            if (!string.IsNullOrWhiteSpace(nombre_deduccion.Text))
            {
                if (!string.IsNullOrWhiteSpace(descripcion_deduccion.Text))
                {
                    if (porcentaje_deduccion.Value != 0)
                    {
                        return true;
                    }
                    else
                    {
                        DialogResult resultado = MessageBox.Show("El campo de porcentaje se encuentra vacío", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("El campo de descripción se encuentra vacío", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else
            {
                DialogResult resultado = MessageBox.Show("El campo de nombre se encuentra vacío", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void IniciotoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Principal pr = new Principal();
            this.SetVisibleCore(false);
            pr.ShowDialog();
        }

        private void IniciotoolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            this.SetVisibleCore(false);
            Principal p = new Principal();
            p.ShowDialog();
           // Application.Exit();
        }

        private void btn_guardar_Click_1(object sender, EventArgs e)
        {
            if (validarCampos() == true)
            {
                deduccion.Nombre = nombre_deduccion.Text;
                deduccion.Descripcion = descripcion_deduccion.Text;
                deduccion.Porcentaje = (double)porcentaje_deduccion.Value;
                try
                {
                    if (deducciones_DAO.editar(deduccion))
                    {
                        DialogResult result = MessageBox.Show("Los datos se han editado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (result == DialogResult.OK)
                        {
                            Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al editar");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al editar el registro");

                }

            }
        }

        private void btn_cancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
