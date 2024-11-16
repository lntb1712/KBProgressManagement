using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using KBProgressManagement.DAO;
using KBProgressManagement.DTO;
using SATO.MLComponent;
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
    public partial class frmPrintLabel : DevExpress.XtraEditors.XtraForm
    {
        private BindingSource productList = new BindingSource();
        private BindingSource printLabelDetailList = new BindingSource();
        private BindingSource processDetail = new BindingSource();



        public frmPrintLabel()
        {
            InitializeComponent();
        }

        private void frmPrintLabel_Load(object sender, EventArgs e)
        {
            pcbPrintPreview.LayoutFile = Application.StartupPath + @"\Layout.mllayx";
            txtPrintTime.Text = DateTime.Now.ToString("dd/MM/yyyy");
            cboPrintName.Properties.DataSource = System.Drawing.Printing.PrinterSettings.InstalledPrinters;
            LoadCBOProductCode();
            cboProductID.ItemIndex = 0;

            BindingData();
            txtQuantity.Enabled = false;



        }
        private void LoadCBOProductCode()
        {
            productList.DataSource = ProductRegistrationDAO.Instance.GetProductList();
            cboProductID.Properties.DataSource = productList;
            cboProductID.Properties.ValueMember = "ProductCode";
            cboProductID.Properties.DisplayMember = "ProductCode";
        }

        private void cboProductID_EditValueChanged(object sender, EventArgs e)
        {
            txtProductName.Text = cboProductID.GetColumnValue("ProductName").ToString();
            LoadCBOProductCode();
            LoadPrintLabelDetail();
            LoadPrint();
        }

        private void BindingData()
        {
            txtQuantity.DataBindings.Add(new Binding("Text", dgPrintLabelDetail.DataSource, "BoxQty", true, DataSourceUpdateMode.Never));
        }

        private void LoadPrintLabelDetail()
        {
            printLabelDetailList.DataSource = PrintLabelDetailDAO.Instance.GetPrintLabelDetail(cboProductID.EditValue.ToString());
            dgPrintLabelDetail.DataSource = printLabelDetailList;
        }

        private void gvPrintLabelDetail_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            GridView view = sender as GridView;
            PrintLabelDetailDTO printLabelDetail = view.GetRow(e.RowHandle) as PrintLabelDetailDTO;
            if (printLabelDetail != null)
            {
                processDetail.DataSource = ProcessDetailForPrintLabelDAO.Instance.GetProcessListForPrintLabel(printLabelDetail.PartCode);
                e.ChildList = processDetail;
            }
        }

        private void gvPrintLabelDetail_MasterRowGetRelationCount(object sender, MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void gvPrintLabelDetail_MasterRowGetRelationName(object sender, MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "Process List";
        }
        private void LoadPrint()
        {
            if (gvPrintLabelDetail.RowCount <= 0)
            {
                return;
            }
            string partCode = gvPrintLabelDetail.GetRowCellValue(gvPrintLabelDetail.FocusedRowHandle, colPartCode).ToString();
            string partNameVN = gvPrintLabelDetail.GetRowCellValue(gvPrintLabelDetail.FocusedRowHandle, colPartNameVN).ToString();
            string partNameJP = gvPrintLabelDetail.GetRowCellValue(gvPrintLabelDetail.FocusedRowHandle, colPartNameJP).ToString();
            try
            {
                pcbPrintPreview.SetPrnDataField("lbl_ProductCode", cboProductID.EditValue.ToString());
                pcbPrintPreview.SetPrnDataField("lbl_ProductName", txtProductName.Text);
                pcbPrintPreview.SetPrnDataField("lbl_QR", autoIncreaseBoxNo().ToString());
                pcbPrintPreview.SetPrnDataField("lbl_LotNo", txtLotNo.Text);
                pcbPrintPreview.SetPrnDataField("lbl_BoxId", autoIncreaseBoxNo().ToString());
                pcbPrintPreview.SetPrnDataField("lbl_PartName1", partNameVN.ToString());
                pcbPrintPreview.SetPrnDataField("lbl_PartName2", partNameJP.ToString());

                List<ProcessDetailForPrintLabelDTO> detailList = ProcessDetailForPrintLabelDAO.Instance.GetProcessListForPrintLabel(partCode);
                for (int i = 0; i < detailList.Count; i++)
                {
                    string PrnField1 = "lbl_PC" + (i + 1).ToString() + "Name1";
                    string PrnField2 = "lbl_PC" + (i + 1).ToString() + "Name2";
                    pcbPrintPreview.SetPrnDataField(PrnField1, detailList[i].ProcessNameVN.ToString());
                    pcbPrintPreview.SetPrnDataField(PrnField2, detailList[i].ProcessNameJP.ToString());
                }

                pcbPrintPreview.SetPrnDataField("Print quantity", "1");
                int result = pcbPrintPreview.Output();
                if (result != 0)
                {
                    MessageBox.Show($"Error MLV6 {result}", "SATO WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "SATO WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error); }




        }

        private void cboProductID_Properties_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            LoadCBOProductCode();
            LoadPrintLabelDetail();

        }

        private int autoIncreaseBoxNo()
        {
            try
            {
                string query = "exec CheckBoxNo";
                object result = DataProvider.Instance.ExecuteScalar(query, new object[] { });
                if (result != DBNull.Value)
                {
                    int boxTemp = Convert.ToInt32(result);
                    boxTemp++;
                    return boxTemp;

                }
                else
                {
                    int boxTempNew = 0;
                    boxTempNew++;
                    result = Convert.ToInt32(DateTime.Now.ToString("yyMMdd") + boxTempNew.ToString("D3"));
                    boxTempNew = Convert.ToInt32(result);
                    return boxTempNew;
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }


        }

        private void PrintSetting(int boxNo)
        {
            try
            {
                MLComponent mLComponent = new MLComponent();
                string filePath = Application.StartupPath + @"\Layout.mllayx";
                mLComponent.LayoutFile = filePath;

                mLComponent.Setting = "DRV:" + cboPrintName.EditValue.ToString();
                mLComponent.Protocol = SATO.MLComponent.Protocols.Status4;
             


                mLComponent.Timeout = 3;


                int result = 0;
                if (gvPrintLabelDetail.RowCount <= 0)
                {
                    return;
                }
                string partCode = gvPrintLabelDetail.GetRowCellValue(gvPrintLabelDetail.FocusedRowHandle, colPartCode).ToString();
                string partNameVN = gvPrintLabelDetail.GetRowCellValue(gvPrintLabelDetail.FocusedRowHandle, colPartNameVN).ToString();
                string partNameJP = gvPrintLabelDetail.GetRowCellValue(gvPrintLabelDetail.FocusedRowHandle, colPartNameJP).ToString();

                mLComponent.SetPrnDataField("lbl_ProductCode", cboProductID.EditValue.ToString());
                mLComponent.SetPrnDataField("lbl_ProductName", txtProductName.Text);
                mLComponent.SetPrnDataField("lbl_QR", autoIncreaseBoxNo().ToString());
                mLComponent.SetPrnDataField("lbl_LotNo", txtLotNo.Text);
                mLComponent.SetPrnDataField("lbl_BoxId", boxNo.ToString());
                mLComponent.SetPrnDataField("lbl_PartName1", partNameVN.ToString());
                mLComponent.SetPrnDataField("lbl_PartName2", partNameJP.ToString());

                List<ProcessDetailForPrintLabelDTO> detailList = ProcessDetailForPrintLabelDAO.Instance.GetProcessListForPrintLabel(partCode);
                for (int i = 0; i < detailList.Count; i++)
                {
                    string PrnField1 = "lbl_PC" + (i + 1).ToString() + "Name1";
                    string PrnField2 = "lbl_PC" + (i + 1).ToString() + "Name2";
                    mLComponent.SetPrnDataField(PrnField1, detailList[i].ProcessNameVN.ToString());
                    mLComponent.SetPrnDataField(PrnField2, detailList[i].ProcessNameJP.ToString());
                }

                mLComponent.SetPrnDataField("Print quantity", "1");


                result = mLComponent.OpenPort(1);

                result = mLComponent.Output();
                result = mLComponent.Cut();

                result = mLComponent.ClosePort();
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnPrintLabel_Click(object sender, EventArgs e)
        {
            string TotalQuantity = txtTotalQuantity.Text;
            string LotNo = txtLotNo.Text;
            string ProductLine = txtProductLine.Text;
            string ProductCode = cboProductID.EditValue.ToString();
            DateTime DueDate = Convert.ToDateTime(dueDate.EditValue.ToString());
            int boxNo;

            if (TotalQuantity.Equals(""))
            {
                XtraMessageBox.Show("Error empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (LotNo.Equals(""))
            {
                XtraMessageBox.Show("Error empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ProductLine.Equals(""))
            {
                XtraMessageBox.Show("Error empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            if (cboPrintName.EditValue == null)
            {
                XtraMessageBox.Show("Please select printer", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dueDate.EditValue == null)
            {
                XtraMessageBox.Show("Please choose Due Date", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int rsOdd = Convert.ToInt32(TotalQuantity) / Convert.ToInt32(txtQuantity.Text);
            int rsOut = Convert.ToInt32(TotalQuantity) - Convert.ToInt32(txtQuantity.Text) * rsOdd;
            try
            {
                if (Convert.ToInt32(TotalQuantity) < Convert.ToInt32(txtQuantity.Text))
                {
                    boxNo = autoIncreaseBoxNo();
                    PrintLabelDAO.Instance.InsertAndUpdatePrintLabel(boxNo, ProductCode, gvPrintLabelDetail.GetFocusedRowCellValue(colPartCode).ToString(), ProductLine, LotNo, Convert.ToInt32(TotalQuantity),DueDate, Properties.Settings.Default.FullName);
                    PrintSetting(boxNo);
                }
                else
                {
                    for (int i = 1; i <= rsOdd; i++)
                    {
                        boxNo = autoIncreaseBoxNo();
                        PrintLabelDAO.Instance.InsertAndUpdatePrintLabel(boxNo, ProductCode, gvPrintLabelDetail.GetFocusedRowCellValue(colPartCode).ToString(), ProductLine, LotNo, Convert.ToInt32(txtQuantity.Text),DueDate, Properties.Settings.Default.FullName);
                        PrintSetting(boxNo);
                    }
                    if (Convert.ToInt32(TotalQuantity) % Convert.ToInt32(txtQuantity.Text) != 0)
                    {
                        boxNo = autoIncreaseBoxNo();
                        PrintLabelDAO.Instance.InsertAndUpdatePrintLabel(boxNo, ProductCode, gvPrintLabelDetail.GetFocusedRowCellValue(colPartCode).ToString(), ProductLine, LotNo, rsOut,DueDate, Properties.Settings.Default.FullName);
                        PrintSetting(boxNo);

                    }
                }
                XtraMessageBox.Show("Print Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.PrintName = cboPrintName.EditValue.ToString();
            Properties.Settings.Default.Save();

        }

        private void gvPrintLabelDetail_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            LoadPrint();
        }

    }
}