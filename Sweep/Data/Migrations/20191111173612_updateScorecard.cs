using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GolfSweep.Data.Migrations
{
    public partial class updateScorecard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Eighth",
                table: "ScoreCards");

            migrationBuilder.DropColumn(
                name: "Eithteenth",
                table: "ScoreCards");

            migrationBuilder.DropColumn(
                name: "Eleventh",
                table: "ScoreCards");

            migrationBuilder.DropColumn(
                name: "Fifteenth",
                table: "ScoreCards");

            migrationBuilder.DropColumn(
                name: "Fifth",
                table: "ScoreCards");

            migrationBuilder.DropColumn(
                name: "First",
                table: "ScoreCards");

            migrationBuilder.DropColumn(
                name: "Fourteenth",
                table: "ScoreCards");

            migrationBuilder.DropColumn(
                name: "Fourth",
                table: "ScoreCards");

            migrationBuilder.DropColumn(
                name: "Ninth",
                table: "ScoreCards");

            migrationBuilder.DropColumn(
                name: "Second",
                table: "ScoreCards");

            migrationBuilder.DropColumn(
                name: "Seventeenth",
                table: "ScoreCards");

            migrationBuilder.DropColumn(
                name: "Seventh",
                table: "ScoreCards");

            migrationBuilder.DropColumn(
                name: "Sixteenth",
                table: "ScoreCards");

            migrationBuilder.DropColumn(
                name: "Sixth",
                table: "ScoreCards");

            migrationBuilder.DropColumn(
                name: "Tenth",
                table: "ScoreCards");

            migrationBuilder.DropColumn(
                name: "Third",
                table: "ScoreCards");

            migrationBuilder.DropColumn(
                name: "Thirteenth",
                table: "ScoreCards");

            migrationBuilder.DropColumn(
                name: "Twelwth",
                table: "ScoreCards");

            migrationBuilder.CreateTable(
                name: "Score",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTimeOffset>(nullable: false),
                    Gross = table.Column<int>(nullable: false),
                    Nett = table.Column<int>(nullable: false),
                    Points = table.Column<int>(nullable: false),
                    HoleNumber = table.Column<int>(nullable: false),
                    ScoreCardId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Score", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Score_ScoreCards_ScoreCardId",
                        column: x => x.ScoreCardId,
                        principalTable: "ScoreCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Score_ScoreCardId",
                table: "Score",
                column: "ScoreCardId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Score");

            migrationBuilder.AddColumn<int>(
                name: "Eighth",
                table: "ScoreCards",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Eithteenth",
                table: "ScoreCards",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Eleventh",
                table: "ScoreCards",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Fifteenth",
                table: "ScoreCards",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Fifth",
                table: "ScoreCards",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "First",
                table: "ScoreCards",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Fourteenth",
                table: "ScoreCards",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Fourth",
                table: "ScoreCards",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Ninth",
                table: "ScoreCards",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Second",
                table: "ScoreCards",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Seventeenth",
                table: "ScoreCards",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Seventh",
                table: "ScoreCards",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Sixteenth",
                table: "ScoreCards",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Sixth",
                table: "ScoreCards",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Tenth",
                table: "ScoreCards",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Third",
                table: "ScoreCards",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Thirteenth",
                table: "ScoreCards",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Twelwth",
                table: "ScoreCards",
                nullable: false,
                defaultValue: 0);
        }
    }
}
