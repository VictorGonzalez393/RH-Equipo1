using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroNegocio_RH_ERP_ISC_8A
{
    class Mensajes
    {
        public static void Error(string error)
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void Info(string info)
        {
            MessageBox.Show(info, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult PreguntaAdvertencia(string pregunta)
        {
            return MessageBox.Show(pregunta, "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        public static DialogResult PreguntaInfo(string pregunta)
        {
            return MessageBox.Show(pregunta, "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
    }
}
