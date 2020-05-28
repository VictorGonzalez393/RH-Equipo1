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
    public partial class HistorialPuestos_Editar : Form
    {
       private HistorialPuesto historial;
        Empleados_DAO empleadodao = new Empleados_DAO();
        Ciudades_DAO ciudadesdao = new Ciudades_DAO();
        Puestos_DAO pues_dao = new Puestos_DAO();
        Departamentos_DAO dep_dao = new Departamentos_DAO();
        Sucursales_DAO sucursalesdao = new Sucursales_DAO();
        HistorialesPuestos_DAO hist_dao = new HistorialesPuestos_DAO();
        public HistorialPuestos_Editar(HistorialPuesto historial)
        {
            InitializeComponent();
            this.historial = historial;
        }

        public HistorialPuestos_Editar()
        {
        }

        private void HistorialPuestos_Editar_Load(object sender, EventArgs e)
        {
            string consulta_where = " where estatus = @estatus";
            List<string> parametros = new List<string>();
            parametros.Add("@estatus");
            List<object> valores = new List<object>();
            valores.Add('A');
            List<Puesto> puestos = pues_dao.consultaGeneral(consulta_where, parametros, valores);
            foreach (Puesto pues in puestos)
            {
                historialpuesto_puesto.Items.Add(pues);
            }

            List<Departamento> departamentos = dep_dao.consultaGeneral(consulta_where, parametros, valores);
            foreach (Departamento dep in departamentos)
            {
                historialpuesto_departamento.Items.Add(dep);
            }


            foreach (Puesto puesto in historialpuesto_puesto.Items)
            {
                if (puesto.IdPuesto == historial.idPuesto)
                    historialpuesto_puesto.SelectedItem = puesto;
            }

            foreach (Departamento departamento in historialpuesto_departamento.Items)
            {
                if (departamento.idDepto == historial.idDepartamento)
                    historialpuesto_departamento.SelectedItem = departamento;
            }

            historialpuesto_finicio.Text = historial.FechaInicio;
            historialpuesto_ffin.Text = historial.FechaFin;
            salario1.Value = (decimal)historial.Salario;
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SetVisibleCore(false);
            Principal p = new Principal();
            p.ShowDialog();
        }

        private void atrásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool validarCampos()
        {
            if (!string.IsNullOrWhiteSpace(historialpuesto_puesto.Text))
            {
                if (!string.IsNullOrWhiteSpace(historialpuesto_departamento.Text))
                {
                    if (!string.IsNullOrWhiteSpace(historialpuesto_ffin.Text))
                    {
                        if (!string.IsNullOrWhiteSpace(historialpuesto_finicio.Text))
                        {
                            if (salario1.Value != 0)
                            {
                                return true;
                            }
                            else
                            {
                                DialogResult resultado = MessageBox.Show("El campo Salario se encuentra vacío", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return false;
                            }
                        }
                        else
                        {
                            DialogResult resultado = MessageBox.Show("El campo Fecha Inicio se encuentra vacío", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                    else
                    {
                        DialogResult resultado = MessageBox.Show("El campo Fecha Fin se encuentra vacío", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("El campo Departamento se encuentra vacío", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else
            {
                DialogResult resultado = MessageBox.Show("El campo Puesto se encuentra vacío", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (validarCampos() == true)
            {
                historial.idEmpleado = (int)ID.Value;
                historial.idPuesto = ((Puesto)historialpuesto_puesto.Items[historialpuesto_puesto.SelectedIndex]).IdPuesto;
                historial.idDepartamento = ((Departamento)historialpuesto_departamento.Items[historialpuesto_departamento.SelectedIndex]).idDepto;
                historial.FechaInicio = historialpuesto_finicio.Text;
                historial.FechaFin = historialpuesto_ffin.Text;
                historial.Salario = (double)salario1.Value;

               
                try
                {
                    if (hist_dao.editar(historial))
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

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
