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
    public partial class Departamentos_nuevo : Form
    {
        Departamentos_DAO depto_DAO;
        public Departamentos_nuevo()
        {
            InitializeComponent();
            depto_DAO = new Departamentos_DAO();
        }

        private void IniciotoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Principal pr = new Principal();
            this.SetVisibleCore(false);
            pr.ShowDialog();
        }

        private void Departamentos_nuevo_Load(object sender, EventArgs e)
        {
            id_depa.Value = depto_DAO.getMaxID();
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

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (validarCampos() == true)
            {
                Departamento depto = new Departamento(0, nombre_depa.Text,'A');
                try
                {
                    if (depto_DAO.validarDepto(depto))
                    {

                        depto_DAO.registrar(depto);
                        Mensajes.Info("Registro realizado exitosamente");
                        Close();
                    }
                    else
                    {
                        Mensajes.Error("El departamento ya se encuentra registrado.");
                    }
                }
                catch (Exception)
                {
                    Mensajes.Error("Error al registrar el departamento.");
                }

            }
        }
    }
}
