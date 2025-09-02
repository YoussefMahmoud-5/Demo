using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Demo03.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDepartmentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
