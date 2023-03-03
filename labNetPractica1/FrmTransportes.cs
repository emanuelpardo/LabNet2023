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
    public partial class FrmTransportes : Form
    {
        List<TransportePublico> L_TransportePub;
        public FrmTransportes()
        {
            InitializeComponent();
            L_TransportePub = new List<TransportePublico>();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Salir?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                Application.Exit();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (L_TransportePub?.Count < 10)
            {
                FrmAgregarTransporte frmAT = new FrmAgregarTransporte(L_TransportePub);
                if (frmAT.ShowDialog() == DialogResult.OK)
                { 
                    
                }
            }
            else
            {
                MessageBox.Show("Ya existen 10 transportes públicos");
            }
        }
    }
}
