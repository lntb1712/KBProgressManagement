using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBProgressManagement.DTO
{
    public class ProductRegistrationDTO
    {
        private string _productCode;
        private string _productName;
        private string _boxQty;

        public string ProductCode { get => _productCode; set => _productCode = value; }
        public string ProductName { get => _productName; set => _productName = value; }
        public string BoxQty { get => _boxQty; set => _boxQty = value; }

        public ProductRegistrationDTO(string productCode, string productName, string boxQty)
        {
            _productCode = productCode;
            _productName = productName;
            _boxQty = boxQty;
        }
       public ProductRegistrationDTO(DataRow row) 
        {
            ProductCode = row["ProductCode"].ToString();
            ProductName = row["ProductName"].ToString();
            BoxQty = row["BoxQty"].ToString();
        }
    }
    
}
