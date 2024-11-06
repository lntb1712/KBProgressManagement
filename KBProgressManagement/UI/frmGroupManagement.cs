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
    public partial class frmGroupManagement : DevExpress.XtraEditors.XtraForm
    {
        private BindingSource groupManagementList = new BindingSource();
        private BindingSource groupFunctionsList = new BindingSource();

        DXValidationProvider dxValidationProvider = new DXValidationProvider();

        public frmGroupManagement()
        {
            InitializeComponent();
            dxValidationProvider.ValidationMode = ValidationMode.Manual;
            InitValidationRules();
        }

        private void frmGroupManagement_Load(object sender, EventArgs e)
        {
            LoadData();
            ButtonStatus(true);
            BindingData();
        }
        private void LoadData()
        {
            groupManagementList.DataSource = GroupManagementDAO.Instance.GetGroupManagementList();
            dgGroup.DataSource = groupManagementList;
        }

        private void ButtonStatus(bool status)
        {
            btnNew.Enabled = status;
            btnDelete.Enabled = status;
            btnCancel.Enabled = !status;
            btnRefresh.Enabled = status;
            txtGroupID.Enabled = !status;
        }

        private void BindingData()
        {
            txtGroupID.DataBindings.Add(new Binding("Text", dgGroup.DataSource, "GroupID", true, DataSourceUpdateMode.Never));
            txtGroupName.DataBindings.Add(new Binding("Text", dgGroup.DataSource, "GroupName", true, DataSourceUpdateMode.Never));
            txtGroupDescription.DataBindings.Add(new Binding("Text", dgGroup.DataSource, "GroupDescription", true, DataSourceUpdateMode.Never));
        }

        private void InitValidationRules()
        {

            ConditionValidationRule notEmptyValidationRule = new ConditionValidationRule();
            notEmptyValidationRule.ConditionOperator = ConditionOperator.IsNotBlank;
            notEmptyValidationRule.ErrorText = "Vui lòng nhập thông tin";

            dxValidationProvider.SetValidationRule(txtGroupID, notEmptyValidationRule);
            dxValidationProvider.SetIconAlignment(txtGroupID, ErrorIconAlignment.MiddleRight);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ButtonStatus(false);
            txtGroupID.Text = String.Empty;
            txtGroupName.Text = String.Empty;
            txtGroupDescription.Text = String.Empty;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ButtonStatus(true);
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider.Validate() == false)
            {
                return;
            }

            string groupID = txtGroupID.Text;
            string groupName = txtGroupName.Text;
            string groupDescription = txtGroupDescription.Text;
            bool isEnable = false;
            gvGroupFunctions.CloseEditor();

            if (btnNew.Enabled == false)
            {
                try
                {
                    GroupManagementDAO.Instance.InsertGroupManagement(groupID, groupName, groupDescription, Properties.Settings.Default.FullName);
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
                    GroupManagementDAO.Instance.UpdateGroupManagement(groupID, groupName, groupDescription, Properties.Settings.Default.FullName);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            for (int i = 0; i < gvGroupFunctions.RowCount; i++)
            {

                string functionID = gvGroupFunctions.GetRowCellValue(i, colFunctionID).ToString();
                if (gvGroupFunctions.GetRowCellDisplayText(i, colIsEnable).ToString() == "Checked")
                {
                    isEnable = true;
                }
                else
                {
                    isEnable = false;
                }
                try
                {
                    GroupFunctionsDAO.Instance.InsertAndUpdateGroupFunctionsList(groupID, functionID, isEnable, Properties.Settings.Default.FullName);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("Do you want to delete?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (int rowHandle in gvGroup.GetSelectedRows())
                    {
                        GroupManagementDAO.Instance.DeleteGroupManagement(gvGroup.GetRowCellValue(rowHandle, colGroupID).ToString());
                    }
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtGroupID_TextChanged(object sender, EventArgs e)
        {
            string groupID = txtGroupID.Text.Trim();
            groupFunctionsList.DataSource = GroupFunctionsDAO.Instance.GetGroupFunctionsList(groupID);
            dgGroupFunctions.DataSource = groupFunctionsList;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}