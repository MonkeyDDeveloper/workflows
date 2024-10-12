using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PortfolioBackend.Migrations
{
    /// <inheritdoc />
    public partial class initial_data_for_projects : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "projects",
                columns: new[] { "id", "description", "name" },
                values: new object[,]
                {
                    { 1, "", "Dockerized Product Management System with Authentication" },
                    { 2, "", "Dockerized Python Flask Rest Api - MongoDB" },
                    { 3, "", "Api Gateway - Lambda Functions Rest Api" },
                    { 4, "", "Dockerized Portfolio - .Net - Postgres" }
                });

            migrationBuilder.InsertData(
                table: "technologies",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 38, "JsonWebTokens" },
                    { 39, "Python 3.10.12" },
                    { 40, "Flask 3.0.3" },
                    { 41, "PyMongo 4.7.2" },
                    { 42, "Mongoose" },
                    { 43, "AWS API Gateway" },
                    { 44, "AWS Lambda Functions" },
                    { 45, "Nextjs" },
                    { 46, "PostgreSQL" },
                    { 47, ".NET 8" },
                    { 48, "Entity Framework" },
                    { 49, "Digital Ocean Droplets" },
                    { 50, "Github Actions" }
                });

            migrationBuilder.InsertData(
                table: "TechnologieProject",
                columns: new[] { "Id", "project_id", "technologie_id" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 1, 6 },
                    { 4, 1, 11 },
                    { 5, 1, 12 },
                    { 6, 1, 33 },
                    { 7, 1, 34 },
                    { 8, 1, 28 },
                    { 9, 1, 38 },
                    { 10, 2, 12 },
                    { 11, 2, 39 },
                    { 12, 2, 40 },
                    { 13, 2, 41 },
                    { 14, 3, 42 },
                    { 15, 3, 43 },
                    { 16, 3, 44 },
                    { 17, 3, 28 },
                    { 18, 4, 45 },
                    { 19, 4, 46 },
                    { 20, 4, 47 },
                    { 21, 4, 48 },
                    { 22, 4, 49 },
                    { 23, 4, 50 },
                    { 24, 4, 28 },
                    { 25, 4, 12 },
                    { 26, 4, 23 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TechnologieProject",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TechnologieProject",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TechnologieProject",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TechnologieProject",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TechnologieProject",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TechnologieProject",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TechnologieProject",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TechnologieProject",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TechnologieProject",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TechnologieProject",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TechnologieProject",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TechnologieProject",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TechnologieProject",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TechnologieProject",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TechnologieProject",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TechnologieProject",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TechnologieProject",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TechnologieProject",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TechnologieProject",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "TechnologieProject",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "TechnologieProject",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "TechnologieProject",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "TechnologieProject",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "TechnologieProject",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "TechnologieProject",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "TechnologieProject",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "projects",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "projects",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "projects",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "projects",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 50);
        }
    }
}
