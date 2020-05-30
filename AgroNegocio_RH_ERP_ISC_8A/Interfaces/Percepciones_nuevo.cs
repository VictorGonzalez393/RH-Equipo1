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
    public partial class Percepciones_nuevo : Form
    {
        Percepciones_DAO percepciones_DAO;
        public Percepciones_nuevo()
        {
            InitializeComponent();
            percepciones_DAO = new Percepciones_DAO();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Principal pr = new Principal();
            this.SetVisibleCore(false);
            pr.ShowDialog();
            //Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Percepciones_nuevo_Load(object sender, EventArgs e)
        {
            
            id_percepcion.Value = percepciones_DAO.getMaxID();
        }

        private bool validarCampos()
        {
            if (!string.IsNullOrWhiteSpace(nombre_percepcion.Text))
            {
                if (!string.IsNullOrWhiteSpace(descriocion_percepcion.Text))
                {
                    if (dias_percepcion.Value != 0)
                    {
                        return true;
                    }
                    else
                    {
                        DialogResult resultado = MessageBox.Show("El campo de días a pagar se encuentra vacío", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("El campo de descripción se encuentra vacío", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else
            {
                DialogResult resultado = MessageBox.Show("El campo de nombre se encuentra vacío", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (validarCampos() == true)
            {
                Percepcion percepcion_new = new Percepcion(0, nombre_percepcion.Text, descriocion_percepcion.Text, (int)dias_percepcion.Value, 'A');
                try
                {
                    if (percepciones_DAO.validarPercepcion(percepcion_new)) { 

                        percepciones_DAO.registrar(percepcion_new);
                        Mensajes.Info("Registro realizado exitosamente");
                        Close();
                    }
                    else
                    {
                        Mensajes.Error("La percepción ya se encuentra registrada");
                    }
                } 
                catch(Exception ex)
                {
                    Mensajes.Error("Error al registrar la percepción");
                    Console.WriteLine("Error: " + ex.Message);
                }

            }
        }

        private void dias_percepcion_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
