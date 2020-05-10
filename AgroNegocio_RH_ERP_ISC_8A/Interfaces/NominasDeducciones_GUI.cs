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
    public partial class NominasDeducciones_GUI : Form
    {
        int idEmp, idNomina;
        Empleados_DAO em_dao;
        Nomina_DAO nom_dao;
        Deducciones_DAO ded_dao;
        NominaDeduccion_DAO nd_dao;
        private List<NominaDeduccion> nd = new List<NominaDeduccion>();
        double salarioMin = 123.22;
        double salarioE;
        Nomina nomina;

        public NominasDeducciones_GUI()
        {
            InitializeComponent();
        }

        public NominasDeducciones_GUI(int idNomina, int idEmpleado)
        {
            InitializeComponent();
            this.idEmp = idEmpleado;
            this.idNomina = idNomina;
            em_dao = new Empleados_DAO();
            ded_dao = new Deducciones_DAO();
            nom_dao = new Nomina_DAO();
            nd_dao = new NominaDeduccion_DAO();
        }


        private void NominasDeducciones_GUI_Load(object sender, EventArgs e)
        {
            /* Llenar campos idNomina y Nombre de empleado*/
            id_nomina.Text = idNomina.ToString();
            empleadotxt.Text = em_dao.getNombre(idEmp);
            salarioE = em_dao.getSalario(idEmp);
            nomina = nom_dao.ExtraerNomina(idNomina);

            /*Llenar el combo de deducciones existentes en la BD*/
            string consulta_where="";
            if (salarioE <= salarioMin)
            {
                consulta_where = " where estatus=@estatus and nombre <>'ISR'";
            }
            else
            {
                consulta_where = " where estatus=@estatus";
            }         
            List<string> parametros = new List<string>();
            parametros.Add("@estatus");
            List<object> valores = new List<object>();
            valores.Add('A');
            List<Deduccion> deducciones  = ded_dao.consultaGeneral(consulta_where, parametros, valores);
            foreach (Deduccion deduc in deducciones)
            {
                deduccions.Items.Add(deduc);
            }

            Actualizar();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (deduccions.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona una Deducción");
            }
            else
            {
                Deduccion selecD = (Deduccion)deduccions.SelectedItem; //obtiene la deduccion seleccionada
                int d = selecD.IdDeduccion;

                if (!existeDeduccion(d))
                {
                    ////Guardar 
                    double SalarioTotal = salarioE * (nomina.diasTrabajados - nomina.faltas);
                    Console.WriteLine("Salario total: " + SalarioTotal);
                    double importe = (SalarioTotal * selecD.Porcentaje) / 100;
                    Console.WriteLine("porcentaje: " + selecD.Porcentaje);
                    double totalD = (double)nomina.totalD + importe;
                    double cantNeta = (double)nomina.cantidadNeta - importe;
                    Console.WriteLine("importe: " + importe + " cantidadNeta: " + cantNeta);
                    NominaDeduccion nominaD = new NominaDeduccion(Convert.ToInt32(id_nomina.Text), selecD.IdDeduccion, importe, 'A', selecD.Nombre, selecD.Descripcion);
                    if (nd_dao.registrar(nominaD, totalD, cantNeta))
                    {
                        Mensajes.Info("Se agregó la Deducción.");
                        Actualizar();
                    }
                    else
                    {
                        Mensajes.Error("Error al registrar NominaDeducción");
                    }
                }
                else
                {
                    Mensajes.Error("La Deducción ya está agregada.");
                }
            }
        }

        private Boolean existeDeduccion(int d) /*Consultar en la tabla si ya existe la deducción que se quiere agregar*/
        {
            foreach (DataGridViewRow row in tablaNominasD.Rows)
            {
                if (row.Cells["Id"].Value.Equals(d)) 
                {
                    return true;
                }
            }
            return false;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (tablaNominasD.SelectedRows.Count != -1)
            {

                try
                {
                    DialogResult resultado = MessageBox.Show("¿Estás seguro que desea eliminar la Deducción?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        DataGridViewRow row = tablaNominasD.SelectedRows[0];
                        int idDeduc = (int)row.Cells[0].Value;
                        double importe = (double)row.Cells[3].Value;
                        double totalD = (double)nomina.totalD - importe;
                        double cantNeta = (double)nomina.cantidadNeta + importe;
                        if(nd_dao.eliminar(idDeduc, idNomina, totalD, cantNeta))
                        {
                            MessageBox.Show("Se eliminó la Deducción.");
                            Actualizar();
                        }
                        else
                        {
                            MessageBox.Show("Error al borrar la Deducción.");
                        }   
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al intentar eliminar el departamento.");
                }
            }
            else
            {
                 MessageBox.Show("Selecciona la Deducción a eliminar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Actualizar()
        {
            /* Llenar la tabla de deduccines agregadas a la nomina*/
            nd = nd_dao.consultaGeneral(" where idNomina=@idNomina",
                new List<string>() { "@idNomina" },
                new List<object>() { idNomina });

            foreach (NominaDeduccion nd_temp in nd)
            {
                DataGridViewRow renglon = new DataGridViewRow();
                renglon.CreateCells(tablaNominasD);
                renglon.Cells[0].Value = nd_temp.idDeduccion;
                renglon.Cells[1].Value = nd_temp.nombre;
                renglon.Cells[2].Value = nd_temp.descripcion;
                renglon.Cells[3].Value = nd_temp.importe;
                tablaNominasD.Rows.Add(renglon);
            }
        }
    }
}
