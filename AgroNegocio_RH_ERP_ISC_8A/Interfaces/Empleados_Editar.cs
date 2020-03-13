using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgroNegocio_RH_ERP_ISC_8A.Datos;
using AgroNegocio_RH_ERP_ISC_8A.Modelo;

namespace AgroNegocio_RH_ERP_ISC_8A.Interfaces
{


    public partial class Empleados_Editar : Form
    {
        private Empleado empleado;

        public Empleados_Editar(Empleado empleado)
        {
            InitializeComponent();
            this.empleado = empleado;
        }

        private void cbx_Edo_civil_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
