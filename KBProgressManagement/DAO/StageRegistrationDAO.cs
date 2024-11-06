using KBProgressManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBProgressManagement.DAO
{
    public class StageRegistrationDAO
    {
        private static StageRegistrationDAO instance;
        public static StageRegistrationDAO Instance
        {
            get { if (instance == null) instance = new StageRegistrationDAO(); return StageRegistrationDAO.instance; }
            private set { StageRegistrationDAO.instance = value; }
        }

        private StageRegistrationDAO() { }

        public List<StageRegistrationDTO> GetStageRegistrationList()
        {
            List<StageRegistrationDTO> list = new List<StageRegistrationDTO>();
            string query = "exec GetProcessList";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                StageRegistrationDTO obj = new StageRegistrationDTO(row);
                list.Add(obj);
            }
            return list;
        }

        public bool InsertAndUpdateProcessMaster(string ProcessID, string ProcessNameVN, string ProcessNameJP, string UpdateBy)
        {
            string query = "exec InsertAndUpdateProcessMaster @ProcessID , @ProcessNameVN , @ProcessNameJP , @UpdateBy";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { ProcessID, ProcessNameVN, ProcessNameJP, UpdateBy });
            return result > 0;
        }

        public bool DeleteProcessMaster(string ProcessID)
        {
            string query = "exec DeleteProcessMaster @ProcessID";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { ProcessID });
            return result > 0;
        }
    }
}
