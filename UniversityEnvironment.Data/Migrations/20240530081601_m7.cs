using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityEnvironment.Data.Migrations
{
    /// <inheritdoc />
    public partial class m7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentMessage_Students_StudentId",
                table: "StudentMessage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentMessage",
                table: "StudentMessage");

            migrationBuilder.RenameTable(
                name: "StudentMessage",
                newName: "StudentMessages");

            migrationBuilder.RenameIndex(
                name: "IX_StudentMessage_StudentId",
                table: "StudentMessages",
                newName: "IX_StudentMessages_StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentMessages",
                table: "StudentMessages",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentMessages_Students_StudentId",
                table: "StudentMessages",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentMessages_Students_StudentId",
                table: "StudentMessages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentMessages",
                table: "StudentMessages");

            migrationBuilder.RenameTable(
                name: "StudentMessages",
                newName: "StudentMessage");

            migrationBuilder.RenameIndex(
                name: "IX_StudentMessages_StudentId",
                table: "StudentMessage",
                newName: "IX_StudentMessage_StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentMessage",
                table: "StudentMessage",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentMessage_Students_StudentId",
                table: "StudentMessage",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
