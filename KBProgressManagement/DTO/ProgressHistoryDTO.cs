using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBProgressManagement.DTO
{
    public class ProgressHistoryDTO
    {

        private int _boxNo;
        private string _productCode;
        private string _productName;
        private string _partCode;
        private string _partNameVN;
        private string _partNameJP;
        private string _processID;
        private string _processNameVN;
        private string _processNameJP;
        private int _quantity;
        private int _nGQuantity;
        private DateTime _updateTime;
        private DateTime _dueDate;
        private string lotNo;

        public ProgressHistoryDTO(int boxNo, string productCode, string productName, string partCode, string partNameVN, string partNameJP, string processID, string processNameVN, string processNameJP, int quantity, int ngQuantity, DateTime updateTime, DateTime dueDate,string lotNo)
        {
            BoxNo = boxNo;
            ProductCode = productCode;
            ProductName = productName;
            PartCode = partCode;
            PartNameVN = partNameVN;
            PartNameJP = partNameJP;
            ProcessID = processID;
            ProcessNameVN = processNameVN;
            ProcessNameJP = processNameJP;
            Quantity = quantity;
            NGQuantity = ngQuantity;
            UpdateTime = updateTime;
            DueDate = dueDate;
            LotNo = lotNo;
        }

        public ProgressHistoryDTO(DataRow row)
        {
            BoxNo = Convert.ToInt32(row["BoxNo"].ToString());
            ProductCode = row["ProductCode"].ToString();
            ProductName = row["ProductName"].ToString();
            PartCode = row["PartCode"].ToString();
            PartNameVN = row["PartNameVN"].ToString();
            PartNameJP = row["PartNameJP"].ToString();
            ProcessID = row["ProcessID"].ToString();
            ProcessNameVN = row["ProcessNameVN"].ToString();
            ProcessNameJP = row["ProcessNameJP"].ToString();
            Quantity = Convert.ToInt32(row["Quantity"].ToString());
            NGQuantity = Convert.ToInt32(row["NGQuantity"].ToString());
            UpdateTime = Convert.ToDateTime(row["UpdateTime"].ToString());
            DueDate = Convert.ToDateTime(row["DueDate"].ToString());
            LotNo = row["LotNo"].ToString();
        }

        public int BoxNo { get => _boxNo; set => _boxNo = value; }
        public string ProductCode { get => _productCode; set => _productCode = value; }
        public string ProductName { get => _productName; set => _productName = value; }
        public string PartCode { get => _partCode; set => _partCode = value; }
        public string PartNameVN { get => _partNameVN; set => _partNameVN = value; }
        public string PartNameJP { get => _partNameJP; set => _partNameJP = value; }
        public string ProcessID { get => _processID; set => _processID = value; }
        public string ProcessNameVN { get => _processNameVN; set => _processNameVN = value; }
        public string ProcessNameJP { get => _processNameJP; set => _processNameJP = value; }
        public int Quantity { get => _quantity; set => _quantity = value; }
        public int NGQuantity { get => _nGQuantity; set => _nGQuantity = value; }
        public DateTime UpdateTime { get => _updateTime; set => _updateTime = value; }
        public DateTime DueDate { get => _dueDate; set => _dueDate = value; }
        public string LotNo { get => lotNo; set => lotNo = value; }
    }
}
