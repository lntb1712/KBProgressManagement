using KBProgressManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBProgressManagement.DAO
{
    public class GroupFunctionsDAO
    {
        private static GroupFunctionsDAO instance;
        public static GroupFunctionsDAO Instance
        {
            get { if (instance == null) instance = new GroupFunctionsDAO(); return GroupFunctionsDAO.instance; }
            private set { GroupFunctionsDAO.instance = value; }
        }

        private GroupFunctionsDAO() { }

        public List<GroupFunctionsDTO> GetGroupFunctionsList(string groupID)
        {
            List<GroupFunctionsDTO> list = new List<GroupFunctionsDTO>();
            string query = "EXEC GetGroupFunctionsList @groupID";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { groupID });
            foreach (DataRow item in data.Rows)
            {
                GroupFunctionsDTO obj = new GroupFunctionsDTO(item);
                list.Add(obj);
            }
            return list;
        }

        public bool InsertAndUpdateGroupFunctionsList(string groupID, string functionID, bool isEnable, string updateBy)
        {
            string query = "InsertAndUpdateGroupFunctionsList @groupID , @functionID , @isEnable , @updateBy";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { groupID, functionID, isEnable, updateBy });
            return result > 0;
        }
    }
}
