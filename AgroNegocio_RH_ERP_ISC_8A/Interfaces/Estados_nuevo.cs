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
    public partial class Estados_nuevo : Form
    {
        Estados_DAO estados_DAO;

        public Estados_nuevo()
        {
            InitializeComponent();
            estados_DAO = new Estados_DAO();
        }

        private void IniciotoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Principal pr = new Principal();
            this.SetVisibleCore(false);
            pr.ShowDialog();
        }

        private void Estados_nuevo_Load(object sender, EventArgs e)
        {
            id_estado.Value = estados_DAO.getMaxID();
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
                Estado nuevo_estado = new Estado(0, nombre_estado.Text, siglas_estado.Text, 'A');
                try
                {
                    if (estados_DAO.validarEstado(nuevo_estado))
                    {

                        estados_DAO.registrar(nuevo_estado);
                        MessageBox.Show("Registro realizado exitosamente");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("El estado ya se encuentra registrado");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }

            }
        }
    }
}
