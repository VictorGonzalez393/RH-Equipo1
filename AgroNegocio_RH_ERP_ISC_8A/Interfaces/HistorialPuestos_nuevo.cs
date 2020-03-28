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
 
    public partial class HistorialPuestos_nuevo : Form
    {
        Puestos_DAO puestosdao = new Puestos_DAO();
        Departamentos_DAO departamentosdao = new Departamentos_DAO();
        Empleados_DAO empleadosdao = new Empleados_DAO();
        HistorialPuestos_DAO historialdao = new HistorialPuestos_DAO();
        public HistorialPuestos_nuevo()
        {
            InitializeComponent();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HistorialPuestos_nuevo_Load(object sender, EventArgs e)
        {
            string consulta_where = " where estatus = @estatus";
            List<string> parametros = new List<string>();
            parametros.Add("@estatus");
            List<object> valores = new List<object>();
            valores.Add('A');

            List<Empleado> empleados = empleadosdao.consultaGeneral(consulta_where, parametros, valores);

            foreach (Empleado empleado in empleados)
            {
                empleado_historial.Items.Add(empleado);
            }

            List<Puesto> puestos = puestosdao.consultaGeneral(consulta_where, parametros, valores);

            foreach (Puesto puesto in puestos)
            {
                puesto_historial.Items.Add(puesto);
            }

            List<Departamento> departamentos = departamentosdao.consultaGeneral(consulta_where, parametros, valores);

            foreach (Departamento departamento in departamentos)
            {
                departamento_historial.Items.Add(departamento);
            }


        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Empleado empleado = (Empleado)empleado_historial.SelectedItem;
            Puesto puesto = (Puesto)puesto_historial.SelectedItem;
            Departamento departamento = (Departamento)departamento_historial.SelectedItem;
            HistorialPuesto historial_nuevo = new HistorialPuesto(empleado.IdEmpleado,puesto.IdPuesto,departamento.idDepto,finicio_historial.Value,ffin_historial.Text,0);
            try
            {
               
                    if (historialdao.registrar(historial_nuevo))
                    {
                        MessageBox.Show("Insercion exitosa");
                        Close();
                    }
                    else
                        MessageBox.Show("Error al Insertar");
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar al empleado wey" + ex.Message);
            }
        }
    }
}
