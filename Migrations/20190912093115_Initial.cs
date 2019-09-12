using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Intelligent_Retail2.Migrations
{
    public partial class Initial : Migration
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
                name: "DeviceManage",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
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
                name: "User",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserNickName = table.Column<string>(nullable: true),
                    UserOpenID = table.Column<string>(nullable: true),
                    UserPhone = table.Column<string>(nullable: true),
                    UserGender = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminUser");

            migrationBuilder.DropTable(
                name: "DeviceManage");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
