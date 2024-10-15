using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioBackend.Migrations
{
    /// <inheritdoc />
    public partial class column_github_uri_on_project : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "github_uri",
                table: "projects",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "projects",
                keyColumn: "id",
                keyValue: 1,
                column: "github_uri",
                value: "https://github.com/MonkeyDDeveloper/dockerized-full-stack-application");

            migrationBuilder.UpdateData(
                table: "projects",
                keyColumn: "id",
                keyValue: 2,
                column: "github_uri",
                value: "https://github.com/MonkeyDDeveloper/dockerized-flask-api-mongodb");

            migrationBuilder.UpdateData(
                table: "projects",
                keyColumn: "id",
                keyValue: 3,
                column: "github_uri",
                value: "https://github.com/MonkeyDDeveloper/aws-lambda-apigateway-functions");

            migrationBuilder.UpdateData(
                table: "projects",
                keyColumn: "id",
                keyValue: 4,
                column: "github_uri",
                value: "https://github.com/MonkeyDDeveloper/workflows");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "github_uri",
                table: "projects");
        }
    }
}
