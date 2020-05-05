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
    public partial class Nomina_editar : Form
    {
        int idEmp;
        public Nomina_editar()
        {
            InitializeComponent();
        }
        public Nomina_editar(string empleado, int idEmp)
        {
            InitializeComponent();
            this.idEmp = idEmp;
            txtEmp.Text = empleado;
        }
        private void Nomina_editar_Load(object sender, EventArgs e)
        {

        }
    }
}
