using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hurghada.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddTourGuideToTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PropertyAmenities_Properties_PropertyId",
                table: "PropertyAmenities");

            migrationBuilder.EnsureSchema(
                name: "TourGuide");

            migrationBuilder.CreateTable(
                name: "Guides",
                schema: "TourGuide",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotherLanguage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfilePhoto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IDPhoto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCertified = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guides", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                schema: "TourGuide",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GuideLanguages",
                schema: "TourGuide",
                columns: table => new
                {
                    GuideId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    GuideLanguageLevel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuideLanguages", x => new { x.GuideId, x.LanguageId });
                    table.ForeignKey(
                        name: "FK_GuideLanguages_Guides_GuideId",
                        column: x => x.GuideId,
                        principalSchema: "TourGuide",
                        principalTable: "Guides",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GuideLanguages_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalSchema: "TourGuide",
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GuideLanguages_LanguageId",
                schema: "TourGuide",
                table: "GuideLanguages",
                column: "LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyAmenities_Properties_PropertyId",
                table: "PropertyAmenities",
                column: "PropertyId",
                principalSchema: "Property",
                principalTable: "Properties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PropertyAmenities_Properties_PropertyId",
                table: "PropertyAmenities");

            migrationBuilder.DropTable(
                name: "GuideLanguages",
                schema: "TourGuide");

            migrationBuilder.DropTable(
                name: "Guides",
                schema: "TourGuide");

            migrationBuilder.DropTable(
                name: "Languages",
                schema: "TourGuide");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyAmenities_Properties_PropertyId",
                table: "PropertyAmenities",
                column: "PropertyId",
                principalSchema: "Property",
                principalTable: "Properties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
