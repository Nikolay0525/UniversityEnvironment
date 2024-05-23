using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityEnvironment.Data.Migrations
{
    /// <inheritdoc />
    public partial class m4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionAnswers_TestQuestions_QuestionId",
                table: "QuestionAnswers");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_QuestionAnswers_QuestionAnswerId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_QuestionAnswerId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_QuestionAnswers_QuestionId",
                table: "QuestionAnswers");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "TestQuestions");

            migrationBuilder.DropColumn(
                name: "QuestionAnswerId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "QuestionId",
                table: "QuestionAnswers");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "TestQuestions",
                newName: "QuestionText");

            migrationBuilder.AddColumn<Guid>(
                name: "TestQuestionId",
                table: "QuestionAnswers",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionAnswers_TestQuestionId",
                table: "QuestionAnswers",
                column: "TestQuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionAnswers_TestQuestions_TestQuestionId",
                table: "QuestionAnswers",
                column: "TestQuestionId",
                principalTable: "TestQuestions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionAnswers_TestQuestions_TestQuestionId",
                table: "QuestionAnswers");

            migrationBuilder.DropIndex(
                name: "IX_QuestionAnswers_TestQuestionId",
                table: "QuestionAnswers");

            migrationBuilder.DropColumn(
                name: "TestQuestionId",
                table: "QuestionAnswers");

            migrationBuilder.RenameColumn(
                name: "QuestionText",
                table: "TestQuestions",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "TestQuestions",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<Guid>(
                name: "QuestionAnswerId",
                table: "Students",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<Guid>(
                name: "QuestionId",
                table: "QuestionAnswers",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.CreateIndex(
                name: "IX_Students_QuestionAnswerId",
                table: "Students",
                column: "QuestionAnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionAnswers_QuestionId",
                table: "QuestionAnswers",
                column: "QuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionAnswers_TestQuestions_QuestionId",
                table: "QuestionAnswers",
                column: "QuestionId",
                principalTable: "TestQuestions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_QuestionAnswers_QuestionAnswerId",
                table: "Students",
                column: "QuestionAnswerId",
                principalTable: "QuestionAnswers",
                principalColumn: "Id");
        }
    }
}
