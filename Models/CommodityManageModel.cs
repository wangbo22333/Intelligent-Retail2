using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intelligent_Retail2.Models
{
    public class CommodityManage
    {
        public int ID { get; set; }
        public string CategoryID { get; set; }
        public string BrandID { get; set; }
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public string ProductPrice { get; set; }
        public int ProductStock { get; set; }
        public int ProductSale { get; set; }
    }
}
