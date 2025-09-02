using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Demo03.Migrations
{
    /// <inheritdoc />
    public partial class EditAddressColNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Departments",
                keyColumn: "DeptId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Departments",
                keyColumn: "DeptId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Departments",
                keyColumn: "DeptId",
                keyValue: 8);

            migrationBuilder.RenameColumn(
                name: "EmpAddress_Street",
                schema: "dbo",
                table: "Employees",
                newName: "Street");

            migrationBuilder.RenameColumn(
                name: "EmpAddress_Country",
                schema: "dbo",
                table: "Employees",
                newName: "Country");

            migrationBuilder.RenameColumn(
                name: "EmpAddress_City",
                schema: "dbo",
                table: "Employees",
                newName: "City");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Street",
                schema: "dbo",
                table: "Employees",
                newName: "EmpAddress_Street");

            migrationBuilder.RenameColumn(
                name: "Country",
                schema: "dbo",
                table: "Employees",
                newName: "EmpAddress_Country");

            migrationBuilder.RenameColumn(
                name: "City",
                schema: "dbo",
                table: "Employees",
                newName: "EmpAddress_City");

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Departments",
                columns: new[] { "DeptId", "Code", "DateOfCreation", "Name", "ManagerEmpId" },
                values: new object[,]
                {
                    { 6, 99, new DateOnly(2021, 3, 19), "Sales", null },
                    { 7, 100, new DateOnly(2023, 7, 1), "Software Engineering", null },
                    { 8, 105, new DateOnly(2024, 12, 25), "Markting", null }
                });
        }
    }
}
