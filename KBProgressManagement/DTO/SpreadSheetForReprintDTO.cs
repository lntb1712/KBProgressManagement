using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBProgressManagement.DTO
{
    public class SpreadSheetForReprintDTO
    {
        private int boxNo;
        private string productCode;
        private string productName;
        private string partCode;
        private string partNameVN;
        private string partNameJP;
        private string lotNo;

        public SpreadSheetForReprintDTO(int boxNo, string productCode, string productName, string partCode, string partNameVN, string partNameJP, string lotNo)
        {
            this.boxNo = boxNo;
            this.productCode = productCode;
            this.productName = productName;
            this.partCode = partCode;
            this.partNameVN = partNameVN;
            this.partNameJP = partNameJP;
            this.lotNo = lotNo;
        }

        public SpreadSheetForReprintDTO(DataRow row)
        {
            BoxNo = Convert.ToInt32(row["BoxNo"].ToString());
            ProductCode = row["ProductCode"].ToString();
            ProductName = row["ProductName"].ToString();
            PartCode = row["PartCode"].ToString();
            PartNameVN = row["PartNameVN"].ToString();
            PartNameJP = row["PartNameJP"].ToString();
            LotNo = row["LotNo"].ToString();
        }
        public int BoxNo { get => boxNo; set => boxNo = value; }
        public string ProductCode { get => productCode; set => productCode = value; }
        public string ProductName { get => productName; set => productName = value; }
        public string PartCode { get => partCode; set => partCode = value; }
        public string PartNameVN { get => partNameVN; set => partNameVN = value; }
        public string PartNameJP { get => partNameJP; set => partNameJP = value; }
        public string LotNo { get => lotNo; set => lotNo = value; }
    }
}
