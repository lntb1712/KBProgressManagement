using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBProgressManagement.DTO
{
    public class StageRegistrationDTO
    {
        private string _processID;
        private string _processNameVN;
        private string _processNameJP;

        public StageRegistrationDTO(string processID, string processNameVN, string processNameJP)
        {
            _processID = processID;
            _processNameVN = processNameVN;
            _processNameJP = processNameJP;
        }

        public StageRegistrationDTO(DataRow row)
        {
            ProcessID = row["ProcessID"].ToString();
            ProcessNameVN = row["ProcessNameVN"].ToString();
            ProcessNameJP = row["ProcessNameJP"].ToString();
        }
        public string ProcessID { get => _processID; set => _processID = value; }
        public string ProcessNameVN { get => _processNameVN; set => _processNameVN = value; }
        public string ProcessNameJP { get => _processNameJP; set => _processNameJP = value; }
    }
}
