using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GolfSweep.Data.Migrations
{
    public partial class removeCardsFromEvent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ScoreCards_Events_EventId",
                table: "ScoreCards");

            migrationBuilder.DropIndex(
                name: "IX_ScoreCards_EventId",
                table: "ScoreCards");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "ScoreCards");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "EventId",
                table: "ScoreCards",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ScoreCards_EventId",
                table: "ScoreCards",
                column: "EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_ScoreCards_Events_EventId",
                table: "ScoreCards",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
