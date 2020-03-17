using Microsoft.EntityFrameworkCore.Migrations;

namespace CovidDashboardCanada.Migrations
{
    public partial class AddedXAndY : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "xPosition",
                table: "Recordset",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "yPosition",
                table: "Recordset",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "xPosition",
                table: "Recordset");

            migrationBuilder.DropColumn(
                name: "yPosition",
                table: "Recordset");
        }
    }
}
