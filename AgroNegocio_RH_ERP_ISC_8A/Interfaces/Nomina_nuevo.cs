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
    public partial class Nomina_nuevo : Form
    {
        public Nomina_nuevo()
        {
            InitializeComponent();
        }

        private void textTotalD_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nomina_nuevo_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void totalP_ValueChanged(object sender, EventArgs e)
        {

        }

        private void atrásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void IniciotoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Principal p = new Principal();
            p.ShowDialog();
            this.Close();
        }
    }
}
