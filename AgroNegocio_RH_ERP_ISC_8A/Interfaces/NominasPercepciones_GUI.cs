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
        private List<NominaPercepcion> nd = new List<NominaPercepcion>();
        double salarioMin = 123.22;
        double salarioE;
        Nomina nomina;

        private void NominasPercepciones_GUI_Load(object sender, EventArgs e)
        {
            //idNom = nomina.idNomina;
            salarioE = this.em_dao.getSalario(nomina.idEmpleado);
            /*Llenar el combo de deducciones existentes en la BD*/
            string consulta_where = "";
            if (salarioE <= salarioMin)
            {
                consulta_where = " where estatus=@estatus and nombre <>'ISR'";
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
                percepciones.Items.Add(percep);
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

        private void Actualizar()
        {
            /* Llenar la tabla de deduccines agregadas a la nomina*/
            nd = np_dao.consultaGeneral(" where idNomina=@idNomina",
                new List<string>() { "@idNomina" },
                new List<object>() { nomina.idNomina });

            foreach (NominaPercepcion np_temp in nd)
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
