using AgroNegocio_RH_ERP_ISC_8A.Datos;
using AgroNegocio_RH_ERP_ISC_8A.Modelo;
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

namespace AgroNegocio_RH_ERP_ISC_8A.Interfaces
{
    public partial class Incapacidades_editar : Form
    {
        Incapacidad inc;
        Incapcidades_DAO inc_dao;
        int idEmp;
        MemoryStream archivo_actual;
        Image imag;
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
            id_incap.Value = inc.IdIncapacidad;
            evd_1.Image = inc_dao.GetImage(inc.IdIncapacidad);
            imag = inc_dao.GetImage(inc.IdIncapacidad);
            enf_txt.Text = inc.Enfermedad;
            fechaIn.Value = Convert.ToDateTime(inc.FechaInicio);
            fechaFi.Value = Convert.ToDateTime(inc.FechaFin);
        }
        private bool validarDatos()
        {
            bool band = false;
            if (!string.IsNullOrWhiteSpace(enf_txt.Text))
            {
                if (fechaIn.Value <= fechaFi.Value)
                {
                    if (fechaIn.Value >= DateTime.Today)
                    {
                        if (fechaFi.Value >= DateTime.Today)
                        {
                            if (evd_1.Image != null || imag != null)
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

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (validarDatos() == true)
            {
                Incapacidad i = new Incapacidad((int)id_incap.Value, idEmp, Empleado.Text, " ", " ",
                    enf_txt.Text, fechaIn.Text, fechaFi.Text, imag);
                try
                {
                    if (inc_dao.editar(i))
                    {
                        Mensajes.Info("Se edito correctamente la incapacidad");
                        Close();
                    }
                    else
                    {
                        Mensajes.Error("Error al editar la incapacidad");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    Mensajes.Error("Error al registrar la incapacidad");
                }
            }
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
    }
}
