using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intelligent_Retail2.Models
{
    public class DeviceProduct
    {
        public int ID { get; set; }
        public int DeviceID { get; set; }
        public string ProductID { get; set; }
        public int DeviceProductStock { get; set; }
        public int DeviceProductSale { get; set; }


    }
}
