using Microsoft.EntityFrameworkCore.Migrations;

namespace APPartment.Data.Migrations
{
    public partial class Number1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Apartment");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "Apartment",
                nullable: false,
                defaultValue: 0);
        }
    }
}
