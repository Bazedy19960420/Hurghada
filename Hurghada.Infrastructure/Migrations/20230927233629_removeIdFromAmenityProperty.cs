using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hurghada.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class removeIdFromAmenityProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "PropertyAmenities");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "PropertyAmenities",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
