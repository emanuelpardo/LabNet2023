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

namespace GUI
{
    public partial class FrmTransportes : Form
    {
        BLLTransportes NegocioTransporte;
        public FrmTransportes()
        {
            InitializeComponent();
            NegocioTransporte = new BLLTransportes();
            ConfigurarDgv();


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Salir?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                Application.Exit();
        }

        public void ConfigurarDgv()
        {
            
            this.dgvTransporte.EditMode = DataGridViewEditMode.EditProgrammatically;
            this.dgvTransporte.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransporte.MultiSelect = false;
        }

        public void Mostrar(object o)
        {
            this.dgvTransporte.DataSource = null;
            this.dgvTransporte.DataSource = o;
        
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
                        {
                            Mostrar(NegocioTransporte.RetornarLista());
                            MessageBox.Show("Agregado OK", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
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

        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTransporte.RowCount > 0)
                {
                    TransportePublico TP = dgvTransporte.SelectedRows[0].DataBoundItem as TransportePublico;
                    if (TP != null)
                        MessageBox.Show(TP.Avanzar(), "Avance", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            if (dgvTransporte.RowCount > 0)
            {
                TransportePublico TP = dgvTransporte.SelectedRows[0].DataBoundItem as TransportePublico;
                if (TP != null)
                    MessageBox.Show(TP.Detenerse(), "Detenido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
