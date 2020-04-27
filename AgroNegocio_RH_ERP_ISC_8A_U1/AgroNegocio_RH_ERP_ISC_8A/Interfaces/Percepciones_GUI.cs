using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgroNegocio_RH_ERP_ISC_8A.Modelo;
using AgroNegocio_RH_ERP_ISC_8A.Datos;


namespace AgroNegocio_RH_ERP_ISC_8A.Interfaces
{
    public partial class Percepciones_GUI : Form
    {
        Percepciones_DAO percepciones_DAO = new Percepciones_DAO();
        public Percepciones_GUI()
        {
            InitializeComponent();
        }

        private void llenarTabla(List<Percepcion> percepciones)
        {
            tablaPercepciones.Rows.Clear();
            foreach(Percepcion percepcion in percepciones)
            {
                DataGridViewRow renglon = new DataGridViewRow();
                renglon.CreateCells(tablaPercepciones);
                renglon.Cells[0].Value = percepcion.IdPercepcion;
                renglon.Cells[1].Value = percepcion.Nombre;
                renglon.Cells[2].Value = percepcion.Descripcion;
                renglon.Cells[3].Value = percepcion.DiasPagar;
                renglon.Cells[4].Value = percepcion.Estatus;
                tablaPercepciones.Rows.Add(renglon);
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void actualizarTabla()
        {
            String consulta_wh = "where estatus=@estatus";
            List<string> parametros = new List<string>();
            parametros.Add("@estatus");
            List<object> valores = new List<object>();
            valores.Add('A');
            llenarTabla(percepciones_DAO.consultaGeneral(consulta_wh, parametros, valores));
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tablePercepciones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {

                    DialogResult resultado = MessageBox.Show("¿Estás seguro que desea eliminar la percepción?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resultado == DialogResult.Yes)
                    {
                        DataGridViewRow renglon = tablaPercepciones.Rows[e.RowIndex];
                        int idPer = (int)renglon.Cells[0].Value;
                        percepciones_DAO.eliminar(idPer);
                        actualizarTabla();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else { 
                DialogResult resultado = MessageBox.Show("Selecciona la percepción", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void nuevoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Percepciones_nuevo percepciones_Nuevo = new Percepciones_nuevo();
            percepciones_Nuevo.ShowDialog();
            actualizarTabla();
        }

        private void Percepciones_GUI_Load(object sender, EventArgs e)
        {
            actualizarTabla();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tablaPercepciones.SelectedRows.Count != -1)
            {
                DataGridViewRow row = tablaPercepciones.SelectedRows[0];

                Percepcion percepcion_editar = new Percepcion(
                    (int)row.Cells[0].Value,
                    (string)row.Cells[1].Value,
                    (string)row.Cells[2].Value,
                    (int)row.Cells[3].Value,
                    (char) row.Cells[4].Value
                    );
                Percepciones_editar percepciones_Editar = new Percepciones_editar(percepcion_editar);
                this.SetVisibleCore(false);
                percepciones_Editar.ShowDialog();
                this.SetVisibleCore(true);
                actualizarTabla();
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Selecciona la percepción", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tablaPercepciones.SelectedRows.Count != -1) { 

                try
                {
                    DialogResult resultado = MessageBox.Show("¿Estás seguro que desea eliminar la percepción?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        DataGridViewRow row = tablaPercepciones.SelectedRows[0];
                        int idPercepcion = (int)row.Cells[0].Value;
                        percepciones_DAO.eliminar(idPercepcion);
                        actualizarTabla();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: "+ex.Message);
                }
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Selecciona la percepción", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if(buscarPerTxt.Text.Equals(" "))
            {
                DialogResult resultado = MessageBox.Show("No hay datos para buscar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); 

            }
            else
            {
                string consulta_wh = "where nombre like '%'+@nombre+'%'+ and estatus=@estatus";
                List<string> parametros = new List<string>();
                parametros.Add("@nombre");
                parametros.Add("@estatus");
                List<object> valores = new List<object>();
                valores.Add(buscarPerTxt.Text);
                valores.Add('A');
                llenarTabla(percepciones_DAO.consultaGeneral(consulta_wh, parametros, valores));

            }
        }

        private void buscarPerTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
