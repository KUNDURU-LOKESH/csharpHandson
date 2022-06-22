using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework.Data.Migrations
{
    public partial class InitialMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeEducations_Employees_EmployeeID",
                table: "EmployeeEducations");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeEducations_EmployeeID",
                table: "EmployeeEducations");

            migrationBuilder.DropColumn(
                name: "EmployeeID",
                table: "EmployeeEducations");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployeeID",
                table: "EmployeeEducations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeEducations_EmployeeID",
                table: "EmployeeEducations",
                column: "EmployeeID");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeEducations_Employees_EmployeeID",
                table: "EmployeeEducations",
                column: "EmployeeID",
                principalTable: "Employees",
                principalColumn: "ID");
        }
    }
}
