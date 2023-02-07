using Microsoft.EntityFrameworkCore.Migrations;

namespace GolfSweep.Data.Migrations
{
    public partial class EntryGroupInt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Group",
                table: "Entries",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Group",
                table: "Entries",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
