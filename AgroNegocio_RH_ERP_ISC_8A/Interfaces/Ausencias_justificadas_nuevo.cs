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
    public partial class Ausencias_justificadas_nuevo : Form
    {
        Ausencias_justificadas_DAO ausencias_Justificadas_DAO;
        public Ausencias_justificadas_nuevo()
        {
            InitializeComponent();
            ausencias_Justificadas_DAO = new Ausencias_justificadas_DAO();
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

        private void Ausencias_justificadas_nuevo_Load(object sender, EventArgs e)
        {
            id_justificacion.Value = ausencias_Justificadas_DAO.getMaxID();
        }
        private bool validarCampos()
        {
            if (!string.IsNullOrWhiteSpace(fechaSolicitud_ausencia_Justificada.Text))
            {
                if (!string.IsNullOrWhiteSpace(fechaInicio_ausencia_Justificada.Text))
                {
                    if (!string.IsNullOrWhiteSpace(fechaFin_ausencia_Justficada.Text))
                    {
                        if (!string.IsNullOrWhiteSpace(tipo_ausencia_Justificada.Text))
                        {
                            if (id_empleadoS.Value != 0)
                            {
                                if (id_empleadoA.Value != 0)
                                {
                                    return true;
                                }
                                else
                                {
                                    DialogResult resultado = MessageBox.Show("El campo de idEmpleadoA se encuentra vacío", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return false;
                                }
                            }
                            else
                            {
                                DialogResult resultado = MessageBox.Show("El campo de idEmpleadoS se encuentra vacío", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return false;
                            }
                        }
                        else
                        {
                            DialogResult resultado = MessageBox.Show("El campo de tipo se encuentra vacío", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                    else
                    {
                        DialogResult resultado = MessageBox.Show("El campo de fechaFin se encuentra vacío", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("El campo de fechaInicio se encuentra vacío", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else
            {
                DialogResult resultado = MessageBox.Show("El campo de fechaSolicitud se encuentra vacío", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (validarCampos() == true)
            {
                Ausencia_justificada ausencia_Justificada_new = new Ausencia_justificada(0, fechaSolicitud_ausencia_Justificada.Text, fechaInicio_ausencia_Justificada.Text, fechaFin_ausencia_Justificada.Text, tipo_ausencia_Justificada.Text, (int)idEmpleadoS_ausencia_Justificada.Value, (int)idEmpleadoA_ausencia_Justificada.Value, 'A');
                try
                {
                    if (ausencias_Justificadas_DAO.validarAusencia_iustificada(ausencia_Justificada_new))
                    {

                        ausencias_Justificadas_DAO.registrar(ausencia_Justificada_new);
                        MessageBox.Show("Registro realizado exitosamente");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("La justificacion ya se encuentra registrada");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar la justificacion");
                }

            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void IniciotoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
