using KBProgressManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBProgressManagement.DAO
{
    public class ProcessDetailForPrintLabelDAO
    {
        private static ProcessDetailForPrintLabelDAO instance;
        public static ProcessDetailForPrintLabelDAO Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new ProcessDetailForPrintLabelDAO();
                }
                return instance;
            }
            set
            {
                ProcessDetailForPrintLabelDAO.instance = value;
            }
        }

        public List<ProcessDetailForPrintLabelDTO> GetProcessListForPrintLabel(string partCode)
        {
            List<ProcessDetailForPrintLabelDTO> list = new List<ProcessDetailForPrintLabelDTO>();
            string query = "exec GetProcessDetail @partCode";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { partCode });
            foreach (DataRow item in data.Rows)
            {
                ProcessDetailForPrintLabelDTO obj = new ProcessDetailForPrintLabelDTO(item);
                list.Add(obj);
            }
            return list;
        }
    }
}
