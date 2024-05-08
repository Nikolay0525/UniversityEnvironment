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
            migrationBuilder.DropForeignKey(
                name: "FK_coursesadmins_Admins_AdminId",
                table: "coursesadmins");

            migrationBuilder.DropForeignKey(
                name: "FK_coursesstudents_Students_StudentId",
                table: "coursesstudents");

            migrationBuilder.DropForeignKey(
                name: "FK_coursesteachers_Teachers_TeacherId",
                table: "coursesteachers");

            migrationBuilder.RenameColumn(
                name: "TeacherId",
                table: "coursesteachers",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "coursesstudents",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "AdminId",
                table: "coursesadmins",
                newName: "UserId");

            migrationBuilder.AlterColumn<int>(
                name: "Role",
                table: "Teachers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "Role",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "Role",
                table: "Admins",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_coursesadmins_Admins_UserId",
                table: "coursesadmins",
                column: "UserId",
                principalTable: "Admins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_coursesstudents_Students_UserId",
                table: "coursesstudents",
                column: "UserId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_coursesteachers_Teachers_UserId",
                table: "coursesteachers",
                column: "UserId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_coursesadmins_Admins_UserId",
                table: "coursesadmins");

            migrationBuilder.DropForeignKey(
                name: "FK_coursesstudents_Students_UserId",
                table: "coursesstudents");

            migrationBuilder.DropForeignKey(
                name: "FK_coursesteachers_Teachers_UserId",
                table: "coursesteachers");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "coursesteachers",
                newName: "TeacherId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "coursesstudents",
                newName: "StudentId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "coursesadmins",
                newName: "AdminId");

            migrationBuilder.AlterColumn<string>(
                name: "Role",
                table: "Teachers",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Role",
                table: "Students",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Role",
                table: "Admins",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_coursesadmins_Admins_AdminId",
                table: "coursesadmins",
                column: "AdminId",
                principalTable: "Admins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_coursesstudents_Students_StudentId",
                table: "coursesstudents",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_coursesteachers_Teachers_TeacherId",
                table: "coursesteachers",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
