using BL;
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
    public partial class FrmLinQ : Form
    {
        private BL_LinQ _blLinQ;
        public FrmLinQ()
        {
            InitializeComponent();
            _blLinQ = new BL_LinQ();
            ConfigurarDataGrid();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfigurarDataGrid()
        {
            dgvLinq.MultiSelect = false;
            dgvLinq.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLinq.EditMode = DataGridViewEditMode.EditProgrammatically;

        }
        private void MostrarDataGrid(object o)
        {
            dgvLinq.DataSource = null;
            dgvLinq.DataSource = o;
        }

       
        private void btnPuntos_Click(object sender, EventArgs e)
        {
            try
            {
                MostrarDataGrid(_blLinQ.GetPuntoLinq(int.Parse(((Button)sender).Text)));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
