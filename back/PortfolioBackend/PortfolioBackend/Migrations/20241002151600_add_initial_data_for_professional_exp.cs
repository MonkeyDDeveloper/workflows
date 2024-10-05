using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PortfolioBackend.Migrations
{
    /// <inheritdoc />
    public partial class add_initial_data_for_professional_exp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "professional_experiences",
                columns: new[] { "Id", "Description", "EndDate", "StartDate", "Title" },
                values: new object[,]
                {
                    { 1, "Created a web application to streamline the student enrollment process.", new DateOnly(2022, 7, 31), new DateOnly(2021, 2, 1), "FullStack Developer at MonkeyDDevelopment" },
                    { 2, "Implemented Nomina360, a web app for human resources management.", new DateOnly(2023, 11, 30), new DateOnly(2022, 10, 1), "FullStack Developer at Soluciones y Proyectos SA" },
                    { 3, "Developed a client's page using the new version of Shopify Theme Dawn.", new DateOnly(2024, 2, 29), new DateOnly(2023, 11, 1), "Frontend Developer at CacaoWebStudio" },
                    { 4, "Created an application to manage the capacitation of operators in Yucatán, México.", new DateOnly(2024, 12, 31), new DateOnly(2024, 5, 1), "Software Engineer at Dacodes" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "professional_experiences",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "professional_experiences",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "professional_experiences",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "professional_experiences",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
