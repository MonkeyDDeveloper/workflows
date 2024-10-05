using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioBackend.Migrations
{
    /// <inheritdoc />
    public partial class update_responsabilities_table_name : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_reponsabilities_professional_experiences_ExperienceId",
                table: "reponsabilities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_reponsabilities",
                table: "reponsabilities");

            migrationBuilder.RenameTable(
                name: "reponsabilities",
                newName: "responsabilities");

            migrationBuilder.RenameIndex(
                name: "IX_reponsabilities_ExperienceId",
                table: "responsabilities",
                newName: "IX_responsabilities_ExperienceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_responsabilities",
                table: "responsabilities",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_responsabilities_professional_experiences_ExperienceId",
                table: "responsabilities",
                column: "ExperienceId",
                principalTable: "professional_experiences",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_responsabilities_professional_experiences_ExperienceId",
                table: "responsabilities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_responsabilities",
                table: "responsabilities");

            migrationBuilder.RenameTable(
                name: "responsabilities",
                newName: "reponsabilities");

            migrationBuilder.RenameIndex(
                name: "IX_responsabilities_ExperienceId",
                table: "reponsabilities",
                newName: "IX_reponsabilities_ExperienceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_reponsabilities",
                table: "reponsabilities",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_reponsabilities_professional_experiences_ExperienceId",
                table: "reponsabilities",
                column: "ExperienceId",
                principalTable: "professional_experiences",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
