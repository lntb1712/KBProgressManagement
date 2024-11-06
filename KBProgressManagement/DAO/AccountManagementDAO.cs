using KBProgressManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBProgressManagement.DAO
{
    public class AccountManagementDAO
    {
        private static AccountManagementDAO instance;
        public static AccountManagementDAO Instance
        {
            get { if (instance == null) instance = new AccountManagementDAO(); return AccountManagementDAO.instance; }
            private set { AccountManagementDAO.instance = value; }
        }

        private AccountManagementDAO() { }

        public List<AccountManagementDTO> GetAccountList()
        {
            List<AccountManagementDTO> list = new List<AccountManagementDTO>();
            string query = "EXEC GetAccountList";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                AccountManagementDTO obj = new AccountManagementDTO(item);
                list.Add(obj);
            }
            return list;
        }

        public DataTable GetAccountLogin(string userID, string password)
        {
            List<AccountManagementDTO> list = new List<AccountManagementDTO>();
            string query = "EXEC AccountLogin @userID , @userPassword";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { userID, password });
            return data;
        }

        public bool InsertAccount(string userID, string password, string fullName, string groupID, string updateBy)
        {
            string query = "InsertAccount @userID , @userPassword , @fullname , @groupID , @updateBy";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { userID, password, fullName, groupID, updateBy });
            return result > 0;
        }

        public bool UpdateAccount(string userID, string password, string fullName, string groupID, string updateBy)
        {
            string query = "UpdateAccount @userID , @userPassword , @fullname , @groupID , @updateBy";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { userID, password, fullName, groupID, updateBy });
            return result > 0;
        }

        public bool DeleteAccount(string userID)
        {
            string query = "DeleteAccount @userID";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { userID });
            return result > 0;
        }
    }
}
