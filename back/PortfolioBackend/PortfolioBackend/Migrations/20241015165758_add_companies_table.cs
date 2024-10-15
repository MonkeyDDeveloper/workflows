using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PortfolioBackend.Migrations
{
    /// <inheritdoc />
    public partial class add_companies_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "technologies_experiences",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TechnologieProject",
                newName: "id");

            migrationBuilder.CreateTable(
                name: "companies",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    logo_path = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_companies", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "company_experiences",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    company_id = table.Column<int>(type: "integer", nullable: false),
                    experience_id = table.Column<int>(type: "integer", nullable: false),
                    ProfessionalExperienceId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_company_experiences", x => x.id);
                    table.ForeignKey(
                        name: "FK_company_experiences_companies_company_id",
                        column: x => x.company_id,
                        principalTable: "companies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_company_experiences_professional_experiences_ProfessionalEx~",
                        column: x => x.ProfessionalExperienceId,
                        principalTable: "professional_experiences",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_company_experiences_professional_experiences_experience_id",
                        column: x => x.experience_id,
                        principalTable: "professional_experiences",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "companies",
                columns: new[] { "id", "logo_path", "name" },
                values: new object[,]
                {
                    { 1, "/experience/monkey_d_developer.png", "MonkeyDDeveloper" },
                    { 2, "/experience/nomina360.png", "Soluciones y Proyectos SA" },
                    { 3, "/experience/cacao_logo.jpg", "Cacao Web Studio" },
                    { 4, "/experience/dacodes_logo.webp", "Dacodes" }
                });

            migrationBuilder.InsertData(
                table: "company_experiences",
                columns: new[] { "id", "company_id", "experience_id", "ProfessionalExperienceId" },
                values: new object[,]
                {
                    { 1, 1, 1, null },
                    { 2, 2, 2, null },
                    { 3, 3, 3, null },
                    { 4, 4, 4, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_company_experiences_company_id",
                table: "company_experiences",
                column: "company_id");

            migrationBuilder.CreateIndex(
                name: "IX_company_experiences_experience_id",
                table: "company_experiences",
                column: "experience_id");

            migrationBuilder.CreateIndex(
                name: "IX_company_experiences_ProfessionalExperienceId",
                table: "company_experiences",
                column: "ProfessionalExperienceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "company_experiences");

            migrationBuilder.DropTable(
                name: "companies");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "technologies_experiences",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "TechnologieProject",
                newName: "Id");
        }
    }
}
