using Microsoft.EntityFrameworkCore.Migrations;

namespace CovidDashboardCanada.Migrations
{
    public partial class AddedLatitudeAndLongtitude : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Latitude",
                table: "Recordset",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Longtitude",
                table: "Recordset",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Recordset");

            migrationBuilder.DropColumn(
                name: "Longtitude",
                table: "Recordset");
        }
    }
}
