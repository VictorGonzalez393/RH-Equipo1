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
                string dia = dias.SelectedItem.ToString();
                DataGridViewRow renglon = obtenerDiaEnTabla(dia);
                if (renglon != null) //El día si existe, ahora, verificar si es A o I
                {
                    if ( Convert.ToChar(renglon.Cells["Estatus"].Value) == 'A') //Si el día existe y está activo
                    {
                        Mensajes.Info("El dia ya se agrego al horario del empleado");
                    }
                    else
                    { //Solamente se debe mostrar el renglon
                        renglon.Cells["Dia"].Value = dias.SelectedItem.ToString();
                        renglon.Cells[2].Value = horai.Value.TimeOfDay;
                        renglon.Cells[3].Value = horaf.Value.TimeOfDay;
                        renglon.Cells[4].Value = 'A';
                        renglon.Visible = true;
                    }
                }
                else
                {
                    renglon = new DataGridViewRow();
                    renglon.CreateCells(tablaHorario);
                    renglon.Cells[0].Value = 0;
                    renglon.Cells[1].Value = dias.SelectedItem.ToString();
                    renglon.Cells[2].Value = horai.Value.TimeOfDay;
                    renglon.Cells[3].Value = horaf.Value.TimeOfDay;
                    renglon.Cells[4].Value = 'A';
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
                //try
                //{
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
                            //int idhorario = (int)renglon.Cells[0].Value;
                            //dorarios_DAO.eliminar(idhorario);
                            renglon.Cells["Estatus"].Value = "I";
                            int index = renglon.Index;
                            tablaHorario.CurrentCell = null;
                            tablaHorario.Rows[index].Visible = false;
                           // actualizar();
                        }
                        Mensajes.Info("Se elimino exitosamente");
                    }
                //}
            }
            else
                Mensajes.Error("Selecciona un día");
        }

        private void actualizar()
        {
            horarios = dorarios_DAO.consultaGeneral(" where  idempleado=@idemp and estatus=@estatus",
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
                renglon.Cells[4].Value = horario.Estatus;
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
            DataGridViewRow renglon = obtenerDiaEnTabla(dia);
            if (renglon != null)
            {
                renglon.Cells["Inicio"].Value = horai.Value.TimeOfDay;
                renglon.Cells["Fin"].Value = horaf.Value.TimeOfDay;
            }
            else
            {
                Mensajes.Error("El dia no se puede editar");
            }
            cancelarEdicion();
        }

        private DataGridViewRow obtenerDiaEnTabla(string dia)
        {
            foreach (DataGridViewRow row in tablaHorario.Rows)
            {
                if (row.Cells["Dia"].Value.ToString().Equals(dia))
                {
                    return row;
                }
            }
            return null;
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
            if (tablaHorario.Rows.Count > 0)
            {
                foreach (DataGridViewRow renglon in tablaHorario.Rows)
                {
                    Horario horario_nuevo = new Horario(
                        (int)renglon.Cells["ID"].Value,
                        (TimeSpan)renglon.Cells["Inicio"].Value,
                        (TimeSpan)renglon.Cells["Fin"].Value,
                        (string)renglon.Cells["Dia"].Value,
                        idemp,
                        Convert.ToChar(renglon.Cells["Estatus"].Value)
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
                            if (horario_nuevo.Estatus=='A')
                            {
                                if (!dorarios_DAO.editar(horario_nuevo))
                                {
                                    Mensajes.Error("Error al actualizar el horario del dia " + horario_nuevo.Dias);
                                    break;
                                }
                            }
                            else
                            {
                                if (!dorarios_DAO.eliminar(horario_nuevo.ID))
                                {
                                    Mensajes.Error("Error al eliminar el horario del dia " + horario_nuevo.Dias);
                                    break;
                                }
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
            else
            {
                Mensajes.Info("No se ha agregado ningún horario.");
            }
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
