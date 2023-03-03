using BE;
using BLL;
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
        BLLTransportes NegocioTransporte;
        public FrmTransportes()
        {
            InitializeComponent();
            NegocioTransporte = new BLLTransportes();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Salir?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                Application.Exit();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                    if (NegocioTransporte.Lista_esMenoraDiez())
                    {
                        FrmAgregarTransporte frmAT = new FrmAgregarTransporte();
                        if (frmAT.ShowDialog() == DialogResult.OK)
                        {
                            var (ok, mensaje) = this.NegocioTransporte.AgregarLista(frmAT.TipoTransporte, frmAT.NumeroPasajeros, frmAT.NumeroTransporte);
                            if (ok)
                                MessageBox.Show("Agregado OK", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show(mensaje);
                        }
                    }
                    else
                        MessageBox.Show("Ya existen 10 transportes públicos");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);                
            }
           
        }
    }
}
