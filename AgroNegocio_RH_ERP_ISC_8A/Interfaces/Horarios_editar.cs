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
        private readonly List<string> nombre_dias = new List<string>() { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };

        public Horarios_editar()
        {
            InitializeComponent();
        }

        public Horarios_editar(int idemp, string nombreemp)
        {
            InitializeComponent();
            this.idemp = idemp;
            idEmpleado.Text = idemp.ToString();
            nombre.Text = nombreemp;
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
                    Mensajes.Info("El dia ya se agrego al horario del empleado");
                }
                else
                {
                    DataGridViewRow renglon = new DataGridViewRow();
                    renglon.CreateCells(tablaHorario);
                    renglon.Cells[0].Value = 0;
                    renglon.Cells[1].Value = dias.SelectedItem.ToString();
                    renglon.Cells[2].Value = horai.Value.TimeOfDay;
                    renglon.Cells[3].Value = horaf.Value.TimeOfDay;
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
            horai.Value = new DateTime(1998, 01, 13);
            horaf.Value = new DateTime(1998, 01, 13);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (tablaHorario.SelectedRows.Count == 1)
            {
                try
                {
                    DialogResult resultado = MessageBox.Show("Seguro que desea eliminar el horario?", "alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        DataGridViewRow renglon = tablaHorario.SelectedRows[0];
                        if ((int)renglon.Cells["ID"].Value == 0)
                        {
                            tablaHorario.Rows.Remove(renglon);
                        }
                        else
                        {
                            int idhorario = (int)renglon.Cells[0].Value;
                            dorarios_DAO.eliminar(idhorario);
                            actualizar();
                        }
                        Mensajes.Info("Día eliminado exitosamente");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar eliminar el dia." + ex.Message);
                }
            }
            else
                MessageBox.Show("Selecciona una ciudad");
        }

        private void actualizar()
        {
            horarios = dorarios_DAO.consultaGeneral(" where  idempleado=@idemp",
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



        private void cancelarEdicion()
        {
            dias.Items.Clear();
            editar.Visible = false;
            cancelarEditar.Visible = false;
            agregar.Visible = true;
            dias.Items.AddRange(nombre_dias.ToArray());
        }
        private void editar_Click(object sender, EventArgs e)
        {
            string dia = dias.SelectedItem.ToString();
            foreach (DataGridViewRow renglon in tablaHorario.Rows)
            {
                if (renglon.Cells["Dia"].Value.ToString().Equals(dia))
                {
                    renglon.Cells["Inicio"].Value = horai.Value.TimeOfDay;
                    renglon.Cells["Fin"].Value = horaf.Value.TimeOfDay;
                    cancelarEdicion();
                    break;
                }
            }
        }

        private void tablaHorario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var horario = tablaHorario.Rows[e.RowIndex];

                dias.Items.Clear();
                dias.Items.Add((string)horario.Cells["Dia"].Value);
                dias.SelectedIndex = 0;
                horai.Value = new DateTime(1998, 01, 13).Add((TimeSpan)horario.Cells["Inicio"].Value);
                horaf.Value = new DateTime(1998, 01, 13).Add((TimeSpan)horario.Cells["Fin"].Value);
                editar.Visible = true;
                agregar.Visible = false;
                cancelarEditar.Visible = true;
            }
        }

        private void cancelarEditar_Click(object sender, EventArgs e)
        {
            cancelarEdicion();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow renglon in tablaHorario.Rows)
            {
                Horario horario_nuevo = new Horario(
                    (int)renglon.Cells["ID"].Value,
                    (TimeSpan)renglon.Cells["Inicio"].Value,
                    (TimeSpan)renglon.Cells["Fin"].Value,
                    (string)renglon.Cells["Dia"].Value,
                    idemp,
                    'A'
                    );
                try
                {
                    if (horario_nuevo.ID == 0) //Este horario no está en la BD
                    {
                        if (!dorarios_DAO.registrar(horario_nuevo))
                        {
                            Mensajes.Error("Error al registrar el horario del dia " + horario_nuevo.Dias);
                            break;
                        }
                    }
                    else
                    {
                        if (!dorarios_DAO.editar(horario_nuevo))
                        {
                            Mensajes.Error("Error al actualizar el horario del dia " + horario_nuevo.Dias);
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Mensajes.Error("Se ha generado un error con la BD. " + ex.Message);
                }
            }
            Mensajes.Info("Horarios guardados exitosamente");
            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = Mensajes.PreguntaAdvertencia("¿Deseas regresar?\nLos cambios no se guardarán");
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
