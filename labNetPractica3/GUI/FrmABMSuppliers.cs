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
    public partial class FrmABMSuppliers : Form
    {
        private BL_Suppliers _blSuppliers;
        public FrmABMSuppliers()
        {
            InitializeComponent();
            _blSuppliers = new BL_Suppliers();
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
                MostrarDataGrid(_blSuppliers.GetListAll());
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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    Suppliers SP = new Suppliers();
                    SP.SupplierID = int.Parse(txtId.Text);
                    SP.CompanyName = txtCompanyName.Text;
                    SP.ContactName = txtContact.Text;
                    _blSuppliers.Insert(SP);
                }
                else
                    MessageBox.Show("Ingresar los 2 campos obligatoriamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private bool Validar()
        {
            if (!string.IsNullOrEmpty(txtId.Text.Trim()) &&
                !string.IsNullOrEmpty(txtCompanyName.Text.Trim()))
                return true;
            else
                return false;
        
        }
    }
}
