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
    public partial class Empleados_nuevo : Form
    {
        Empleados_DAO empleadodao = new Empleados_DAO();
        Ciudades_DAO ciudadesdao = new Ciudades_DAO();
        Puestos_DAO puestosdao = new Puestos_DAO();
        Departamentos_DAO departamentosdao = new Departamentos_DAO();
        Sucursales_DAO sucursalesdao = new Sucursales_DAO();
        MemoryStream archivo_actual;
        Image imag;
        public Empleados_nuevo()
        {
            InitializeComponent();
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
                if (puesto.Samax <= salario_empleado.Value && puesto.Samin >= salario_empleado.Value) {
                    Empleado empleado_nuevo = new Empleado(0, nombre_empleado.Text, apaterno_empleado.Text, amaterno_empleado.Text, sexo_empleado.Text
                        , fcontratacion_empleado.Text, fnacimiento_empleado.Text, (double)salario_empleado.Value, nss_empleado.Text, estadocivil_empleado.Text,
                        (int)diasvacaciones_empleado.Value, (int)diaspermiso_empleado.Value, direccion_empleado.Text, colonia_empleado.Text, Convert.ToString(codigopostal_empleado.Value),
                        escolaridad_empleado.Text, (double)comision_empleado.Value, 'A', ((Departamento)departamento_empleado.Items[departamento_empleado.SelectedIndex]).idDepto,
                        ((Puesto)puesto_empleado.Items[puesto_empleado.SelectedIndex]).IdPuesto,
                        ((Ciudad)ciudad_empleado.Items[ciudad_empleado.SelectedIndex]).ID,
                        ((Sucursal)sucursal_empleado.Items[sucursal_empleado.SelectedIndex]).IdSucursal, imag);


                    try
                    {
                        if (empleadodao.validarEmpleado(empleado_nuevo))
                        {
                            if (empleadodao.registrar(empleado_nuevo))
                            {
                                Mensajes.Info("Insercion exitosa. Favor de llenar su horario.");
                                Horarios_editar horarios_Editar = new Horarios_editar(empleado_nuevo.IdEmpleado,
                                    empleado_nuevo.Nombre + " " + empleado_nuevo.Apaterno + " " + empleado_nuevo.Amaterno);
                                horarios_Editar.ShowDialog();
                                Close();
                            }

                            else
                            {
                                Mensajes.Error("Error al guardar el empleado");
                            }
                                
                        }
                        else {
                            Mensajes.Error("Error al Insertar. El empleado ya existe");
                            
                        }
                    }
                    catch (Exception ex)
                    {
                        Mensajes.Error("Error al insertar al empleado" + ex.Message);
                    }
                }
                else
                {
                    Mensajes.Error("El salario del empleado es mayor o menor al salario del puesto");
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

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog abrir = new OpenFileDialog()
            {
                ValidateNames = true,
                Multiselect=false, Filter="Imagen|*.jpg"
            })
            {
                if (abrir.ShowDialog() == DialogResult.OK)
                {
                    byte[] bt = File.ReadAllBytes(abrir.FileName);
                    archivo_actual = new MemoryStream(bt);
                    imag = new Bitmap(new Bitmap(new MemoryStream(bt)),new Size(120, 134));
                    img_1.Image = imag;
                }
            }
            
        }
    }
}


