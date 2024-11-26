using KBProgressManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBProgressManagement.DAO
{
    public class ChartProgressOverTimeDAO
    {
        private static ChartProgressOverTimeDAO instance;
        public static ChartProgressOverTimeDAO Instance
        {
            get { if (instance == null) instance = new ChartProgressOverTimeDAO(); return ChartProgressOverTimeDAO.instance; }
            private set { ChartProgressOverTimeDAO.instance = value; }
        }

        private ChartProgressOverTimeDAO() { }

        public List<ChartProgressOverTimeDTO> GetChartProgressOverTime()
        {
            List<ChartProgressOverTimeDTO> list = new List<ChartProgressOverTimeDTO>();
            string query = "GetProgressOverTimeChart";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ChartProgressOverTimeDTO obj = new ChartProgressOverTimeDTO(item);
                list.Add(obj);
            }
            return list;
        }
    }
}
