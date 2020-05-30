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
    

    public partial class Empleados_Editar : Form
    {
        private Empleado empleado;
        Empleados_DAO empleadodao = new Empleados_DAO();
        Ciudades_DAO ciudadesdao = new Ciudades_DAO();
        Puestos_DAO puestosdao = new Puestos_DAO();
        Departamentos_DAO departamentosdao = new Departamentos_DAO();
        Sucursales_DAO sucursalesdao = new Sucursales_DAO();
        MemoryStream archivo_actual;
        Image imag;

        public Empleados_Editar(Empleado empleado)
        {
            InitializeComponent();
            this.empleado = empleado;
            imag = empleadodao.GetImage(empleado.IdEmpleado);
        }

        private void cbx_Edo_civil_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Empleados_Editar_Load(object sender, EventArgs e)
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

            List<Sucursal> sucursales = sucursalesdao.consultaGeneral(consulta_where, parametros, valores);

            foreach (Sucursal sucursal in sucursales)
            {
                sucursal_empleado.Items.Add(sucursal);
            }

            nombre_empleado.Text = empleado.Nombre;
            apaterno_empleado.Text = empleado.Apaterno;
            amaterno_empleado.Text = empleado.Amaterno;
            sexo_empleado.SelectedItem = empleado.Sexo;
            fcontratacion_empleado.Text = empleado.FechaContratacion;
            fnacimiento_empleado.Text = empleado.FechaNacimiento;
            salario_empleado.Value = (decimal)empleado.Salario;
            nss_empleado.Text = empleado.Nss;
            estadocivil_empleado.SelectedItem = empleado.EstadoCivil;
            diasvacaciones_empleado.Value = empleado.DiasVacaciones;
            diaspermiso_empleado.Value = empleado.DiasPermiso;
            direccion_empleado.Text = empleado.Direccion;
            colonia_empleado.Text = empleado.Colonia;
            codigopostal_empleado.Text = empleado.CodigoPostal;
            escolaridad_empleado.SelectedItem = empleado.Escolaridad;
            comision_empleado.Value = (int)empleado.PorcentajeComision;
            img_1.Image = empleado.img;

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

            foreach (Ciudad ciudad in ciudad_empleado.Items)
            {
                if (ciudad.ID == empleado.IdCiudad)
                    ciudad_empleado.SelectedItem = ciudad;
            }

            foreach (Sucursal sucursal in sucursal_empleado.Items)
            {
                if (sucursal.IdSucursal == empleado.IdSucursal)
                    sucursal_empleado.SelectedItem = sucursal;
            }



        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (validarDatos() == true)
            {
                Puesto puesto = (Puesto)puesto_empleado.SelectedItem;
                if(salario_empleado.Value<=puesto.Samax && salario_empleado.Value >= puesto.Samin) { 

                        empleado.Nombre = nombre_empleado.Text;
                        empleado.Apaterno = apaterno_empleado.Text;
                        empleado.Amaterno = amaterno_empleado.Text;
                        empleado.Sexo = sexo_empleado.Text;
                        empleado.FechaContratacion = fcontratacion_empleado.Text;
                        empleado.FechaNacimiento = fnacimiento_empleado.Text;
                        empleado.Salario = (double)salario_empleado.Value;
                        empleado.Nss = nss_empleado.Text;
                        empleado.EstadoCivil = estadocivil_empleado.Text;
                        empleado.DiasVacaciones = (int)diasvacaciones_empleado.Value;
                        empleado.DiasPermiso = (int)diaspermiso_empleado.Value;
                        empleado.Direccion = direccion_empleado.Text;
                        empleado.Colonia = colonia_empleado.Text;
                        empleado.CodigoPostal = codigopostal_empleado.Text;
                        empleado.Escolaridad = escolaridad_empleado.Text;
                        empleado.PorcentajeComision = (double)comision_empleado.Value;
                        empleado.IdDepartamento = ((Departamento)departamento_empleado.Items[departamento_empleado.SelectedIndex]).idDepto;
                        empleado.IdPuesto = ((Puesto)puesto_empleado.Items[puesto_empleado.SelectedIndex]).IdPuesto;
                        empleado.IdCiudad = ((Ciudad)ciudad_empleado.Items[ciudad_empleado.SelectedIndex]).ID;
                        empleado.IdSucursal = ((Sucursal)sucursal_empleado.Items[sucursal_empleado.SelectedIndex]).IdSucursal;
                        empleado.img = imag;
                        try
                        {
                            if (empleadodao.editar(empleado))
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
                            Console.WriteLine("Error: "+ex.Message);
                            Mensajes.Error("Error al guardar el empleado");

                        }
                }
                else
                {
                    Mensajes.Error("El salario es menor o mayor al salario del puesto");
                }
            }
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
                                                                                        {
                                                                                            if (imag != null)
                                                                                            {

                                                                                                return true;

                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                Mensajes.Error("Falta la fotografía del empleado");
                                                                                                return false;
                                                                                            }
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            Mensajes.Error("Falta seleccionar la sucursal");
                                                                                            return false;
                                                                                        }

                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        Mensajes.Error("Falta la Ciudad");
                                                                                        return false;

                                                                                    }



                                                                                }
                                                                                else
                                                                                {
                                                                                    Mensajes.Error("Falta el Puesto");
                                                                                    return false;
                                                                                }
                                                                            }
                                                                            else
                                                                            {
                                                                                Mensajes.Error("Falta el Departamento");
                                                                                return false;
                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            Mensajes.Error("Falta la Comision");
                                                                            return false;
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        Mensajes.Error("Falta la Escolaridad");
                                                                        return false;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    Mensajes.Error("Falta el C.P");
                                                                    return false;
                                                                }

                                                            }
                                                            else
                                                            {
                                                                Mensajes.Error("Falta la Colonia");
                                                                return false;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            Mensajes.Error("Falta la Dirección");
                                                            return false;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        Mensajes.Error("Falta los Dias de Permiso");
                                                        return false;
                                                    }
                                                }
                                                else
                                                {
                                                    Mensajes.Error("Faltan los dias de Vacaciones ");
                                                    return false;
                                                }
                                            }
                                            else
                                            {
                                                Mensajes.Error("Falta el estado Civil ");
                                                return false;
                                            }
                                        }
                                        else
                                        {
                                            Mensajes.Error("Falta el NSS");
                                            return false;
                                        }
                                    }
                                    else
                                    {
                                        Mensajes.Error("Falta el Salario");
                                        return false;
                                    }
                                }
                                else
                                {
                                    Mensajes.Error("Falta la Fecha de Nacimiento ");
                                    return false;
                                }
                            }
                            else
                            {
                                Mensajes.Error("Falta la Fecha de Contratación ");
                                return false;
                            }
                        }
                        else
                        {
                            Mensajes.Error("Falta el sexo");
                            return false;
                        }
                    }
                    else
                    {
                        Mensajes.Error("Falta el Apellido Materno");
                        return false;
                    }
                }
                else
                {
                    Mensajes.Error("Falta el Apellido Paterno");
                    return false;
                }
            }
            else
            {
                Mensajes.Error("Falta el Nombre");
                return false;
            }
        }



        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nss_empleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SetVisibleCore(false);
            Principal p = new Principal();
            p.ShowDialog();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog abrir = new OpenFileDialog()
            {
                ValidateNames = true,
                Multiselect = false,
                Filter = "Imagen|*.jpg"
            })
            {
                if (abrir.ShowDialog() == DialogResult.OK)
                {
                    byte[] bt = File.ReadAllBytes(abrir.FileName);
                    archivo_actual = new MemoryStream(bt);
                    imag = new Bitmap(new Bitmap(new MemoryStream(bt)), new Size(120, 134));
                    img_1.Image = imag;
                }
            }
        }

        private void atrásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void puesto_empleado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
