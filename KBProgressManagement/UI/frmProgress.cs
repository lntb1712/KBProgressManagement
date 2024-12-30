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
        public void InexpandAllMasterRows(GridView View)
        {
            View.BeginUpdate();
            try
            {
                int dataRowCount = View.DataRowCount;
                for (int rHandle = 0; rHandle < dataRowCount; rHandle++)
                    View.SetMasterRowExpanded(rHandle, false);
            }
            finally
            {
                View.EndUpdate();
            }
        }
        private void LoadProgressBar() {
            ExpandAllMasterRows(gvProgress);
            int count =gvProgress.RowCount;

           
            for (int k = 0; k < count; k++) {
                {
                    float countStatusProcess = 0;
                    GridView view = (GridView)gvProgress.GetDetailView(k,gvProgress.GetVisibleDetailRelationIndex(k));
            
                    if (view != null)
                    {
                        float result = 0;
                        for (int j = 0; j < view.RowCount; j++)
                        {
                            
                            if ((DateTime)view.GetRowCellValue(j, colUpdateTime) != default(DateTime)&& (int)view.GetRowCellValue(j, colCQty) > 0)
                            {
                                
                                int temp1 = (int)view.GetRowCellValue(0, colTotal) + (int)view.GetRowCellValue(0, colNGQuantity);
                                int total = (int)view.GetRowCellValue(0, colCQty) + temp1;
                                int case1 = (int)view.GetRowCellValue(0, colCase);
                                int temp = Convert.ToInt32(case1 - ((float)(total) / (float)temp1));
                                float temp3 = (float)temp / (float)case1;
                                float temp6 = (float)(temp - 1) / (float)case1;
                                float temp2 = 0;
                                if ((int)view.GetRowCellValue(j, colCQty) <= 0)
                                {
                                    countStatusProcess += temp3;
                                }
                                else if ((int)view.GetRowCellValue(j, colCQty) > 0)
                                {
                                    if (j == 0)
                                    {
                                        countStatusProcess += temp3;
                                    }
                                    else
                                    {
                                     
                                        if(j==view.RowCount - 1)
                                        {
                                            if (temp > 1)
                                            {
                                                temp2 = (view.RowCount - j - 1) * temp6;
                                                countStatusProcess += temp6;
                                            }
                                            else
                                            {
                                                temp2 = (view.RowCount - j - 1) * temp3;
                                                countStatusProcess += temp3;
                                            }
                                            
                                        }
                                        else
                                        {
                                            int temp4 = j + 1;
                                            if ((DateTime)view.GetRowCellValue(temp4, colUpdateTime) != default(DateTime) && (int)view.GetRowCellValue(temp4, colCQty) <= 0 && (int)view.GetRowCellValue(j, colCQty) != 0)
                                            {
                                                if (temp > 1)
                                                {
                                                    temp2 = (view.RowCount - j - 1) * temp6;
                                                    countStatusProcess += temp6;
                                                }
                                                else
                                                {
                                                    temp2 = (view.RowCount - j - 1) * temp3;
                                                    countStatusProcess += temp3;
                                                }
                                            }
                                        
                                        }
                                      
                                        if (j != 0)
                                        {
                                            result = (float)(countStatusProcess + temp2) / (float)(view.RowCount) * 100;
                                            break;
                                        }
                                    }
                                }
                                
                            }
                            else if ((DateTime)view.GetRowCellValue(j, colUpdateTime) != default(DateTime) && (int)view.GetRowCellValue(j, colCQty) <= 0 && (int)view.GetRowCellValue(0, colCQty) == 0)
                            {
                                countStatusProcess++;

                            }
                            else if ((DateTime)view.GetRowCellValue(j, colUpdateTime) != default(DateTime) && (int)view.GetRowCellValue(j, colCQty) <= 0 && (int)view.GetRowCellValue(0, colCQty) != 0)
                            {
                                int temp1 = (int)view.GetRowCellValue(0, colTotal) + (int)view.GetRowCellValue(0, colNGQuantity);
                                int total = (int)view.GetRowCellValue(0, colCQty) + temp1;
                                int case1 = (int)view.GetRowCellValue(0, colCase);
                                int temp = Convert.ToInt32(case1 - ((float)(total) / (float)temp1));
                                float temp3 = (float)temp / (float)case1;
                                float temp6 = (float)(temp - 1) / (float)case1;
                                float temp2 = 0;
                                countStatusProcess +=temp3;

                            }




                        }
                        if (result == 0)
                        {
                            result = (float)(countStatusProcess) / (float)(view.RowCount) * 100;
                        }
                        gvProgress.SetRowCellValue(k,colProgressBar, result);
                    }


                } 
            }
            InexpandAllMasterRows(gvProgress);

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
                ExpandAllMasterRows(gvProgress);
                dgProgress.ExportToXlsx(saveFileDialog.FileName, options);
            }
            else
            {
                return;
            }
        }

        private void gvProgress_MasterRowExpanded(object sender, CustomMasterRowEventArgs e)
        {
            GridView view = sender as GridView;
            GridView childView = view.GetDetailView(e.RowHandle, e.RelationIndex) as GridView;
            if (childView != null)
            {
                childView.Columns["ProcessID"].Caption = "Mã công đoạn";
                childView.Columns["ProcessNameVN"].Caption = "Tên công đoạn(Việt)";
                childView.Columns["ProcessNameJP"].Caption = "Tên công đoạn(Nhật)";
                childView.Columns["Total"].Caption ="Số lượng";
                childView.Columns["Case"].Caption = "Số lượng box";
                childView.Columns["NGQuantity"].Caption ="Số lượng hao hụt";
                childView.Columns["CQty"].Caption = "Số lượng chưa hoàn thành";
                childView.Columns["UpdateTime"].Caption = "Thời gian cập nhật";

                childView.Columns["ProcessID"].VisibleIndex = 0;
                childView.Columns["ProcessNameVN"].VisibleIndex =1;
                childView.Columns["ProcessNameJP"].VisibleIndex =2;
                childView.Columns["Total"].VisibleIndex =3;
                childView.Columns["Case"].VisibleIndex =4;
                childView.Columns["NGQuantity"].VisibleIndex= 5;
                childView.Columns["CQty"].VisibleIndex = 6;
                childView.Columns["UpdateTime"].VisibleIndex =7;

                childView.Columns["ProcessID"].Width = 225;
                childView.Columns["ProcessNameVN"].Width = 225;
                childView.Columns["ProcessNameJP"].Width = 225;
                childView.Columns["Total"].Width = 225;
                childView.Columns["Case"].Width = 225;
                childView.Columns["NGQuantity"].Width = 225;
                childView.Columns["CQty"].Width = 225;
                childView.Columns["UpdateTime"].Width = 225;

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