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
    public partial class frmSpreadSheetForReprint : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        IWorkbook workbook;
        DataView dataView;
        List<string> lstBox = new List<string>();

        public frmSpreadSheetForReprint(List<string>lstBox)
        {
            InitializeComponent();
            workbook = spreadsheetControl1.Document;
            workbook.LoadDocument(Application.StartupPath + "\\LayoutKB.xlsx", DocumentFormat.Xlsx);
            this.lstBox = lstBox;
        }
        private void LoadData()
        {
            Worksheet originalWorksheet = workbook.Worksheets[0];
            for (int i = 0; i < lstBox.Count; i++)
            {

                Worksheet copiedWorksheet = workbook.Worksheets.Add(lstBox[i].ToString());
                copiedWorksheet.CopyFrom(originalWorksheet);
                int boxNo = Convert.ToInt32(lstBox[i].ToString());
                foreach (var item in SpreadSheetForReprintDAO.Instance.GetSpreadSheetForReprint(boxNo))
                {
                    copiedWorksheet.Cells["B2"].Value = item.BoxNo;
                    copiedWorksheet.Cells["B3"].Value = item.ProductCode;
                    copiedWorksheet.Cells["B4"].Value = item.ProductName;
                    copiedWorksheet.Cells["B5"].Value = item.PartNameVN;
                    copiedWorksheet.Cells["B6"].Value = item.PartNameJP;
                    copiedWorksheet.Cells["B7"].Value = item.LotNo;
                    Zen.Barcode.CodeQrBarcodeDraw qrBarcodeDraw = Zen.Barcode.BarcodeDrawFactory.CodeQr;
                    var barcodeImage = qrBarcodeDraw.Draw(item.BoxNo.ToString(), 25);
                    copiedWorksheet.Pictures.AddPicture(barcodeImage, copiedWorksheet.Cells["G2"]);
                    List<ProcessDetailForPrintLabelDTO> detailList = ProcessDetailForPrintLabelDAO.Instance.GetProcessListForPrintLabel(item.PartCode);
                    List<string> lst = new List<string> { "B", "C", "D", "E", "F", "G", "H", "I" };
                    for (int j = 0; j < detailList.Count; j++)
                    {
                        copiedWorksheet.Cells[lst[j].ToString() + "8"].Value = detailList[j].ProcessNameVN.ToString();
                        copiedWorksheet.Cells[lst[j].ToString() + "9"].Value = detailList[j].ProcessNameJP.ToString();

                    }
                }

            }
            originalWorksheet.Visible = false;

        }

        private void frmSpreadSheetForReprint_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}