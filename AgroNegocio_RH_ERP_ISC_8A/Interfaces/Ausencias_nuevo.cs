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
    public partial class Ausencias_nuevo : Form
    {
        Empleados_DAO em_dao;
        Ausencias_justificadas_DAO au_dao;
        int idEs = 0;
        public Ausencias_nuevo(string nombre, int idES)
        {
            InitializeComponent();
            au_dao = new Ausencias_justificadas_DAO();
            id_au.Value = au_dao.getMaxID();
            empleadoS.Text = nombre;
            idEs = idES;
        }

        private void Ausencias_nuevo_Load(object sender, EventArgs e)
        {
            var lista = new Datos.Empleados_DAO().consultaGeneral2("where estatus='A' and idEmpleado <> "+idEs, new List<string>(), new List<object>());
            empleadoA_cm.DisplayMember = "NombreCompleto";
            empleadoA_cm.ValueMember = "IdEmpleado";
            empleadoA_cm.DataSource = lista;
            tipo_cm.Items.Add("Vacaciones");
            tipo_cm.Items.Add("Asuntos familiares");
        }

        private void atrásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Principal p = new Principal();
            SetVisibleCore(false);
            p.ShowDialog();
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

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            char tipo = ' ';
            if (validarDatos() == true)
            {
                
                if (tipo_cm.SelectedItem.ToString()=="Vacaciones")
                {
                    tipo = 'V';
                }
                else if(tipo_cm.SelectedItem.ToString() == "Asuntos familiares")
                {
                    tipo = 'F';
                }

                Ausencia_justificada au = new Ausencia_justificada(
                    Convert.ToInt32(id_au.Value), fechaSol.Text, fechaIn.Text,
                   fechaFin.Text,tipo,empleadoA_cm.SelectedItem.ToString(),Convert.ToInt32(empleadoA_cm.SelectedValue.ToString()), this.empleadoS.Text,this.idEs,'A');

                if (au_dao.registrar(au))
                {
                    Mensajes.Info("Se registro correctamente");
                    Close();
                }
                else
                {
                    Mensajes.Error("Error al registrar en la BD");
                }
            }

        }

        private bool validarDatos()
        {
            if (fechaIn.Value < fechaFin.Value )
            {
                if (tipo_cm.SelectedIndex != -1)
                {
                    if(fechaFin.Value != fechaSol.Value)
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
    }
}
