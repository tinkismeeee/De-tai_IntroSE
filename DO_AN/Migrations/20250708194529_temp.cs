using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DO_AN.Migrations
{
    /// <inheritdoc />
    public partial class temp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "user_info",
                columns: table => new
                {
                    username = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    magioithieu1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    gender = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    day = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    month = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    year = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    phone = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_info", x => x.username);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "user_info");
        }
    }
}
