using Microsoft.EntityFrameworkCore.Migrations;

namespace educationPortal.Migrations
{
    public partial class CourseContentIdToCourses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseContentId",
                table: "Courses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CourseContentId",
                table: "Courses",
                column: "CourseContentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_CourseContents_CourseContentId",
                table: "Courses",
                column: "CourseContentId",
                principalTable: "CourseContents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_CourseContents_CourseContentId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_CourseContentId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseContentId",
                table: "Courses");
        }
    }
}
