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
    public partial class Nomina_nuevo : Form
    {
        int idEmp;
        double salarioE = 0;
        double salarioMin = 123.22;
        Nomina_DAO nomina_DAO =new Nomina_DAO();
        Percepciones_DAO percepciones_dao = new Percepciones_DAO();
        Deducciones_DAO deducciones_dao = new Deducciones_DAO();
        FormasPago_DAO fp_dao = new FormasPago_DAO();
        Empleados_DAO em_dao = new Empleados_DAO();
        double sueldoTotal = 0;
        public Nomina_nuevo()
        {
            InitializeComponent();
        }
        public Nomina_nuevo(string empleado, int idEmp)
        {
            InitializeComponent();
            this.idEmp = idEmp;
            txtEmp.Text = empleado;
            salarioE = em_dao.getSalario(this.idEmp);
            
            
        }

        private void textTotalD_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nomina_nuevo_Load(object sender, EventArgs e)
        {
            idNomina.Value = nomina_DAO.getMaxID();
            string consulta_where = " where estatus=@estatus";
            List<string> parametros = new List<string>();
            parametros.Add("@estatus");
            List<object> valores = new List<object>();
            valores.Add('A');

            List<Percepcion> percepciones = percepciones_dao.consultaGeneral(consulta_where,parametros,valores);
            foreach(Percepcion per in percepciones) 
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void totalP_ValueChanged(object sender, EventArgs e)
        {

        }

        private void atrásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void IniciotoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Principal p = new Principal();
            this.SetVisibleCore(false);
            p.ShowDialog();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formaPago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void listDeducciones_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCalPer_Click(object sender, EventArgs e)
        {
            double tD=0, tP=0;
           
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
                    cantNeta.Text =Convert.ToString(cNeta);
                }
                if (salarioE>salarioMin && tD == 0)
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
                            if(Convert.ToDecimal(totalP.Text)!=0 && Convert.ToDecimal(cantNeta.Text) != 0)
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

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (validarDatos()==true)
            {
                if (nomina_DAO.existe(fechaPago.Text, idEmp)==false)
                {
                    FormasPago fp = (FormasPago)formaPago_cm.SelectedItem;
                    Nomina n = new Nomina(idEmp, (int)idNomina.Value, fechaPago.Text,
                        Convert.ToDecimal(totalP.Text), Convert.ToDecimal(totalD.Text), Convert.ToDecimal(cantNeta.Text), (int)diasTrabajados.Value, (int)faltas.Value,
                        fechaInicio.Text, fechaFin.Text, fp.nombre, 'A');
                    if (nomina_DAO.insertar(n) == true)
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
                        Mensajes.Info("La nómina se registro correctamente");

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

        private void fechaInicio_ValueChanged(object sender, EventArgs e)
        {

        }
    } 
}
