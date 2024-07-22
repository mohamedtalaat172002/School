using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace School.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class StudentGradRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GradID",
                table: "students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_students_GradID",
                table: "students",
                column: "GradID");

            migrationBuilder.AddForeignKey(
                name: "FK_students_Grads_GradID",
                table: "students",
                column: "GradID",
                principalTable: "Grads",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_Grads_GradID",
                table: "students");

            migrationBuilder.DropIndex(
                name: "IX_students_GradID",
                table: "students");

            migrationBuilder.DropColumn(
                name: "GradID",
                table: "students");
        }
    }
}
