using Microsoft.EntityFrameworkCore.Migrations;

namespace CovidDashboardCanada.Migrations
{
    public partial class FixedColoumnNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "yPosition",
                table: "Recordset",
                newName: "YPosition");

            migrationBuilder.RenameColumn(
                name: "xPosition",
                table: "Recordset",
                newName: "XPosition");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "YPosition",
                table: "Recordset",
                newName: "yPosition");

            migrationBuilder.RenameColumn(
                name: "XPosition",
                table: "Recordset",
                newName: "xPosition");
        }
    }
}
