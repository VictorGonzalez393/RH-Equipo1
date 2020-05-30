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
    public partial class FormaPago_Nuevo : Form
    {
        FormasPago_DAO formaPagoDAO;
        public FormaPago_Nuevo()
        {
            InitializeComponent();
            formaPagoDAO = new FormasPago_DAO();
        }

        private void FormaPago_Nuevo_Load(object sender, EventArgs e)
        {
            id_pago.Value = formaPagoDAO.getMaxID();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Principal pr = new Principal();
            this.SetVisibleCore(false);
            pr.ShowDialog();
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
                FormasPago formaspago = new FormasPago((int)id_pago.Value, nombre_pago.Text, 'A');
                try
                {
                    if (formaPagoDAO.validarPago(formaspago))
                    {


                        if (formaPagoDAO.registrar(formaspago) == false)
                        {
                            Mensajes.Error("Registro no realizado exitosamente");
                        }
                        else
                            Mensajes.Info("Registro realizado exitosamente");
                        Close();
                    }
                    else
                    {
                        Mensajes.Error("El pago ya se encuentra registrado.");
                    }
                }
                catch (Exception)
                {
                    Mensajes.Error("Error al registrar el pago.");
                }

            }
        }
    }
}
