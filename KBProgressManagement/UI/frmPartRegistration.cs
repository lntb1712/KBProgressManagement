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
    public partial class frmPartRegistration : DevExpress.XtraEditors.XtraForm
    {
        private BindingSource partList = new BindingSource();
        private BindingSource partProcessList = new BindingSource();

        DXValidationProvider dxValidationProvider = new DXValidationProvider();

        public frmPartRegistration()
        {
            InitializeComponent();
            dxValidationProvider.ValidationMode = ValidationMode.Manual;
            InitValidationRules();
        }

        private void ButtonStatus(bool status)
        {
            btnNew.Enabled = status;
            btnCancel.Enabled = !status;
            btnDelete.Enabled = status;
            btnRefresh.Enabled = status;

            txtPartCode.Enabled = !status;
        }

        private void InitValidationRules()
        {
            ConditionValidationRule notEmptyValidationRule = new ConditionValidationRule();
            notEmptyValidationRule.ConditionOperator = ConditionOperator.IsNotBlank;
            notEmptyValidationRule.ErrorText = "Vui lòng nhập thông tin";

            dxValidationProvider.SetValidationRule(txtPartCode, notEmptyValidationRule);
            dxValidationProvider.SetIconAlignment(txtPartCode, ErrorIconAlignment.MiddleRight);
        }

        private void BindingData()
        {
            txtPartCode.DataBindings.Add(new Binding("Text", dgPartRegistration.DataSource, "PartCode", true, DataSourceUpdateMode.Never));
            txtPartNameVN.DataBindings.Add(new Binding("Text", dgPartRegistration.DataSource, "PartNameVN", true, DataSourceUpdateMode.Never));
            txtPartNameJP.DataBindings.Add(new Binding("Text", dgPartRegistration.DataSource, "PartNameJP", true, DataSourceUpdateMode.Never));
            txtBoxQty.DataBindings.Add(new Binding("Text", dgPartRegistration.DataSource, "BoxQty", true, DataSourceUpdateMode.Never));
        }

        private void LoadDataPartRegistration()
        {
            partList.DataSource = PartMasterDAO.Instance.GetPartMasterList();
            dgPartRegistration.DataSource = partList;
        }

        private void LoadDataPartProcess()
        {
            partProcessList.DataSource = PartProcessDAO.Instance.GetPartProcessList(txtPartCode.Text.Trim());
            dgProcess.DataSource = partProcessList;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ButtonStatus(false);
            txtPartCode.Text = string.Empty;
            txtPartNameVN.Text = string.Empty;
            txtPartNameJP.Text = string.Empty;
            txtBoxQty.Text = string.Empty;

            txtPartCode.Focus();
        }

        private void frmPartRegistration_Load(object sender, EventArgs e)
        {
            LoadDataPartRegistration();
            ButtonStatus(true);
            BindingData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider.Validate() == false)
            {
                return;
            }

            gvProcess.CloseEditor();

            string PartCode = txtPartCode.Text.Trim();
            string PartNameVN = txtPartNameVN.Text.Trim();
            string PartNameJP = txtPartNameJP.Text.Trim();
            int BoxQty = Convert.ToInt32(txtBoxQty.Text.Trim());

            if (btnNew.Enabled == false)
            {
                try
                {
                    var result = PartMasterDAO.Instance.InsertAndUpdatePartMaster(PartCode, PartNameVN, PartNameJP, BoxQty, Properties.Settings.Default.FullName);
                    if (result == true)
                    {
                        for (int i = 0; i < gvProcess.RowCount; i++)
                        {
                            string ProcessID = gvProcess.GetRowCellValue(i, colProcessID).ToString();
                            int ProcessNumber = Convert.ToInt32(gvProcess.GetRowCellValue(i, colNumberProcess).ToString());

                            PartProcessDAO.Instance.InsertAndUpdatePartProcess(ProcessID, PartCode, ProcessNumber, Properties.Settings.Default.FullName);
                        }

                    }
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
                    var result = PartMasterDAO.Instance.InsertAndUpdatePartMaster(PartCode, PartNameVN, PartNameJP, BoxQty, Properties.Settings.Default.FullName);
                    if (result == true)
                    {
                        for (int i = 0; i < PartProcessDAO.Instance.GetPartProcessList(PartCode).Count; i++)
                        {
                            string ProcessID = gvProcess.GetRowCellValue(i, colProcessID).ToString();
                            int ProcessNumber = Convert.ToInt32(gvProcess.GetRowCellValue(i, colNumberProcess).ToString());

                            PartProcessDAO.Instance.InsertAndUpdatePartProcess(ProcessID, PartCode, ProcessNumber, Properties.Settings.Default.FullName);
                        }

                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            LoadDataPartRegistration();
            ButtonStatus(true);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadDataPartRegistration();
            ButtonStatus(true);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDataPartRegistration();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("Do you want to delete?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (int rowHandle in gvPartRegistration.GetSelectedRows())
                    {
                        var result = PartProcessDAO.Instance.DeletePartProcess(gvPartRegistration.GetRowCellValue(rowHandle, colPartCode).ToString());
                        if (result == true)
                        {
                            PartMasterDAO.Instance.DeletePartMaster(gvPartRegistration.GetRowCellValue(rowHandle, colPartCode).ToString());
                        }
                    }
                    LoadDataPartRegistration();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtPartCode_TextChanged(object sender, EventArgs e)
        {
            LoadDataPartProcess();
        }
    }
}