using BE;
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
    public partial class FrmShippers : Form
    {
        private BL_Shippers _blShippers;
        public FrmShippers()
        {
            InitializeComponent();
            _blShippers = new BL_Shippers();
        }

        private void MostrarDataGrid(object o)
        {
            dgvShippers.DataSource = null;
            dgvShippers.DataSource = o;
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            try
            {
                MostrarDataGrid(_blShippers.GetListAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
