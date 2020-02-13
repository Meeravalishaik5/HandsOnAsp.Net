using Microsoft.EntityFrameworkCore.Migrations;

namespace EmartMvcCaseStudy.Migrations.SubCategory
{
    public partial class SubCategoryCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    SID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SNAME = table.Column<string>(nullable: true),
                    CID = table.Column<int>(nullable: false),
                    ABOUTSUBCATEGORY = table.Column<string>(nullable: true),
                    GST = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.SID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubCategories");
        }
    }
}
