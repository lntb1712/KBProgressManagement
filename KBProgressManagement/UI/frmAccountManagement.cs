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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace KBProgressManagement.UI
{
    public partial class frmAccountManagement : DevExpress.XtraEditors.XtraForm
    {
        private BindingSource accountList = new BindingSource();
        private BindingSource groupList = new BindingSource();

        DXValidationProvider dxValidationProvider = new DXValidationProvider();
        public frmAccountManagement()
        {
            InitializeComponent();
            dxValidationProvider.ValidationMode = ValidationMode.Manual;
            InitValidationRules();
        }

        private void frmAccountManagement_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadGroupData();
            ButtonStatus(true);
            BindingData();
        }

        private void LoadData()
        {
            accountList.DataSource = AccountManagementDAO.Instance.GetAccountList();
            dgAccountList.DataSource = accountList;
        }

        private void LoadGroupData()
        {
            groupList.DataSource = GroupManagementDAO.Instance.GetGroupManagementList();
            cboGroupID.Properties.DataSource = groupList;
            cboGroupID.Properties.DisplayMember = "GroupName";
            cboGroupID.Properties.ValueMember = "GroupID";
        }

        private void ButtonStatus(bool status)
        {
            btnNew.Enabled = status;
            btnDelete.Enabled = status;
            btnCancel.Enabled = !status;
            btnRefresh.Enabled = status;
            txtUserName.Enabled = !status;
        }

        private void BindingData()
        {
            txtUserName.DataBindings.Add(new Binding("Text", dgAccountList.DataSource, "UserID", true, DataSourceUpdateMode.Never));
            txtPassword.DataBindings.Add(new Binding("Text", dgAccountList.DataSource, "Password", true, DataSourceUpdateMode.Never));
            txtFullName.DataBindings.Add("Text", dgAccountList.DataSource, "Fullname", true, DataSourceUpdateMode.Never);
            cboGroupID.DataBindings.Add(new Binding("EditValue", dgAccountList.DataSource, "GroupID", true, DataSourceUpdateMode.Never));
        }

        private void InitValidationRules()
        {
            ConditionValidationRule notEmptyValidationRule = new ConditionValidationRule();
            notEmptyValidationRule.ConditionOperator = ConditionOperator.IsNotBlank;
            notEmptyValidationRule.ErrorText = "Vui lòng nhập thông tin";

            dxValidationProvider.SetValidationRule(txtUserName, notEmptyValidationRule);
            dxValidationProvider.SetIconAlignment(txtUserName, ErrorIconAlignment.MiddleRight);

            dxValidationProvider.SetValidationRule(txtPassword, notEmptyValidationRule);
            dxValidationProvider.SetIconAlignment(txtPassword, ErrorIconAlignment.MiddleRight);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ButtonStatus(false);
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtFullName.Text = string.Empty;
            cboGroupID.EditValue = string.Empty;
            txtFullName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider.Validate() == false)
            {
                return;
            }

            string userID = txtUserName.Text;
            string userPassword = txtPassword.Text;
            string fullname = txtFullName.Text;
            string groupID = cboGroupID.GetColumnValue("GroupID").ToString();

            if (btnNew.Enabled == false)
            {
                try
                {
                    AccountManagementDAO.Instance.InsertAccount(userID, userPassword, fullname, groupID, Properties.Settings.Default.FullName);
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
                    AccountManagementDAO.Instance.UpdateAccount(userID, userPassword, fullname, groupID, Properties.Settings.Default.FullName);
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
                    foreach (int rowHandle in gvAccountList.GetSelectedRows())
                    {
                        AccountManagementDAO.Instance.DeleteAccount(gvAccountList.GetRowCellValue(rowHandle, colUserName).ToString());
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

        private void cboGroupID_Enter(object sender, EventArgs e)
        {
            LoadGroupData();
        }
    }
}