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
    public partial class Incapacidades_editar : Form
    {
        Incapacidad inc;
        Incapcidades_DAO inc_dao;
        int idEmp;
        public Incapacidades_editar()
        {
            InitializeComponent();
        }
        public Incapacidades_editar(Incapacidad i, int idEmp, string nombre)
        {
            InitializeComponent();
            inc = i;
            inc_dao = new Incapcidades_DAO();
            this.idEmp = idEmp;
            this.Empleado.Text = nombre;
        }
        private void Incapacidades_editar_Load(object sender, EventArgs e)
        {

        }
    }
}
