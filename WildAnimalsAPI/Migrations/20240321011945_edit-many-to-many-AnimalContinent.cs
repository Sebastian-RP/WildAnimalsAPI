using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WildAnimalsAPI.Migrations
{
    /// <inheritdoc />
    public partial class editmanytomanyAnimalContinent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimalContinentMapping");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Continents",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "AnimalContinent",
                columns: table => new
                {
                    AnimalId = table.Column<int>(type: "int", nullable: false),
                    ContinentId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalContinent", x => new { x.AnimalId, x.ContinentId });
                    table.ForeignKey(
                        name: "FK_AnimalContinent_Animals_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimalContinent_Continents_ContinentId",
                        column: x => x.ContinentId,
                        principalTable: "Continents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnimalContinent_ContinentId",
                table: "AnimalContinent",
                column: "ContinentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimalContinent");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Continents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "AnimalContinentMapping",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnimalId = table.Column<int>(type: "int", nullable: false),
                    ContinentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalContinentMapping", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnimalContinentMapping_Animals_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimalContinentMapping_Continents_ContinentId",
                        column: x => x.ContinentId,
                        principalTable: "Continents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnimalContinentMapping_AnimalId",
                table: "AnimalContinentMapping",
                column: "AnimalId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalContinentMapping_ContinentId",
                table: "AnimalContinentMapping",
                column: "ContinentId");
        }
    }
}
