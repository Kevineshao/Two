using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Two.Migrations
{
    public partial class d : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_Basic",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Basic_NickName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Basic_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Basic_Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Basic_Sex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Basic_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Basic_Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Basic", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_Goods",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Goods_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MyProperty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kind_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Goods_State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Goods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_Inventory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Inventory_Number = table.Column<int>(type: "int", nullable: false),
                    Specs_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Inventory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_Kind",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kind_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kind_Pid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kind_State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Kind", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_Member",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Member_Grade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Member_Expire = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Member_Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    User_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Member", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_Photo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Photo_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo_Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Goods_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Photo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_Specs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Goods_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Specs_Weight = table.Column<int>(type: "int", nullable: false),
                    Specs_Length = table.Column<int>(type: "int", nullable: false),
                    Specs_Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Specs_Taste = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Specs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_Basic");

            migrationBuilder.DropTable(
                name: "tb_Goods");

            migrationBuilder.DropTable(
                name: "tb_Inventory");

            migrationBuilder.DropTable(
                name: "tb_Kind");

            migrationBuilder.DropTable(
                name: "tb_Member");

            migrationBuilder.DropTable(
                name: "tb_Photo");

            migrationBuilder.DropTable(
                name: "tb_Specs");
        }
    }
}
