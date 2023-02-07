using Microsoft.EntityFrameworkCore.Migrations;

namespace GolfSweep.Data.Migrations
{
    public partial class EventHanciapOnScoreCard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EventHandicap",
                table: "Entries");

            migrationBuilder.AddColumn<int>(
                name: "EventHandicap",
                table: "ScoreCards",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EventHandicap",
                table: "ScoreCards");

            migrationBuilder.AddColumn<int>(
                name: "EventHandicap",
                table: "Entries",
                nullable: false,
                defaultValue: 0);
        }
    }
}
