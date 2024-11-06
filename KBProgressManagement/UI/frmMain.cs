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
            foreach(var item in Ribbon.Items) 
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
        }

        private void btnGroupManagement_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new frmGroupManagement(), this);
        }
    }
}