using Microsoft.EntityFrameworkCore.Migrations;

namespace PaginationDemo.Migrations
{
    public partial class ExtendBookModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<short>(
                name: "YearReleased",
                table: "Books",
                nullable: false,
                defaultValue: (short)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "YearReleased",
                table: "Books");
        }
    }
}
