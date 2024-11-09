using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBProgressManagement.DTO
{
    public class ProductPartDTO
    {
        private string _productCode;
        private string _partCode;

        public string ProductCode { get => _productCode; set => _productCode = value; }
        public string PartCode { get => _partCode; set => _partCode = value; }

        public ProductPartDTO(string ProductCode, string PartCode)
        {
            this._productCode = ProductCode;
            this._partCode = PartCode;
        }

        public ProductPartDTO(DataRow row)
        {
            ProductCode = row["ProductCode"].ToString();
            PartCode = row["PartCode"].ToString();
        }


    }
}
