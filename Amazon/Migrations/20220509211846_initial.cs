using Microsoft.EntityFrameworkCore.Migrations;

namespace Amazon.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pincodes",
                columns: table => new
                {
                    A_UID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    A_Zipcode = table.Column<int>(type: "int", nullable: true),
                    A_Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    A_State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    A_City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    A_Area = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    A_District = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    A_Phone_code = table.Column<int>(type: "int", nullable: false),
                    A_Iso2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    A_Isacive = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pincodes", x => x.A_UID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    A_Product_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    A_Product_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    A_Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    A_Price = table.Column<double>(type: "float", nullable: true),
                    A_Quantity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    A_Model_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    A_About = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    A_Product_specification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    A_Tech_details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    A_Product_weight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    A_Product_dimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    A_Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    A_Varient = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    A_Product_url = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.A_Product_id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    A_User_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    A_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    A_Email_add = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    A_Phone_number = table.Column<long>(type: "bigint", nullable: false),
                    A_Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    A_Created = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    A_Isactive = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.A_User_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pincodes");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
