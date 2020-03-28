using AgroNegocio_RH_ERP_ISC_8A.Datos;
using AgroNegocio_RH_ERP_ISC_8A.Modelo;
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
    public partial class HistorialPuestos_editar : Form
    {
        private HistorialPuesto historialpuesto;
        HistorialPuestos_DAO historialdao = new HistorialPuestos_DAO();
        public HistorialPuestos_editar(HistorialPuesto historialpuesto)
        {
            InitializeComponent();
            this.historialpuesto = historialpuesto;
        }
    }
}
