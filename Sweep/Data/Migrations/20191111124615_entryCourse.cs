using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GolfSweep.Data.Migrations
{
    public partial class entryCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CourseId",
                table: "Events",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Events_CourseId",
                table: "Events",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Courses_CourseId",
                table: "Events",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Courses_CourseId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_CourseId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Events");
        }
    }
}
