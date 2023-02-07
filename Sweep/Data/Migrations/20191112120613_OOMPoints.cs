using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GolfSweep.Data.Migrations
{
    public partial class OOMPoints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OOMPoints",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTimeOffset>(nullable: false),
                    SweepId = table.Column<Guid>(nullable: true),
                    Points = table.Column<int>(nullable: false),
                    Position = table.Column<int>(nullable: false),
                    PlayerId = table.Column<Guid>(nullable: true),
                    CardId = table.Column<Guid>(nullable: true),
                    EventId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OOMPoints", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OOMPoints_ScoreCards_CardId",
                        column: x => x.CardId,
                        principalTable: "ScoreCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OOMPoints_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OOMPoints_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OOMPoints_Sweeps_SweepId",
                        column: x => x.SweepId,
                        principalTable: "Sweeps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OOMPoints_CardId",
                table: "OOMPoints",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_OOMPoints_EventId",
                table: "OOMPoints",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_OOMPoints_PlayerId",
                table: "OOMPoints",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_OOMPoints_SweepId",
                table: "OOMPoints",
                column: "SweepId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OOMPoints");
        }
    }
}
