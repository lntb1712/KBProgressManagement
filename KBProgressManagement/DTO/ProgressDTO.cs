using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBProgressManagement.DTO
{
    public class ProgressDTO
    {
        private string partCode;
        private string partNameVN;
        private string partNameJP;
        private string productCode;
        private string productName;
        private string lotNo;
        private int progress;

        public ProgressDTO(string LotNo, string partCode, string partNameVN, string partNameJP, string productCode, string productName)
        {
            this.partCode = partCode;
            this.partNameVN = partNameVN;
            this.partNameJP = partNameJP;
            this.productCode = productCode;
            this.productName = productName;
            this.lotNo = LotNo;
        }

        public ProgressDTO(DataRow row)
        {
            ProductCode = row["ProductCode"].ToString();
            ProductName = row["ProductName"].ToString();
            PartCode = row["PartCode"].ToString();
            PartNameVN = row["PartNameVN"].ToString();
            PartNameJP = row["PartNameJP"].ToString();
            LotNo = row["LotNo"].ToString();
            Progress = Convert.ToInt32(row["Progress"].ToString());
        }

        public string PartCode { get => partCode; set => partCode = value; }
        public string PartNameVN { get => partNameVN; set => partNameVN = value; }
        public string PartNameJP { get => partNameJP; set => partNameJP = value; }
        public string ProductCode { get => productCode; set => productCode = value; }
        public string ProductName { get => productName; set => productName = value; }
        public string LotNo { get => lotNo; set => lotNo = value; }
        public int Progress { get => progress; set => progress = value; }
    }
}
