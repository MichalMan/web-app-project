using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeBnB.Migrations
{
    public partial class Skeleton : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LandLordEmail",
                table: "LandLord",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Renter",
                columns: table => new
                {
                    RenterID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RenterName = table.Column<string>(nullable: true),
                    RenterEmail = table.Column<string>(nullable: true),
                    RenterApartmentApartmentID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Renter", x => x.RenterID);
                    table.ForeignKey(
                        name: "FK_Renter_Apartment_RenterApartmentApartmentID",
                        column: x => x.RenterApartmentApartmentID,
                        principalTable: "Apartment",
                        principalColumn: "ApartmentID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    ReviewID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReviewGrade = table.Column<int>(nullable: false),
                    ReviewDate = table.Column<DateTime>(nullable: false),
                    ReviewContent = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.ReviewID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Renter_RenterApartmentApartmentID",
                table: "Renter",
                column: "RenterApartmentApartmentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Renter");

            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropColumn(
                name: "LandLordEmail",
                table: "LandLord");
        }
    }
}
