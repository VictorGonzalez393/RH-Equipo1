﻿using System;
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
    public partial class Empleados_nuevo : Form
    {
        Empleados_DAO empleadodao = new Empleados_DAO();
        Ciudades_DAO ciudadesdao = new Ciudades_DAO();
        Puestos_DAO puestosdao = new Puestos_DAO();
        Departamentos_DAO departamentosdao = new Departamentos_DAO();
        public Empleados_nuevo()
        {
            InitializeComponent();
        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }





        private bool validarDatos()
        {
            if (!string.IsNullOrWhiteSpace(nombre_empleado.Text))
            {
                if (ciudad_empleado.SelectedIndex != -1)
                    return true;
                else
                {
                    MessageBox.Show("Falta la ciudad");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Falta el nombre");
                return false;
            }

        }






        private void btn_cancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SetVisibleCore(false);
            Principal p = new Principal();
            p.ShowDialog();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (validarDatos() == true)
            {
                Ciudad ciudad = (Ciudad)ciudad_empleado.SelectedItem;
                Departamento departamento = (Departamento)departamento_empleado.SelectedItem;
                Puesto puesto = (Puesto)puesto_empleado.SelectedItem;
                Empleado empleado_nuevo = new Empleado(0, nombre_empleado.Text, apaterno_empleado.Text, amaterno_empleado.Text, sexo_empleado.Text
                    , fcontratacion_empleado.Text, fnacimiento_empleado.Text, 0, nss_empleado.Text, estadocivil_empleado.Text, 0, 0, direccion_empleado.Text
                    , colonia_empleado.Text, 0, escolaridad_empleado.Text, 0, 'A', departamento.idDepto, puesto.IdPuesto, ciudad.ID, 0);
                try
                {
                    if (empleadodao.validarEmpleado(empleado_nuevo))
                    {
                        if (tablaHorario.Rows.Count > 0)
                        {
                            //List<Horario> horarios = new List<Horario>();
                            foreach (DataGridViewRow renglon in tablaHorario.Rows)
                            {
                                Horario horario_nuevo = new Horario(0,
                                    renglon.Cells["Inicio"].Value.ToString(),
                                    renglon.Cells["Fin"].Value.ToString(),
                                    renglon.Cells["Dia"].Value.ToString(),
                                    0,
                                    'A'
                                    );
                               empleado_nuevo.horarios.Add(horario_nuevo);
                            }
                            if (empleadodao.registrar(empleado_nuevo))
                            {
                                MessageBox.Show("Registro exitoso");
                                Close();
                            }
                            else
                                MessageBox.Show("Error al registrar");
                        }
                        else
                            MessageBox.Show("Error al registrar. No hay ningún horario de trabajo");

                    }
                    else
                        MessageBox.Show("Error al registrar. El empleado ya existe");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar al empleado");
                }
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Empleados_nuevo_Load(object sender, EventArgs e)
        {
            string consulta_where = " where estatus = @estatus";
            List<string> parametros = new List<string>();
            parametros.Add("@estatus");
            List<object> valores = new List<object>();
            valores.Add('A');

            List<Ciudad> ciudades = ciudadesdao.consultaGeneral(consulta_where, parametros, valores);

            foreach (Ciudad ciudad in ciudades)
            {
                ciudad_empleado.Items.Add(ciudad);
            }

            List<Puesto> puestos = puestosdao.consultaGeneral(consulta_where, parametros, valores);

            foreach (Puesto puesto in puestos)
            {
                puesto_empleado.Items.Add(puesto);
            }

            List<Departamento> departamentos = departamentosdao.consultaGeneral(consulta_where, parametros, valores);

            foreach (Departamento departamento in departamentos)
            {
                departamento_empleado.Items.Add(departamento);
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void agregar_Click(object sender, EventArgs e)
        {
            if (dias.SelectedIndex >= 0)
            {
                if (buscarDiaenTabla(dias.SelectedItem.ToString()))
                {
                    MessageBox.Show("El dia ya se agrego a la tabla", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //if (horaf.Value > horai.Value)
                    //{
                    //}
                    DataGridViewRow renglon = new DataGridViewRow();
                    renglon.CreateCells(tablaHorario);

                    renglon.Cells[0].Value = dias.SelectedItem.ToString();
                    renglon.Cells[1].Value = horai.Value.ToString("HH:mm:ss");
                    renglon.Cells[2].Value = horaf.Value.ToString("HH:mm:ss");
                    tablaHorario.Rows.Add(renglon);
                }

            }
            else
                MessageBox.Show("Selecciona un dia", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private bool buscarDiaenTabla(string dia)
        {
            bool bandera = false;
            foreach (DataGridViewRow renglon in tablaHorario.Rows)
            {
                if (renglon.Cells["Dia"].Value.ToString().Equals(dia))
                {
                    bandera = true;
                    break;
                }
            }
            return bandera;
        }

        private void tablaHorario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tablaHorario.Rows.Remove(tablaHorario.Rows[e.RowIndex]);
            }
        }

     
    }
}