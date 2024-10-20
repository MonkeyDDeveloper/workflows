using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioBackend.Migrations
{
    /// <inheritdoc />
    public partial class update_projects_description : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "projects",
                keyColumn: "id",
                keyValue: 1,
                column: "description",
                value: "Full stack application that uses JWT to auth. The front was built with Nuxtjs and the back with express, both of them usgin typescript. It is dockerized and uses a Mongo Database. ");

            migrationBuilder.UpdateData(
                table: "projects",
                keyColumn: "id",
                keyValue: 2,
                column: "description",
                value: "An example of rest api using Flask library and an ORM to connect and interact with a Mongo Database.");

            migrationBuilder.UpdateData(
                table: "projects",
                keyColumn: "id",
                keyValue: 3,
                column: "description",
                value: "AWS Lambda funtions as microservices built with TypeScript to create a rest api.");

            migrationBuilder.UpdateData(
                table: "projects",
                keyColumn: "id",
                keyValue: 4,
                column: "description",
                value: "The page you are watching, it was built using nextjs, typescript, .net and postgres as database. Also, it is deployed automatically using github actions in a digital ocean droplet.");

            migrationBuilder.UpdateData(
                table: "projects",
                keyColumn: "id",
                keyValue: 5,
                column: "description",
                value: "Dockerized TypeScript Api that uses Redis db to caching data. It implements Swagger Docs, and Jest for testing.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "projects",
                keyColumn: "id",
                keyValue: 1,
                column: "description",
                value: "");

            migrationBuilder.UpdateData(
                table: "projects",
                keyColumn: "id",
                keyValue: 2,
                column: "description",
                value: "");

            migrationBuilder.UpdateData(
                table: "projects",
                keyColumn: "id",
                keyValue: 3,
                column: "description",
                value: "");

            migrationBuilder.UpdateData(
                table: "projects",
                keyColumn: "id",
                keyValue: 4,
                column: "description",
                value: "");

            migrationBuilder.UpdateData(
                table: "projects",
                keyColumn: "id",
                keyValue: 5,
                column: "description",
                value: "");
        }
    }
}
