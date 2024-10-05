using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PortfolioBackend.Migrations
{
    /// <inheritdoc />
    public partial class testing_relatins : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TechnologiesExperiences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TechnologieId = table.Column<int>(type: "integer", nullable: false),
                    ExperienceId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechnologiesExperiences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TechnologiesExperiences_ProfessionalExperiences_ExperienceId",
                        column: x => x.ExperienceId,
                        principalTable: "ProfessionalExperiences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TechnologiesExperiences_Technologies_TechnologieId",
                        column: x => x.TechnologieId,
                        principalTable: "Technologies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TechnologiesExperiences_ExperienceId",
                table: "TechnologiesExperiences",
                column: "ExperienceId");

            migrationBuilder.CreateIndex(
                name: "IX_TechnologiesExperiences_TechnologieId",
                table: "TechnologiesExperiences",
                column: "TechnologieId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TechnologiesExperiences");
        }
    }
}
