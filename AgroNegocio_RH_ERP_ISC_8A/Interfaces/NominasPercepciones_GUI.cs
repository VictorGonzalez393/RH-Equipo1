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
    public partial class NominasPercepciones_GUI : Form
    {
        int idEmp, idNom;
        Empleados_DAO em_dao;
        Nomina_DAO nom_dao;
        Percepciones_DAO per_dao;
        NominaPercepcion_DAO np_dao;
        private List<NominaPercepcion> np = new List<NominaPercepcion>();
        double salarioMin = 123.22;
        double salarioE;
        Nomina nomina;

        private void NominasPercepciones_GUI_Load(object sender, EventArgs e)
        {
            //idNom = nomina.idNomina;
            salarioE = this.em_dao.getSalario(nomina.idEmpleado);
            /*Llenar el combo de percepciones existentes en la BD*/
            string consulta_where = "";
            if (salarioMin == salarioE)
            {
                consulta_where = " where estatus=@estatus and nombre <>'Subsidio'";
            }
            else
            {
                consulta_where = " where estatus=@estatus";
            }
            List<string> parametros = new List<string>();
            parametros.Add("@estatus");
            List<object> valores = new List<object>();
            valores.Add('A');
            List<Percepcion> percepciones = per_dao.consultaGeneral(consulta_where, parametros, valores);
            foreach (Percepcion percep in percepciones)
            {
                percepcions.Items.Add(percep);
            }

            Actualizar();

        }

        public NominasPercepciones_GUI(Nomina nom, int idEmpleado, string name, double salarioE)
        {
            InitializeComponent();
            this.idEmp = idEmpleado;
            //Mensajes.Info("Nomina: " + nom.idNomina + " f:" + nom.fechaPago);
            this.id_nomina.Text = Convert.ToString(nom.idNomina);
            em_dao = new Empleados_DAO();
            per_dao = new Percepciones_DAO();
            nom_dao = new Nomina_DAO();
            np_dao = new NominaPercepcion_DAO();
            nomina = nom;
            this.empleadotxt.Text = name;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (percepcions.SelectedIndex == -1)
            {
                Mensajes.Error("Selecciona una Deducción");
            }
            else
            {
                Percepcion selecP = (Percepcion)percepcions.SelectedItem; //obtiene la Percepcion seleccionada
                int p = selecP.IdPercepcion;

                if (!existePercepcion(p))
                {
                    ////Guardar 
                    double importe = (salarioE * per_dao.getDias(selecP.Nombre));
                    Console.WriteLine("CantidadNeta: " + nomina.cantidadNeta + " TotalD: " + nomina.totalD);
                    double totalP = Convert.ToDouble(nomina.totalP) + importe;

                    double cantNeta = Convert.ToDouble(nomina.cantidadNeta) - importe;
                    Console.WriteLine("importe: " + importe + " cantidadNeta: " + cantNeta);
                    NominaPercepcion nominaP = new NominaPercepcion(Convert.ToInt32(id_nomina.Text), selecP.IdPercepcion, importe, 'A', selecP.Nombre, selecP.Descripcion);
                    if (np_dao.registrar(nominaP, totalP, cantNeta))
                    {
                        Mensajes.Info("Se agregó la Percepción.");
                        Actualizar();
                    }
                    else
                    {
                        Mensajes.Error("Error al registrar NominaPercepción");
                    }
                }
                else
                {
                    Mensajes.Error("La Percepción ya está agregada.");
                }
            }
        }

        private Boolean existePercepcion(int d) /*Consultar en la tabla si ya existe la percepción que se quiere agregar*/
        {
            foreach (DataGridViewRow row in tablaNominasP.Rows)
            {
                if (row.Cells["Id"].Value.Equals(d))
                {
                    return true;
                }
            }
            return false;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (tablaNominasP.SelectedRows.Count != -1)
            {

                try
                {
                    DialogResult resultado = MessageBox.Show("¿Estás seguro que desea eliminar la Percepción?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        DataGridViewRow row = tablaNominasP.SelectedRows[0];
                        int idPercep = Convert.ToInt32(row.Cells[0].Value);
                        double importe = Convert.ToDouble(row.Cells[3].Value);
                        double totalP = Convert.ToDouble(nomina.totalP) - importe;
                        double cantNeta = Convert.ToDouble(nomina.cantidadNeta) + importe;
                        Console.WriteLine("DATOS: " + idPercep + " imp:" + importe + " totalP: " + totalP + " cantNeta: " + cantNeta + " Nomina" + nomina.idNomina);
                        if (np_dao.eliminar(idPercep, nomina.idNomina, totalP, cantNeta))
                        {
                            Mensajes.Info("Se eliminó la Percepción.");
                            Actualizar();
                        }
                        else
                        {
                            Mensajes.Error("Error al borrar la Percepción.");
                        }
                    }
                }
                catch (Exception)
                {
                    Mensajes.Error("Error al intentar eliminar la nómina percepción.");
                }
            }
            else
            {
                MessageBox.Show("Selecciona la Percepción a eliminar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Actualizar()
        {
            /* Llenar la tabla de percepciones agregadas a la nomina*/
            np = np_dao.consultaGeneral(" where idNomina=@idNomina",
                new List<string>() { "@idNomina" },
                new List<object>() { nomina.idNomina });

            foreach (NominaPercepcion np_temp in np)
            {
                DataGridViewRow renglon = new DataGridViewRow();
                renglon.CreateCells(tablaNominasP);
                renglon.Cells[0].Value = np_temp.idPercepcion;
                renglon.Cells[1].Value = np_temp.nombre;
                renglon.Cells[2].Value = np_temp.descripcion;
                renglon.Cells[3].Value = np_temp.importe;
                tablaNominasP.Rows.Add(renglon);
            }

            
        }
    }
}
