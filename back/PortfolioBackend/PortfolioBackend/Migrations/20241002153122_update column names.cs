using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioBackend.Migrations
{
    /// <inheritdoc />
    public partial class updatecolumnnames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_responsabilities_professional_experiences_ExperienceId",
                table: "responsabilities");

            migrationBuilder.DropForeignKey(
                name: "FK_technologies_experiences_professional_experiences_Experienc~",
                table: "technologies_experiences");

            migrationBuilder.DropForeignKey(
                name: "FK_technologies_experiences_technologies_TechnologieId",
                table: "technologies_experiences");

            migrationBuilder.RenameColumn(
                name: "TechnologieId",
                table: "technologies_experiences",
                newName: "technologie_id");

            migrationBuilder.RenameColumn(
                name: "ExperienceId",
                table: "technologies_experiences",
                newName: "experience_id");

            migrationBuilder.RenameIndex(
                name: "IX_technologies_experiences_TechnologieId",
                table: "technologies_experiences",
                newName: "IX_technologies_experiences_technologie_id");

            migrationBuilder.RenameIndex(
                name: "IX_technologies_experiences_ExperienceId",
                table: "technologies_experiences",
                newName: "IX_technologies_experiences_experience_id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "technologies",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "technologies",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "responsabilities",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "responsabilities",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "ExperienceId",
                table: "responsabilities",
                newName: "experience_id");

            migrationBuilder.RenameIndex(
                name: "IX_responsabilities_ExperienceId",
                table: "responsabilities",
                newName: "IX_responsabilities_experience_id");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "professional_experiences",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "professional_experiences",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "professional_experiences",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "professional_experiences",
                newName: "start_date");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "professional_experiences",
                newName: "end_date");

            migrationBuilder.AddForeignKey(
                name: "FK_responsabilities_professional_experiences_experience_id",
                table: "responsabilities",
                column: "experience_id",
                principalTable: "professional_experiences",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_technologies_experiences_professional_experiences_experienc~",
                table: "technologies_experiences",
                column: "experience_id",
                principalTable: "professional_experiences",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_technologies_experiences_technologies_technologie_id",
                table: "technologies_experiences",
                column: "technologie_id",
                principalTable: "technologies",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_responsabilities_professional_experiences_experience_id",
                table: "responsabilities");

            migrationBuilder.DropForeignKey(
                name: "FK_technologies_experiences_professional_experiences_experienc~",
                table: "technologies_experiences");

            migrationBuilder.DropForeignKey(
                name: "FK_technologies_experiences_technologies_technologie_id",
                table: "technologies_experiences");

            migrationBuilder.RenameColumn(
                name: "technologie_id",
                table: "technologies_experiences",
                newName: "TechnologieId");

            migrationBuilder.RenameColumn(
                name: "experience_id",
                table: "technologies_experiences",
                newName: "ExperienceId");

            migrationBuilder.RenameIndex(
                name: "IX_technologies_experiences_technologie_id",
                table: "technologies_experiences",
                newName: "IX_technologies_experiences_TechnologieId");

            migrationBuilder.RenameIndex(
                name: "IX_technologies_experiences_experience_id",
                table: "technologies_experiences",
                newName: "IX_technologies_experiences_ExperienceId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "technologies",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "technologies",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "responsabilities",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "responsabilities",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "experience_id",
                table: "responsabilities",
                newName: "ExperienceId");

            migrationBuilder.RenameIndex(
                name: "IX_responsabilities_experience_id",
                table: "responsabilities",
                newName: "IX_responsabilities_ExperienceId");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "professional_experiences",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "professional_experiences",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "professional_experiences",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "start_date",
                table: "professional_experiences",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "end_date",
                table: "professional_experiences",
                newName: "EndDate");

            migrationBuilder.AddForeignKey(
                name: "FK_responsabilities_professional_experiences_ExperienceId",
                table: "responsabilities",
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
    }
}
