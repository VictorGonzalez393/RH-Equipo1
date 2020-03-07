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
    public partial class Departamentos_editar : Form
    {
        private Departamento depto;
        private Departamentos_DAO depto_DAO;
        public Departamentos_editar(Departamento depto)
        {
            InitializeComponent();
            this.depto = depto;
            this.depto_DAO = new Departamentos_DAO();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (validarCampos() == true)
            {
                depto.Nombre = nombre_depa.Text;
                try
                {
                    if (depto_DAO.editar(depto))
                    {
                        DialogResult result = MessageBox.Show("Los datos se han editado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Departamentos_editar_Load(object sender, EventArgs e)
        {
            nombre_depa.Text = depto.Nombre;
            id_depa.Value = depto.idDepto;
        }

        private bool validarCampos()
        {
            if (!string.IsNullOrWhiteSpace(nombre_depa.Text))
            {
                return true;
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

        private void IniciotoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Principal pr = new Principal();
            this.SetVisibleCore(false);
            pr.ShowDialog();
        }
    }

}
