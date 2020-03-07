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
    public partial class Deducciones_GUI : Form
    {
        Deducciones_DAO deducciones_DAO = new Deducciones_DAO();
        public Deducciones_GUI()
        {
            InitializeComponent();
        }

        private void llenarTabla(List<Deduccion> deducciones)
        {
            tablaDeducciones.Rows.Clear();
            foreach (Deduccion deduccion in deducciones)
            {
                DataGridViewRow renglon = new DataGridViewRow();
                renglon.CreateCells(tablaDeducciones);
                renglon.Cells[0].Value = deduccion.IdDeduccion;
                renglon.Cells[1].Value = deduccion.Nombre;
                renglon.Cells[2].Value = deduccion.Descripcion;
                renglon.Cells[3].Value = deduccion.Porcentaje;
                renglon.Cells[4].Value = deduccion.Estatus;
                tablaDeducciones.Rows.Add(renglon);
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
            llenarTabla(deducciones_DAO.consultaGeneral(consulta_wh, parametros, valores));
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableDdeducciones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {

                    DialogResult resultado = MessageBox.Show("¿Estás seguro que desea eliminar la deducción?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resultado == DialogResult.Yes)
                    {
                        DataGridViewRow renglon = tablaDeducciones.Rows[e.RowIndex];
                        int idPer = (int)renglon.Cells[0].Value;
                        deducciones_DAO.eliminar(idPer);
                        actualizarTabla();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Selecciona la deducción", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void nuevoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Deducciones_nuevo deducciones_Nuevo = new Deducciones_nuevo();
            deducciones_Nuevo.ShowDialog();
            actualizarTabla();
        }

        private void Deducciones_GUI_Load(object sender, EventArgs e)
        {
            actualizarTabla();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tablaDeducciones.SelectedRows.Count != -1)
            {
                DataGridViewRow row = tablaDeducciones.SelectedRows[0];

                Deduccion deduccion_editar = new Deduccion(
                    (int)row.Cells[0].Value,
                    (string)row.Cells[1].Value,
                    (string)row.Cells[2].Value,
                    (double)row.Cells[3].Value,
                    (char)row.Cells[4].Value
                    );
                Deducciones_editar deducciones_Editar = new Deducciones_editar(deduccion_editar);
                this.SetVisibleCore(false);
                deducciones_Editar.ShowDialog();
                this.SetVisibleCore(true);
                actualizarTabla();
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Selecciona la deducción", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tablaDeducciones.SelectedRows.Count != -1)
            {

                try
                {
                    DialogResult resultado = MessageBox.Show("¿Estás seguro que desea eliminar la deducción?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        DataGridViewRow row = tablaDeducciones.SelectedRows[0];
                        int idDeduccion = (int)row.Cells[0].Value;
                        deducciones_DAO.eliminar(idDeduccion);
                        actualizarTabla();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Selecciona la deducción", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (buscarDedTxt.Text.Equals(""))
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
                valores.Add(buscarDedTxt.Text);
                valores.Add('A');
                llenarTabla(deducciones_DAO.consultaGeneral(consulta_wh, parametros, valores));

            }
        }

        private void Deducciones_GUI_Load_1(object sender, EventArgs e)
        {
            actualizarTabla();
        }

        private void nuevoToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            Deducciones_nuevo deducciones = new Deducciones_nuevo();
            deducciones.ShowDialog();
            actualizarTabla();
        }

        private void editarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (tablaDeducciones.SelectedRows.Count != -1)
            {
                DataGridViewRow row = tablaDeducciones.SelectedRows[0];

                Deduccion deduccion_editar = new Deduccion(
                    (int)row.Cells[0].Value,
                    (string)row.Cells[1].Value,
                    (string)row.Cells[2].Value,
                    (double)row.Cells[3].Value,
                    (char)row.Cells[4].Value
                    );
                Deducciones_editar deducciones_Editar = new Deducciones_editar(deduccion_editar);
                this.SetVisibleCore(false);
                deducciones_Editar.ShowDialog();
                this.SetVisibleCore(true);
                actualizarTabla();
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Selecciona la deducción", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void eliminarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (tablaDeducciones.SelectedRows.Count != -1)
            {

                try
                {
                    DialogResult resultado = MessageBox.Show("¿Estás seguro que desea eliminar la deducción?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        DataGridViewRow row = tablaDeducciones.SelectedRows[0];
                        int idDeduccion = (int)row.Cells[0].Value;
                        deducciones_DAO.eliminar(idDeduccion);
                        actualizarTabla();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Selecciona la deducción", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
