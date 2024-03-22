using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WildAnimalsAPI.Migrations
{
    /// <inheritdoc />
    public partial class addseedercontinents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "SurfaceKm2",
                table: "Continents",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "Population",
                table: "Continents",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Continents",
                columns: new[] { "Id", "Name", "Population", "SurfaceKm2" },
                values: new object[,]
                {
                    { 1, "Asia", 4693000000L, 44614000L },
                    { 2, "Africa", 1386000000L, 30370000L },
                    { 3, "America del Norte", 593000000L, 24709000L },
                    { 4, "America del Sur", 434000000L, 17843000L },
                    { 5, "Antártida", 0L, 14200000L },
                    { 6, "Europa", 741000000L, 10180000L },
                    { 7, "Oceanía", 44000000L, 8920000L }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.AlterColumn<int>(
                name: "SurfaceKm2",
                table: "Continents",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "Population",
                table: "Continents",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");
        }
    }
}
