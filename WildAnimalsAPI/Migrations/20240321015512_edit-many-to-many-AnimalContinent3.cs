using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WildAnimalsAPI.Migrations
{
    /// <inheritdoc />
    public partial class editmanytomanyAnimalContinent3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnimalContinent_Animals_AnimalId",
                table: "AnimalContinent");

            migrationBuilder.DropForeignKey(
                name: "FK_AnimalContinent_Continents_ContinentId",
                table: "AnimalContinent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnimalContinent",
                table: "AnimalContinent");

            migrationBuilder.RenameTable(
                name: "AnimalContinent",
                newName: "AnimalContinents");

            migrationBuilder.RenameIndex(
                name: "IX_AnimalContinent_ContinentId",
                table: "AnimalContinents",
                newName: "IX_AnimalContinents_ContinentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnimalContinents",
                table: "AnimalContinents",
                columns: new[] { "AnimalId", "ContinentId" });

            migrationBuilder.AddForeignKey(
                name: "FK_AnimalContinents_Animals_AnimalId",
                table: "AnimalContinents",
                column: "AnimalId",
                principalTable: "Animals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AnimalContinents_Continents_ContinentId",
                table: "AnimalContinents",
                column: "ContinentId",
                principalTable: "Continents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnimalContinents_Animals_AnimalId",
                table: "AnimalContinents");

            migrationBuilder.DropForeignKey(
                name: "FK_AnimalContinents_Continents_ContinentId",
                table: "AnimalContinents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnimalContinents",
                table: "AnimalContinents");

            migrationBuilder.RenameTable(
                name: "AnimalContinents",
                newName: "AnimalContinent");

            migrationBuilder.RenameIndex(
                name: "IX_AnimalContinents_ContinentId",
                table: "AnimalContinent",
                newName: "IX_AnimalContinent_ContinentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnimalContinent",
                table: "AnimalContinent",
                columns: new[] { "AnimalId", "ContinentId" });

            migrationBuilder.AddForeignKey(
                name: "FK_AnimalContinent_Animals_AnimalId",
                table: "AnimalContinent",
                column: "AnimalId",
                principalTable: "Animals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AnimalContinent_Continents_ContinentId",
                table: "AnimalContinent",
                column: "ContinentId",
                principalTable: "Continents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
