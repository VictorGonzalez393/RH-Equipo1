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
    
    public partial class NominasPercepciones_nuevo : Form
    {
        NominasPercepciones_DAO nominaspercepciones_DAO;
        public NominasPercepciones_nuevo()
        {
            InitializeComponent();
            nominaspercepciones_DAO = new NominasPercepciones_DAO();
        }

        private bool validarCampos()
        {
                if (!string.IsNullOrWhiteSpace(nomina_nominasp.Text))
                {
                    if (!string.IsNullOrWhiteSpace(percepcion_nominasp.Text))
                    {
                        return true;
                    }
                    else
                    {
                        DialogResult resultado = MessageBox.Show("El campo Percepcion se encuentra vacío", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("El campo de nomina se encuentra vacío", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
           
        }
    }
}
