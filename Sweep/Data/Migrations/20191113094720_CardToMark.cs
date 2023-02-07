using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GolfSweep.Data.Migrations
{
    public partial class CardToMark : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "MarkerId",
                table: "Entries",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Entries_MarkerId",
                table: "Entries",
                column: "MarkerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Entries_ScoreCards_MarkerId",
                table: "Entries",
                column: "MarkerId",
                principalTable: "ScoreCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entries_ScoreCards_MarkerId",
                table: "Entries");

            migrationBuilder.DropIndex(
                name: "IX_Entries_MarkerId",
                table: "Entries");

            migrationBuilder.DropColumn(
                name: "MarkerId",
                table: "Entries");
        }
    }
}
