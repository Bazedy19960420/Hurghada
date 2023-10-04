using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hurghada.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddLanguageData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "TourGuide",
                table: "Languages",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "English" },
                    { 2, "German" },
                    { 3, "French" },
                    { 4, "Italian" },
                    { 5, "Spanish" },
                    { 6, "Russian" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "TourGuide",
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "TourGuide",
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "TourGuide",
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "TourGuide",
                table: "Languages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "TourGuide",
                table: "Languages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "TourGuide",
                table: "Languages",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
