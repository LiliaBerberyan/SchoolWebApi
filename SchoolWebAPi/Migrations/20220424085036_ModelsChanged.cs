using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolWebAPi.Migrations
{
    public partial class ModelsChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Subject_Students_StudentId",
                table: "Student_Subject");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Subject_Subjects_SubjectId",
                table: "Student_Subject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Student_Subject",
                table: "Student_Subject");

            migrationBuilder.RenameTable(
                name: "Student_Subject",
                newName: "Student_Subjects");

            migrationBuilder.RenameIndex(
                name: "IX_Student_Subject_SubjectId",
                table: "Student_Subjects",
                newName: "IX_Student_Subjects_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Student_Subject_StudentId",
                table: "Student_Subjects",
                newName: "IX_Student_Subjects_StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student_Subjects",
                table: "Student_Subjects",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Subjects_Students_StudentId",
                table: "Student_Subjects",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Subjects_Subjects_SubjectId",
                table: "Student_Subjects",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Subjects_Students_StudentId",
                table: "Student_Subjects");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Subjects_Subjects_SubjectId",
                table: "Student_Subjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Student_Subjects",
                table: "Student_Subjects");

            migrationBuilder.RenameTable(
                name: "Student_Subjects",
                newName: "Student_Subject");

            migrationBuilder.RenameIndex(
                name: "IX_Student_Subjects_SubjectId",
                table: "Student_Subject",
                newName: "IX_Student_Subject_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Student_Subjects_StudentId",
                table: "Student_Subject",
                newName: "IX_Student_Subject_StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student_Subject",
                table: "Student_Subject",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Subject_Students_StudentId",
                table: "Student_Subject",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Subject_Subjects_SubjectId",
                table: "Student_Subject",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
