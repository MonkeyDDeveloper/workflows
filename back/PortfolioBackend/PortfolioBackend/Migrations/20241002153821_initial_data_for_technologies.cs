using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PortfolioBackend.Migrations
{
    /// <inheritdoc />
    public partial class initial_data_for_technologies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "technologies",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1, "Nuxt 3.10.2" },
                    { 2, "Vue.js 3.4.x" },
                    { 3, "Vue.js 2.7" },
                    { 4, "Vuetify 2.6" },
                    { 5, "Bootstrap 4.x" },
                    { 6, "Nuxt/ui 2.13.0" },
                    { 7, "TailwindCSS 3.4.1" },
                    { 8, "Zod 3.2.24" },
                    { 9, "Node 20.0.0" },
                    { 10, "PostgreSQL 12" },
                    { 11, "Git" },
                    { 12, "Docker" },
                    { 13, "Nuxt 3.10.2" },
                    { 14, "Vue.js 3.4.x" },
                    { 15, "Nuxt/ui 2.13.0" },
                    { 16, "TailwindCSS 3.4.1" },
                    { 17, "Zod 3.2.24" },
                    { 18, "Node 20.0.0" },
                    { 19, "i18n 8.1.1" },
                    { 20, "Resend 3.2.0" },
                    { 21, "Shopify Dawn 13.0.1" },
                    { 22, "Liquid Template Language 5.4.0" },
                    { 23, "Git" },
                    { 24, "Vue.js 3.2.3" },
                    { 25, "Node 10.24.0" },
                    { 26, "Quasar Framework 0.17" },
                    { 27, "MongoDB 5.0" },
                    { 28, "TypeScript 5.4" },
                    { 29, "JavaScript (Vanilla)" },
                    { 30, "Pug.js (HTML)" },
                    { 31, "Bootstrap 5.0" },
                    { 32, "Node.js 14.0.0" },
                    { 33, "Express 4.0" },
                    { 34, "MongoDB 5.0" },
                    { 35, "DigitalOcean" },
                    { 36, "Nginx" },
                    { 37, "NameCheap" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 37);
        }
    }
}
