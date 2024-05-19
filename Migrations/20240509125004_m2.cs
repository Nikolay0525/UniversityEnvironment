using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityEnvironment.Data.Migrations
{
    /// <inheritdoc />
    public partial class m2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ForgetPassword",
                table: "Teachers",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ForgetPassword",
                table: "Students",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ForgetPassword",
                table: "Admins",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ForgetPassword",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "ForgetPassword",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ForgetPassword",
                table: "Admins");
        }
    }
}
