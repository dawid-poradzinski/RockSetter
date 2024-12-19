using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RockSetter.Migrations
{
    /// <inheritdoc />
    public partial class AddedImageFileName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageFileName",
                table: "Rocks",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Rocks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Density", "ImageFileName", "Name" },
                values: new object[] { 4.0, "amethyst", "amethyst" });

            migrationBuilder.UpdateData(
                table: "Rocks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Density", "ImageFileName" },
                values: new object[] { 4.0, "emerald" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageFileName",
                table: "Rocks");

            migrationBuilder.UpdateData(
                table: "Rocks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Density", "Name" },
                values: new object[] { 4f, "Amethysd" });

            migrationBuilder.UpdateData(
                table: "Rocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "Density",
                value: 4f);
        }
    }
}
