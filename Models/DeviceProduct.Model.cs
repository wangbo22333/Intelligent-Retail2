using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Intelligent_Retail2.Models
{
    public class DeviceProduct
    {
        public int ID { get; set; }
        [DisplayName("设备ID")]
        public int DeviceID { get; set; }
        [DisplayName("商品ID")]
        public string ProductID { get; set; }
        [DisplayName("本机商品库存")]
        public int DeviceProductStock { get; set; }
        [DisplayName("本机商品销量")]
        public int DeviceProductSale { get; set; }


    }
}
