using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBProgressManagement.DTO
{
    public class ProcessDetailForPrintLabelDTO
    {
        private string processID;
        private string processNameVN;
        private string processNameJP;
        private string processNumber;

        public ProcessDetailForPrintLabelDTO(string processID, string processNameVN, string processNameJP, string processNumber)
        {
            this.processID = processID;
            this.processNameVN = processNameVN;
            this.processNameJP = processNameJP;
            this.processNumber = processNumber;
        }

        public ProcessDetailForPrintLabelDTO(DataRow row)
        {
            ProcessID = row["ProcessID"].ToString();
            ProcessNameVN = row["ProcessNameVN"].ToString();
            ProcessNameJP = row["ProcessNameJP"].ToString();
            ProcessNumber = row["ProcessNumber"].ToString();
        }

        public string ProcessID { get => processID; set => processID = value; }
        public string ProcessNumber { get => processNumber; set => processNumber = value; }
        public string ProcessNameVN { get => processNameVN; set => processNameVN = value; }
        public string ProcessNameJP { get => processNameJP; set => processNameJP = value; }
    }
}
