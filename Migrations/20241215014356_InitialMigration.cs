using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RockSetter.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
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
                    Density = table.Column<float>(type: "REAL", nullable: false),
                    Hardness = table.Column<int>(type: "INTEGER", nullable: false),
                    Formula = table.Column<string>(type: "TEXT", nullable: false),
                    Month = table.Column<int>(type: "INTEGER", nullable: false),
                    Favorible = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rocks", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Rocks",
                columns: new[] { "Id", "Density", "Favorible", "Formula", "Hardness", "Month", "Name" },
                values: new object[] { 1, 4f, false, "Si_02H20", 4, 4, "Amethysd" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rocks");
        }
    }
}
