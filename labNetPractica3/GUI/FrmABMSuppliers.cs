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
            ConfigurarDataGrid();
            _blSuppliers = new BL_Suppliers();
            btnRefrescar_Click(null, new EventArgs());


        }
        private void ConfigurarDataGrid()
        {
            dgvSuppliers.MultiSelect = false;
            dgvSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSuppliers.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void MostrarDataGrid(object o)
        {
            dgvSuppliers.DataSource = null;
            dgvSuppliers.DataSource = o;
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

        private bool Existe()
        {
            bool existe = false;
            try
            {
                existe = _blSuppliers.Existe(txtCompanyName.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            return existe;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    if (!Existe())
                    {
                        Suppliers SP = new Suppliers();
                        SP.CompanyName = txtCompanyName.Text;
                        SP.ContactName = txtContact.Text;
                        SP.ContactTitle = txtContactTitle.Text;
                        SP.City = txtCity.Text;

                        _blSuppliers.Insert(SP);
                        MessageBox.Show("insertado");
                        btnRefrescar_Click(null, new EventArgs());
                    }
                    else
                        MessageBox.Show("Nombre de compañía existente");

                }
                else
                    MessageBox.Show("Ingresar campo obligatorio (*)");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                LimpiarTextboxs();
            }
        }

        private void LimpiarTextboxs()
        {
            this.txtCity.Text = "";
            this.txtCompanyName.Text = "";
            this.txtContact.Text = "";
            this.txtContactTitle.Text = "";

        }
        private bool Validar()
        {
            if (!string.IsNullOrEmpty(txtCompanyName.Text.Trim()))
                return true;
            else
                return false;

        }


        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSuppliers.RowCount > 0)
                {
                    Suppliers SPP = null;
                    SPP = dgvSuppliers.SelectedRows[0].DataBoundItem as Suppliers;
                    if (SPP != null)
                    {
                        if (!string.IsNullOrEmpty(txtCompanyName.Text.Trim()))
                        {
                            SPP.City = txtCity.Text;
                            SPP.CompanyName = txtCompanyName.Text;
                            SPP.ContactTitle = txtContactTitle.Text;
                            SPP.ContactName = txtContact.Text;
                            _blSuppliers.Modify(SPP);
                            MessageBox.Show("modificado");
                            btnRefrescar_Click(null, new EventArgs());
                        }
                        else
                            MessageBox.Show("Escriba un CompanyName para modificar");

                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                LimpiarTextboxs();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSuppliers.RowCount > 0)
                {
                    Suppliers SPP = null;
                    SPP = dgvSuppliers.SelectedRows[0].DataBoundItem as Suppliers;
                    _blSuppliers.Delete(SPP);
                    MessageBox.Show("eliminado");
                    btnRefrescar_Click(null, new EventArgs());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                LimpiarTextboxs();
            }

        }

        private void dgvSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            Suppliers SP = null;
            if (dgvSuppliers.RowCount > 0)
            {

                SP = dgvSuppliers.SelectedRows[0].DataBoundItem as Suppliers;
                if (SP != null)
                {
                    txtContactTitle.Text = SP.ContactTitle ?? "";
                    txtCity.Text = SP.City ?? "";
                    txtContact.Text = SP.ContactName ?? "";
                    txtCompanyName.Text = SP.CompanyName ?? "";
                }
            }
        }
    }
}
