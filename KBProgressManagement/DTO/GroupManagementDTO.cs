using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBProgressManagement.DTO
{
    public class GroupManagementDTO
    {
        string _groupID, _groupName, _groupDescription, _updateBy;
        DateTime _updateTime;

        public GroupManagementDTO(string groupID, string groupName, string groupDescription, string updateBy, DateTime updateTime)
        {
            GroupID = groupID;
            GroupName = groupName;
            GroupDescription = groupDescription;
            UpdateBy = updateBy;
            UpdateTime = updateTime;
        }

        public GroupManagementDTO(DataRow row)
        {
            GroupID = row["GroupID"].ToString();
            GroupName = row["GroupName"].ToString();
            GroupDescription = row["GroupDescription"].ToString();
            UpdateBy = row["UpdateBy"].ToString();
            UpdateTime = DateTime.Parse(row["UpdateTime"].ToString());
        }

        public string GroupID { get => _groupID; set => _groupID = value; }
        public string GroupName { get => _groupName; set => _groupName = value; }
        public string GroupDescription { get => _groupDescription; set => _groupDescription = value; }
        public string UpdateBy { get => _updateBy; set => _updateBy = value; }
        public DateTime UpdateTime { get => _updateTime; set => _updateTime = value; }
    }
}
