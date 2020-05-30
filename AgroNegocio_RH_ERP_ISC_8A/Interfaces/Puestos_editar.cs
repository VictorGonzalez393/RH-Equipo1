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
    public partial class Puestos_editar : Form
    {
        private Puesto puesto;
        private Puestos_DAO puestos_DAO;
        public Puestos_editar(Puesto puesto)
        {
            InitializeComponent();
            this.puesto = puesto;
            puestos_DAO = new Puestos_DAO();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (validarCampos() == true)
            {
                puesto.Nombre = nombre_puesto.Text;
                puesto.Samin = samin_puesto.Value;
                puesto.Samax = samax_puesto.Value;
                try
                {
                    if (puestos_DAO.editar(puesto))
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
                    MessageBox.Show(ex.Message);

                }

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void id_puesto_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void nombre_puesto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void samin_puesto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void Puestos_editar_Load(object sender, EventArgs e)
        {
            nombre_puesto.Text = puesto.Nombre;
            samin_puesto.Value = puesto.Samin;
            samax_puesto.Value = puesto.Samax;
            id_puesto.Value = puesto.IdPuesto;
        }

        private bool validarCampos()
        {
            if (!string.IsNullOrWhiteSpace(nombre_puesto.Text))
            {
                if (samin_puesto.Value!=0)
                {
                    if (samax_puesto.Value!=0)
                    {
                        return true;
                    }
                    else
                    {
                        DialogResult resultado = MessageBox.Show("El campo de salario máximo se encuentra vacío", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("El campo de salario mínimo se encuentra vacío", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else
            {
                DialogResult resultado = MessageBox.Show("El campo de nombre se encuentra vacío", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void IniciotoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Principal pr = new Principal();
            this.SetVisibleCore(false);
            pr.ShowDialog();
            //Application.Exit();
        }

        private void btn_cancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_guardar_Click_1(object sender, EventArgs e)
        {
            if (validarCampos() == true)
            {
                puesto.Nombre = nombre_puesto.Text;
                puesto.Samin = samin_puesto.Value;
                puesto.Samax = samax_puesto.Value;
                try
                {
                    if (samin_puesto.Value < samax_puesto.Value)
                    {
                        if (puestos_DAO.editar(puesto))
                        {
                            DialogResult result = MessageBox.Show("Los datos se han editado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (result == DialogResult.OK)
                            {
                                Close();
                            }
                        }
                        else
                        {
                            Mensajes.Error("Error al editar");
                        }
                    }
                    else
                    {
                        Mensajes.Error("No puede ser el salario minimo mayor al maximo");
                    }
                }
                catch (Exception ex)
                {
                    Mensajes.Error("Error al editar el registro");
                    Console.WriteLine("Error: " + ex.Message);

                }

            }
        }

        private void backToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void IniciotoolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Principal pr = new Principal();
            this.SetVisibleCore(false);
            pr.ShowDialog();
        }
    }
}
    

