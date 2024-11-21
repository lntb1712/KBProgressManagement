using KBProgressManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBProgressManagement.DAO
{
    public class ProgressDAO
    {
        private static ProgressDAO instance;
        public static ProgressDAO Instance
        {
            get { if (instance == null) instance = new ProgressDAO(); return ProgressDAO.instance; }
            private set { ProgressDAO.instance = value; }
        }

        public List<ProgressDTO> GetProgress()
        {
            List<ProgressDTO> list = new List<ProgressDTO>();
            string query = "exec GetProgress";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                ProgressDTO obj = new ProgressDTO(row);
                list.Add(obj);

            }
            return list;

        }
        public List<ProgressDTO> GetProgressSearch(DateTime fromDate, DateTime toDate)
        {
            List<ProgressDTO> list = new List<ProgressDTO>();
            string query = "exec GetProgressBySearch @fromDate , @toDate";
            var temp = fromDate.ToString("MM-dd-yyyy");
            var temp1 = toDate.ToString("MM-dd-yyyy");

            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { temp, temp1 });
            foreach (DataRow row in dt.Rows)
            {
                ProgressDTO obj = new ProgressDTO(row);
                list.Add(obj);

            }
            return list;

        }
    }
}
