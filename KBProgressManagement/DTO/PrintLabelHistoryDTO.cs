using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBProgressManagement.DTO
{
    public class PrintLabelHistoryDTO
    {
        private int boxNo;
        private string productCode;
        private string partCode;
        private string productLine;
        private string lotNo;
        private int quantity;
        private DateTime dueDate;
        private DateTime printTime;
        private string printBy;

        public PrintLabelHistoryDTO(int boxNo, string productCode, string partCode, string productLine, string lotNo, int quantity,DateTime dueDate, DateTime printTime, string printBy)
        {
            this.boxNo = boxNo;
            this.productCode = productCode;
            this.partCode = partCode;
            this.productLine = productLine;
            this.lotNo = lotNo;
            this.quantity = quantity;
            this.dueDate = dueDate;
            this.printTime = printTime;
            this.printBy = printBy;
        }

        public PrintLabelHistoryDTO(DataRow row)
        {
            BoxNo = Convert.ToInt32(row["BoxNo"].ToString());
            ProductCode = row["ProductCode"].ToString();
            PartCode = row["PartCode"].ToString();
            ProductLine = row["ProductLine"].ToString();
            LotNo = row["LotNo"].ToString();
            Quantity = Convert.ToInt32(row["Quantity"].ToString());
            DueDate= Convert.ToDateTime(row["DueDate"].ToString());
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
        public string ProductCode { get => productCode; set => productCode = value; }
        public DateTime DueDate { get => dueDate; set => dueDate = value; }
    }
}
