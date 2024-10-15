using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioBackend.Migrations
{
    /// <inheritdoc />
    public partial class fix_company_experiences_relations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_company_experiences_professional_experiences_ProfessionalEx~",
                table: "company_experiences");

            migrationBuilder.DropIndex(
                name: "IX_company_experiences_experience_id",
                table: "company_experiences");

            migrationBuilder.DropIndex(
                name: "IX_company_experiences_ProfessionalExperienceId",
                table: "company_experiences");

            migrationBuilder.DropColumn(
                name: "ProfessionalExperienceId",
                table: "company_experiences");

            migrationBuilder.CreateIndex(
                name: "IX_company_experiences_experience_id",
                table: "company_experiences",
                column: "experience_id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_company_experiences_experience_id",
                table: "company_experiences");

            migrationBuilder.AddColumn<int>(
                name: "ProfessionalExperienceId",
                table: "company_experiences",
                type: "integer",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "company_experiences",
                keyColumn: "id",
                keyValue: 1,
                column: "ProfessionalExperienceId",
                value: null);

            migrationBuilder.UpdateData(
                table: "company_experiences",
                keyColumn: "id",
                keyValue: 2,
                column: "ProfessionalExperienceId",
                value: null);

            migrationBuilder.UpdateData(
                table: "company_experiences",
                keyColumn: "id",
                keyValue: 3,
                column: "ProfessionalExperienceId",
                value: null);

            migrationBuilder.UpdateData(
                table: "company_experiences",
                keyColumn: "id",
                keyValue: 4,
                column: "ProfessionalExperienceId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_company_experiences_experience_id",
                table: "company_experiences",
                column: "experience_id");

            migrationBuilder.CreateIndex(
                name: "IX_company_experiences_ProfessionalExperienceId",
                table: "company_experiences",
                column: "ProfessionalExperienceId");

            migrationBuilder.AddForeignKey(
                name: "FK_company_experiences_professional_experiences_ProfessionalEx~",
                table: "company_experiences",
                column: "ProfessionalExperienceId",
                principalTable: "professional_experiences",
                principalColumn: "id");
        }
    }
}
