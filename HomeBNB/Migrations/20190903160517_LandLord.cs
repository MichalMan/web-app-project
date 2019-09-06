using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeBnB.Migrations
{
    public partial class LandLord : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LandLordID",
                table: "Apartment",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "LandLord",
                columns: table => new
                {
                    LandLordID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Rating = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandLord", x => x.LandLordID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Apartment_LandLordID",
                table: "Apartment",
                column: "LandLordID");

            migrationBuilder.AddForeignKey(
                name: "FK_Apartment_LandLord_LandLordID",
                table: "Apartment",
                column: "LandLordID",
                principalTable: "LandLord",
                principalColumn: "LandLordID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apartment_LandLord_LandLordID",
                table: "Apartment");

            migrationBuilder.DropTable(
                name: "LandLord");

            migrationBuilder.DropIndex(
                name: "IX_Apartment_LandLordID",
                table: "Apartment");

            migrationBuilder.DropColumn(
                name: "LandLordID",
                table: "Apartment");
        }
    }
}
