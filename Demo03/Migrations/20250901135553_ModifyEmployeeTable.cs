using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo03.Migrations
{
    /// <inheritdoc />
    public partial class ModifyEmployeeTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                schema: "dbo",
                table: "Employees",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "dbo",
                table: "Employees",
                newName: "EmpId");

            migrationBuilder.AlterColumn<decimal>(
                name: "Salary",
                schema: "dbo",
                table: "Employees",
                type: "money",
                nullable: false,
                defaultValue: 4000m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 4000m);

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                schema: "dbo",
                table: "Employees",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                schema: "dbo",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmpName",
                schema: "dbo",
                table: "Employees",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                schema: "dbo",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                schema: "dbo",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmpName",
                schema: "dbo",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                schema: "dbo",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "Password",
                schema: "dbo",
                table: "Employees",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "EmpId",
                schema: "dbo",
                table: "Employees",
                newName: "Id");

            migrationBuilder.AlterColumn<decimal>(
                name: "Salary",
                schema: "dbo",
                table: "Employees",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 4000m,
                oldClrType: typeof(decimal),
                oldType: "money",
                oldDefaultValue: 4000m);

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                schema: "dbo",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
