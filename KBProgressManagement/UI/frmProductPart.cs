using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
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
    public partial class frmProductPart : DevExpress.XtraEditors.XtraForm
    {
        private BindingSource productPartList = new BindingSource();

        DXValidationProvider dxValidationProvider = new DXValidationProvider();
        public frmProductPart()
        {
            InitializeComponent();
            dxValidationProvider.ValidationMode = ValidationMode.Manual;
            InitValidationRules();
        }

        private void frmProductPart_Load(object sender, EventArgs e)
        {

            ButtonStatus(true);
            LoadData();
            LoadDataCombobox();
            BindingData();
        }
        private void InitValidationRules()
        {
            ConditionValidationRule notEmptyValidationRule = new ConditionValidationRule();
            notEmptyValidationRule.ConditionOperator = ConditionOperator.IsNotBlank;
            notEmptyValidationRule.ErrorText = "Vui lòng nhập thông tin";

            dxValidationProvider.SetValidationRule(cboProductCode, notEmptyValidationRule);
            dxValidationProvider.SetIconAlignment(cboProductCode, ErrorIconAlignment.MiddleRight);

            dxValidationProvider.SetValidationRule(cboPartCode, notEmptyValidationRule);
            dxValidationProvider.SetIconAlignment(cboPartCode, ErrorIconAlignment.MiddleRight);
        }

        private void ButtonStatus(bool status)
        {
            btnNew.Enabled = status;
            btnCancel.Enabled = !status;
            btnDelete.Enabled = status;
            btnRefresh.Enabled = status;

            cboProductCode.Enabled = !status;
            cboPartCode.Enabled = !status;
        }
        private void BindingData()
        {
            cboProductCode.DataBindings.Add(new Binding("Text", dgProductPart.DataSource, "ProductCode", true, DataSourceUpdateMode.Never));
            cboPartCode.DataBindings.Add(new Binding("Text", dgProductPart.DataSource, "PartCode", true, DataSourceUpdateMode.Never));
        }

        private void LoadData()
        {
            productPartList.DataSource = ProductPartDAO.Instance.GetProductPartList();
            dgProductPart.DataSource = productPartList;
        }

        private void LoadDataCombobox()
        {
            cboProductCode.Clear();
            foreach (var item in ProductRegistrationDAO.Instance.GetProductList())
            {
                cboProductCode.Properties.Items.Add(item.ProductCode);
            }

            cboPartCode.Clear();
            foreach (var item in PartMasterDAO.Instance.GetPartMasterList())
            {
                cboPartCode.Properties.Items.Add(item.PartCode);
            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ButtonStatus(false);
            cboPartCode.Text = string.Empty;
            cboProductCode.Text = string.Empty;

            cboProductCode.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider.Validate() == false)
            {
                return;
            }

            string productCode = cboProductCode.Text.Trim();
            string partCode = cboPartCode.Text.Trim();

            if (btnNew.Enabled == false)
            {
                try
                {
                    ProductPartDAO.Instance.InsertAndUpdateProductPart(productCode, partCode, Properties.Settings.Default.FullName);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                try
                {
                    ProductPartDAO.Instance.InsertAndUpdateProductPart(productCode, partCode, Properties.Settings.Default.FullName);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            LoadData();
            ButtonStatus(true);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadData();
            ButtonStatus(true);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("Do you want to delete?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (int rowHandle in gvProductPart.GetSelectedRows())
                    {
                        ProductPartDAO.Instance.DeleteProductPart(gvProductPart.GetRowCellValue(rowHandle, colProductCode).ToString(), gvProductPart.GetRowCellValue(rowHandle, colPartCode).ToString());
                    }
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}