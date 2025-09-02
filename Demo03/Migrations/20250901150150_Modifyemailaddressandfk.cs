using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo03.Migrations
{
    /// <inheritdoc />
    public partial class Modifyemailaddressandfk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmentDeptId",
                schema: "dbo",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "Email",
                schema: "dbo",
                table: "Employees",
                newName: "EmailAddress");

            migrationBuilder.RenameColumn(
                name: "DepartmentDeptId",
                schema: "dbo",
                table: "Employees",
                newName: "FKDepartmentDeptId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_DepartmentDeptId",
                schema: "dbo",
                table: "Employees",
                newName: "IX_Employees_FKDepartmentDeptId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_FKDepartmentDeptId",
                schema: "dbo",
                table: "Employees",
                column: "FKDepartmentDeptId",
                principalSchema: "dbo",
                principalTable: "Departments",
                principalColumn: "DeptId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_FKDepartmentDeptId",
                schema: "dbo",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "FKDepartmentDeptId",
                schema: "dbo",
                table: "Employees",
                newName: "DepartmentDeptId");

            migrationBuilder.RenameColumn(
                name: "EmailAddress",
                schema: "dbo",
                table: "Employees",
                newName: "Email");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_FKDepartmentDeptId",
                schema: "dbo",
                table: "Employees",
                newName: "IX_Employees_DepartmentDeptId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DepartmentDeptId",
                schema: "dbo",
                table: "Employees",
                column: "DepartmentDeptId",
                principalSchema: "dbo",
                principalTable: "Departments",
                principalColumn: "DeptId");
        }
    }
}
