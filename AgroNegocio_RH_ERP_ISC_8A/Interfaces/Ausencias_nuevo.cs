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
    public partial class Ausencias_nuevo : Form
    {
        Empleados_DAO em_dao;
        Ausencias_justificadas_DAO au_dao;
        int idEs = 0;
        public Ausencias_nuevo(string nombre, int idES)
        {
            InitializeComponent();
            em_dao = new Empleados_DAO();
            au_dao = new Ausencias_justificadas_DAO();
            id_au.Value = au_dao.getMaxID();
            empleadoS.Text = nombre;
            idEs = idES;
        }

        private void Ausencias_nuevo_Load(object sender, EventArgs e)
        {
            string consulta_where = " where estatus = @estatus";
            List<string> parametros = new List<string>();
            parametros.Add("@estatus");
            List<object> valores = new List<object>();
            valores.Add('A');

            List<Empleado> emp = em_dao.consultaGeneral(consulta_where, parametros, valores);

            foreach(Empleado em in emp)
            {
                empleadoA_cm.Items.Add(em);
            }
            tipo_cm.Items.Add("Vacaciones");
            tipo_cm.Items.Add("Asuntos familiares");
        }

        private void atrásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Principal p = new Principal();
            SetVisibleCore(false);
            p.ShowDialog();
            Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
