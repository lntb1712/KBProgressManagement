using KBProgressManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBProgressManagement.DAO
{
    public class ProductPartDAO
    {

        private static ProductPartDAO instance;
        public static ProductPartDAO Instance
        {
            get { if (instance == null) instance = new ProductPartDAO(); return ProductPartDAO.instance; }
            private set { ProductPartDAO.instance = value; }
        }

        private ProductPartDAO() { }

        public List<ProductPartDTO> GetProductPartList()
        {
            List<ProductPartDTO> list = new List<ProductPartDTO>();
            string query = "exec GetProductPartList";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                ProductPartDTO obj = new ProductPartDTO(row);
                list.Add(obj);
            }
            return list;
        }

        public bool InsertAndUpdateProductPart(string productCode, string partCode, string UpdateBy)
        {
            string query = "exec InsertAndUpdateProductPart @productCode , @partCode , @UpdateBy";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { productCode, partCode, UpdateBy });
            return result > 0;
        }

        public bool DeleteProductPart(string productCode, string partCode)
        {
            string query = "exec DeleteProductPart @productCode , @partCode";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { productCode, partCode });
            return result > 0;
        }
    }
}
