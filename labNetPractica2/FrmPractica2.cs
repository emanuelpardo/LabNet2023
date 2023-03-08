using labNetPractica2.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using labNetPractica2.Logica;

namespace labNetPractica2
{
    public partial class FrmPractica2 : Form
    {
        Logic logic;
        public FrmPractica2()
        {
            InitializeComponent();
            logic = new Logic();
        }

        private void btnPrimerPunto_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(Decimal.Parse(txtNumeroUno.Text).DividirPorCero().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " - " + ex.StackTrace);
            }
        }

        public void BtnPuntoDos_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(Decimal.Parse(txtNumeroUno.Text).Dividir(Decimal.Parse(txtNumeroDos.Text)).ToString());
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Seguro Ingreso una letra o no ingreso nada! {ex.Message} - {ex.StackTrace}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Excepcion General: {ex.Message}  -  {ex.StackTrace}");
            }
            



        }

        private void btnPuntoTres_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show($"Resultado : {logic.PuntoTres_ExcepcionDesdeLogic_a_Presentacion(txtNumeroUno.Text, txtNumeroDos.Text)}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }

        }

        private void btnPuntoCuatro_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show($"Resultado : {logic.PuntoCuatro_ExcepcionPersonalizadaDesdeLogic_a_Presentacion(txtNumeroUno.Text, txtNumeroDos.Text)}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }
    }
}
