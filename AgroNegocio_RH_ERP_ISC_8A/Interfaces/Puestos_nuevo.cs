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
    public partial class Puestos_nuevo : Form
    {
        Puestos_DAO puestos_DAO;
        public Puestos_nuevo()
        {
            InitializeComponent();
            puestos_DAO = new Puestos_DAO();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Principal pr = new Principal();
            this.SetVisibleCore(false);
            pr.ShowDialog();
            //Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void Puestos_nuevo_Load(object sender, EventArgs e)
        {
            id_puesto.Value = puestos_DAO.getMaxID();
        }

        private bool validarCampos()
        {
            if (!string.IsNullOrWhiteSpace(nombre_puesto.Text))
            {
                if (!string.IsNullOrWhiteSpace(samin_puesto.Text))
                {
                    if (samax_puesto.Value != 0)
                    {
                        return true;
                    }
                    else
                    {
                        DialogResult resultado = MessageBox.Show("El campo de salario máximo se encuentra vacío", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("El campo de salario mínimo se encuentra vacío", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                Puesto puesto_new = new Puesto(0, nombre_puesto.Text, samin_puesto.Text, (int)samax_puesto.Value, 'A');
                try
                {
                    if (puestos_DAO.validarPuesto(puesto_new))
                    {

                        puestos_DAO.registrar(puesto_new);
                        MessageBox.Show("Registro realizado exitosamente");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("El puesto ya se encuentra registrada");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar el puesto");
                }

            }
        }

        private void samax_puesto_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
    
