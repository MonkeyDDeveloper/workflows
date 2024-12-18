using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PortfolioBackend.Migrations
{
    /// <inheritdoc />
    public partial class add_python_cli_project : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "projects",
                columns: new[] { "id", "description", "github_uri", "name" },
                values: new object[] { 6, "CRUD with Python using Psycopg2, Docker, Postgres SQL Scripts, Bcrypt, PrettyTable and email-validator", "https://github.com/MonkeyDDeveloper/python_console_crud", "Python CLI CRUD with Postgres" });

            migrationBuilder.InsertData(
                table: "TechnologieProject",
                columns: new[] { "id", "project_id", "technologie_id" },
                values: new object[,]
                {
                    { 35, 6, 46 },
                    { 36, 6, 39 },
                    { 37, 6, 23 },
                    { 38, 6, 12 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TechnologieProject",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "TechnologieProject",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "TechnologieProject",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "TechnologieProject",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "projects",
                keyColumn: "id",
                keyValue: 6);
        }
    }
}
