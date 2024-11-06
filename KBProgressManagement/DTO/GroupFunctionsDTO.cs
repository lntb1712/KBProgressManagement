using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBProgressManagement.DTO
{
    public class GroupFunctionsDTO
    {

        string _functionID, _functionName, _device;
        bool _isEnable;

        public GroupFunctionsDTO(string functionID, string functionName, bool isEnable, string device)
        {
            FunctionID = functionID;
            FunctionName = functionName;
            IsEnable = isEnable;
            Device = device;
        }

        public GroupFunctionsDTO(DataRow row)
        {
            FunctionID = row["FunctionID"].ToString();
            FunctionName = row["FunctionName"].ToString();
            Device = row["Device"].ToString();
            IsEnable = String.IsNullOrEmpty(row["IsEnable"].ToString()) ? false : Convert.ToBoolean(row["IsEnable"].ToString());
        }

        public string FunctionID { get => _functionID; set => _functionID = value; }
        public string FunctionName { get => _functionName; set => _functionName = value; }
        public bool IsEnable { get => _isEnable; set => _isEnable = value; }
        public string Device { get => _device; set => _device = value; }
    }
}
