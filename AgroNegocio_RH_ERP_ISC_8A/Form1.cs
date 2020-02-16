using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgroNegocio_RH_ERP_ISC_8A.Interfaces;

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

        private void button1_Click(object sender, EventArgs e)
        {
            /*cn.Conectar("LaLiz", "Hola.123");
            MessageBox.Show("Conexion exitosa" + cn.ToString());*/
            Principal principal = new Principal();
            this.SetVisibleCore(false);
            principal.ShowDialog();
            Application.Exit();

        }
    }
}
