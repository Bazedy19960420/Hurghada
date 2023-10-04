using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hurghada.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Property");

            migrationBuilder.CreateTable(
                name: "Amenities",
                schema: "Property",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amenities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PropertyTypes",
                schema: "Property",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Properties",
                schema: "Property",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DownPayment = table.Column<int>(type: "int", nullable: false),
                    MonthlyPayment = table.Column<int>(type: "int", nullable: false),
                    DailyPayment = table.Column<int>(type: "int", nullable: false),
                    BedRooms = table.Column<int>(type: "int", nullable: false),
                    PathRooms = table.Column<int>(type: "int", nullable: false),
                    Area = table.Column<int>(type: "int", nullable: false),
                    Floor = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsFurnished = table.Column<bool>(type: "bit", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    PropertyTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Properties_PropertyTypes_PropertyTypeId",
                        column: x => x.PropertyTypeId,
                        principalSchema: "Property",
                        principalTable: "PropertyTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PropertyAmenities",
                columns: table => new
                {
                    PropertyId = table.Column<int>(type: "int", nullable: false),
                    AmenityId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyAmenities", x => new { x.PropertyId, x.AmenityId });
                    table.ForeignKey(
                        name: "FK_PropertyAmenities_Amenities_AmenityId",
                        column: x => x.AmenityId,
                        principalSchema: "Property",
                        principalTable: "Amenities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PropertyAmenities_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalSchema: "Property",
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                schema: "Property",
                table: "Amenities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Air conditioning" },
                    { 2, "Balcony" },
                    { 4, "Cable TV" },
                    { 5, "Cleaning after exit" },
                    { 6, "Cofee pot" },
                    { 7, "Computer" },
                    { 8, "Cot" },
                    { 11, "Fan" },
                    { 12, "Kitchen Appliances" },
                    { 13, "Swimming bool" },
                    { 14, "Wifi" },
                    { 15, "Landline" },
                    { 16, "Parking" },
                    { 17, "Pets allowed" },
                    { 18, "Garden" },
                    { 19, "Gym" },
                    { 20, "BeachAcess" },
                    { 21, "Security" },
                    { 22, "Elevator" }
                });

            migrationBuilder.InsertData(
                schema: "Property",
                table: "PropertyTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Apartment" },
                    { 2, "Villa" },
                    { 3, "Chalet" },
                    { 4, "Studio" },
                    { 5, "Duplex" },
                    { 6, "Penthouse" },
                    { 7, "Townhouse" },
                    { 8, "Twin House" },
                    { 9, "Cabin" },
                    { 10, "Building" },
                    { 11, "Farm House" },
                    { 12, "Chalet" },
                    { 13, "Hotel" },
                    { 14, "Resort" },
                    { 15, "House" },
                    { 16, "Flat" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Properties_PropertyTypeId",
                schema: "Property",
                table: "Properties",
                column: "PropertyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyAmenities_AmenityId",
                table: "PropertyAmenities",
                column: "AmenityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PropertyAmenities");

            migrationBuilder.DropTable(
                name: "Amenities",
                schema: "Property");

            migrationBuilder.DropTable(
                name: "Properties",
                schema: "Property");

            migrationBuilder.DropTable(
                name: "PropertyTypes",
                schema: "Property");
        }
    }
}
