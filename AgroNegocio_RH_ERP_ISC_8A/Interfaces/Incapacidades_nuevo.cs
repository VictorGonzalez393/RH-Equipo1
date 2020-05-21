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
    public partial class Incapacidades_nuevo : Form
    {
        int idEmp;
        
        public Incapacidades_nuevo()
        {
            InitializeComponent();
        }
        public Incapacidades_nuevo(string nombre, int idEmpleado)
        {
            InitializeComponent();
            this.Empleado.Text = nombre;
            idEmp = idEmpleado;
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Incapacidades_nuevo_Load(object sender, EventArgs e)
        {

        }
    }
}
