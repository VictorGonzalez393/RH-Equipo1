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
    public partial class Horarios_editar : Form
    {
        private int idemp;
        private List<Horario> horarios = new List<Horario>();
        private Horarios_DAO dorarios_DAO = new Horarios_DAO();

        public Horarios_editar()
        {
            InitializeComponent();
        }

        public Horarios_editar(int idemp)
        {
            this.idemp = idemp;

            actualizar();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dias.SelectedIndex >= 0)
            {
                if (buscarDiaenTabla(dias.SelectedItem.ToString()))
                {
                    MessageBox.Show("El dia ya se agrego a la tabla", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //if (horaf.Value > horai.Value)
                    //{
                    //}
                    DataGridViewRow renglon = new DataGridViewRow();
                    renglon.CreateCells(tablaHorario);

                    renglon.Cells[0].Value = dias.SelectedItem.ToString();
                    renglon.Cells[1].Value = horai.Value.ToString("HH:mm:ss");
                    renglon.Cells[2].Value = horaf.Value.ToString("HH:mm:ss");
                    tablaHorario.Rows.Add(renglon);
                }

            }
            else
                MessageBox.Show("Selecciona un dia", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private bool buscarDiaenTabla(string dia)
        {
            bool bandera = false;
            foreach (DataGridViewRow renglon in tablaHorario.Rows)
            {
                if (renglon.Cells["Dia"].Value.ToString().Equals(dia))
                {
                    bandera = true;
                    break;
                }
            }
            return bandera;
        }

        private void Horarios_editar_Load(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (tablaHorario.SelectedRows.Count==1)
            {
                try
                {

                    DialogResult resultado = MessageBox.Show("Seguro que desea eliminar el horario?", "alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resultado == DialogResult.Yes)
                    {
                        DataGridViewRow renglon = tablaHorario.SelectedRows[0];
                        int idhorario = (int)renglon.Cells[0].Value;
                        dorarios_DAO.eliminar(idhorario);
                        actualizar();

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar eliminar la ciudad");
                }
            }
            else
                MessageBox.Show("Selecciona una ciudad");
        }

        private void actualizar()
        {
            horarios.Clear();
            tablaHorario.Rows.Clear();
            horarios = new Horarios_DAO().consultaGeneral(" where  idempleado=@idemp",
                            new List<string>() { "@idemp", "@estatus" },
                            new List<object>() { idemp, 'A' });

            foreach (Horario horario in horarios)
            {
                DataGridViewRow renglon = new DataGridViewRow();
                renglon.CreateCells(tablaHorario);
                renglon.Cells[0].Value = horario.ID;
                renglon.Cells[1].Value = horario.Dias;
                renglon.Cells[2].Value = horario.HoraI;
                renglon.Cells[3].Value = horario.HoraF;
                tablaHorario.Rows.Add(renglon);
            }
        }

        private void tablaHorario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var horario = horarios[e.RowIndex];

                foreach(string dia in dias.Items)
                {
                    if (dia.Equals(horario.Dias))
                    {
                        dias.SelectedItem = dia;
                    }
                }
            }
        }

        private void editar_Click(object sender, EventArgs e)
        {

        }
    }
}
