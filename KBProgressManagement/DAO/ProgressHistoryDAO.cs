using KBProgressManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBProgressManagement.DAO
{
    public class ProgressHistoryDAO
    {
        private static ProgressHistoryDAO instance;

        public static ProgressHistoryDAO Instance
        {
            get { if (instance == null) instance = new ProgressHistoryDAO(); return ProgressHistoryDAO.instance; }
            private set { ProgressHistoryDAO.instance = value; }
        }
        public List<ProgressHistoryDTO> GetHistoryList()
        {
            List<ProgressHistoryDTO> list = new List<ProgressHistoryDTO>();
            string query = "GetHistoryList";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                ProgressHistoryDTO obj = new ProgressHistoryDTO(row);
                list.Add(obj);
            }
            return list;
        }
    }
}
