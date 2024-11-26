using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBProgressManagement.DTO
{
    public class ChartProgressDTO
    {
        private int total;
        private string processID;
        private string statusDescription;

        public ChartProgressDTO(int total, string statusDescription)
        {
            this.total = total;
            this.statusDescription = statusDescription;
        }
        public ChartProgressDTO(DataRow row)
        {
            Total = Convert.ToInt32(row["Total"].ToString());
            StatusDescription = row["StatusDescription"].ToString();

        }
        public int Total { get => total; set => total = value; }
        public string StatusDescription { get => statusDescription; set => statusDescription = value; }
    }
}

