using Microsoft.EntityFrameworkCore.Migrations;

namespace GolfSweep.Data.Migrations
{
    public partial class removeScoreFromHoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Points",
                table: "Holes");

            migrationBuilder.DropColumn(
                name: "Score",
                table: "Holes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Points",
                table: "Holes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Score",
                table: "Holes",
                nullable: false,
                defaultValue: 0);
        }
    }
}
