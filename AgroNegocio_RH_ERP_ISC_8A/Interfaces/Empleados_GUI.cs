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
    public partial class Empleados_GUI : Form
    {
        public Empleados_GUI()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void agregarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleados_nuevo empleadosnuevo = new Empleados_nuevo();
            this.SetVisibleCore(false);
            empleadosnuevo.ShowDialog();
            this.SetVisibleCore(true);
        }

        private void tablaEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void editarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleados_Editar empleadoseditar = new Empleados_Editar();
            this.SetVisibleCore(false);
            empleadoseditar.ShowDialog();
            this.SetVisibleCore(true);
        }
    }
}
