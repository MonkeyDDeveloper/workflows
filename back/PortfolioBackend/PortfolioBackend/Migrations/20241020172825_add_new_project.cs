using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PortfolioBackend.Migrations
{
    /// <inheritdoc />
    public partial class add_new_project : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "projects",
                columns: new[] { "id", "description", "github_uri", "name" },
                values: new object[] { 5, "", "https://github.com/MonkeyDDeveloper/api-ts-swagger", "TypeScript Api" });

            migrationBuilder.InsertData(
                table: "technologies",
                columns: new[] { "id", "abbr", "name" },
                values: new object[,]
                {
                    { 51, "redis", "Redis" },
                    { 52, "swagger", "Swagger" },
                    { 53, "jest", "Jest" },
                    { 54, "axios", "Axios" }
                });

            migrationBuilder.InsertData(
                table: "TechnologieProject",
                columns: new[] { "id", "project_id", "technologie_id" },
                values: new object[,]
                {
                    { 27, 5, 51 },
                    { 28, 5, 52 },
                    { 29, 5, 53 },
                    { 30, 5, 54 },
                    { 31, 5, 49 },
                    { 32, 5, 23 },
                    { 33, 5, 12 },
                    { 34, 5, 9 }
                });

            migrationBuilder.InsertData(
                table: "technologies_experiences",
                columns: new[] { "id", "experience_id", "technologie_id" },
                values: new object[,]
                {
                    { 36, 2, 53 },
                    { 37, 2, 52 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TechnologieProject",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "TechnologieProject",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "TechnologieProject",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "TechnologieProject",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "TechnologieProject",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "TechnologieProject",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "TechnologieProject",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "TechnologieProject",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "technologies_experiences",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "technologies_experiences",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "projects",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 54);
        }
    }
}
