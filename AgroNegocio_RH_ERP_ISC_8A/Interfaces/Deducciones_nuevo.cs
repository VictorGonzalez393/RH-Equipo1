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
using AgroNegocio_RH_ERP_ISC_8A.Modelo;

namespace AgroNegocio_RH_ERP_ISC_8A.Interfaces
{
    public partial class Deducciones_nuevo : Form
    {
        Deducciones_DAO deducciones_DAO;
        public Deducciones_nuevo()
        {
            InitializeComponent();
            deducciones_DAO = new Deducciones_DAO();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Principal pr = new Principal();
            this.SetVisibleCore(false);
            pr.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Deducciones_nuevo_Load(object sender, EventArgs e)
        {

            id_deduccion.Value = deducciones_DAO.getMaxID();
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

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (validarCampos() == true)
            {
                Deduccion deduccion_new = new Deduccion(0, nombre_deduccion.Text, descripcion_deduccion.Text, (int)porcentaje_deduccion.Value, 'A');
                try
                {
                    if (deducciones_DAO.validarDeduccion(deduccion_new))
                    {

                        deducciones_DAO.registrar(deduccion_new);
                        MessageBox.Show("Registro realizado exitosamente");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("La deducción ya se encuentra registrada");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar la deducción");
                }

            }
        }

        private void backToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void IniciotoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.SetVisibleCore(false);
            Principal p = new Principal();
            p.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void id_deduccion_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
