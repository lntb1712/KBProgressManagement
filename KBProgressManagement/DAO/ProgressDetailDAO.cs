using KBProgressManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBProgressManagement.DAO
{
    public class ProgressDetailDAO
    {
        private static ProgressDetailDAO instance;

        public static ProgressDetailDAO Instance
        {
            get { if (instance == null) instance = new ProgressDetailDAO(); return ProgressDetailDAO.instance; }
            private set { ProgressDetailDAO.instance = value; }
        }

        public List<ProgressDetailDTO> GetProgressDetailList(string LotNo, string ProductCode, string PartCode)
        {
            List<ProgressDetailDTO> list = new List<ProgressDetailDTO>();
            string query = "exec GetProgressDetail @LotNo , @ProductCode , @PartCode";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { LotNo, ProductCode, PartCode });
            foreach (DataRow row in dt.Rows)
            {
                ProgressDetailDTO obj = new ProgressDetailDTO(row);
                list.Add(obj);
            }
            return list;


        }
    }
}
