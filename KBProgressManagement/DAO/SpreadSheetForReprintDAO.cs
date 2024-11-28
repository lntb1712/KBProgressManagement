using KBProgressManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBProgressManagement.DAO
{
    public class SpreadSheetForReprintDAO
    {
        private static SpreadSheetForReprintDAO instance;
        public static SpreadSheetForReprintDAO Instance
        {
            get { if (instance == null) instance = new SpreadSheetForReprintDAO(); return SpreadSheetForReprintDAO.instance; }
            private set { SpreadSheetForReprintDAO.instance = value; }
        }

        private SpreadSheetForReprintDAO() { }

        public List<SpreadSheetForReprintDTO> GetSpreadSheetForReprint(int boxNo)
        {
            List<SpreadSheetForReprintDTO> list = new List<SpreadSheetForReprintDTO>();
            string query = "EXEC GetReprintForSpreadSheet @boxNo";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new string[] {boxNo.ToString()});
            foreach (DataRow item in data.Rows)
            {
                SpreadSheetForReprintDTO obj = new SpreadSheetForReprintDTO(item);
                list.Add(obj);
            }
            return list;
        }
    }
}
