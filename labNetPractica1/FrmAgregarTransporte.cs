using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labNetPractica1
{
    public partial class FrmAgregarTransporte : Form
    {

        List<TransportePublico> L_Tpublico;
        public FrmAgregarTransporte()
        {
            InitializeComponent();
            
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

          
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (L_Tpublico != null)
            {
                if (Int32.Parse(txtNumero.Text) > 0 && L_TransportePub)
                    TransportePublico NuevoTP;
                if (rbOmnibus.Checked)
                    NuevoTP = new Omnibus();
                else if (rbTaxi.Checked)
                    NuevoTP = new Taxi();
            }

            
        }
    }
}
