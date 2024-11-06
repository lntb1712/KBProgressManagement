using KBProgressManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBProgressManagement.DAO
{
    public class GroupManagementDAO
    {
        private static GroupManagementDAO instance;
        public static GroupManagementDAO Instance
        {
            get { if (instance == null) instance = new GroupManagementDAO(); return GroupManagementDAO.instance; }
            private set { GroupManagementDAO.instance = value; }
        }

        private GroupManagementDAO() { }

        public List<GroupManagementDTO> GetGroupManagementList()
        {
            List<GroupManagementDTO> list = new List<GroupManagementDTO>();
            string query = "EXEC GetGroupManagementList";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                GroupManagementDTO obj = new GroupManagementDTO(item);
                list.Add(obj);
            }
            return list;
        }

        public bool InsertGroupManagement(string groupID, string groupName, string groupDescription, string updateBy)
        {
            string query = "InsertGroupManagement @groupID , @groupName , @groupDescription , @updateBy";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { groupID, groupName, groupDescription, updateBy });
            return result > 0;
        }

        public bool UpdateGroupManagement(string groupID, string groupName, string groupDescription, string updateBy)
        {
            string query = "UpdateGroupManagement @groupID , @groupName , @groupDescription , @updateBy";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { groupID, groupName, groupDescription, updateBy });
            return result > 0;
        }

        public bool DeleteGroupManagement(string groupID)
        {
            string query = "DeleteGroupManagement @groupID";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { groupID });
            return result > 0;
        }
    }
}
