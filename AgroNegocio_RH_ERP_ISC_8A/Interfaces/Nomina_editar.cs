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
using AgroNegocio_RH_ERP_ISC_8A.Datos;

namespace AgroNegocio_RH_ERP_ISC_8A.Interfaces
{
    public partial class Nomina_editar : Form
    {
        int idEmp;
        Nomina nom;
        Percepciones_DAO percepciones_dao = new Percepciones_DAO();
        Deducciones_DAO deducciones_dao = new Deducciones_DAO();
        NominaDeduccion_DAO nd_dao = new NominaDeduccion_DAO();
        NominaPercepcion_DAO np_dao = new NominaPercepcion_DAO();
        FormasPago_DAO fp_dao = new FormasPago_DAO();
        Nomina_DAO nomina_DAO = new Nomina_DAO();
        //NominasDeducciones_DAO nd_dao = new NominasDeducciones_DAO();
        //NominasPercepciones_DAO np_dao = new NominasPercepciones_DAO();
        double salarioE = 0;
        double salarioMin = 0;
        double sueldoTotal = 0;
        public Nomina_editar(string emp, Nomina nom, double salarioE, double salarioMin)
        {
            InitializeComponent();
            this.idEmp = nom.idEmpleado;
            this.nom = nom;
            txtEmp.Text = emp;
            this.salarioE = salarioE;
            this.salarioMin = salarioMin;
        }
        
        private void Nomina_editar_Load(object sender, EventArgs e)
        {
            this.idNomina.Value = (decimal)nom.idNomina;
            this.cantNeta.Text =Convert.ToString(nom.cantidadNeta);
            this.totalP.Text = Convert.ToString(nom.totalP);
            this.totalD.Text = Convert.ToString(nom.totalD);
            this.diasTrabajados.Value = (decimal)nom.diasTrabajados;
            this.faltas.Value = (decimal)nom.faltas;
            this.fechaInicio.Value = Convert.ToDateTime(nom.fechaInicio);
            this.fechaPago.Value = Convert.ToDateTime(nom.fechaPago);
            this.fechaFin.Value = Convert.ToDateTime(nom.fechaFin);

            string consulta_where = " where estatus=@estatus";
            List<string> parametros = new List<string>();
            parametros.Add("@estatus");
            List<object> valores = new List<object>();
            valores.Add('A');
            List<Percepcion> percepciones = percepciones_dao.consultaGeneral(consulta_where, parametros, valores);
            foreach (Percepcion per in percepciones)
            {
                listPercepciones.Items.Add(per);
            }
            List<Deduccion> deducciones = deducciones_dao.consultaGeneral(consulta_where, parametros, valores);
            foreach (Deduccion dec in deducciones)
            {
                listDeducciones.Items.Add(dec);
            }

            List<FormasPago> fp = fp_dao.consultaGeneral(consulta_where, parametros, valores);
            foreach (FormasPago f in fp)
            {
                formaPago_cm.Items.Add(f);
            }

            
                        
            foreach (FormasPago f in fp)
            {
                if(f.nombre.Equals(nom.formaPago))
                formaPago_cm.SelectedItem=f;
            }

            if (salarioE > salarioMin)
            {
                listPercepciones.SetSelected(listPercepciones.FindString("Sueldo"), true);
                listDeducciones.SetSelected(listDeducciones.FindString("ISR"), true);
                listDeducciones.SetSelected(listDeducciones.FindString("IMSS"), true);
                listPercepciones.Items.RemoveAt(listPercepciones.FindString("Subsidio"));
            }
            else
            {
                listPercepciones.SetSelected(listPercepciones.FindString("Sueldo"), true);
                listPercepciones.SetSelected(listPercepciones.FindString("Subsidio"), true);
                listDeducciones.Items.Clear();
            }
        }

        private void totalP_ValueChanged(object sender, EventArgs e)
        {

        }

        private void totalD_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cantidadNeta_ValueChanged(object sender, EventArgs e)
        {
                    }

        private void btnCalPer_Click(object sender, EventArgs e)
        {
            double tD = 0, tP = 0;

            if (diasTrabajados.Value != 0)
            {
                double dias = Convert.ToDouble(diasTrabajados.Value) - Convert.ToDouble(faltas.Value);
                sueldoTotal = dias * salarioE;
                for (int i = 0; i < listDeducciones.Items.Count; i++)
                {
                    if (listDeducciones.GetSelected(i) == true)
                    {
                        double porcentaje = deducciones_dao.getPorcentaje(listDeducciones.Items[i].ToString()) / 100;
                        tD += porcentaje * sueldoTotal;
                    }
                }

                totalD.Text = Convert.ToString(tD);
                for (int i = 0; i < listPercepciones.Items.Count; i++)
                {
                    if (listPercepciones.GetSelected(i) == true)
                    {
                        if (listPercepciones.Items[i].ToString().Equals("Sueldo"))
                        {
                            tP += sueldoTotal;
                        }
                        else
                        {
                            tP += percepciones_dao.getDias(listPercepciones.Items[i].ToString()) * salarioE;
                        }

                    }
                }
                totalP.Text = Convert.ToString(tP);
                if (tD <= tP)
                {
                    double cNeta = tP - tD;
                    cantNeta.Text = Convert.ToString(cNeta);
                }
                if (salarioE > salarioMin && tD == 0)
                {
                    Mensajes.Error("No se han agregado las deducciones, favor de seleccionar por lo menos el IMSS");
                }
                if (tP == 0)
                {
                    Mensajes.Error("No se han agregado las percepciones, favor de seleccionar por lo menos el Sueldo");
                }
            }
            else
            {
                Mensajes.Error("Falta agregar los días a pagar");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IniciotoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Principal p = new Principal();
            this.SetVisibleCore(false);
            p.ShowDialog();
            this.Close();
        }

        private void atrásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (validarDatos() == true)
            {
                if (nomina_DAO.existe(fechaPago.Text, idEmp) == true)
                {
                    FormasPago fp = (FormasPago)formaPago_cm.SelectedItem;
                    Nomina n = new Nomina(idEmp, (int)idNomina.Value, fechaPago.Text,
                        Convert.ToDecimal(totalP.Text), Convert.ToDecimal(totalD.Text), Convert.ToDecimal(cantNeta.Text), (int)diasTrabajados.Value, (int)faltas.Value,
                        fechaInicio.Text, fechaFin.Text, fp.nombre, 'A');
                    if (nomina_DAO.editar(n) == true)
                    {
                        double imp;
                        for (int i = 0; i < listDeducciones.Items.Count; i++)
                        {
                            imp = 0;
                            if (listDeducciones.GetSelected(i) == true)
                            {

                                double porcentaje = deducciones_dao.getPorcentaje(listDeducciones.Items[i].ToString()) / 100;
                                imp = porcentaje * sueldoTotal;
                                nomina_DAO.insertarND((int)idNomina.Value, deducciones_dao.getIdD(listDeducciones.Items[i].ToString()), imp);
                                Console.WriteLine("Deduccion:" + listDeducciones.Items[i].ToString() + " porcentaje: " + porcentaje + " imp:" + imp);
                            }
                            
                        }
                        for (int i = 0; i < listPercepciones.Items.Count; i++)
                        {
                            imp = 0;
                            if (listPercepciones.GetSelected(i) == true)
                            {
                                if (listPercepciones.Items[i].ToString().Equals("Sueldo"))
                                {
                                    imp = sueldoTotal;
                                }
                                else
                                {
                                    imp = percepciones_dao.getDias(listPercepciones.Items[i].ToString()) * salarioE;
                                }
                                nomina_DAO.insertarNP((int)idNomina.Value, percepciones_dao.getIdP(listPercepciones.Items[i].ToString()), imp);
                            }

                        }
                        Mensajes.Info("La nómina se edito correctamente");

                        Close();

                    }
                    else
                    {
                        Mensajes.Error("Error al insertar en la BD");
                    }


                }
                else
                {
                    Mensajes.Error("Ya existe nómina con la misma fecha de pago");
                }
            }
        }
        private bool validarDatos()
        {
            bool val = false;
            if (fechaInicio.Value < fechaFin.Value)
            {
                if (diasTrabajados.Value > 0)
                {
                    if (faltas.Value >= 0)
                    {
                        if (formaPago_cm.SelectedIndex != -1)
                        {
                            if (Convert.ToDecimal(totalP.Text) != 0 && Convert.ToDecimal(cantNeta.Text) != 0)
                            {
                                return true;
                            }
                            else
                            {
                                Mensajes.Error("No se ha calculado la nómina, favor de dar clic en el botón de calcular");
                                return val;
                            }
                        }
                        else
                        {
                            Mensajes.Error("No se ha seleccionado ninguna forma de pago, favor de volver a ingresar");
                            return val;
                        }
                    }
                    else
                    {
                        Mensajes.Error("No puede haber valores negativos en las faltas, favor de volver a ingresar");
                        return val;
                    }
                }
                else
                {
                    Mensajes.Error("Falta asignar los días de trabajo, favor de volver a ingresar");
                    return val;
                }
            }
            else
            {
                Mensajes.Error("La fecha de inicio es mayor que la fecha fin, favor de volver a ingresar");
                return val;
            }
        }
    }
}
