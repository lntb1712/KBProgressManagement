using DevExpress.XtraEditors;
using KBProgressManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBProgressManagement.UI
{
    public partial class frmProductRegistration : DevExpress.XtraEditors.XtraForm
    {
        private BindingSource productList =new BindingSource();
        public frmProductRegistration()
        {
            InitializeComponent();
        }

        private void frmProductRegistration_Load(object sender, EventArgs e)
        {
            loadProductList();
            ButtonStatus(true);
            BindingData();
        }
        private void loadProductList() 
        {
            productList.DataSource = ProductRegistrationDAO.Instance.GetProductList();
            dgProductRegistration.DataSource = productList;
        }
        private void ButtonStatus(bool status)
        {
            btnNew.Enabled = status;
            btnDelete.Enabled = status;
            btnCancel.Enabled = !status;
            btnRefresh.Enabled = status;
            txtProductID.Enabled = !status;

        }
        private void BindingData()
        {
            txtProductID.DataBindings.Add(new Binding("Text",dgProductRegistration.DataSource,"ProductCode",true,DataSourceUpdateMode.Never));
            txtProductName.DataBindings.Add(new Binding("Text", dgProductRegistration.DataSource, "ProductName", true, DataSourceUpdateMode.Never));
            txtBoxQuantity.DataBindings.Add(new Binding("Text", dgProductRegistration.DataSource, "BoxQty", true, DataSourceUpdateMode.Never));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           string BoxQuantity=txtBoxQuantity.Text.Trim();
           string ProductCode=txtProductID.Text.Trim();
           string ProductName=txtProductName.Text.Trim();

            if(BoxQuantity.Equals(""))
            {
                XtraMessageBox.Show("Error Empty","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ProductCode.Equals(""))
            {
                XtraMessageBox.Show("Error Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ProductName.Equals(""))
            {
                XtraMessageBox.Show("Error Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (btnNew.Enabled==false)
            {
                try
                {
                    ProductRegistrationDAO.Instance.InsertAndUpdateProductMaster(ProductCode, ProductName, int.Parse(BoxQuantity), Properties.Settings.Default.FullName);
                    XtraMessageBox.Show("Insert Successfully","Information",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.ToString(), "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return ;
                }
            }
            else
            {
                try
                {
                    ProductRegistrationDAO.Instance.InsertAndUpdateProductMaster(ProductCode, ProductName, int.Parse(BoxQuantity), Properties.Settings.Default.FullName);
                    XtraMessageBox.Show("Insert Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            loadProductList();
            ButtonStatus(true);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("Do you want to delete?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (int rowHandle in gvProductRegistration.GetSelectedRows())
                    {

                        ProductRegistrationDAO.Instance.DeleteProductMaster(gvProductRegistration.GetRowCellValue(rowHandle, colProductID).ToString());
                    }


                    loadProductList();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtProductName.Text = string.Empty;
            txtProductID.Text = string.Empty;
            txtBoxQuantity.Text = string.Empty;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ButtonStatus(true);
            loadProductList();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadProductList();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ButtonStatus(false);

            txtProductName.Text = string.Empty;
            txtProductID.Text = string.Empty;
            txtBoxQuantity.Text = string.Empty;

            txtProductID.Focus();
        }
    }
}