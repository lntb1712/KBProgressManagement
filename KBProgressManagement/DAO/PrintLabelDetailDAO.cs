using KBProgressManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBProgressManagement.DAO
{
    public class PrintLabelDetailDAO
    {
        private static PrintLabelDetailDAO instance;
        public BindingList<PartProcessDTO> listPartMatching;
        public static PrintLabelDetailDAO Instance
        {
            get { if (instance == null) instance = new PrintLabelDetailDAO(); return PrintLabelDetailDAO.instance; }
            private set { PrintLabelDetailDAO.instance = value; }
        }

        public List<PrintLabelDetailDTO> GetPrintLabelDetail(string ProductCode)
        {
            List<PrintLabelDetailDTO> list = new List<PrintLabelDetailDTO>();
            string query = "exec GetPrintLabelDetail @productCode";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { ProductCode });
            foreach (DataRow row in dt.Rows)
            {
                PrintLabelDetailDTO obj = new PrintLabelDetailDTO(row);
                list.Add(obj);

            }
            return list;

        }
    }
}
