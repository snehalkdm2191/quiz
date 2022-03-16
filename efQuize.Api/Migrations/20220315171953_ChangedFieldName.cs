using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace efQuize.Api.Migrations
{
    public partial class ChangedFieldName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Questions_QuestionId",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Genre_GenreId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_GenreId",
                table: "Questions");

            migrationBuilder.RenameColumn(
                name: "QuestionId",
                table: "Answers",
                newName: "QuestionsId");

            migrationBuilder.RenameIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                newName: "IX_Answers_QuestionsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Questions_QuestionsId",
                table: "Answers",
                column: "QuestionsId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Questions_QuestionsId",
                table: "Answers");

            migrationBuilder.RenameColumn(
                name: "QuestionsId",
                table: "Answers",
                newName: "QuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_Answers_QuestionsId",
                table: "Answers",
                newName: "IX_Answers_QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_GenreId",
                table: "Questions",
                column: "GenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Questions_QuestionId",
                table: "Answers",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Genre_GenreId",
                table: "Questions",
                column: "GenreId",
                principalTable: "Genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
