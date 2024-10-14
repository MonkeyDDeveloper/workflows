using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioBackend.Migrations
{
    /// <inheritdoc />
    public partial class add_boolean_field_pe_model : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "is_current",
                table: "professional_experiences",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "professional_experiences",
                keyColumn: "id",
                keyValue: 1,
                column: "is_current",
                value: false);

            migrationBuilder.UpdateData(
                table: "professional_experiences",
                keyColumn: "id",
                keyValue: 2,
                column: "is_current",
                value: false);

            migrationBuilder.UpdateData(
                table: "professional_experiences",
                keyColumn: "id",
                keyValue: 3,
                column: "is_current",
                value: false);

            migrationBuilder.UpdateData(
                table: "professional_experiences",
                keyColumn: "id",
                keyValue: 4,
                column: "is_current",
                value: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "is_current",
                table: "professional_experiences");
        }
    }
}
