using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBProgressManagement.DTO
{
    public class PartProcessDTO
    {
        private string _processID;
        private string _processNameVN;
        private string _processNameJP;
        private int _processNumber;

        public string ProcessID { get => _processID; set => _processID = value; }
        public string ProcessNameVN { get => _processNameVN; set => _processNameVN = value; }
        public string ProcessNameJP { get => _processNameJP; set => _processNameJP = value; }
        public int ProcessNumber { get => _processNumber; set => _processNumber = value; }

        public PartProcessDTO(string ProcessID, string ProcessNameVN, string ProcessNameJP, int ProcessNumber)
        {
            this.ProcessID = ProcessID;
            this.ProcessNameVN = ProcessNameVN;
            this.ProcessNameJP = ProcessNameJP;
            this.ProcessNumber = ProcessNumber;
        }



        public PartProcessDTO(DataRow row)
        {
            ProcessID = row["ProcessID"].ToString();
            ProcessNameVN = row["ProcessNameVN"].ToString();
            ProcessNameJP = row["ProcessNameJP"].ToString();
            ProcessNumber = row["ProcessNumber"].ToString().Equals("")
                            ? 0 : Convert.ToInt32(row["ProcessNumber"].ToString());
        }
    }
}
