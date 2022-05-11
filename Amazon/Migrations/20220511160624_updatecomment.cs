using Microsoft.EntityFrameworkCore.Migrations;

namespace Amazon.Migrations
{
    public partial class updatecomment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "comments",
                columns: table => new
                {
                    A_Comment_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    A_Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    A_Comment_user_id = table.Column<int>(type: "int", nullable: false),
                    A_Comment_Product_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comments", x => x.A_Comment_id);
                });

            migrationBuilder.CreateTable(
                name: "reviews",
                columns: table => new
                {
                    A_Review_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    A_Like = table.Column<int>(type: "int", nullable: false),
                    A_View = table.Column<int>(type: "int", nullable: false),
                    A_Review_product_id = table.Column<int>(type: "int", nullable: false),
                    A_Review_user_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reviews", x => x.A_Review_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "comments");

            migrationBuilder.DropTable(
                name: "reviews");
        }
    }
}
