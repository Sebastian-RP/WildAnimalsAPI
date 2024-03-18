using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WildAnimalsAPI.Migrations
{
    /// <inheritdoc />
    public partial class continentAndAnimalTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommonName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScientificName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AverageHeightMin = table.Column<int>(type: "int", nullable: false),
                    AverageHeightMax = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AverageSpeedMin = table.Column<int>(type: "int", nullable: false),
                    AverageSpeedMax = table.Column<int>(type: "int", nullable: false),
                    AverageWeightMin = table.Column<int>(type: "int", nullable: false),
                    AverageWeightMax = table.Column<int>(type: "int", nullable: false),
                    EstimatedPopulationSize = table.Column<int>(type: "int", nullable: false),
                    AverageLifespanMin = table.Column<int>(type: "int", nullable: false),
                    AverageLifespanMax = table.Column<int>(type: "int", nullable: false),
                    Diet = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Continents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Population = table.Column<int>(type: "int", nullable: false),
                    SurfaceKm2 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Continents", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimalContinentMapping");

            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.DropTable(
                name: "Continents");
        }
    }
}
