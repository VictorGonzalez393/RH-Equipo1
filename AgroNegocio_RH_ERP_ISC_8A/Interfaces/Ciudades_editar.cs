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
        Ciudades_DAO ciudadDAO = new Ciudades_DAO();
        public Ciudades_editar(Ciudad ciudad)
        {
            InitializeComponent();
            this.ciudad = ciudad;
        }

        private void Ciudades_editar_Load(object sender, EventArgs e)
        {
            nombre_ciudad.Text = ciudad.Nombre;
            for(int i = 0; i< estado_ciudad.Items.Count; i++)
            {
                if(ciudad.IDEstado.ToString().Equals(estado_ciudad.Items[i]))
                {
                    estado_ciudad.SelectedIndex = i;
                }
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
