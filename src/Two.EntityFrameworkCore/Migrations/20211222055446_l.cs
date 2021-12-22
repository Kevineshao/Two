using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Two.Migrations
{
    public partial class l : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_Address",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address_Addressee = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address_Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address_City = table.Column<int>(type: "int", nullable: false),
                    Address_Province = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address_home = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_Detail",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Detail_Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Detail_Quantity = table.Column<int>(type: "int", nullable: false),
                    Detail_Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Detail_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Detail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_Logistics",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Logistics_Order = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logistics_Address = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TeliveryTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ServedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Logistics_State = table.Column<int>(type: "int", nullable: false),
                    Logistics_Staff = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logistics_Record = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Logistics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Orders_State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Orders_Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Orders_Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Pay_State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Pay_Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Orders", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_Address");

            migrationBuilder.DropTable(
                name: "tb_Detail");

            migrationBuilder.DropTable(
                name: "tb_Logistics");

            migrationBuilder.DropTable(
                name: "tb_Orders");
        }
    }
}
