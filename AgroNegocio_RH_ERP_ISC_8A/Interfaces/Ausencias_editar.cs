using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgroNegocio_RH_ERP_ISC_8A.Modelo;
using AgroNegocio_RH_ERP_ISC_8A.Datos;

namespace AgroNegocio_RH_ERP_ISC_8A.Interfaces
{
    public partial class Ausencias_editar : Form
    {
        Ausencia_justificada au;
        Ausencias_justificadas_DAO au_dao;
        int idEmpl;
        string nombreE;
        public Ausencias_editar(Ausencia_justificada a,int idEm, string nombre)
        {
            InitializeComponent();
            au = a;
            idEmpl = idEm;
            nombreE = nombre;
            au_dao = new Ausencias_justificadas_DAO();
        }

        private void Ausencias_editar_Load(object sender, EventArgs e)
        {
            this.empleadoS.Text = nombreE;
            this.id_au.Value = au.IdAusencia;
            this.fechaSol.Value = Convert.ToDateTime(au.FechaSolicitud);
            this.fechaIn.Value=  Convert.ToDateTime(au.FechaInicio);
            this.fechaFin.Value= Convert.ToDateTime(au.FechaFin);
            var lista = new Datos.Empleados_DAO().consultaGeneral2("where estatus='A' and idEmpleado <> " + idEmpl, new List<string>(), new List<object>());
            empleadoA_cm.DisplayMember = "NombreCompleto";
            empleadoA_cm.ValueMember = "IdEmpleado";
            empleadoA_cm.DataSource = lista;
            tipo_cm.Items.Add("Vacaciones");
            tipo_cm.Items.Add("Asuntos familiares");
            if (au.Tipo.Equals('V'))
            {
                tipo_cm.SelectedItem="Vacaciones";
            }
            else if (au.Tipo.Equals('F'))
            {
                tipo_cm.SelectedItem= "Asuntos familiares";
            }
         
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Principal p = new Principal();
            SetVisibleCore(false);
            p.ShowDialog();
        }

        private void atrásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void empleadoA_cm_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Modelo.Empleado emp = (Modelo.Empleado)empleadoA_cm.SelectedItem;
        }
        private bool validarDatos()
        {
            if (fechaIn.Value < fechaFin.Value)
            {
                if (tipo_cm.SelectedIndex != -1)
                {
                    if (fechaFin.Value != fechaSol.Value)
                    {
                        if (fechaIn.Value > fechaSol.Value)
                        {
                            if (fechaIn.Value != fechaSol.Value)
                            {
                                return true;
                            }
                            else
                            {
                                Mensajes.Error("La fecha inicio debe ser diferente a la fecha de solicitud");
                                return false;
                            }
                        }
                        else
                        {
                            Mensajes.Error("La fecha inicio es menor a la fecha solicitud");
                            return false;
                        }
                    }
                    else
                    {
                        Mensajes.Error("La fecha fin no debe ser igual a la fecha de solicitud ");
                        return false;
                    }

                }
                else
                {
                    Mensajes.Error("Seleccione un tipo de ausencia");
                    return false;
                }
            }
            else
            {
                Mensajes.Error("La fecha de inicio es menor que la de fin");
                return false;
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            char tipo = ' ';
            if (validarDatos() == true)
            {

                if (tipo_cm.SelectedItem.ToString() == "Vacaciones")
                {
                    tipo = 'V';
                }
                else if (tipo_cm.SelectedItem.ToString() == "Asuntos familiares")
                {
                    tipo = 'F';
                }

                Ausencia_justificada au = new Ausencia_justificada(
                    Convert.ToInt32(id_au.Value), fechaSol.Text, fechaIn.Text,
                   fechaFin.Text, tipo, empleadoA_cm.SelectedItem.ToString(), Convert.ToInt32(empleadoA_cm.SelectedValue.ToString()), this.empleadoS.Text, this.idEmpl, 'A');

                if (au_dao.editar(au))
                {
                    Mensajes.Info("Se edito correctamente");
                    Close();
                }
                else
                {
                    Mensajes.Error("Error al editar en la BD");
                }
            }
        }
    }
}
