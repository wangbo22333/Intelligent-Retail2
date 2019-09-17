using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Intelligent_Retail2.Models
{
    public class UserOrder
    {
        public int ID { get; set; }
        [DisplayName("订单编号")]
        public string UserOrderID { get; set; }
        [DisplayName("用户手机号")]
        public string UserPhone { get; set; }
        [DisplayName("商品编号")]
        public string ProductID { get; set; }
        [DisplayName("该商品数量")]
        public int ProductNumber { get; set; }


    }
}
