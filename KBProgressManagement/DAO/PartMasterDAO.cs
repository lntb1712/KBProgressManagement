using KBProgressManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBProgressManagement.DAO
{
    public class PartMasterDAO
    {
        private static PartMasterDAO instance;
        public static PartMasterDAO Instance
        {
            get { if (instance == null) instance = new PartMasterDAO(); return PartMasterDAO.instance; }
            private set { PartMasterDAO.instance = value; }
        }

        private PartMasterDAO() { }

        public List<PartMasterDTO> GetPartMasterList()
        {
            List<PartMasterDTO> list = new List<PartMasterDTO>();
            string query = "exec GetpartMasterList";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                PartMasterDTO obj = new PartMasterDTO(row);
                list.Add(obj);
            }
            return list;
        }

        public bool InsertAndUpdatePartMaster(string PartCode, string PartNameVN, string PartNameJP, int BoxQty, string UpdateBy)
        {
            string query = "exec InsertAndUpdatePartMaster @PartCode , @PartNameVN , @PartNameJP , @BoxQty , @UpdateBy";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { PartCode, PartNameVN, PartNameJP, BoxQty, UpdateBy });
            return result > 0;
        }

        public bool DeletePartMaster(string PartCode)
        {
            string query = "exec DeletePartMaster @PartCode";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { PartCode });
            return result > 0;
        }
    }
}
