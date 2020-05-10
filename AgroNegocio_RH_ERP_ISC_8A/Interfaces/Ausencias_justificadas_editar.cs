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
    public partial class Ausencias_justificadas_editar : Form
    {
        Ausencias_justificadas_DAO ausencias_Justificadas_DAO;
        public Ausencias_justificadas_editar()
        {
            InitializeComponent();
            this.justificaciones = justificaciones;
            ausencias_Justificadas_DAO = new Ausencias_justificadas_DAO();
        }

        private void Ausencias_justificadas_editar_Load(object sender, EventArgs e)
        {
            fechaSolicitud_ausencia_Justificada.Text = ausencia_Justificada.FechaSolicitud;
            fechaInicio_ausencia_Justificada.Text = ausencia_Justificada.FechaInicio;
            fechaFin_ausencia_Justficada.Value = ausencia_Justificada.FechaFin;
            tipo_ausencia_Justificada = ausencia_Justificada.Tipo;
            id_empleadoS.Value = ausencia_Justificada.IdEmpleadoS;
            id_empleadoA.Value = ausencia_Justificada.IdEmpleadoA;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (validarCampos() == true)
            {
                ausencia_Justificada.FechaSolicitud = fechaSolicitud_ausencia_Justificada.Text;
                ausencia_Justificada.FechaInicio = fechaInicio_ausencia_Justificada.Text;
                ausencia_Justificada.FechaFin = fechaFin_ausencia_Justficada.Text;
                ausencia_Justificada.Tipo = tipo_ausencia_Justificada.Text;
                ausencia_Justificada.IdEmpleadoS = (int)id_empleadoS.Value;
                ausencia_Justificada.IdEmpleadoA = (int)id_empleadoA.Value;
                try
                {
                    if (ausencias_Justificadas_DAO.editar(ausencia_Justificada))
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
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void id_justificacion_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void fechaSolicitud_ausencia_Justificada_ValueChanged(object sender, EventArgs e)
        {

        }

        private void fechaInicio_ausencia_Justificada_ValueChanged(object sender, EventArgs e)
        {

        }

        private void fechaFin_ausencia_Justficada_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tipo_ausencia_Justificada_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_empleadoS_ValueChanged(object sender, EventArgs e)
        {

        }

        private void id_empleadoA_ValueChanged(object sender, EventArgs e)
        {

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

        private void IniciotoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Principal pr = new Principal();
            this.SetVisibleCore(false);
            pr.ShowDialog();
            //Application.Exit();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    }

