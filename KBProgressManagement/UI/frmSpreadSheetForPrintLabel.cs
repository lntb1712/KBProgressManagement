using DevExpress.Spreadsheet;
using DevExpress.XtraBars;
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
    public partial class frmSpreadSheetForPrintLabel : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        IWorkbook workbook;
        DataView dataView;
        string productCode, productName, partCode, partNameVN, partNameJP, LotNo;
        List<string>lstBox = new List<string> ();

        private void frmSpreadSheetForPrintLabel_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public frmSpreadSheetForPrintLabel(string productCode, string productName, string partCode, string partNameVN, string partNameJP,List<string>lstBox, string LotNo)
        {
            InitializeComponent();
            workbook = spreadsheetControl1.Document;
            workbook.LoadDocument(Application.StartupPath + "\\LayoutKB.xlsx", DocumentFormat.Xlsx);
            this.productCode = productCode;
            this.productName = productName;
            this.partCode = partCode;
            this.partNameVN = partNameVN;
            this.partNameJP = partNameJP;
            this.lstBox=lstBox;
            this.LotNo = LotNo;

        }
        private void LoadData()
        {
            Worksheet originalWorksheet = workbook.Worksheets[0];
            for (int i = 0; i < lstBox.Count; i++)
            {

                Worksheet copiedWorksheet = workbook.Worksheets.Add(lstBox[i].ToString());
                copiedWorksheet.CopyFrom(originalWorksheet);
                copiedWorksheet.Cells["B2"].Value = lstBox[i];
                copiedWorksheet.Cells["B3"].Value = productCode;
                copiedWorksheet.Cells["B4"].Value = productName;
                copiedWorksheet.Cells["B5"].Value = partNameVN;
                copiedWorksheet.Cells["B6"].Value = partNameJP;
                copiedWorksheet.Cells["B7"].Value = LotNo;
                Zen.Barcode.CodeQrBarcodeDraw qrBarcodeDraw = Zen.Barcode.BarcodeDrawFactory.CodeQr;
                var barcodeImage = qrBarcodeDraw.Draw(lstBox[i], 25);
                copiedWorksheet.Pictures.AddPicture(barcodeImage, copiedWorksheet.Cells["G2"]);
                List<ProcessDetailForPrintLabelDTO> detailList = ProcessDetailForPrintLabelDAO.Instance.GetProcessListForPrintLabel(partCode);
                List<string> lst = new List<string> { "B", "C", "D", "E", "F", "G", "H", "I" };
                for (int j = 0; j < detailList.Count; j++)
                {
                    copiedWorksheet.Cells[lst[j].ToString() + "8"].Value = detailList[j].ProcessNameVN.ToString();
                    copiedWorksheet.Cells[lst[j].ToString() + "9"].Value = detailList[j].ProcessNameJP.ToString();

                }
                
            }
            originalWorksheet.Visible = false;

        }
    }
}