using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Intelligent_Retail2.Models
{
    public class CommodityManage
    {
        public int ID { get; set; }
        [DisplayName("商品类别ID")]
        public string CategoryID { get; set; }
        [DisplayName("品牌ID")]
        public string BrandID { get; set; }
        [DisplayName("商品名称")]
        public string ProductName { get; set; }
        [DisplayName("商品图片")]
        public string ProductImage { get; set; }
        [DisplayName("商品价格")]
        public string ProductPrice { get; set; }
        [DisplayName("商品总库存")]
        public int ProductStock { get; set; }
        [DisplayName("商品总销量")]
        public int ProductSale { get; set; }
    }
}
