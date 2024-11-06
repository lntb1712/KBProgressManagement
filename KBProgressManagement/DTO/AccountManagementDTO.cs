using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBProgressManagement.DTO
{
    public class AccountManagementDTO
    {
        string _userID, _password, _fullname, _groupID, _groupName, _updateBy;
        DateTime _updateTime;

        public AccountManagementDTO(string userID, string password, string fullname, string groupID, string groupName, string updateBy, DateTime updateTime)
        {
            UserID = userID;
            Password = password;
            Fullname = fullname;
            GroupID = groupID;
            GroupName = groupName;
            UpdateBy = updateBy;
            UpdateTime = updateTime;
        }

        public AccountManagementDTO(DataRow row)
        {
            UserID = row["UserID"].ToString();
            Password = row["UserPassword"].ToString();
            Fullname = row["Fullname"].ToString();
            GroupID = row["GroupID"].ToString();
            GroupName = row["GroupName"].ToString();
            UpdateBy = row["UpdateBy"].ToString();
            UpdateTime = DateTime.Parse(row["UpdateTime"].ToString());
        }

        public string UserID { get => _userID; set => _userID = value; }
        public string Password { get => _password; set => _password = value; }
        public string Fullname { get => _fullname; set => _fullname = value; }
        public string GroupID { get => _groupID; set => _groupID = value; }
        public string GroupName { get => _groupName; set => _groupName = value; }
        public string UpdateBy { get => _updateBy; set => _updateBy = value; }
        public DateTime UpdateTime { get => _updateTime; set => _updateTime = value; }
    }
}
