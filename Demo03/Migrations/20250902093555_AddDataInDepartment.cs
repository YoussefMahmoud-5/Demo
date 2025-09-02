using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Demo03.Migrations
{
    /// <inheritdoc />
    public partial class AddDataInDepartment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Departments",
                columns: new[] { "DeptId", "Code", "DateOfCreation", "Name", "MngID" },
                values: new object[,]
                {
                    { 1, 100, new DateOnly(2024, 4, 13), "Sales", null },
                    { 2, 101, new DateOnly(2020, 9, 15), "HR", null },
                    { 3, 102, new DateOnly(2025, 5, 30), "Marketing", null },
                    { 4, 103, new DateOnly(2019, 11, 1), "Software Eng.", null },
                    { 5, 104, new DateOnly(2020, 9, 15), "IT", null },
                    { 6, 105, new DateOnly(2025, 5, 30), "Teaching", null },
                    { 7, 106, new DateOnly(2019, 11, 1), "Engineering", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Departments",
                keyColumn: "DeptId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Departments",
                keyColumn: "DeptId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Departments",
                keyColumn: "DeptId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Departments",
                keyColumn: "DeptId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Departments",
                keyColumn: "DeptId",
                keyValue: 5);

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
        }
    }
}
