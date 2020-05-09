﻿using AgroNegocio_RH_ERP_ISC_8A.Datos;
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
    public partial class Ciudades_nuevo : Form
    {
        Estados_DAO estadoDAO = new Estados_DAO();
        Ciudades_DAO ciudadDAO = new Ciudades_DAO();
        public Ciudades_nuevo()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Ciudades_nuevo_Load(object sender, EventArgs e)
        {
            string consulta_where = " where estatus = @estatus";
            List<string> parametros = new List<string>();
            parametros.Add("@estatus");
            List<object> valores = new List<object>();
            valores.Add('A');

            List<Estado> estados = estadoDAO.consultaGeneral(consulta_where, parametros, valores);

            foreach(Estado estado in estados)
            {
                estado_ciudad.Items.Add(estado);
            }

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (validarDatos()==true)
            {
                Estado estado = (Estado)estado_ciudad.SelectedItem;
                Ciudad ciudad_nueva = new Ciudad(0, nombre_ciudad.Text, 
                   estado.IdEstado, 'A');
                try
                {
                    if (ciudadDAO.validarCiudad(ciudad_nueva))
                    {
                        if (ciudadDAO.registrar(ciudad_nueva))
                        {
                            MessageBox.Show("Registro exitoso");
                            Close();
                        }
                        else
                            MessageBox.Show("Error al registrar");
                    }
                    else
                        MessageBox.Show("Error al registrar. La ciudad ya existe");
                }
                catch(Exception ex)
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