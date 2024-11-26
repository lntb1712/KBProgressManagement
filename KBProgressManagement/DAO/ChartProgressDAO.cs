using KBProgressManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBProgressManagement.DAO
{
    public class ChartProgressDAO
    {
        private static ChartProgressDAO instance;
        public static ChartProgressDAO Instance
        {
            get { if (instance == null) instance = new ChartProgressDAO(); return ChartProgressDAO.instance; }
            private set { ChartProgressDAO.instance = value; }
        }

        private ChartProgressDAO() { }

        public List<ChartProgressDTO> GetChartProgress()
        {
            List<ChartProgressDTO> list = new List<ChartProgressDTO>();
            string query = "GetProgressChart";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ChartProgressDTO obj = new ChartProgressDTO(item);
                list.Add(obj);
            }
            return list;
        }
    }
}
