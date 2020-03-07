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
    public partial class Estados_editar : Form
    {
        private Estado estado;
        private Estados_DAO estados_DAO;
        
        public Estados_editar(Estado estado)
        {
            InitializeComponent();
            this.estado = estado;
            estados_DAO = new Estados_DAO();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (validarCampos() == true)
            {
                estado.Nombre = nombre_estado.Text;
                estado.Siglas= siglas_estado.Text;
                try
                {
                    if (estados_DAO.editar(estado))
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

        private void Estados_editar_Load(object sender, EventArgs e)
        {
            nombre_estado.Text = estado.Nombre;
            siglas_estado.Text = estado.Siglas;
            id_estado.Value = estado.IdEstado;
        }

        private bool validarCampos()
        {
            if (!string.IsNullOrWhiteSpace(nombre_estado.Text))
            {
                if (!string.IsNullOrWhiteSpace(siglas_estado.Text))
                {
                    return true;
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("El campo de siglas se encuentra vacío", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}
