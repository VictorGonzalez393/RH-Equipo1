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
    public partial class Estados_GUI : Form
    {
        Estados_DAO estados_DAO = new Estados_DAO();
        public Estados_GUI()
        {
            InitializeComponent();
        }

        private void llenarTabla(List<Estado> estados)
        {
            tablaEstados.Rows.Clear();
            foreach (Estado estado in estados)
            {
                DataGridViewRow renglon = new DataGridViewRow();
                renglon.CreateCells(tablaEstados);
                renglon.Cells[0].Value = estado.IdEstado;
                renglon.Cells[1].Value = estado.Nombre;
                renglon.Cells[2].Value = estado.Siglas;
                renglon.Cells[3].Value = estado.Estatus;
                tablaEstados.Rows.Add(renglon);
            }
        }
        private void actualizarTabla()
        {
            String consulta_wh = "where estatus=@estatus";
            List<string> parametros = new List<string>();
            parametros.Add("@estatus");
            List<object> valores = new List<object>();
            valores.Add('A');
            llenarTabla(estados_DAO.consultaGeneral(consulta_wh, parametros, valores));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {

                    DialogResult resultado = MessageBox.Show("¿Estás seguro que desea eliminar el estadp?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resultado == DialogResult.Yes)
                    {
                        DataGridViewRow renglon = tablaEstados.Rows[e.RowIndex];
                        int idE = (int)renglon.Cells[0].Value;
                        estados_DAO.eliminar(idE);
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
                DialogResult resultado = MessageBox.Show("Selecciona el estado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estados_nuevo estados_Nuevo = new Estados_nuevo();
            estados_Nuevo.ShowDialog();
            actualizarTabla();
        }

        private void Estados_GUI_Load(object sender, EventArgs e)
        {
            actualizarTabla();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tablaEstados.SelectedRows.Count != -1)
            {
                DataGridViewRow row = tablaEstados.SelectedRows[0];

                Estado estado_editar = new Estado(
                    (int)row.Cells[0].Value,
                    (string)row.Cells[1].Value,
                    (string)row.Cells[2].Value,
                    (char)row.Cells[3].Value
                    );
                Estados_editar estados_Editar = new Estados_editar(estado_editar);
                this.SetVisibleCore(false);
                estados_Editar.ShowDialog();
                this.SetVisibleCore(true);
                actualizarTabla();
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Selecciona el estado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tablaEstados.SelectedRows.Count != -1)
            {

                try
                {
                    DialogResult resultado = MessageBox.Show("¿Estás seguro que desea eliminar el estado?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        DataGridViewRow row = tablaEstados.SelectedRows[0];
                        int idEstado = (int)row.Cells[0].Value;
                        estados_DAO.eliminar(idEstado);
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
                DialogResult resultado = MessageBox.Show("Selecciona el Estado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (buscarEstadoTxt.Text.Equals(" "))
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
                valores.Add(buscarEstadoTxt.Text);
                valores.Add('A');
                llenarTabla(estados_DAO.consultaGeneral(consulta_wh, parametros, valores));

            }
        }
    }
}
