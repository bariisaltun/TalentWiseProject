using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WiseProject.Data.Migrations
{
    public partial class duedate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EnrollmentDate",
                table: "Assignments",
                newName: "DueDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DueDate",
                table: "Assignments",
                newName: "EnrollmentDate");
        }
    }
}
