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
    public partial class Empleados_nuevo : Form
    {
        Empleados_DAO empleadodao = new Empleados_DAO();
        Ciudades_DAO ciudadesdao = new Ciudades_DAO();
        Puestos_DAO puestosdao = new Puestos_DAO();
        Departamentos_DAO departamentosdao = new Departamentos_DAO();
        Sucursales_DAO sucursalesdao = new Sucursales_DAO();
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
                if (!string.IsNullOrWhiteSpace(apaterno_empleado.Text))
                {

                    if (!string.IsNullOrWhiteSpace(amaterno_empleado.Text))

                    {
                        if (sexo_empleado.SelectedIndex != -1)

                        {
                            if (!string.IsNullOrWhiteSpace(fcontratacion_empleado.Text))

                            {
                                if (!string.IsNullOrWhiteSpace(fnacimiento_empleado.Text))

                                {
                                    if (salario_empleado.Value != 0)

                                    {
                                        if (!string.IsNullOrWhiteSpace(nss_empleado.Text))

                                        {
                                            if (estadocivil_empleado.SelectedIndex != -1)

                                            {
                                                if (diasvacaciones_empleado.Value != 0)

                                                {
                                                    if (diaspermiso_empleado.Value != 0)

                                                    {
                                                        if (!string.IsNullOrWhiteSpace(direccion_empleado.Text))

                                                        {
                                                            if (!string.IsNullOrWhiteSpace(colonia_empleado.Text))

                                                            {
                                                                if (codigopostal_empleado.Value != 0)

                                                                {
                                                                    if (escolaridad_empleado.SelectedIndex != -1)

                                                                    {
                                                                        if (comision_empleado.Value != 0)

                                                                        {
                                                                            if (departamento_empleado.SelectedIndex != -1)

                                                                            {
                                                                                if (puesto_empleado.SelectedIndex != -1)

                                                                                {
                                                                                    if (ciudad_empleado.SelectedIndex != -1)

                                                                                    {
                                                                                        if (sucursal_empleado.SelectedIndex != -1)
                                                                                            return true;


                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        MessageBox.Show("Falta la Ciudad");

                                                                                    }



                                                                                }
                                                                                else
                                                                                {
                                                                                    MessageBox.Show("Falta el Puesto");
                                                                                    return false;
                                                                                }
                                                                            }
                                                                            else
                                                                            {
                                                                                MessageBox.Show("Falta el Departamento");
                                                                                return false;
                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            MessageBox.Show("Falta la Comision");
                                                                            return false;
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        MessageBox.Show("Falta la Escolaridad");
                                                                        return false;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    MessageBox.Show("Falta el C.P");
                                                                    return false;
                                                                }

                                                            }
                                                            else
                                                            {
                                                                MessageBox.Show("Falta la Colonia");
                                                                return false;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Falta la Dirección");
                                                            return false;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Falta los Dias de Permiso");
                                                        return false;
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Faltan los dias de Vacaciones ");
                                                    return false;
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Falta el estado Civi ");
                                                return false;
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Falta el NSS");
                                            return false;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Falta el Salario");
                                        return false;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Falta la Fecha de Nacimiento ");
                                    return false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Falta la Fecha de Contratación ");
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Falta el sexo");
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Falta el Apellido Materno");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Falta el Apellido Paterno");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Falta el Nombre");
                return false;
            }
            return false;
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
                Sucursal sucursal = (Sucursal)sucursal_empleado.SelectedItem;
                Empleado empleado_nuevo = new Empleado(0, nombre_empleado.Text, apaterno_empleado.Text, amaterno_empleado.Text, sexo_empleado.Text
                    , fcontratacion_empleado.Text, fnacimiento_empleado.Text, 0, nss_empleado.Text, estadocivil_empleado.Text, 0, 0, direccion_empleado.Text
                    , colonia_empleado.Text, codigopostal_empleado.Text, escolaridad_empleado.Text, 0, 'A', departamento.idDepto, puesto.IdPuesto, ciudad.ID, sucursal.IdSucursal);
                try
                {
                    if (empleadodao.validarEmpleado(empleado_nuevo))
                    {
                        if (empleadodao.registrar(empleado_nuevo))
                        {
                            MessageBox.Show("Insercion exitosa. Favor de llenar su horario.");
                            Horarios_editar horarios_Editar = new Horarios_editar(empleado_nuevo.IdEmpleado,
                                empleado_nuevo.Nombre + " " + empleado_nuevo.Apaterno + " " + empleado_nuevo.Amaterno);
                            Close();
                        }
                        else
                            MessageBox.Show("Error al Insertar");
                    }
                    else
                        MessageBox.Show("Error al Insertar. El empleado ya existe");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar al empleado wey" + ex.Message);
                }

            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Empleados_nuevo_Load(object sender, EventArgs e)
        {
            id_empleado.Value = empleadodao.getMaxID();

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

            List<Sucursal> sucursales = sucursalesdao.consultaGeneral(consulta_where, parametros, valores);

            foreach (Sucursal sucursal in sucursales)
            {
                sucursal_empleado.Items.Add(sucursal);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

            }
        }
    }
}


