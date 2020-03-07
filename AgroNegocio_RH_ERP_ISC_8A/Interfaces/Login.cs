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

namespace AgroNegocio_RH_ERP_ISC_8A.Interfaces
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "Usuario" && txtUsuario.Text != " " && txtUsuario.Text != "")
            {
                if (txtPass.Text != "Contraseña" && txtPass.Text != " " && txtPass.Text != "")
                {

                    Login_model user = new Login_model();
                    var loginValido = user.Loginx(txtUsuario.Text, txtPass.Text);
                    if (loginValido == true)
                    {
                        this.SetVisibleCore(false);
                        Principal p = new Principal(txtUsuario.Text);
                        p.ShowDialog();

                    }
                    else
                    {
                        msgError("Usuario o Password incorrectos. \n Vuelva a intentarlo.");
                        txtPass.Clear();
                        txtUsuario.Focus();
                    }
                }
                else
                {
                    txtPass.Focus();
                    msgError("Ingresar Password.");
                    
                }
            }
            else
            {
                txtUsuario.Focus();
                msgError("Ingresar Usuario.");
                
            }
        }

        private void msgError(string msg)
        {
            lblErrorMessage.Text = "    " + msg;
            lblErrorMessage.Visible = true;
        }
        private void Logout(object sender,FormClosedEventArgs e)
        {
            txtPass.Clear();
            txtUsuario.Clear();
            lblErrorMessage.Visible = false;
        }

        private void lblErrorMessage_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtUsuario_MouseClick(object sender, MouseEventArgs e)
        {
            txtUsuario.Clear();
        }

        private void txtPass_MouseClick(object sender, MouseEventArgs e)
        {
            txtPass.Clear();
        }
    }
}
