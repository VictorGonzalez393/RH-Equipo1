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
    public partial class Ausencias_editar : Form
    {
        public Ausencias_editar(Ausencia_justificada a,int idEm, string nombre)
        {
            InitializeComponent();
        }

        private void Ausencias_editar_Load(object sender, EventArgs e)
        {

        }
    }
}
