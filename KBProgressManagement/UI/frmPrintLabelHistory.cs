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
    public partial class frmPrintLabelHistory : DevExpress.XtraEditors.XtraForm
    {
        private BindingSource historyList = new BindingSource();
        public frmPrintLabelHistory()
        {
            InitializeComponent();
        }

        private void frmPrintLabelHistory_Load(object sender, EventArgs e)
        {
            LoadPrintLabelHistory();
        }
        private void LoadPrintLabelHistory()
        {
            historyList.DataSource =PrintLabelHistoryDAO.Instance.GetLabelHistoryList();
            dgPrintLabelHistory.DataSource = historyList;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadPrintLabelHistory();
        }
    }
}