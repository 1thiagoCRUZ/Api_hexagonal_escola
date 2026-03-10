using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Escola.Migrations
{
    /// <inheritdoc />
    public partial class alternametables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Course_IdCourse",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course",
                table: "Course");

            migrationBuilder.RenameTable(
                name: "Student",
                newName: "student");

            migrationBuilder.RenameTable(
                name: "Course",
                newName: "course");

            migrationBuilder.RenameIndex(
                name: "IX_Student_IdCourse",
                table: "student",
                newName: "IX_student_IdCourse");

            migrationBuilder.AddPrimaryKey(
                name: "PK_student",
                table: "student",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_course",
                table: "course",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_student_course_IdCourse",
                table: "student",
                column: "IdCourse",
                principalTable: "course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_student_course_IdCourse",
                table: "student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_student",
                table: "student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_course",
                table: "course");

            migrationBuilder.RenameTable(
                name: "student",
                newName: "Student");

            migrationBuilder.RenameTable(
                name: "course",
                newName: "Course");

            migrationBuilder.RenameIndex(
                name: "IX_student_IdCourse",
                table: "Student",
                newName: "IX_Student_IdCourse");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                table: "Student",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course",
                table: "Course",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Course_IdCourse",
                table: "Student",
                column: "IdCourse",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
