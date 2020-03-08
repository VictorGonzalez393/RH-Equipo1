using AgroNegocio_RH_ERP_ISC_8A.Datos;
using AgroNegocio_RH_ERP_ISC_8A.Modelo;
using System;
using System.Windows.Forms;
namespace AgroNegocio_RH_ERP_ISC_8A.Interfaces
{
    public partial class Percepciones_editar : Form
    {
        private Percepcion percepcion;
        private Percepciones_DAO percepciones_DAO;
        public Percepciones_editar(Percepcion percepcion)
        {
            InitializeComponent();
            this.percepcion = percepcion;
            percepciones_DAO = new Percepciones_DAO();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (validarCampos() == true)
            {
                percepcion.Nombre = nombre_percepcion.Text;
                percepcion.Descripcion = descripcion_percepcion.Text;
                percepcion.DiasPagar =(int) dias_percepcion.Value;
                try
                {
                    if (percepciones_DAO.editar(percepcion))
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

                }catch(Exception ex)
                {
                    MessageBox.Show("Error al editar el registro");

                }

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void id_percepcion_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void nombre_percepcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void descriocion_percepcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Percepciones_editar_Load(object sender, EventArgs e)
        {
            nombre_percepcion.Text = percepcion.Nombre;
            descripcion_percepcion.Text = percepcion.Descripcion;
            dias_percepcion.Value = percepcion.DiasPagar;
            id_percepcion.Value = percepcion.IdPercepcion;
        }

        private bool validarCampos()
        {
            if (!string.IsNullOrWhiteSpace(nombre_percepcion.Text))
            {
                if (!string.IsNullOrWhiteSpace(descripcion_percepcion.Text))
                {
                    if (dias_percepcion.Value!=0)
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
    }
}
