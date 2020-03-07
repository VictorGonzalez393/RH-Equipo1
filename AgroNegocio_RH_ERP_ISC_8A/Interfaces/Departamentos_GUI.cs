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
    public partial class Departamentos_GUI : Form
    {
        Departamentos_DAO depto_DAO = new Departamentos_DAO();

        public Departamentos_GUI()
        {
            InitializeComponent();
        }


        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Departamentos_nuevo nuevo = new Departamentos_nuevo();
            nuevo.ShowDialog();
            actualizarTabla();
        }

        private void actualizarTabla()
        {
            String consulta_wh = "where estatus=@estatus";
            List<string> parametros = new List<string>();
            parametros.Add("@estatus");
            List<object> valores = new List<object>();
            valores.Add('A');
            llenarTabla(depto_DAO.consultaGeneral(consulta_wh, parametros, valores));
        }

        private void llenarTabla(List<Departamento> deptos)
        {
            tablaDepartamentos.Rows.Clear();
            foreach (Departamento depto in deptos)
            {
                DataGridViewRow renglon = new DataGridViewRow();
                renglon.CreateCells(tablaDepartamentos);
                renglon.Cells[0].Value = depto.idDepto;
                renglon.Cells[1].Value = depto.Nombre;
                tablaDepartamentos.Rows.Add(renglon);
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tablaDepartamentos.SelectedRows.Count != -1)
            {
                DataGridViewRow row = tablaDepartamentos.SelectedRows[0];

                Departamento depto = new Departamento(
                    (int)row.Cells[0].Value,
                    (string)row.Cells[1].Value,
                    (char)row.Cells[2].Value
                    );
                Departamentos_editar depto_editar = new Departamentos_editar(depto);
                this.SetVisibleCore(false);
                depto_editar.ShowDialog();
                this.SetVisibleCore(true);
                actualizarTabla();
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Selecciona el departamento.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tablaDepartamentos.SelectedRows.Count != -1)
            {

                try
                {
                    DialogResult resultado = MessageBox.Show("¿Estás seguro que desea eliminar el Departamento?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        DataGridViewRow row = tablaDepartamentos.SelectedRows[0];
                        int idDepto = (int)row.Cells[0].Value;
                        depto_DAO.eliminar(idDepto);
                        actualizarTabla();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al intentar eliminar el departamento.");
                }
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Selecciona el Deparatmento a eliminar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (buscarDeptoTxt.Text.Equals(" "))
            {
                DialogResult resultado = MessageBox.Show("No hay datos para buscar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                string consulta_wh = "where nombre like '%'+@nombre+'%'+ and estatus=@estatus";
                List<string> parametros = new List<string>();
                parametros.Add("@nombre");
                parametros.Add("@estatus");
                List<object> valores = new List<object>();
                valores.Add(buscarDeptoTxt.Text);
                valores.Add('A');
                llenarTabla(depto_DAO.consultaGeneral(consulta_wh, parametros, valores));

            }
        }

        private void Departamentos_GUI_Load(object sender, EventArgs e)
        {
            actualizarTabla(); 
        }
    }
}
