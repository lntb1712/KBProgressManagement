using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBProgressManagement.DTO
{
    public class ChartProgressOverTimeDTO
    {
        private int total;
        private string processID;
        private string statusDescription;

        public ChartProgressOverTimeDTO(int total, string processID, string statusDescription)
        {
            this.total = total;
            this.processID = processID;
            this.statusDescription = statusDescription;
        }
        public ChartProgressOverTimeDTO(DataRow row) {
            Total = Convert.ToInt32(row["Total"].ToString());
            StatusDescription = row["StatusDescription"].ToString();
            ProcessID = row["ProcessID"].ToString() ;
        }
        public int Total { get => total; set => total = value; }
        public string ProcessID { get => processID; set => processID = value; }
        public string StatusDescription { get => statusDescription; set => statusDescription = value; }
    }
}
