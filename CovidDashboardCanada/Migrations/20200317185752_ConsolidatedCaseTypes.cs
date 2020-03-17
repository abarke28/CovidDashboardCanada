using Microsoft.EntityFrameworkCore.Migrations;

namespace CovidDashboardCanada.Migrations
{
    public partial class ConsolidatedCaseTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DailyCaseRecord",
                table: "DailyCaseRecord");

            migrationBuilder.RenameTable(
                name: "DailyCaseRecord",
                newName: "Recordset");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Recordset",
                table: "Recordset",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Recordset",
                table: "Recordset");

            migrationBuilder.RenameTable(
                name: "Recordset",
                newName: "DailyCaseRecord");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DailyCaseRecord",
                table: "DailyCaseRecord",
                column: "ID");
        }
    }
}
