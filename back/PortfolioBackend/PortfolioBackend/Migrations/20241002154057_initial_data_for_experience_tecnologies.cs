using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PortfolioBackend.Migrations
{
    /// <inheritdoc />
    public partial class initial_data_for_experience_tecnologies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "technologies_experiences",
                columns: new[] { "Id", "experience_id", "technologie_id" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 1, 3 },
                    { 4, 1, 4 },
                    { 5, 1, 5 },
                    { 6, 1, 6 },
                    { 7, 1, 7 },
                    { 8, 1, 8 },
                    { 9, 1, 9 },
                    { 10, 1, 10 },
                    { 11, 1, 11 },
                    { 12, 1, 12 },
                    { 13, 2, 13 },
                    { 14, 2, 14 },
                    { 15, 2, 16 },
                    { 16, 2, 17 },
                    { 17, 2, 18 },
                    { 18, 2, 19 },
                    { 19, 2, 20 },
                    { 20, 2, 21 },
                    { 21, 2, 22 },
                    { 22, 3, 24 },
                    { 23, 3, 25 },
                    { 24, 3, 26 },
                    { 25, 3, 27 },
                    { 26, 3, 28 },
                    { 27, 4, 29 },
                    { 28, 4, 30 },
                    { 29, 4, 31 },
                    { 30, 4, 32 },
                    { 31, 4, 33 },
                    { 32, 4, 34 },
                    { 33, 4, 35 },
                    { 34, 4, 36 },
                    { 35, 4, 37 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "technologies_experiences",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "technologies_experiences",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "technologies_experiences",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "technologies_experiences",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "technologies_experiences",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "technologies_experiences",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "technologies_experiences",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "technologies_experiences",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "technologies_experiences",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "technologies_experiences",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "technologies_experiences",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "technologies_experiences",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "technologies_experiences",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "technologies_experiences",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "technologies_experiences",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "technologies_experiences",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "technologies_experiences",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "technologies_experiences",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "technologies_experiences",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "technologies_experiences",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "technologies_experiences",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "technologies_experiences",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "technologies_experiences",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "technologies_experiences",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "technologies_experiences",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "technologies_experiences",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "technologies_experiences",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "technologies_experiences",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "technologies_experiences",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "technologies_experiences",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "technologies_experiences",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "technologies_experiences",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "technologies_experiences",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "technologies_experiences",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "technologies_experiences",
                keyColumn: "Id",
                keyValue: 35);
        }
    }
}
