using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AgroNegocio_RH_ERP_ISC_8A
{
    public partial class Form1 : Form
    {
        private Datos.Conexion cn;
        public Form1()
        {
            InitializeComponent();
            cn = new Datos.Conexion();
            
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            cn.Conectar("MIZUKI", "", "");
            MessageBox.Show("Conexion exitosa");
        }
    }
}
