using KBProgressManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBProgressManagement.DAO
{
    public class PartProcessDAO
    {
        private static PartProcessDAO instance;
        public static PartProcessDAO Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new PartProcessDAO();
                }
                return instance;
            }
            set
            {
                PartProcessDAO.instance = value;
            }
        }

        public List<PartProcessDTO> GetPartProcessList(string partCode)
        {
            List<PartProcessDTO> list = new List<PartProcessDTO>();
            string query = "exec GetPartProcess @partCode";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { partCode });
            foreach (DataRow row in data.Rows)
            {
                PartProcessDTO obj = new PartProcessDTO(row);
                list.Add(obj);
            }
            return list;
        }


        public bool InsertAndUpdatePartProcess(string ProcessID, string PartCode, int ProcessNumber, string UpdateBy)
        {
            string query = "exec InsertAndUpdatePartProcess @ProcessID , @PartCode , @ProcessNumber , @UpdateBy";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { ProcessID, PartCode, ProcessNumber, UpdateBy });
            return result > 0;
        }

        public bool DeletePartProcess(string PartCode)
        {
            string query = "exec DeletePartProcess @PartCode";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { PartCode });
            return result > 0;
        }
    }
}
