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
    public partial class frmProgressHistory : DevExpress.XtraEditors.XtraForm
    {
        private BindingSource listHistory = new BindingSource();
        public frmProgressHistory()
        {
            InitializeComponent();
        }

        private void frmProgressHistory_Load(object sender, EventArgs e)
        {
            LoadHistoryList();
        }
        private void LoadHistoryList()
        {
            listHistory.DataSource = ProgressHistoryDAO.Instance.GetHistoryList();
            dgProgressHistory.DataSource = listHistory;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadHistoryList();
        }
    }
}