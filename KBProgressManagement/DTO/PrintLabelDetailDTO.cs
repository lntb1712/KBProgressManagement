using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBProgressManagement.DTO
{
    public class PrintLabelDetailDTO
    {
        private string partCode;
        private string partNameVN;
        private string partNameJP;
        private int boxQty;



        public PrintLabelDetailDTO(string partCode, string partNameVN, string partNameJP, int boxqty)
        {
            this.partCode = partCode;
            this.partNameVN = partNameVN;
            this.partNameJP = partNameJP;
            this.BoxQty = boxqty;

        }

        public PrintLabelDetailDTO(DataRow row)
        {
            PartCode = row["PartCode"].ToString();
            PartNameVN = row["PartNameVN"].ToString();
            PartNameJP = row["PartNameJP"].ToString();
            BoxQty = Convert.ToInt32(row["BoxQty"]);


        }

        public string PartCode { get => partCode; set => partCode = value; }
        public string PartNameVN { get => partNameVN; set => partNameVN = value; }
        public string PartNameJP { get => partNameJP; set => partNameJP = value; }
        public int BoxQty { get => boxQty; set => boxQty = value; }
    }
}
