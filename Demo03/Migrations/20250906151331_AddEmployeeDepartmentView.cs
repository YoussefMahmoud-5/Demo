using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo03.Migrations
{
    /// <inheritdoc />
    public partial class AddEmployeeDepartmentView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                                    CREATE VIEW dbo.EmployeeDepartmentView
                                    WITH SCHEMABINDING, ENCRYPTION
                                    AS
                                        SELECT 
                                            E.EmpId      AS EmployeeId,
                                            E.EmpName    AS EmployeeName,
                                            D.DeptId     AS DepartmentId,
                                            D.Name       AS DepartmentName
                                        FROM dbo.Employees E, dbo.Departments D 
                                        where D.DeptId = E.DepartmentId
                                ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Drop view EmployeeDepartmentView");
        }
    }
}
