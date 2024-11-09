using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBProgressManagement.DTO
{
    public class PrintLabelDTO
    {
        private int boxNo;
        private string productCode;
        private string productName;
        private string partCode;
        private string partNameVN;
        private string partNameJP;
        private string productLine;
        private string lotNo;
        private int quantity;
        private DateTime printTime;
        private string printBy;

        public PrintLabelDTO(int boxNo, string productCode, string productName, string partCode, string partNameVN, string partNameJP, string productLine, string lotNo, int quantity, DateTime printTime, string printBy)
        {
            this.boxNo = boxNo;
            this.productCode = productCode;
            this.productName = productName;
            this.partCode = partCode;
            this.partNameVN = partNameVN;
            this.partNameJP = partNameJP;
            this.productLine = productLine;
            this.lotNo = lotNo;
            this.quantity = quantity;
            this.printTime = printTime;
            this.printBy = printBy;
        }

        public PrintLabelDTO(DataRow row)
        {
            BoxNo = Convert.ToInt32(row["BoxNo"].ToString());
            ProductCode = row["ProductCode"].ToString();
            ProductName = row["ProductName"].ToString();
            PartCode = row["PartCode"].ToString();
            PartNameVN = row["PartNameVN"].ToString();
            PartNameJP = row["PartNameJP"].ToString();
            ProductLine = row["ProductLine"].ToString();
            LotNo = row["LotNo"].ToString();
            Quantity = Convert.ToInt32(row["Quantity"].ToString());
            PrintTime = Convert.ToDateTime(row["PrintTime"].ToString());
            PrintBy = row["PrintBy"].ToString();
        }


        public int BoxNo { get => boxNo; set => boxNo = value; }
        public string PartCode { get => partCode; set => partCode = value; }
        public string ProductLine { get => productLine; set => productLine = value; }
        public string LotNo { get => lotNo; set => lotNo = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public DateTime PrintTime { get => printTime; set => printTime = value; }
        public string PrintBy { get => printBy; set => printBy = value; }
        public string PartNameVN { get => partNameVN; set => partNameVN = value; }
        public string PartNameJP { get => partNameJP; set => partNameJP = value; }
        public string ProductCode { get => productCode; set => productCode = value; }
        public string ProductName { get => productName; set => productName = value; }
    }
}
