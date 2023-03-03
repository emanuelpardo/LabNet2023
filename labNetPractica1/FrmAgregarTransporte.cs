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
    public partial class FrmAgregarTransporte : Form
    {
        public string TipoTransporte { get; set; }
        public int NumeroTransporte { get; set; }
        public int NumeroPasajeros { get; set; }
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
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtNumero.Text, out int numero_transporte))
                {
                    if (int.TryParse(txtPasajeros.Text, out int numero_pasajeros))
                    {
                        this.NumeroTransporte = numero_transporte;
                        this.NumeroPasajeros = numero_pasajeros;
                        if (rbOmnibus.Checked)
                            this.TipoTransporte = rbOmnibus.Text;
                        else
                            this.TipoTransporte = rbTaxi.Text;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                        MessageBox.Show("Agregue un número de pasajeros");
                }
                else
                    MessageBox.Show("Agregue un número de pasajeros");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+" - "+ex.StackTrace);
                this.DialogResult = DialogResult.Abort;
            }  
        }
    }
}
