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
    public partial class HistorialPuestos_Nuevo : Form
    {
        public int idEmp { get; set; }
        Empleados_DAO em_dao;
        Puestos_DAO pues_dao;
        Departamentos_DAO dep_dao;
        HistorialesPuestos_DAO hist_dao;
        public HistorialPuestos_Nuevo(Empleado emp, int idEmpleado)
        {
            InitializeComponent();
            this.idEmp = idEmpleado;
            this.historialpuesto_id.Text = Convert.ToString(emp.IdEmpleado);
            this.historialpuesto_nombre.Text = emp.Nombre+" "+emp.Apaterno+" "+emp.Amaterno;
            this.historialpuesto_finicio.Text = emp.FechaContratacion;
            this.salario.Text = Convert.ToString(emp.Salario);
            em_dao = new Empleados_DAO();
            pues_dao = new Puestos_DAO();
            dep_dao = new Departamentos_DAO();
            hist_dao = new HistorialesPuestos_DAO();

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

            if (validarCampos() == true)
            {
                HistorialPuesto historial = new HistorialPuesto((int)historialpuesto_id.Value, ((Puesto)puesto.Items[puesto.SelectedIndex]).IdPuesto, ((Departamento)departamento.Items[departamento.SelectedIndex]).idDepto, historialpuesto_finicio.Text, historialpuesto_ffin.Text,
                    (double)salario.Value);
                try
                {
                  
                        hist_dao.registrar(historial);
                        Mensajes.Info("Registro realizado exitosamente");
                        Close();
                   

                }
                catch (Exception)
                {
                    Mensajes.Error("Error al registrar el Historial.");
                }

            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HistorialPuestos_Nuevo_Load(object sender, EventArgs e)
        {
            string consulta_where = " where estatus = @estatus";
            List<string> parametros = new List<string>();
            parametros.Add("@estatus");
            List<object> valores = new List<object>();
            valores.Add('A');
            List<Puesto> puestos = pues_dao.consultaGeneral(consulta_where, parametros, valores);
            foreach (Puesto pues in puestos)
            {
                puesto.Items.Add(pues);
            }

            List<Departamento> departamentos = dep_dao.consultaGeneral(consulta_where, parametros, valores);
            foreach (Departamento dep in departamentos)
            {
                departamento.Items.Add(dep);
            }

        }

        private void IniciotoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Principal pr = new Principal();
            this.SetVisibleCore(false);
            pr.ShowDialog();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool validarCampos()
        {
            if (!string.IsNullOrWhiteSpace(puesto.Text))
            {
                if (!string.IsNullOrWhiteSpace(departamento.Text))
            {
                if (!string.IsNullOrWhiteSpace(historialpuesto_ffin.Text))
            {
                if (!string.IsNullOrWhiteSpace(historialpuesto_finicio.Text))
                {
                    if (salario.Value != 0)
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
    }
}
