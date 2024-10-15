using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioBackend.Migrations
{
    /// <inheritdoc />
    public partial class add_abbr_column_in_technologie_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "abbr",
                table: "technologies",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "professional_experiences",
                keyColumn: "id",
                keyValue: 1,
                column: "description",
                value: "We created a web application to streamline the student enrollment process.");

            migrationBuilder.UpdateData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 1,
                column: "abbr",
                value: "nuxt");

            migrationBuilder.UpdateData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 2,
                column: "abbr",
                value: "vue");

            migrationBuilder.UpdateData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 3,
                column: "abbr",
                value: "vue");

            migrationBuilder.UpdateData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 4,
                column: "abbr",
                value: "vuetify");

            migrationBuilder.UpdateData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 5,
                column: "abbr",
                value: "bootstrap");

            migrationBuilder.UpdateData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 6,
                column: "abbr",
                value: "nuxtui");

            migrationBuilder.UpdateData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 7,
                column: "abbr",
                value: "tailwind");

            migrationBuilder.UpdateData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 8,
                column: "abbr",
                value: "zod");

            migrationBuilder.UpdateData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 9,
                column: "abbr",
                value: "node");

            migrationBuilder.UpdateData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 10,
                column: "abbr",
                value: "postgres");

            migrationBuilder.UpdateData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 11,
                column: "abbr",
                value: "git");

            migrationBuilder.UpdateData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 12,
                column: "abbr",
                value: "docker");

            migrationBuilder.UpdateData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 13,
                column: "abbr",
                value: "nuxt");

            migrationBuilder.UpdateData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 14,
                column: "abbr",
                value: "vue");

            migrationBuilder.UpdateData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 15,
                column: "abbr",
                value: "nuxtui");

            migrationBuilder.UpdateData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 16,
                column: "abbr",
                value: "tailwind");

            migrationBuilder.UpdateData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 17,
                column: "abbr",
                value: "zod");

            migrationBuilder.UpdateData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 18,
                column: "abbr",
                value: "node");

            migrationBuilder.UpdateData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 19,
                column: "abbr",
                value: "i18n");

            migrationBuilder.UpdateData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 20,
                column: "abbr",
                value: "resend");

            migrationBuilder.UpdateData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 21,
                column: "abbr",
                value: "shopify");

            migrationBuilder.UpdateData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 22,
                column: "abbr",
                value: "liquidtemplate");

            migrationBuilder.UpdateData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 23,
                column: "abbr",
                value: "git");

            migrationBuilder.UpdateData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 24,
                column: "abbr",
                value: "vue");

            migrationBuilder.UpdateData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 25,
                column: "abbr",
                value: "node");

            migrationBuilder.UpdateData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 26,
                column: "abbr",
                value: "quasar");

            migrationBuilder.UpdateData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 27,
                column: "abbr",
                value: "mongo");

            migrationBuilder.UpdateData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 28,
                column: "abbr",
                value: "typescript");

            migrationBuilder.UpdateData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 29,
                column: "abbr",
                value: "javascript");

            migrationBuilder.UpdateData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 30,
                column: "abbr",
                value: "pugjs");

            migrationBuilder.UpdateData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 31,
                column: "abbr",
                value: "bootstrap");

            migrationBuilder.UpdateData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 32,
                column: "abbr",
                value: "node");

            migrationBuilder.UpdateData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 33,
                column: "abbr",
                value: "express");

            migrationBuilder.UpdateData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 34,
                column: "abbr",
                value: "mongo");

            migrationBuilder.UpdateData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 35,
                column: "abbr",
                value: "digitalocean");

            migrationBuilder.UpdateData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 36,
                column: "abbr",
                value: "nginx");

            migrationBuilder.UpdateData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 37,
                column: "abbr",
                value: "namecheap");

            migrationBuilder.UpdateData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 38,
                column: "abbr",
                value: "jwt");

            migrationBuilder.UpdateData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 39,
                column: "abbr",
                value: "python");

            migrationBuilder.UpdateData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 40,
                column: "abbr",
                value: "flask");

            migrationBuilder.UpdateData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 41,
                column: "abbr",
                value: "pymongo");

            migrationBuilder.UpdateData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 42,
                column: "abbr",
                value: "mongoose");

            migrationBuilder.UpdateData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 43,
                column: "abbr",
                value: "awsgateway");

            migrationBuilder.UpdateData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 44,
                column: "abbr",
                value: "awslambda");

            migrationBuilder.UpdateData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 45,
                column: "abbr",
                value: "nextjs");

            migrationBuilder.UpdateData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 46,
                column: "abbr",
                value: "postgres");

            migrationBuilder.UpdateData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 47,
                column: "abbr",
                value: "DotNET");

            migrationBuilder.UpdateData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 48,
                column: "abbr",
                value: "entityframework");

            migrationBuilder.UpdateData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 49,
                column: "abbr",
                value: "digitalocean");

            migrationBuilder.UpdateData(
                table: "technologies",
                keyColumn: "id",
                keyValue: 50,
                column: "abbr",
                value: "githubactions");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "abbr",
                table: "technologies");

            migrationBuilder.UpdateData(
                table: "professional_experiences",
                keyColumn: "id",
                keyValue: 1,
                column: "description",
                value: "Created a web application to streamline the student enrollment process.");
        }
    }
}
