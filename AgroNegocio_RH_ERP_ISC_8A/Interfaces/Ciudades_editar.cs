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
    public partial class Ciudades_editar : Form
    {
        private Ciudad ciudad;
        Estados_DAO estadoDAO = new Estados_DAO();
        Ciudades_DAO ciudadDAO = new Ciudades_DAO();
        public Ciudades_editar(Ciudad ciudad)
        {
            InitializeComponent();
            this.ciudad = ciudad;
        }

        private void Ciudades_editar_Load(object sender, EventArgs e)
        {
            string consulta_where = " where estatus = @estatus";
            List<string> parametros = new List<string>();
            parametros.Add("@estatus");
            List<object> valores = new List<object>();
            valores.Add('A');

            List<Estado> estados = estadoDAO.consultaGeneral(consulta_where, parametros, valores);

            foreach (Estado estado in estados)
            {
                estado_ciudad.Items.Add(estado);
            }


            nombre_ciudad.Text = ciudad.Nombre;

            foreach(Estado estado in estado_ciudad.Items)
            {
                if (estado.IdEstado == ciudad.IDEstado)
                    estado_ciudad.SelectedItem = estado;
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (validarDatos() == true)
            {
                ciudad.Nombre = nombre_ciudad.Text;
                ciudad.IDEstado = int.Parse(estado_ciudad.Items[estado_ciudad.SelectedIndex].ToString());
                try
                {
                    if (ciudadDAO.validarCiudadEditar(ciudad))
                    {
                        if (ciudadDAO.editar(ciudad))
                        {
                            MessageBox.Show("Edición exitosa");
                            Close();
                        }
                        else
                            MessageBox.Show("Error al editar");
                    }
                    else
                        MessageBox.Show("Error al editar. La ciudad ya existe");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private bool validarDatos()
        {
            if (!string.IsNullOrWhiteSpace(nombre_ciudad.Text))
            {
                if (estado_ciudad.SelectedIndex != -1)
                    return true;
                else
                {
                    MessageBox.Show("Falta el estado");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Falta el nombre");
                return false;
            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
