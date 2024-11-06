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
    public partial class frmStageRegistration : DevExpress.XtraEditors.XtraForm
    {
        private BindingSource stageList = new BindingSource();
        private List<string> statusList = new List<string>();
        public frmStageRegistration()
        {
            InitializeComponent();

        }
        private void ButtonStatus(bool status)
        {
            btnNew.Enabled = status;
            btnDelete.Enabled = status;
            btnCancel.Enabled = !status;
            btnRefresh.Enabled = status;
            txtProcessID.Enabled = !status;
        }

        private void frmStageRegistration_Load(object sender, EventArgs e)
        {
            LoadStageList();
            ButtonStatus(true);
            BindingData();
        }
        private void LoadStageList()
        {
            stageList.DataSource = StageRegistrationDAO.Instance.GetStageRegistrationList();
            dgProcess.DataSource = stageList;
        }




        private void btnNew_Click(object sender, EventArgs e)
        {
            ButtonStatus(false);

            txtProcessID.Text = string.Empty;
            txtProcessNameJP.Text = string.Empty;
            txtProcessNameVN.Text = string.Empty;

            txtProcessID.Focus();
        }
        private void BindingData()
        {
            txtProcessID.DataBindings.Add(new Binding("Text", dgProcess.DataSource, "ProcessID", true, DataSourceUpdateMode.Never));
            txtProcessNameVN.DataBindings.Add(new Binding("Text", dgProcess.DataSource, "ProcessNameVN", true, DataSourceUpdateMode.Never));
            txtProcessNameJP.DataBindings.Add(new Binding("Text", dgProcess.DataSource, "ProcessNameJP", true, DataSourceUpdateMode.Never));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string ProcessID = txtProcessID.Text;
            string ProcessNameVN = txtProcessNameVN.Text;
            string ProcessNameJP = txtProcessNameJP.Text;


            if (ProcessID.Equals(""))
            {
                XtraMessageBox.Show("Error Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ProcessNameVN.Equals(""))
            {
                XtraMessageBox.Show("Error Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ProcessNameJP.Equals(""))
            {
                XtraMessageBox.Show("Error Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            if (btnNew.Enabled == false)
            {
                try
                {
                    StageRegistrationDAO.Instance.InsertAndUpdateProcessMaster(ProcessID, ProcessNameVN, ProcessNameJP, Properties.Settings.Default.FullName);
                    XtraMessageBox.Show("Insert Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    StageRegistrationDAO.Instance.InsertAndUpdateProcessMaster(ProcessID, ProcessNameVN, ProcessNameJP, Properties.Settings.Default.FullName);
                    XtraMessageBox.Show("Update Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            LoadStageList();

            ButtonStatus(true);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("Do you want to delete?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (int rowHandle in gvProcess.GetSelectedRows())
                    {

                        StageRegistrationDAO.Instance.DeleteProcessMaster(gvProcess.GetRowCellValue(rowHandle, colProcessID).ToString());

                    }


                    LoadStageList();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtProcessID.Text = string.Empty;
            txtProcessNameVN.Text = string.Empty;
            txtProcessNameJP.Text = string.Empty;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ButtonStatus(true);
            LoadStageList();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadStageList();
        }
    }
}