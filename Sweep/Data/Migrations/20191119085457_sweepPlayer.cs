using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GolfSweep.Data.Migrations
{
    public partial class sweepPlayer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Public",
                table: "Sweeps",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "SweepPlayers",
                columns: table => new
                {
                    SweepId = table.Column<Guid>(nullable: false),
                    PlayerId = table.Column<Guid>(nullable: false),
                    Approved = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SweepPlayers", x => new { x.SweepId, x.PlayerId });
                    table.ForeignKey(
                        name: "FK_SweepPlayers_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SweepPlayers_Sweeps_SweepId",
                        column: x => x.SweepId,
                        principalTable: "Sweeps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SweepPlayers_PlayerId",
                table: "SweepPlayers",
                column: "PlayerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SweepPlayers");

            migrationBuilder.DropColumn(
                name: "Public",
                table: "Sweeps");
        }
    }
}
