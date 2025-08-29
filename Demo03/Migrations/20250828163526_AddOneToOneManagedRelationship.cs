using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo03.Migrations
{
    /// <inheritdoc />
    public partial class AddOneToOneManagedRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ManagerEmpId",
                schema: "dbo",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Departments_ManagerEmpId",
                schema: "dbo",
                table: "Departments",
                column: "ManagerEmpId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Employees_ManagerEmpId",
                schema: "dbo",
                table: "Departments",
                column: "ManagerEmpId",
                principalSchema: "dbo",
                principalTable: "Employees",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Employees_ManagerEmpId",
                schema: "dbo",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_ManagerEmpId",
                schema: "dbo",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "ManagerEmpId",
                schema: "dbo",
                table: "Departments");
        }
    }
}
