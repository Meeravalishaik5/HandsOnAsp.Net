using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmartMvcCaseStudy.Migrations.Buyer
{
    public partial class BuyerCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Buyers",
                columns: table => new
                {
                    BID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BUSERNAME = table.Column<string>(nullable: true),
                    BPASSWORD = table.Column<string>(nullable: true),
                    BEMAILID = table.Column<string>(nullable: true),
                    BMOBILENO = table.Column<double>(nullable: false),
                    BLDT = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buyers", x => x.BID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Buyers");
        }
    }
}
