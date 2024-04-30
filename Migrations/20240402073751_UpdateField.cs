using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Crud_Sqlite.Migrations
{
    /// <inheritdoc />
    public partial class UpdateField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Employees",
                newName: "EmployeeName");

            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "Employees",
                newName: "EmployeeNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmployeeNumber",
                table: "Employees",
                newName: "MyProperty");

            migrationBuilder.RenameColumn(
                name: "EmployeeName",
                table: "Employees",
                newName: "Name");
        }
    }
}
