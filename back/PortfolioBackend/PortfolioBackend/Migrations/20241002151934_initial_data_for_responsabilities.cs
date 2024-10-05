using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PortfolioBackend.Migrations
{
    /// <inheritdoc />
    public partial class initial_data_for_responsabilities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "reponsabilities",
                columns: new[] { "Id", "Description", "ExperienceId" },
                values: new object[,]
                {
                    { 1, "Defining the current enrollment process and its weaknesses.", 1 },
                    { 2, "Design the pages and use cases, with focus on easy use for its users.", 1 },
                    { 3, "Make reviews with the administrative staff and the students of the institute.", 1 },
                    { 4, "Define the correct structure of subjects, students, careers, admin users for the database.", 1 },
                    { 5, "Be responsible for the frontend, backend, database and release of the application.", 1 },
                    { 6, "Implement readable and clean code, following the best practices.", 2 },
                    { 7, "Analyze the requirements to implement them correctly.", 2 },
                    { 8, "Realize unit testing of the functions created.", 2 },
                    { 9, "Have great communication with the rest of the dev team, and also with the administrative team.", 2 },
                    { 10, "Realize code review of the tasks of the rest of the team.", 2 },
                    { 11, "Efficiently implement components, snippets, and sections of Shopify.", 3 },
                    { 12, "Testing every new section created to ensure its working in different screen sizes.", 3 },
                    { 13, "Priority user experience, make efficient js code.", 3 },
                    { 14, "Defining project structure.", 3 },
                    { 15, "Keep track of tasks and good communication with the designing and development team.", 3 },
                    { 16, "Ensure clean and understandable code (code review).", 3 },
                    { 17, "Create and implement Vuejs components using domain-driven-design.", 4 },
                    { 18, "Estimate the time to implement requirements in hours in meetings with the team.", 4 },
                    { 19, "Follow the business requirements and use cases.", 4 },
                    { 20, "Good communication with the QA and development team.", 4 },
                    { 21, "Ensure clean and understandable code and code refactorization.", 4 },
                    { 22, "Side help with Backend code analysis and DB.", 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "reponsabilities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "reponsabilities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "reponsabilities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "reponsabilities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "reponsabilities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "reponsabilities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "reponsabilities",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "reponsabilities",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "reponsabilities",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "reponsabilities",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "reponsabilities",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "reponsabilities",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "reponsabilities",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "reponsabilities",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "reponsabilities",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "reponsabilities",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "reponsabilities",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "reponsabilities",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "reponsabilities",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "reponsabilities",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "reponsabilities",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "reponsabilities",
                keyColumn: "Id",
                keyValue: 22);
        }
    }
}
