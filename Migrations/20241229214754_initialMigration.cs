using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RockSetter.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rocks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Density = table.Column<double>(type: "REAL", nullable: false),
                    Hardness = table.Column<int>(type: "INTEGER", nullable: false),
                    Formula = table.Column<string>(type: "TEXT", nullable: false),
                    Month = table.Column<int>(type: "INTEGER", nullable: false),
                    Favorible = table.Column<bool>(type: "INTEGER", nullable: false),
                    ImageFileName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rocks", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Rocks",
                columns: new[] { "Id", "Density", "Favorible", "Formula", "Hardness", "ImageFileName", "Month", "Name" },
                values: new object[,]
                {
                    { 1, 4.0, false, "Si_02H20", 4, "amethyst.jpeg", 4, "amethyst" },
                    { 2, 4.0, true, "Si_02H20", 4, "emerald.jpeg", 4, "Emerald" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rocks");
        }
    }
}
