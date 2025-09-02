using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo03.Migrations
{
    /// <inheritdoc />
    public partial class ModifyManagerRelationShip : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Departments_ManagerEmpId",
                schema: "dbo",
                table: "Departments");

            migrationBuilder.AlterColumn<int>(
                name: "ManagerEmpId",
                schema: "dbo",
                table: "Departments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "DateOfCreation",
                schema: "dbo",
                table: "Departments",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldComputedColumnSql: "GetDate()");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_ManagerEmpId",
                schema: "dbo",
                table: "Departments",
                column: "ManagerEmpId",
                unique: true,
                filter: "[ManagerEmpId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Departments_ManagerEmpId",
                schema: "dbo",
                table: "Departments");

            migrationBuilder.AlterColumn<int>(
                name: "ManagerEmpId",
                schema: "dbo",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "DateOfCreation",
                schema: "dbo",
                table: "Departments",
                type: "date",
                nullable: false,
                computedColumnSql: "GetDate()",
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_ManagerEmpId",
                schema: "dbo",
                table: "Departments",
                column: "ManagerEmpId",
                unique: true);
        }
    }
}
