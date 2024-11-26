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
    public partial class frmChartProgress : DevExpress.XtraEditors.XtraForm
    {
        private BindingSource ProgressChartList = new BindingSource();
        public frmChartProgress()
        {
            InitializeComponent();
        }

        private void frmChartProgress_Load(object sender, EventArgs e)
        {
            LoadProgressChart();
        }
        private void LoadProgressChart()
        {
            ProgressChartList.DataSource = ChartProgressDAO.Instance.GetChartProgress();
            chartProgress.DataSource = ProgressChartList;
            chartProgress.Series[0].ArgumentDataMember = "StatusDescription";
            chartProgress.Series[0].ValueDataMembers.AddRange(new string[] { "Total" });
        }
    }
}