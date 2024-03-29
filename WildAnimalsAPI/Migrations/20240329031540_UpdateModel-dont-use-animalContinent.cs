using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WildAnimalsAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModeldontuseanimalContinent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimalContinents");

            migrationBuilder.AddColumn<string>(
                name: "Locations",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Locations",
                table: "Animals");

            migrationBuilder.CreateTable(
                name: "AnimalContinents",
                columns: table => new
                {
                    AnimalId = table.Column<int>(type: "int", nullable: false),
                    ContinentId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalContinents", x => new { x.AnimalId, x.ContinentId });
                    table.ForeignKey(
                        name: "FK_AnimalContinents_Animals_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimalContinents_Continents_ContinentId",
                        column: x => x.ContinentId,
                        principalTable: "Continents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnimalContinents_ContinentId",
                table: "AnimalContinents",
                column: "ContinentId");
        }
    }
}
