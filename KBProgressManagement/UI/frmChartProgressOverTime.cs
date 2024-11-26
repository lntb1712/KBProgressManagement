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
    public partial class frmChartProgressOverTime : DevExpress.XtraEditors.XtraForm
    {
        private BindingSource ProgressOverTimeList = new BindingSource();
        public frmChartProgressOverTime()
        {
            InitializeComponent();
        }

        private void frmChartProgressOverTime_Load(object sender, EventArgs e)
        {
            ProgressOverTimeList.DataSource = ChartProgressOverTimeDAO.Instance.GetChartProgressOverTime();
            chartProgressOverTime.DataSource=ProgressOverTimeList;
            chartProgressOverTime.Series[0].ArgumentDataMember = "ProcessID";
            chartProgressOverTime.Series[0].ValueDataMembers.AddRange(new string[] { "Total" });
        }
    }
}