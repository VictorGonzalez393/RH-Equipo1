using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgroNegocio_RH_ERP_ISC_8A.Datos;
using AgroNegocio_RH_ERP_ISC_8A.Modelo;

namespace AgroNegocio_RH_ERP_ISC_8A.Interfaces
{
    public partial class Incapacidades_nuevo : Form
    {
        int idEmp;
        Incapcidades_DAO inc_dao = new Incapcidades_DAO();
        MemoryStream archivo_actual;
        Image imag;
        public Incapacidades_nuevo()
        {
            InitializeComponent();
        }
        public Incapacidades_nuevo(string nombre, int idEmpleado)
        {
            InitializeComponent();
            this.Empleado.Text = nombre;
            idEmp = idEmpleado;
            
        }
       

        private void Incapacidades_nuevo_Load(object sender, EventArgs e)
        {
            this.id_incap.Value = inc_dao.getMaxID();
        }

        private void btn_evidencia_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog abrir = new OpenFileDialog()
            {
                ValidateNames = true,
                Multiselect = false,
                Filter = "Imagen|*.jpg"
            })
            {
                if (abrir.ShowDialog() == DialogResult.OK)
                {
                    byte[] bt = File.ReadAllBytes(abrir.FileName);
                    archivo_actual = new MemoryStream(bt);
                    imag = new Bitmap(new Bitmap(new MemoryStream(bt)), new Size(244, 294));
                    evd_1.Image = imag;
                }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Principal p = new Principal();
            SetVisibleCore(false);
            p.ShowDialog();

        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        } 
        private bool validarDatos()
        {
            bool band = false;
            if(!string.IsNullOrWhiteSpace(enf_txt.Text))
            {
                if (fechaIn.Value <= fechaFi.Value)
                {
                    if (fechaIn.Value >= DateTime.Today)
                    {
                        if (fechaFi.Value >= DateTime.Today)
                        {
                            if (evd_1.Image != null)
                            {
                                band = true;
                            }
                            else
                            {
                                Mensajes.Error("No ha seleccionado la evidencia");
                            }
                        }
                        else
                        {
                            Mensajes.Error("La fecha fin no debe ser menor que la fecha actual");
                        }
                    }
                    else
                    {
                        Mensajes.Error("La fecha es menor a la fecha actual");
                    }
                }
                else
                {
                    Mensajes.Error("La Fecha Inicio es mayor que la Fecha Fin");
                }
            }
            else
            {
                Mensajes.Error("No ha ingresado la enfermedad");
            }
            return band;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (validarDatos() == true)
            {
                Incapacidad i = new Incapacidad((int)id_incap.Value, idEmp, Empleado.Text, " ", " ",
                    enf_txt.Text, fechaIn.Text, fechaFi.Text, imag);
                try
                {
                    if (inc_dao.registrar(i))
                    {
                        Mensajes.Info("Se registro correctamente la incapacidad");
                        Close();
                    }
                    else
                    {
                        Mensajes.Error("Error al registrar la incapacidad");
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    Mensajes.Error("Error al registrar la incapacidad");
                }
            }
        }

        
    }
}
