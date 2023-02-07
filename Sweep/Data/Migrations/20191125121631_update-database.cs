using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GolfSweep.Data.Migrations
{
    public partial class updatedatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "RulesId",
                table: "Sweeps",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Rules",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CutHandicaps = table.Column<bool>(nullable: false),
                    WinnerCut = table.Column<double>(nullable: false),
                    SecondCut = table.Column<double>(nullable: false),
                    ThirdCut = table.Column<double>(nullable: false),
                    MinPointsForCut = table.Column<int>(nullable: false),
                    OrderOfMerit = table.Column<bool>(nullable: false),
                    OOMEntriesScale = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rules", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sweeps_RulesId",
                table: "Sweeps",
                column: "RulesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sweeps_Rules_RulesId",
                table: "Sweeps",
                column: "RulesId",
                principalTable: "Rules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sweeps_Rules_RulesId",
                table: "Sweeps");

            migrationBuilder.DropTable(
                name: "Rules");

            migrationBuilder.DropIndex(
                name: "IX_Sweeps_RulesId",
                table: "Sweeps");

            migrationBuilder.DropColumn(
                name: "RulesId",
                table: "Sweeps");
        }
    }
}
