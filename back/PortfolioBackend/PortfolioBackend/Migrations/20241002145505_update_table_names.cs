using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioBackend.Migrations
{
    /// <inheritdoc />
    public partial class update_table_names : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Responsabilities_ProfessionalExperiences_ExperienceId",
                table: "Responsabilities");

            migrationBuilder.DropForeignKey(
                name: "FK_TechnologiesExperiences_ProfessionalExperiences_ExperienceId",
                table: "TechnologiesExperiences");

            migrationBuilder.DropForeignKey(
                name: "FK_TechnologiesExperiences_Technologies_TechnologieId",
                table: "TechnologiesExperiences");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Technologies",
                table: "Technologies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TechnologiesExperiences",
                table: "TechnologiesExperiences");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Responsabilities",
                table: "Responsabilities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProfessionalExperiences",
                table: "ProfessionalExperiences");

            migrationBuilder.RenameTable(
                name: "Technologies",
                newName: "technologies");

            migrationBuilder.RenameTable(
                name: "TechnologiesExperiences",
                newName: "technologies_experiences");

            migrationBuilder.RenameTable(
                name: "Responsabilities",
                newName: "reponsabilities");

            migrationBuilder.RenameTable(
                name: "ProfessionalExperiences",
                newName: "professional_experiences");

            migrationBuilder.RenameIndex(
                name: "IX_TechnologiesExperiences_TechnologieId",
                table: "technologies_experiences",
                newName: "IX_technologies_experiences_TechnologieId");

            migrationBuilder.RenameIndex(
                name: "IX_TechnologiesExperiences_ExperienceId",
                table: "technologies_experiences",
                newName: "IX_technologies_experiences_ExperienceId");

            migrationBuilder.RenameIndex(
                name: "IX_Responsabilities_ExperienceId",
                table: "reponsabilities",
                newName: "IX_reponsabilities_ExperienceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_technologies",
                table: "technologies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_technologies_experiences",
                table: "technologies_experiences",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_reponsabilities",
                table: "reponsabilities",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_professional_experiences",
                table: "professional_experiences",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_reponsabilities_professional_experiences_ExperienceId",
                table: "reponsabilities",
                column: "ExperienceId",
                principalTable: "professional_experiences",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_technologies_experiences_professional_experiences_Experienc~",
                table: "technologies_experiences",
                column: "ExperienceId",
                principalTable: "professional_experiences",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_technologies_experiences_technologies_TechnologieId",
                table: "technologies_experiences",
                column: "TechnologieId",
                principalTable: "technologies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_reponsabilities_professional_experiences_ExperienceId",
                table: "reponsabilities");

            migrationBuilder.DropForeignKey(
                name: "FK_technologies_experiences_professional_experiences_Experienc~",
                table: "technologies_experiences");

            migrationBuilder.DropForeignKey(
                name: "FK_technologies_experiences_technologies_TechnologieId",
                table: "technologies_experiences");

            migrationBuilder.DropPrimaryKey(
                name: "PK_technologies",
                table: "technologies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_technologies_experiences",
                table: "technologies_experiences");

            migrationBuilder.DropPrimaryKey(
                name: "PK_reponsabilities",
                table: "reponsabilities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_professional_experiences",
                table: "professional_experiences");

            migrationBuilder.RenameTable(
                name: "technologies",
                newName: "Technologies");

            migrationBuilder.RenameTable(
                name: "technologies_experiences",
                newName: "TechnologiesExperiences");

            migrationBuilder.RenameTable(
                name: "reponsabilities",
                newName: "Responsabilities");

            migrationBuilder.RenameTable(
                name: "professional_experiences",
                newName: "ProfessionalExperiences");

            migrationBuilder.RenameIndex(
                name: "IX_technologies_experiences_TechnologieId",
                table: "TechnologiesExperiences",
                newName: "IX_TechnologiesExperiences_TechnologieId");

            migrationBuilder.RenameIndex(
                name: "IX_technologies_experiences_ExperienceId",
                table: "TechnologiesExperiences",
                newName: "IX_TechnologiesExperiences_ExperienceId");

            migrationBuilder.RenameIndex(
                name: "IX_reponsabilities_ExperienceId",
                table: "Responsabilities",
                newName: "IX_Responsabilities_ExperienceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Technologies",
                table: "Technologies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TechnologiesExperiences",
                table: "TechnologiesExperiences",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Responsabilities",
                table: "Responsabilities",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProfessionalExperiences",
                table: "ProfessionalExperiences",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Responsabilities_ProfessionalExperiences_ExperienceId",
                table: "Responsabilities",
                column: "ExperienceId",
                principalTable: "ProfessionalExperiences",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TechnologiesExperiences_ProfessionalExperiences_ExperienceId",
                table: "TechnologiesExperiences",
                column: "ExperienceId",
                principalTable: "ProfessionalExperiences",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TechnologiesExperiences_Technologies_TechnologieId",
                table: "TechnologiesExperiences",
                column: "TechnologieId",
                principalTable: "Technologies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
