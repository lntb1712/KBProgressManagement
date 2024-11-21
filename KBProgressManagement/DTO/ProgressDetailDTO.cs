using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBProgressManagement.DTO
{
    public class ProgressDetailDTO
    {
        private string _processID;
        private string _processNameJP;
        private string _processNameVN;
        private int _total;
        private int _case;
        private int _nGQuantity;
        private int _cQty;
        private DateTime _updateTime;

        public ProgressDetailDTO(string processID, string processNameVN, string processNameJP, int total, int @case, int ngQuantity, int cQty, DateTime updateTime)
        {
            _processNameJP = processNameJP;
            _processID = processID;
            _processNameVN = processNameVN;
            _total = total;
            _case = @case;
            _nGQuantity = ngQuantity;
            _cQty = cQty;
            _updateTime = updateTime;
        }

        public ProgressDetailDTO(DataRow row)
        {
            ProcessID = row["ProcessID"].ToString();
            ProcessNameVN = row["ProcessNameVN"].ToString();
            ProcessNameJP = row["ProcessNameJP"].ToString();
            Total = Convert.ToInt32(row["Total"].ToString());
            Case = Convert.ToInt32(row["Case"].ToString());
            NGQuantity = Convert.ToInt32(row["NGQuantity"].ToString());
            CQty = Convert.ToInt32(row["CQty"].ToString());
            string temp = row["UpdateTime"].ToString();
            if (temp.Equals(""))
            {
                return;
            }
            else
            {
                UpdateTime = Convert.ToDateTime(row["UpdateTime"].ToString());
            }

        }
        public string ProcessNameVN { get => _processNameVN; set => _processNameVN = value; }
        public int Total { get => _total; set => _total = value; }
        public int Case { get => _case; set => _case = value; }
        public int NGQuantity { get => _nGQuantity; set => _nGQuantity = value; }
        public int CQty { get => _cQty; set => _cQty = value; }
        public string ProcessID { get => _processID; set => _processID = value; }
        public string ProcessNameJP { get => _processNameJP; set => _processNameJP = value; }
        public DateTime UpdateTime { get => _updateTime; set => _updateTime = value; }
    }
}
