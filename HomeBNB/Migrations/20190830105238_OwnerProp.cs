using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeBnB.Migrations
{
    public partial class OwnerProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Owner",
                table: "Apartment",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Owner",
                table: "Apartment");
        }
    }
}
