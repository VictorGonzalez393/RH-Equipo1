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
    public partial class Nomina_GUI : Form
    {
        public int idEmp { get; set; }
        public Nomina_GUI()
        {
            InitializeComponent();
        }
        public Nomina_GUI(int idEmp, string empleado)
        {
            InitializeComponent();
            nombre.Text=empleado;
            this.idEmp = idEmp;
        }

        private void Nomina_GUI_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
