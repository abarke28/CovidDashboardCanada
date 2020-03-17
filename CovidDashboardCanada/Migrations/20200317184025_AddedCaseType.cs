using Microsoft.EntityFrameworkCore.Migrations;

namespace CovidDashboardCanada.Migrations
{
    public partial class AddedCaseType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CaseType",
                table: "DailyCaseRecord",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CaseType",
                table: "DailyCaseRecord");
        }
    }
}
