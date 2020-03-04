using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgroNegocio_RH_ERP_ISC_8A.Interfaces;

namespace AgroNegocio_RH_ERP_ISC_8A.Interfaces
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void pERCEPCIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Percepciones_GUI percepciones = new Percepciones_GUI();
            this.SetVisibleCore(false);
            percepciones.ShowDialog();
            this.SetVisibleCore(true);
        }

        private void eSTADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estados_GUI estados = new Estados_GUI();
            this.SetVisibleCore(false);
            estados.ShowDialog();
            this.SetVisibleCore(true);
        }

        private void dECUCCIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deducciones_GUI deducciones = new Deducciones_GUI();
            this.SetVisibleCore(false);
            deducciones.ShowDialog();
            this.SetVisibleCore(true);
        }

        private void uBICACIONToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SetVisibleCore(false);
            Login l = new Login();
            l.ShowDialog();

            Application.Exit();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleados_GUI empleados = new Empleados_GUI();
            this.SetVisibleCore(false);
            empleados.ShowDialog();
            this.SetVisibleCore(true);
        }
    }
}
