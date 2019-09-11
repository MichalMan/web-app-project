using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APPartment.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LandLord",
                columns: table => new
                {
                    LandLordID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    LandLordEmail = table.Column<string>(nullable: true),
                    Rating = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandLord", x => x.LandLordID);
                });

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    ReviewID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReviewGrade = table.Column<int>(nullable: false),
                    ReviewDate = table.Column<DateTime>(nullable: false),
                    ReviewContent = table.Column<string>(nullable: true),
                    LandLordID = table.Column<int>(nullable: false),
                    ApartmentID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.ReviewID);
                });

            migrationBuilder.CreateTable(
                name: "Apartment",
                columns: table => new
                {
                    ApartmentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MyProperty = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    NumberOfRooms = table.Column<int>(nullable: false),
                    Renovated = table.Column<bool>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    LandLordID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartment", x => x.ApartmentID);
                    table.ForeignKey(
                        name: "FK_Apartment_LandLord_LandLordID",
                        column: x => x.LandLordID,
                        principalTable: "LandLord",
                        principalColumn: "LandLordID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Renter",
                columns: table => new
                {
                    RenterID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RenterName = table.Column<string>(nullable: true),
                    RenterEmail = table.Column<string>(nullable: true),
                    ApartmentID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Renter", x => x.RenterID);
                    table.ForeignKey(
                        name: "FK_Renter_Apartment_ApartmentID",
                        column: x => x.ApartmentID,
                        principalTable: "Apartment",
                        principalColumn: "ApartmentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Apartment_LandLordID",
                table: "Apartment",
                column: "LandLordID");

            migrationBuilder.CreateIndex(
                name: "IX_Renter_ApartmentID",
                table: "Renter",
                column: "ApartmentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Renter");

            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropTable(
                name: "Apartment");

            migrationBuilder.DropTable(
                name: "LandLord");
        }
    }
}
