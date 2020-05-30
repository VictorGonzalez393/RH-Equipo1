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

    public partial class FormaPago_editar : Form
    {
        private FormasPago formaspago;
        private FormasPago_DAO formaspago_DAO;
        public FormaPago_editar(FormasPago formaspago)
        {
            InitializeComponent();
            this.formaspago = formaspago;
            formaspago_DAO = new FormasPago_DAO();
        }

        private void FormaPago_editar_Load(object sender, EventArgs e)
        {
            nombre_pago.Text = formaspago.nombre;
            id_pago.Value = formaspago.idFormaPago;
        }

        private bool validarCampos()
        {
            if (!string.IsNullOrWhiteSpace(nombre_pago.Text))
            {
                return true;
            }
            else
            {
                DialogResult resultado = MessageBox.Show("El campo de nombre se encuentra vacío", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Principal pr = new Principal();
            this.SetVisibleCore(false);
            pr.ShowDialog();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void atrásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (validarCampos() == true)
            {
                formaspago.nombre = nombre_pago.Text;
                try
                {
                    if (formaspago_DAO.editar(formaspago))
                    {
                        MessageBox.Show("Los datos se han editado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                    }
                    else
                    {
                        Mensajes.Error("Error al editar");
                    }

                }
                catch (Exception)
                {
                    Mensajes.Error("Error al editar el pago");

                }

            }
        }
    }
}
