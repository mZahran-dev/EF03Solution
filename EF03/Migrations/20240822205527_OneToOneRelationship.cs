using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF03.Migrations
{
    /// <inheritdoc />
    public partial class OneToOneRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_DepartmentID",
                table: "Instructors");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentID",
                table: "Instructors",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "InsID",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Departments_InsID",
                table: "Departments",
                column: "InsID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructors_InsID",
                table: "Departments",
                column: "InsID",
                principalTable: "Instructors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_DepartmentID",
                table: "Instructors",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructors_InsID",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_DepartmentID",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Departments_InsID",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "InsID",
                table: "Departments");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentID",
                table: "Instructors",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_DepartmentID",
                table: "Instructors",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
