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
    public partial class FrmMenu : Form
    {
        FrmABMSuppliers frm_AbmSuppliers;
        FrmShippers frm_Shippers;
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void aBMShippersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (frm_AbmSuppliers != null)
                    frm_AbmSuppliers.BringToFront();
                else
                {
                    frm_AbmSuppliers = new FrmABMSuppliers();
                    frm_AbmSuppliers.FormClosed += (o, args) => frm_AbmSuppliers = null;
                    frm_AbmSuppliers.MdiParent = this;
                    frm_AbmSuppliers.WindowState = FormWindowState.Maximized;
                    frm_AbmSuppliers.Show();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void listAboutShippersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (frm_Shippers != null)
                    frm_Shippers.BringToFront();
                else
                {
                    frm_Shippers = new FrmShippers();
                    frm_Shippers.FormClosed += (o, args) => frm_Shippers = null;
                    frm_Shippers.MdiParent = this;
                    frm_Shippers.WindowState = FormWindowState.Maximized;
                    frm_Shippers.Show();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea salir?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop) == DialogResult.OK)
                Application.Exit();
        }
    }
}
