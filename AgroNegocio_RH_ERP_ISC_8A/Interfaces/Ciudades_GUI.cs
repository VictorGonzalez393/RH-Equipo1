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
    public partial class Ciudades_GUI : Form
    {
        Ciudades_DAO ciudadesDAO = new Ciudades_DAO();
        public Ciudades_GUI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            actualizarTabla();
        }

        private void llenarTabla(List<Ciudad> ciudades)
        {
            tablaCiudad.Rows.Clear();
            foreach(Ciudad ciudad in ciudades)
            {
                DataGridViewRow renglon = new DataGridViewRow();
                renglon.CreateCells(tablaCiudad);
                renglon.Cells[0].Value = ciudad.ID;
                renglon.Cells[1].Value = ciudad.Nombre;
                renglon.Cells[2].Value = ciudad.IDEstado;
                renglon.Cells[3].Value = ciudad.Estatus;
                tablaCiudad.Rows.Add(renglon);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void agregarCiudadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ciudades_nuevo ciudades_Nuevo = new Ciudades_nuevo();
            ciudades_Nuevo.ShowDialog();

            actualizarTabla();
        }

        private void actualizarTabla()
        {
            string consulta_where = " where estatus = @estatus";
            List<string> parametros = new List<string>();
            parametros.Add("@estatus");
            List<object> valores = new List<object>();
            valores.Add('A');
            llenarTabla(ciudadesDAO.consultaGeneral(consulta_where, parametros, valores));
        }

        private void editarCiudadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tablaCiudad.SelectedRows.Count >0)
            {
                DataGridViewRow row = tablaCiudad.SelectedRows[0];

                Ciudad ciudad_editar = new Ciudad(
                    (int)row.Cells[0].Value,
                    (string)row.Cells[1].Value,
                    (int)row.Cells[2].Value,
                    (char)row.Cells[3].Value
                    );

                Ciudades_editar ciudades_EditarGUI = new Ciudades_editar(ciudad_editar);
                ciudades_EditarGUI.ShowDialog();
                actualizarTabla();
            }
            else
            {
                MessageBox.Show("Selecciona una ciudad");
            }
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tablaCiudad_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {

                    DialogResult resultado =  MessageBox.Show("Seguro que desea eliminar una ciudad?", "alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if(resultado == DialogResult.Yes)
                    {
                        DataGridViewRow renglon = tablaCiudad.Rows[e.RowIndex];
                        int idciudad = (int)renglon.Cells[0].Value;
                        ciudadesDAO.eliminar(idciudad);
                        actualizarTabla();
                    }
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error al intentar eliminar la ciudad");
                }
            }
            else
                MessageBox.Show("Selecciona una ciudad");
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string consulta_where = " where nombre like '%'+ @nombre + '%' and estatus=@estatus";
            List<string> parametros = new List<string>();
            parametros.Add("@nombre");
            parametros.Add("@estatus");
            List<object> valores = new List<object>();
            valores.Add(buscar_ciudad.Text);
            valores.Add('A');
            llenarTabla(ciudadesDAO.consultaGeneral(consulta_where, parametros, valores));
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tablaCiudad.SelectedRows.Count != -1)
            {

                try
                {
                    DialogResult resultado = MessageBox.Show("¿Estás seguro que desea eliminar la ciudad?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        DataGridViewRow row = tablaCiudad.SelectedRows[0];
                        int idCiudad = (int)row.Cells[0].Value;
                        ciudadesDAO.eliminar(idCiudad);
                        actualizarTabla();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar eliminar la ciudad");
                }
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Selecciona la ciudad", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
