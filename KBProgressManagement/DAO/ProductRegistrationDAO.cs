using KBProgressManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBProgressManagement.DAO
{
    public class ProductRegistrationDAO
    {
        public static ProductRegistrationDAO instance;

        public static ProductRegistrationDAO Instance
        {
            get { if (instance == null) instance = new ProductRegistrationDAO(); return ProductRegistrationDAO.instance; }
            private set { ProductRegistrationDAO.instance = value; }
        }

        private ProductRegistrationDAO() { }

        public List<ProductRegistrationDTO> GetProductList()
        {
            List<ProductRegistrationDTO>list=new List<ProductRegistrationDTO>();
            string query = "exec GetProductlist";
            DataTable data =DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                ProductRegistrationDTO obj = new ProductRegistrationDTO(row);
                list.Add(obj);
            }
            return list;
        }
        public bool InsertAndUpdateProductMaster(string ProductCode, string ProductName, int BoxQty, string UpdateBy)
        {
            string query = "exec InsertAndUpdateProductMaster @ProductCode , @ProductName , @BoxQty , UpdateBy";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { ProductCode, ProductName, BoxQty, UpdateBy });
            return result > 0;
        }

        public bool DeleteProductMaster(string ProductCode)
        {
            string query = "exec DeleteProductMaster @ProductCode";
            int result = DataProvider.Instance.ExecuteNonQuery(@query, new object[] { ProductCode });
            return result > 0;
        }

    }
}
