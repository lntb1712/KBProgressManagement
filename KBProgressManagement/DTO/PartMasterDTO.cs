using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBProgressManagement.DTO
{
    public class PartMasterDTO
    {
        private string _partCode;
        private string _partNameVN;
        private string _partNameJP;
        private int _boxQty;

        public PartMasterDTO(string partCode, string partNameVN, string partNameJP, int boxQty)
        {
            _partCode = partCode;
            _partNameVN = partNameVN;
            _partNameJP = partNameJP;
            _boxQty = boxQty;
        }

        public PartMasterDTO(DataRow row)
        {
            PartCode = row["PartCode"].ToString();
            PartNameVN = row["PartNameVN"].ToString();
            PartNameJP = row["PartNameJP"].ToString();
            BoxQty = Convert.ToInt32(row["BoxQty"].ToString());
        }

        public string PartCode { get => _partCode; set => _partCode = value; }
        public string PartNameVN { get => _partNameVN; set => _partNameVN = value; }
        public string PartNameJP { get => _partNameJP; set => _partNameJP = value; }
        public int BoxQty { get => _boxQty; set => _boxQty = value; }
    }
}
