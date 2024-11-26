using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using KBProgressManagement.DAO;
using KBProgressManagement.DTO;
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
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private List<GroupFunctionsDTO> groupFunctionsList = new List<GroupFunctionsDTO>();
        public frmMain()
        {
            InitializeComponent();
        }

        private void LoadPermission()
        {
            foreach(var item in Ribbon.SelectedPage.Ribbon.Items) 
            {
                if (item is DevExpress.XtraBars.BarButtonItem barButtonItem)
                {
                    if (barButtonItem.Name.Equals("btnLogOut"))
                    {
                        barButtonItem.Enabled = true;
                    }else if (groupFunctionsList.Where(element => element.FunctionID.Equals(barButtonItem.Name.ToString()) && element.Device.Equals("PC")).FirstOrDefault() != null )
                    {
                        barButtonItem.Enabled = groupFunctionsList.Where(element => element.FunctionID.Equals(barButtonItem.Name.ToString()) && element.Device.Equals("PC")).FirstOrDefault().IsEnable;
                    }
                    else
                    {
                        barButtonItem.Enabled = false;
                    }
                }
            }
        }

        public void OpenChildForm(Form childForm, Form parentForm)
        {
            Form formchild = Application.OpenForms[childForm.Name];
            if (formchild == null)
            {
                formchild = childForm;
                formchild.MdiParent = parentForm;
            }
            else
            {
                formchild.Focus();
            }
            formchild.Show();
        }

        private void btnUserManagement_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new frmAccountManagement(), this);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtFullName.Caption=Properties.Settings.Default.FullName;
            groupFunctionsList = GroupFunctionsDAO.Instance.GetGroupFunctionsList(Properties.Settings.Default.GroupID).ToList<GroupFunctionsDTO>();
            LoadPermission();
            dateNow.Caption = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnGroupManagement_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new frmGroupManagement(), this);
        }

        private void btnStageRegistration_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new frmStageRegistration(), this);
        }

        private void btnPart_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new frmPartRegistration(), this);
        }

        private void btnProduct_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new frmProductRegistration(), this);
        }

        private void btnProductPart_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new frmProductPart(), this);
        }

        private void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new frmPrintLabel(), this);
        }

        private void btnReprint_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new frmReprint(),this);
        }

        private void btnPrintHistory_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new frmPrintLabelHistory(), this);
        }

        private void btnProgress_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new frmProgress(), this);
        }

        private void btnProgressHistory_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new frmProgressHistory(), this);
        }

        private void btnChartOverTime_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new frmChartProgressOverTime(), this);
        }

        private void btnChartProgressCount_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new frmChartProgress(),this);
        }

        private void ribbon_SelectedPageChanged(object sender, EventArgs e)
        {
            LoadPermission();
        }

        private void btnLogOut_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmLogin frm = new frmLogin();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}