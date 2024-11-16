using KBProgressManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBProgressManagement.DAO
{
    public class PrintLabelDAO
    
        {
            private static PrintLabelDAO instance;
            public static PrintLabelDAO Instance
            {
                get { if (instance == null) instance = new PrintLabelDAO(); return PrintLabelDAO.instance; }
                private set { PrintLabelDAO.instance = value; }
            }

            public List<PrintLabelDTO> GetLabelList()
            {
                List<PrintLabelDTO> list = new List<PrintLabelDTO>();
                string query = "exec getPrintLabelList";
                DataTable dt = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow row in dt.Rows)
                {
                    PrintLabelDTO obj = new PrintLabelDTO(row);
                    list.Add(obj);
                }
                return list;
            }
            public bool InsertAndUpdatePrintLabel(int BoxNo, string ProductCode, string PartCode, string ProductLine, string LotNo, int Quantity,DateTime DueDate, string PrintBy)
            {
                string query = "exec InsertAndUpdatePrintLabel @BoxNo , @ProductCode , @PartCode , @ProductLine , @LotNo , @Quantity , @DueDate , @PrintBy";
                int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { BoxNo, ProductCode, PartCode, ProductLine, LotNo, Quantity, DueDate , PrintBy });
                return result > 0;
            }
        }
}
