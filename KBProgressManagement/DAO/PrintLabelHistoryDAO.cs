using KBProgressManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBProgressManagement.DAO
{
    public class PrintLabelHistoryDAO
    {
        private static PrintLabelHistoryDAO instance;
        public static PrintLabelHistoryDAO Instance
        {
            get { if (instance == null) instance = new PrintLabelHistoryDAO(); return PrintLabelHistoryDAO.instance; }
            private set { PrintLabelHistoryDAO.instance = value; }
        }

        public List<PrintLabelHistoryDTO> GetLabelHistoryList()
        {
            List<PrintLabelHistoryDTO> list = new List<PrintLabelHistoryDTO>();
            string query = "exec GetPrintLabelHistory";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                PrintLabelHistoryDTO obj = new PrintLabelHistoryDTO(row);
                list.Add(obj);
            }
            return list;
        }
        public bool InsertPrintLabelHistory(int BoxNo, string ProductCode, string PartCode, string ProductLine, string LotNo, int Quantity,DateTime DueDate, string PrintBy)
        {
            string query = "exec InsertPrintLabelHistory @BoxNo , @ProductCode , @PartCode , @ProductLine , @LotNo , @Quantity , @DueDate , @PrintBy";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { BoxNo, ProductCode, PartCode, ProductLine, LotNo, Quantity,DueDate, PrintBy });
            return result > 0;
        }
    }
}
