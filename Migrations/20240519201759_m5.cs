using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityEnvironment.Data.Migrations
{
    /// <inheritdoc />
    public partial class m5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tests_Courses_CourseId",
                table: "Tests");

            migrationBuilder.DropTable(
                name: "TestMarks");

            migrationBuilder.AddColumn<int>(
                name: "Mark",
                table: "testsstudents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<Guid>(
                name: "CourseId",
                table: "Tests",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci",
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldNullable: true)
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_Courses_CourseId",
                table: "Tests",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tests_Courses_CourseId",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "Mark",
                table: "testsstudents");

            migrationBuilder.AlterColumn<Guid>(
                name: "CourseId",
                table: "Tests",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci",
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.CreateTable(
                name: "TestMarks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    TestId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    Mark = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestMarks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TestMarks_Tests_TestId",
                        column: x => x.TestId,
                        principalTable: "Tests",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_TestMarks_TestId",
                table: "TestMarks",
                column: "TestId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_Courses_CourseId",
                table: "Tests",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id");
        }
    }
}
