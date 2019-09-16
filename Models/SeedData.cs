using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intelligent_Retail2.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Intelligent_Retail2Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<Intelligent_Retail2Context>>()))
            {
                //查找任意商品
                if (context.CommodityManage.Any())
                {
                    return;   // DB has been seeded
                }
                context.AdminUser.AddRange(
                    new AdminUser
                    {
                        AdminUserName = "SuperAdmin",
                        AdminPassword = "12345678",
                        AdminUserNumber = "001",
                        AdminUserPhone = "17607000230",
                        AdminUserEmail = "986162084@qq.com",
                        AdminUserRole = "超级管理员"
                    },
                    new AdminUser
                    {
                        AdminUserName = "Admin002",
                        AdminPassword = "87654321",
                        AdminUserNumber = "002",
                        AdminUserPhone = "13900001111",
                        AdminUserEmail = "1122334455@qq.com",
                        AdminUserRole = "普通管理员"
                    },
                    new AdminUser
                    {
                        AdminUserName = "Admin003",
                        AdminPassword = "11111111",
                        AdminUserNumber = "003",
                        AdminUserPhone = "13855552222",
                        AdminUserEmail = "66778899@qq.com",
                        AdminUserRole = "普通管理员"
                    }
                    );
                context.BrandCategory.AddRange(
                    new BrandCategory {
                        BrandID = "1000",
                        BrandName = "可口可乐",
                        BrandInfo = "可口可乐的一些供应商信息"
                    },
                    new BrandCategory
                    {
                        BrandID = "1001",
                        BrandName = "百事",
                        BrandInfo = "百事公司的一些供应商信息"
                    },
                    new BrandCategory
                    {
                        BrandID = "1002",
                        BrandName = "康师傅",
                        BrandInfo = "康师傅的一些供应商信息"
                    },
                    new BrandCategory
                    {
                        BrandID = "1003",
                        BrandName = "汇源果汁",
                        BrandInfo = "汇源果汁的一些供应商信息"
                    },
                    new BrandCategory
                    {
                        BrandID = "1004",
                        BrandName = "哇哈哈",
                        BrandInfo = "哇哈哈的一些供应商信息"
                    },
                    new BrandCategory
                    {
                        BrandID = "1005",
                        BrandName = "红牛",
                        BrandInfo = "红牛的一些供应商信息"
                    },
                    new BrandCategory
                    {
                        BrandID = "1006",
                        BrandName = "统一",
                        BrandInfo = "统一的一些供应商信息"
                    }
                    );
                context.CommodityManage.AddRange(
                    new CommodityManage
                    {
                        ProductID = "10001",
                        CategoryID = "1000",
                        BrandID = "1000",
                        ProductName = "可口可乐330ml",
                        ProductImage = "图片路径",
                        ProductWeight = "330",
                        ProductPrice = "2.5",
                        ProductStock = 1000,
                        ProductSale = 199
                    },
                    new CommodityManage
                    {
                        ProductID = "10002",
                        CategoryID = "1000",
                        BrandID = "1000",
                        ProductName = "雪碧330ml",
                        ProductImage = "图片路径",
                        ProductWeight = "330",
                        ProductPrice = "2.5",
                        ProductStock = 999,
                        ProductSale = 211
                    },
                    new CommodityManage
                    {
                        ProductID = "10001",
                        CategoryID = "1000",
                        BrandID = "1000",
                        ProductName = "可口可乐330ml",
                        ProductImage = "图片路径",
                        ProductWeight = "330",
                        ProductPrice = "2.5",
                        ProductStock = 1000,
                        ProductSale = 199
                    },
                    new CommodityManage
                    {
                        ProductID = "10001",
                        CategoryID = "1000",
                        BrandID = "1000",
                        ProductName = "可口可乐330ml",
                        ProductImage = "图片路径",
                        ProductWeight = "330",
                        ProductPrice = "2.5",
                        ProductStock = 1000,
                        ProductSale = 199
                    },
                    new CommodityManage
                    {
                        ProductID = "10001",
                        CategoryID = "1000",
                        BrandID = "1000",
                        ProductName = "可口可乐330ml",
                        ProductImage = "图片路径",
                        ProductWeight = "330",
                        ProductPrice = "2.5",
                        ProductStock = 1000,
                        ProductSale = 199
                    }, 
                    new CommodityManage
                    {
                        ProductID = "10001",
                        CategoryID = "1000",
                        BrandID = "1000",
                        ProductName = "可口可乐330ml",
                        ProductImage = "图片路径",
                        ProductWeight = "330",
                        ProductPrice = "2.5",
                        ProductStock = 1000,
                        ProductSale = 199
                    },
                    new CommodityManage
                    {
                        ProductID = "10001",
                        CategoryID = "1000",
                        BrandID = "1000",
                        ProductName = "可口可乐330ml",
                        ProductImage = "图片路径",
                        ProductWeight = "330",
                        ProductPrice = "2.5",
                        ProductStock = 1000,
                        ProductSale = 199
                    },
                    new CommodityManage
                    {
                        ProductID = "10001",
                        CategoryID = "1000",
                        BrandID = "1000",
                        ProductName = "可口可乐330ml",
                        ProductImage = "图片路径",
                        ProductWeight = "330",
                        ProductPrice = "2.5",
                        ProductStock = 1000,
                        ProductSale = 199
                    },
                    new CommodityManage
                    {
                        ProductID = "10001",
                        CategoryID = "1000",
                        BrandID = "1000",
                        ProductName = "可口可乐330ml",
                        ProductImage = "图片路径",
                        ProductWeight = "330",
                        ProductPrice = "2.5",
                        ProductStock = 1000,
                        ProductSale = 199
                    },
                    new CommodityManage
                    {
                        ProductID = "10001",
                        CategoryID = "1000",
                        BrandID = "1000",
                        ProductName = "可口可乐330ml",
                        ProductImage = "图片路径",
                        ProductWeight = "330",
                        ProductPrice = "2.5",
                        ProductStock = 1000,
                        ProductSale = 199
                    }, 
                    new CommodityManage
                    {
                        ProductID = "10001",
                        CategoryID = "1000",
                        BrandID = "1000",
                        ProductName = "可口可乐330ml",
                        ProductImage = "图片路径",
                        ProductWeight = "330",
                        ProductPrice = "2.5",
                        ProductStock = 1000,
                        ProductSale = 199
                    },
                    new CommodityManage
                    {
                        ProductID = "10001",
                        CategoryID = "1000",
                        BrandID = "1000",
                        ProductName = "可口可乐330ml",
                        ProductImage = "图片路径",
                        ProductWeight = "330",
                        ProductPrice = "2.5",
                        ProductStock = 1000,
                        ProductSale = 199
                    },
                    new CommodityManage
                    {
                        ProductID = "10001",
                        CategoryID = "1000",
                        BrandID = "1000",
                        ProductName = "可口可乐330ml",
                        ProductImage = "图片路径",
                        ProductWeight = "330",
                        ProductPrice = "2.5",
                        ProductStock = 1000,
                        ProductSale = 199
                    },
                    new CommodityManage
                    {
                        ProductID = "10001",
                        CategoryID = "1000",
                        BrandID = "1000",
                        ProductName = "可口可乐330ml",
                        ProductImage = "图片路径",
                        ProductWeight = "330",
                        ProductPrice = "2.5",
                        ProductStock = 1000,
                        ProductSale = 199
                    },
                    new CommodityManage
                    {
                        ProductID = "10001",
                        CategoryID = "1000",
                        BrandID = "1000",
                        ProductName = "可口可乐330ml",
                        ProductImage = "图片路径",
                        ProductWeight = "330",
                        ProductPrice = "2.5",
                        ProductStock = 1000,
                        ProductSale = 199
                    }

                    );

                
                    

                    
                
                context.SaveChanges();
            }
        }
    }
}
