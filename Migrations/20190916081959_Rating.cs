using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Intelligent_Retail2.Migrations
{
    public partial class Rating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdminUser",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AdminUserName = table.Column<string>(nullable: false),
                    AdminPassword = table.Column<string>(nullable: true),
                    AdminUserNumber = table.Column<string>(nullable: false),
                    AdminUserPhone = table.Column<string>(nullable: false),
                    AdminUserEmail = table.Column<string>(nullable: false),
                    AdminUserRole = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminUser", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BrandCategory",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BrandID = table.Column<string>(nullable: true),
                    BrandName = table.Column<string>(nullable: true),
                    BrandInfo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrandCategory", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CommodityManage",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductID = table.Column<string>(nullable: true),
                    CategoryID = table.Column<string>(nullable: true),
                    BrandID = table.Column<string>(nullable: true),
                    ProductName = table.Column<string>(nullable: true),
                    ProductImage = table.Column<string>(nullable: true),
                    ProductWeight = table.Column<string>(nullable: true),
                    ProductPrice = table.Column<string>(nullable: true),
                    ProductStock = table.Column<int>(nullable: false),
                    ProductSale = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommodityManage", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DeviceManage",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeviceID = table.Column<string>(nullable: false),
                    DeviceNumber = table.Column<string>(nullable: false),
                    DeviceProductKey = table.Column<string>(nullable: false),
                    DeviceSecret = table.Column<string>(nullable: false),
                    DeviceProvince = table.Column<string>(nullable: false),
                    DeviceCity = table.Column<string>(nullable: false),
                    DeviceAddress = table.Column<string>(nullable: false),
                    DeviceSetDay = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceManage", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DeviceProduct",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeviceID = table.Column<string>(nullable: true),
                    ProductID = table.Column<string>(nullable: true),
                    DeviceProductStock = table.Column<int>(nullable: false),
                    DeviceProductSale = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceProduct", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategory",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryID = table.Column<string>(nullable: true),
                    CategoryName = table.Column<string>(nullable: true),
                    CategoryInfo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategory", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserNickName = table.Column<string>(nullable: true),
                    UserOpenID = table.Column<string>(nullable: true),
                    UserPhone = table.Column<string>(nullable: true),
                    UserGender = table.Column<string>(nullable: true),
                    UserBirthday = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UserOrder",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserOrderID = table.Column<string>(nullable: true),
                    UserPhone = table.Column<string>(nullable: true),
                    ProductID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserOrder", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminUser");

            migrationBuilder.DropTable(
                name: "BrandCategory");

            migrationBuilder.DropTable(
                name: "CommodityManage");

            migrationBuilder.DropTable(
                name: "DeviceManage");

            migrationBuilder.DropTable(
                name: "DeviceProduct");

            migrationBuilder.DropTable(
                name: "ProductCategory");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "UserOrder");
        }
    }
}
