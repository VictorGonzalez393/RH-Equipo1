using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgroNegocio_RH_ERP_ISC_8A.Datos;
using AgroNegocio_RH_ERP_ISC_8A.Modelo;

namespace AgroNegocio_RH_ERP_ISC_8A.Interfaces
{
    public partial class Empleados_editarH : Form
    {
        private Empleado empleado;
        Empleados_DAO empleadodao = new Empleados_DAO();
        Ciudades_DAO ciudadesdao = new Ciudades_DAO();
        Puestos_DAO puestosdao = new Puestos_DAO();
        Departamentos_DAO departamentosdao = new Departamentos_DAO();
        Sucursales_DAO sucursalesdao = new Sucursales_DAO();
        HistorialesPuestos_DAO hist_dao = new HistorialesPuestos_DAO();
        MemoryStream archivo_actual;
        Image imag;
        public Empleados_editarH(Empleado empleado)
        {
            InitializeComponent();
            this.empleado = empleado;
        }

        private void Empleados_editarH_Load(object sender, EventArgs e)
        {
            string consulta_where = " where estatus = @estatus";
            List<string> parametros = new List<string>();
            parametros.Add("@estatus");
            List<object> valores = new List<object>();
            valores.Add('A');

            //List<Ciudad> ciudades = ciudadesdao.consultaGeneral(consulta_where, parametros, valores);

            //foreach (Ciudad ciudad in ciudades)
            //{
            //    ciudad_empleado.Items.Add(ciudad);
            //}

            List<Puesto> puestos = puestosdao.consultaGeneral(consulta_where, parametros, valores);

            foreach (Puesto puesto in puestos)
            {
                puesto_empleado.Items.Add(puesto);
            }

            foreach (Puesto puesto in puestos)
            {
                pues.Items.Add(puesto);
            }

            List<Departamento> departamentos = departamentosdao.consultaGeneral(consulta_where, parametros, valores);

            foreach (Departamento departamento in departamentos)
            {
                departamento_empleado.Items.Add(departamento);
            }

            foreach (Departamento departamento in departamentos)
            {
                dep.Items.Add(departamento);
            }


            //List<Sucursal> sucursales = sucursalesdao.consultaGeneral(consulta_where, parametros, valores);

            //foreach (Sucursal sucursal in sucursales)
            //{
            //    sucursal_empleado.Items.Add(sucursal);
            //}

            ID.Value = (int)empleado.IdEmpleado;
            //apaterno_empleado.Text = empleado.Apaterno;
            //amaterno_empleado.Text = empleado.Amaterno;
            //sexo_empleado.SelectedItem = empleado.Sexo;
            finicio.Text = empleado.FechaContratacion;
            //fnacimiento_empleado.Text = empleado.FechaNacimiento;
            Salario.Value = (decimal)empleado.Salario;
            //nss_empleado.Text = empleado.Nss;
            //estadocivil_empleado.SelectedItem = empleado.EstadoCivil;
            //diasvacaciones_empleado.Value = empleado.DiasVacaciones;
            //diaspermiso_empleado.Value = empleado.DiasPermiso;
            //direccion_empleado.Text = empleado.Direccion;
            //colonia_empleado.Text = empleado.Colonia;
            //codigopostal_empleado.Text = empleado.CodigoPostal;
            //escolaridad_empleado.SelectedItem = empleado.Escolaridad;
            //comision_empleado.Value = (int)empleado.PorcentajeComision;
            //img_1.Image = empleado.img;

            foreach (Departamento departamento in departamento_empleado.Items)
            {
                if (departamento.idDepto == empleado.IdDepartamento)
                    departamento_empleado.SelectedItem = departamento;
            }

            foreach (Puesto puesto in puesto_empleado.Items)
            {
                if (puesto.IdPuesto == empleado.IdPuesto)
                    puesto_empleado.SelectedItem = puesto;
            }

            foreach (Departamento departamento in departamento_empleado.Items)
            {
                if (departamento.idDepto == empleado.IdDepartamento)
                    departamento_empleado.SelectedItem = departamento;
            }

            foreach (Puesto puesto in puesto_empleado.Items)
            {
                if (puesto.IdPuesto == empleado.IdPuesto)
                    puesto_empleado.SelectedItem = puesto;
            }

            //foreach (Ciudad ciudad in ciudad_empleado.Items)
            //{
            //    if (ciudad.ID == empleado.IdCiudad)
            //        ciudad_empleado.SelectedItem = ciudad;
            //}

            //foreach (Sucursal sucursal in sucursal_empleado.Items)
            //{
            //    if (sucursal.IdSucursal == empleado.IdSucursal)
            //        sucursal_empleado.SelectedItem = sucursal;
            //}
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (validarCampos() == true)
            {
                empleado.IdEmpleado = (int)ID.Value;
                //empleado.Nombre = nombre_empleado.Text;
                //empleado.Apaterno = apaterno_empleado.Text;
                //empleado.Amaterno = amaterno_empleado.Text;
                //empleado.Sexo = sexo_empleado.Text;
                empleado.FechaContratacion = finicio1.Text;
                //empleado.FechaNacimiento = fnacimiento_empleado.Text;
                empleado.Salario = (double)Salario1.Value;
                //empleado.Nss = nss_empleado.Text;
                //empleado.EstadoCivil = estadocivil_empleado.Text;
                //empleado.DiasVacaciones = (int)diasvacaciones_empleado.Value;
                //empleado.DiasPermiso = (int)diaspermiso_empleado.Value;
                //empleado.Direccion = direccion_empleado.Text;
                //empleado.Colonia = colonia_empleado.Text;
                //empleado.CodigoPostal = codigopostal_empleado.Text;
                //empleado.Escolaridad = escolaridad_empleado.Text;
                //empleado.PorcentajeComision = (double)comision_empleado.Value;
                empleado.IdDepartamento = ((Departamento)dep.Items[dep.SelectedIndex]).idDepto;
                empleado.IdPuesto = ((Puesto)pues.Items[pues.SelectedIndex]).IdPuesto;
                //empleado.IdCiudad = ((Ciudad)ciudad_empleado.Items[ciudad_empleado.SelectedIndex]).ID;
                //empleado.IdSucursal = ((Sucursal)sucursal_empleado.Items[sucursal_empleado.SelectedIndex]).IdSucursal;
                //empleado.img = imag;
                try
                {
                    if (empleadodao.editar(empleado))
                    {

                        DialogResult result = MessageBox.Show("Los datos se han editado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (validarCampos() == true)
                        {
                            HistorialPuesto historial = new HistorialPuesto((int)ID.Value, ((Puesto)puesto_empleado.Items[puesto_empleado.SelectedIndex]).IdPuesto, ((Departamento)departamento_empleado.Items[departamento_empleado.SelectedIndex]).idDepto, finicio.Text, ffin.Text,
                                (double)Salario.Value);
                            try
                            {

                                hist_dao.registrar(historial);
                                MessageBox.Show("Registro realizado exitosamente");
                                Close();


                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Error al registrar el Historial.");
                            }

                        }
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

        private void atrásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SetVisibleCore(false);
            Principal p = new Principal();
            p.ShowDialog();
        }

        private bool validarCampos()
        {
            if (!string.IsNullOrWhiteSpace(pues.Text))
            {
                if (!string.IsNullOrWhiteSpace(dep.Text))
                {
                    if (!string.IsNullOrWhiteSpace(ffin.Text))
                    {
                        if (!string.IsNullOrWhiteSpace(finicio.Text))
                        {
                            if (Salario.Value != 0)
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
