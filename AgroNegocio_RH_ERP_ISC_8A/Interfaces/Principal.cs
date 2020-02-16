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
        private void cIUDADESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ciudades_GUI ciudades_GUI = new Ciudades_GUI();
            this.Visible = false;
            ciudades_GUI.ShowDialog();
            this.Visible = true;

        }
    }
}
