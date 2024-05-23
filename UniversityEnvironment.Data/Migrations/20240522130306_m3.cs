using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityEnvironment.Data.Migrations
{
    /// <inheritdoc />
    public partial class m3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "CanChangePassword",
                table: "Teachers",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CanChangePassword",
                table: "Students",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CanChangePassword",
                table: "Admins",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CanChangePassword",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "CanChangePassword",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "CanChangePassword",
                table: "Admins");
        }
    }
}
