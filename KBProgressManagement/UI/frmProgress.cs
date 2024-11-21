using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
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
    public partial class frmProgress : DevExpress.XtraEditors.XtraForm
    {
        private BindingSource listProgress = new BindingSource();
        private BindingSource listProgressDetail = new BindingSource();
        private BindingSource listProcessDetail = new BindingSource();
        private BindingSource listSearch = new BindingSource();
        public frmProgress()
        {
            InitializeComponent();
        }

        private void frmProgress_Load(object sender, EventArgs e)
        {
            LoadProgress();
            ExpandAllMasterRows(gvProgress);
            LoadProgressBar();
        }
        public void ExpandAllMasterRows(GridView View)
        {
            View.BeginUpdate();
            try
            {
                int dataRowCount = View.DataRowCount;
                for (int rHandle = 0; rHandle < dataRowCount; rHandle++)
                    View.SetMasterRowExpanded(rHandle, true);
            }
            finally
            {
                View.EndUpdate();
            }
        }
        private void LoadProgressBar() {
            int count =gvProgress.RowCount;
 
           
            for (int k = 0; k < count; k++) {
                {
                    int countStatusProcess = 0;
                    //string lotNo = (string)gvProgress.GetRowCellValue(k, colLotNo);
                    //string productCode= (string)gvProgress.GetRowCellValue(k, colProductCode);
                    //string partCode= (string)gvProgress.GetRowCellValue(k, colPartCode);
                    //listProcessDetail.DataSource=ProgressDetailDAO.Instance.GetProgressDetailList(lotNo,productCode,partCode);
                    GridView view = (GridView)gvProgress.GetDetailView(k,gvProgress.GetVisibleDetailRelationIndex(k));

                    if (view != null)
                    {
                      
                        for (int j = 0; j < view.RowCount; j++)
                        {
                            if ((DateTime)view.GetRowCellValue(j,colUpdateTime)!=default(DateTime))
                            {
                                countStatusProcess++;
                            }
                        }
           
                        float result = (float)(countStatusProcess)/(float)(view.RowCount) * 100;
                        gvProgress.SetRowCellValue(k,colProgressBar, result);
                    }


                } 
            }

        }

        private void LoadProgress()
        {
            listProgress.DataSource = ProgressDAO.Instance.GetProgress();
            dgProgress.DataSource = listProgress.DataSource;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProgress();
            ExpandAllMasterRows(gvProgress);
            LoadProgressBar();
        }

        private void gvProgress_MasterRowEmpty(object sender, MasterRowEmptyEventArgs e)
        {
            GridView view = sender as GridView;
            ProgressDTO progress = view.GetRow(e.RowHandle) as ProgressDTO;
            if (progress != null)
            {
                e.IsEmpty = false;
            }
        }
        private void gvProgress_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void gvProgress_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            GridView view = sender as GridView;
            ProgressDTO progress = view.GetRow(e.RowHandle) as ProgressDTO;
            if (progress != null)
            {
                e.ChildList = ProgressDetailDAO.Instance.GetProgressDetailList(progress.LotNo, progress.ProductCode, progress.PartCode);
            }
        }

        private void gvProgress_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "Progress Detail";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {


            if (cboFromDate.EditValue == null)
            {
                XtraMessageBox.Show("Error empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (cboToDate.EditValue == null)
            {
                XtraMessageBox.Show("Error empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DateTime fromDate = Convert.ToDateTime(cboFromDate.EditValue.ToString());
            DateTime toDate = Convert.ToDateTime(cboToDate.EditValue.ToString());

            listSearch.DataSource = ProgressDAO.Instance.GetProgressSearch(fromDate, toDate);
            dgProgress.DataSource = listSearch;
            ExpandAllMasterRows(gvProgress);
            LoadProgressBar();

        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel (*.xlsx )|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                XlsxExportOptionsEx options = new XlsxExportOptionsEx();
                options.ExportType = DevExpress.Export.ExportType.WYSIWYG;
                gvProgress.OptionsPrint.PrintDetails = true;
                gvProgress.OptionsPrint.ExpandAllDetails = true;
                dgProgress.ExportToXlsx(saveFileDialog.FileName, options);
            }
            else
            {
                return;
            }
        }

     
      

       


        //private void dgProgress_ViewRegistered(object sender, DevExpress.XtraGrid.ViewOperationEventArgs e)
        //{
        //    if (e.View.IsDetailView == false)
        //        return;

        //    (e.View as GridView).RowCellClick += gvProgressDetail_RowCellClick;
        //}



    }
}