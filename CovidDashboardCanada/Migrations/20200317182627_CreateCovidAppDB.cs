using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CovidDashboardCanada.Migrations
{
    public partial class CreateCovidAppDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DailyCaseRecord",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateString = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    BC = table.Column<int>(nullable: false),
                    AB = table.Column<int>(nullable: false),
                    SK = table.Column<int>(nullable: false),
                    MB = table.Column<int>(nullable: false),
                    ON = table.Column<int>(nullable: false),
                    QC = table.Column<int>(nullable: false),
                    NB = table.Column<int>(nullable: false),
                    NS = table.Column<int>(nullable: false),
                    NF = table.Column<int>(nullable: false),
                    PEI = table.Column<int>(nullable: false),
                    NWT = table.Column<int>(nullable: false),
                    YK = table.Column<int>(nullable: false),
                    NV = table.Column<int>(nullable: false),
                    WS = table.Column<int>(nullable: false),
                    MT = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyCaseRecord", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DailyCaseRecord");
        }
    }
}
