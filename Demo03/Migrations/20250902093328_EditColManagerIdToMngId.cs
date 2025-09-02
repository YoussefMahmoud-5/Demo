using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo03.Migrations
{
    /// <inheritdoc />
    public partial class EditColManagerIdToMngId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Employees_ManagerEmpId",
                schema: "dbo",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_ManagerEmpId",
                schema: "dbo",
                table: "Departments");

            migrationBuilder.RenameColumn(
                name: "ManagerEmpId",
                schema: "dbo",
                table: "Departments",
                newName: "MngID");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_MngID",
                schema: "dbo",
                table: "Departments",
                column: "MngID",
                unique: true,
                filter: "[MngID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Employees_MngID",
                schema: "dbo",
                table: "Departments",
                column: "MngID",
                principalSchema: "dbo",
                principalTable: "Employees",
                principalColumn: "EmpId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Employees_MngID",
                schema: "dbo",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_MngID",
                schema: "dbo",
                table: "Departments");

            migrationBuilder.RenameColumn(
                name: "MngID",
                schema: "dbo",
                table: "Departments",
                newName: "ManagerEmpId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_ManagerEmpId",
                schema: "dbo",
                table: "Departments",
                column: "ManagerEmpId",
                unique: true,
                filter: "[ManagerEmpId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Employees_ManagerEmpId",
                schema: "dbo",
                table: "Departments",
                column: "ManagerEmpId",
                principalSchema: "dbo",
                principalTable: "Employees",
                principalColumn: "EmpId");
        }
    }
}
