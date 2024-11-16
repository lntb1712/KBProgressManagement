﻿using DevExpress.XtraEditors;
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
    public partial class frmReprint : DevExpress.XtraEditors.XtraForm
    {
        private BindingSource listPrintLabelAgain = new BindingSource();
        private List<string> cutModeList = new List<string>();
        public frmReprint()
        {
            InitializeComponent();
        }

     

        

        private void LoadPrintLabelAgainList()
        {
            listPrintLabelAgain.DataSource = PrintLabelDAO.Instance.GetLabelList();
            dgReprint.DataSource = listPrintLabelAgain;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadPrintLabelAgainList();
        }

        private void BindingData()
        {
            txtBoxNo.DataBindings.Add(new Binding("Text", dgReprint.DataSource, "BoxNo", true, DataSourceUpdateMode.Never));
            txtPartCode.DataBindings.Add(new Binding("Text", dgReprint.DataSource, "PartCode", true, DataSourceUpdateMode.Never));
            txtLotNo.DataBindings.Add(new Binding("Text", dgReprint.DataSource, "LotNo", true, DataSourceUpdateMode.Never));
        }
        private void PrintSetting()
        {
            try
            {
                MLComponent mLComponent = new MLComponent();
                string filePath = Application.StartupPath + @"\Label1-2.mllayx";
                mLComponent.LayoutFile = filePath;

                mLComponent.Setting = "DRV:" + cboPrintName.EditValue.ToString();
                mLComponent.Protocol = SATO.MLComponent.Protocols.Status4;

                mLComponent.Timeout = 3;


                int result = 0;
                if (gvReprint.RowCount <= 0)
                {
                    return;
                }
                string partCode = gvReprint.GetRowCellValue(gvReprint.FocusedRowHandle, colPartCode).ToString();
                string partNameVN = gvReprint.GetRowCellValue(gvReprint.FocusedRowHandle, colPartNameVN).ToString();
                string partNameJP = gvReprint.GetRowCellValue(gvReprint.FocusedRowHandle, colPartNameJP).ToString();
                string boxNo = gvReprint.GetRowCellValue(gvReprint.FocusedRowHandle, colBoxNo).ToString();
                string lotNo = gvReprint.GetRowCellValue(gvReprint.FocusedRowHandle, colLotNo).ToString();
                string productCode = gvReprint.GetRowCellValue(gvReprint.FocusedRowHandle, colProductCode).ToString();
                string productName = gvReprint.GetRowCellValue(gvReprint.FocusedRowHandle, colProductName).ToString();


                mLComponent.SetPrnDataField("lbl_ProductCode", productCode);
                mLComponent.SetPrnDataField("lbl_ProductName", productName);
                mLComponent.SetPrnDataField("lbl_QR", boxNo);
                mLComponent.SetPrnDataField("lbl_LotNo", txtLotNo.Text);
                mLComponent.SetPrnDataField("lbl_BoxId", boxNo);
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (cboPrintName.EditValue == null)
            {
                XtraMessageBox.Show("Please select printer", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            foreach (int rowHandle in gvReprint.GetSelectedRows())
            {
                try
                {
                    PrintSetting();
                    int boxNo = (int)gvReprint.GetRowCellValue(gvReprint.FocusedRowHandle, colBoxNo);
                    string partCode = gvReprint.GetRowCellValue(gvReprint.FocusedRowHandle, colPartCode).ToString();
                    string productLine = gvReprint.GetRowCellValue(gvReprint.FocusedRowHandle, colProductLine).ToString();
                    string lotNo = gvReprint.GetRowCellValue(gvReprint.FocusedRowHandle, colLotNo).ToString();
                    int quantity = (int)gvReprint.GetRowCellValue(gvReprint.FocusedRowHandle, colQuantity);
                    string productCode = gvReprint.GetRowCellValue(gvReprint.FocusedRowHandle, colProductCode).ToString();
                    DateTime dueDate= DateTime.Parse(gvReprint.GetRowCellValue(gvReprint.FocusedRowHandle,colDueDate).ToString());
                    PrintLabelHistoryDAO.Instance.InsertPrintLabelHistory(boxNo, productCode, partCode, productLine, lotNo, quantity,dueDate, Properties.Settings.Default.FullName);
                    XtraMessageBox.Show("Print Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {

                    XtraMessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmReprint_Load(object sender, EventArgs e)
        {
            LoadPrintLabelAgainList();
            cboPrintName.Properties.DataSource = System.Drawing.Printing.PrinterSettings.InstalledPrinters;

            cboPrintName.EditValue = Properties.Settings.Default.PrintName;



            BindingData();

            txtBoxNo.Enabled = false;
            txtPartCode.Enabled = false;
            txtLotNo.Enabled = false;
        }
    }
}