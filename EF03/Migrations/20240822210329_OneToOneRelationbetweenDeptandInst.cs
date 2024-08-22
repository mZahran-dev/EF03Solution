using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF03.Migrations
{
    /// <inheritdoc />
    public partial class OneToOneRelationbetweenDeptandInst : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_DepartmentID",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_DepartmentID",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "DepartmentID",
                table: "Instructors");

            migrationBuilder.AddColumn<int>(
                name: "DeptID",
                table: "Instructors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_DeptID",
                table: "Instructors",
                column: "DeptID");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_DeptID",
                table: "Instructors",
                column: "DeptID",
                principalTable: "Departments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_DeptID",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_DeptID",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "DeptID",
                table: "Instructors");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentID",
                table: "Instructors",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_DepartmentID",
                table: "Instructors",
                column: "DepartmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_DepartmentID",
                table: "Instructors",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "ID");
        }
    }
}
