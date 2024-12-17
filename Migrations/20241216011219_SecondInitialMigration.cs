using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RockSetter.Migrations
{
    /// <inheritdoc />
    public partial class SecondInitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Rocks",
                columns: new[] { "Id", "Density", "Favorible", "Formula", "Hardness", "Month", "Name" },
                values: new object[] { 2, 4f, true, "Si_02H20", 4, 4, "Emerald" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rocks",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
