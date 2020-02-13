using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmartMvcCaseStudy.Migrations.Items
{
    public partial class Itemscreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "items",
                columns: table => new
                {
                    IID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CID = table.Column<int>(nullable: false),
                    SCID = table.Column<int>(nullable: false),
                    INAME = table.Column<string>(nullable: true),
                    IPRICE = table.Column<double>(nullable: false),
                    ABOUTITEM = table.Column<string>(nullable: true),
                    STOCK = table.Column<int>(nullable: false),
                    remarks = table.Column<string>(nullable: true),
                    image = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_items", x => x.IID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "items");
        }
    }
}
