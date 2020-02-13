using Microsoft.EntityFrameworkCore.Migrations;

namespace EmartMvcCaseStudy.Migrations
{
    public partial class SellerCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sellers",
                columns: table => new
                {
                    SID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SUSERNAME = table.Column<string>(nullable: true),
                    SPASSWORD = table.Column<string>(nullable: true),
                    SCOMPANYNAME = table.Column<string>(nullable: true),
                    SGSTIN = table.Column<string>(nullable: true),
                    SADDRESS = table.Column<string>(nullable: true),
                    SWEBSITE = table.Column<string>(nullable: true),
                    SMOBILENO = table.Column<double>(nullable: false),
                    SEMAILID = table.Column<string>(nullable: true),
                    PhotoPath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sellers", x => x.SID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sellers");
        }
    }
}
