using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Intelligent_Retail2.Models;

namespace Intelligent_Retail2.Models
{
    public class Intelligent_Retail2Context : DbContext
    {
        public Intelligent_Retail2Context (DbContextOptions<Intelligent_Retail2Context> options)
            : base(options)
        {
        }

        public DbSet<Intelligent_Retail2.Models.User> User { get; set; }

        public DbSet<Intelligent_Retail2.Models.AdminUser> AdminUser { get; set; }

        public DbSet<Intelligent_Retail2.Models.DeviceManage> DeviceManage { get; set; }

        public DbSet<Intelligent_Retail2.Models.CommodityManage> CommodityManage { get; set; }

        public DbSet<Intelligent_Retail2.Models.BrandCategory> BrandCategory { get; set; }

        public DbSet<Intelligent_Retail2.Models.ProductCategory> ProductCategory { get; set; }

        public DbSet<Intelligent_Retail2.Models.DeviceProduct> DeviceProduct { get; set; }

        public DbSet<Intelligent_Retail2.Models.UserOrder> UserOrder { get; set; }
    }
}
