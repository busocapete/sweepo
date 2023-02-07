using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GolfSweep.Data.Migrations
{
    public partial class changeScorecard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ScoreCards_Holes_EighthId",
                table: "ScoreCards");

            migrationBuilder.DropForeignKey(
                name: "FK_ScoreCards_Holes_EithteenthId",
                table: "ScoreCards");

            migrationBuilder.DropForeignKey(
                name: "FK_ScoreCards_Holes_EleventhId",
                table: "ScoreCards");

            migrationBuilder.DropForeignKey(
                name: "FK_ScoreCards_Holes_FifteenthId",
                table: "ScoreCards");

            migrationBuilder.DropForeignKey(
                name: "FK_ScoreCards_Holes_FifthId",
                table: "ScoreCards");

            migrationBuilder.DropForeignKey(
                name: "FK_ScoreCards_Holes_FirstId",
                table: "ScoreCards");

            migrationBuilder.DropForeignKey(
                name: "FK_ScoreCards_Holes_FourteenthId",
                table: "ScoreCards");

            migrationBuilder.DropForeignKey(
                name: "FK_ScoreCards_Holes_FourthId",
                table: "ScoreCards");

            migrationBuilder.DropForeignKey(
                name: "FK_ScoreCards_Holes_NinthId",
                table: "ScoreCards");

            migrationBuilder.DropForeignKey(
                name: "FK_ScoreCards_Holes_SecondId",
                table: "ScoreCards");

            migrationBuilder.DropForeignKey(
                name: "FK_ScoreCards_Holes_SeventeenthId",
                table: "ScoreCards");

            migrationBuilder.DropForeignKey(
                name: "FK_ScoreCards_Holes_SeventhId",
                table: "ScoreCards");

            migrationBuilder.DropForeignKey(
                name: "FK_ScoreCards_Holes_SixteenthId",
                table: "ScoreCards");

            migrationBuilder.DropForeignKey(
                name: "FK_ScoreCards_Holes_SixthId",
                table: "ScoreCards");

            migrationBuilder.DropForeignKey(
                name: "FK_ScoreCards_Holes_TenthId",
                table: "ScoreCards");

            migrationBuilder.DropForeignKey(
                name: "FK_ScoreCards_Holes_ThirdId",
                table: "ScoreCards");

            migrationBuilder.DropForeignKey(
                name: "FK_ScoreCards_Holes_ThirteenthId",
                table: "ScoreCards");

            migrationBuilder.DropForeignKey(
                name: "FK_ScoreCards_Holes_TwelwthId",
                table: "ScoreCards");

            migrationBuilder.DropIndex(
                name: "IX_ScoreCards_EighthId",
                table: "ScoreCards");

            migrationBuilder.DropIndex(
                name: "IX_ScoreCards_EithteenthId",
                table: "ScoreCards");

            migrationBuilder.DropIndex(
                name: "IX_ScoreCards_EleventhId",
                table: "ScoreCards");

            migrationBuilder.DropIndex(
                name: "IX_ScoreCards_FifteenthId",
                table: "ScoreCards");

            migrationBuilder.DropIndex(
                name: "IX_ScoreCards_FifthId",
                table: "ScoreCards");

            migrationBuilder.DropIndex(
                name: "IX_ScoreCards_FirstId",
                table: "ScoreCards");

            migrationBuilder.DropIndex(
                name: "IX_ScoreCards_FourteenthId",
                table: "ScoreCards");

            migrationBuilder.DropIndex(
                name: "IX_ScoreCards_FourthId",
                table: "ScoreCards");

            migrationBuilder.DropIndex(
                name: "IX_ScoreCards_NinthId",
                table: "ScoreCards");

            migrationBuilder.DropIndex(
                name: "IX_ScoreCards_SecondId",
                table: "ScoreCards");

            migrationBuilder.DropIndex(
                name: "IX_ScoreCards_SeventeenthId",
                table: "ScoreCards");

            migrationBuilder.DropIndex(
                name: "IX_ScoreCards_SeventhId",
                table: "ScoreCards");

            migrationBuilder.DropIndex(
                name: "IX_ScoreCards_SixteenthId",
                table: "ScoreCards");

            migrationBuilder.DropIndex(
                name: "IX_ScoreCards_SixthId",
                table: "ScoreCards");

            migrationBuilder.DropIndex(
                name: "IX_ScoreCards_TenthId",
                table: "ScoreCards");

            migrationBuilder.DropIndex(
                name: "IX_ScoreCards_ThirdId",
                table: "ScoreCards");

            migrationBuilder.DropIndex(
                name: "IX_ScoreCards_ThirteenthId",
                table: "ScoreCards");

            migrationBuilder.DropColumn(
                name: "EighthId",
                table: "ScoreCards");

            migrationBuilder.DropColumn(
                name: "EithteenthId",
                table: "ScoreCards");

            migrationBuilder.DropColumn(
                name: "EleventhId",
                table: "ScoreCards");

            migrationBuilder.DropColumn(
                name: "FifteenthId",
                table: "ScoreCards");

            migrationBuilder.DropColumn(
                name: "FifthId",
                table: "ScoreCards");

            migrationBuilder.DropColumn(
                name: "FirstId",
                table: "ScoreCards");

            migrationBuilder.DropColumn(
                name: "FourteenthId",
                table: "ScoreCards");

            migrationBuilder.DropColumn(
                name: "FourthId",
                table: "ScoreCards");

            migrationBuilder.DropColumn(
                name: "NinthId",
                table: "ScoreCards");

            migrationBuilder.DropColumn(
                name: "SecondId",
                table: "ScoreCards");

            migrationBuilder.DropColumn(
                name: "SeventeenthId",
                table: "ScoreCards");

            migrationBuilder.DropColumn(
                name: "SeventhId",
                table: "ScoreCards");

            migrationBuilder.DropColumn(
                name: "SixteenthId",
                table: "ScoreCards");

            migrationBuilder.DropColumn(
                name: "SixthId",
                table: "ScoreCards");

            migrationBuilder.DropColumn(
                name: "TenthId",
                table: "ScoreCards");

            migrationBuilder.DropColumn(
                name: "ThirdId",
                table: "ScoreCards");

            migrationBuilder.DropColumn(
                name: "ThirteenthId",
                table: "ScoreCards");

            migrationBuilder.RenameColumn(
                name: "TwelwthId",
                table: "ScoreCards",
                newName: "CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_ScoreCards_TwelwthId",
                table: "ScoreCards",
                newName: "IX_ScoreCards_CourseId");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "Created",
                table: "ScoreCards",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

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

            migrationBuilder.AddForeignKey(
                name: "FK_ScoreCards_Courses_CourseId",
                table: "ScoreCards",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ScoreCards_Courses_CourseId",
                table: "ScoreCards");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "ScoreCards");

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

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "ScoreCards",
                newName: "TwelwthId");

            migrationBuilder.RenameIndex(
                name: "IX_ScoreCards_CourseId",
                table: "ScoreCards",
                newName: "IX_ScoreCards_TwelwthId");

            migrationBuilder.AddColumn<Guid>(
                name: "EighthId",
                table: "ScoreCards",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "EithteenthId",
                table: "ScoreCards",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "EleventhId",
                table: "ScoreCards",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "FifteenthId",
                table: "ScoreCards",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "FifthId",
                table: "ScoreCards",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "FirstId",
                table: "ScoreCards",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "FourteenthId",
                table: "ScoreCards",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "FourthId",
                table: "ScoreCards",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "NinthId",
                table: "ScoreCards",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SecondId",
                table: "ScoreCards",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SeventeenthId",
                table: "ScoreCards",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SeventhId",
                table: "ScoreCards",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SixteenthId",
                table: "ScoreCards",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SixthId",
                table: "ScoreCards",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TenthId",
                table: "ScoreCards",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ThirdId",
                table: "ScoreCards",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ThirteenthId",
                table: "ScoreCards",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ScoreCards_EighthId",
                table: "ScoreCards",
                column: "EighthId");

            migrationBuilder.CreateIndex(
                name: "IX_ScoreCards_EithteenthId",
                table: "ScoreCards",
                column: "EithteenthId");

            migrationBuilder.CreateIndex(
                name: "IX_ScoreCards_EleventhId",
                table: "ScoreCards",
                column: "EleventhId");

            migrationBuilder.CreateIndex(
                name: "IX_ScoreCards_FifteenthId",
                table: "ScoreCards",
                column: "FifteenthId");

            migrationBuilder.CreateIndex(
                name: "IX_ScoreCards_FifthId",
                table: "ScoreCards",
                column: "FifthId");

            migrationBuilder.CreateIndex(
                name: "IX_ScoreCards_FirstId",
                table: "ScoreCards",
                column: "FirstId");

            migrationBuilder.CreateIndex(
                name: "IX_ScoreCards_FourteenthId",
                table: "ScoreCards",
                column: "FourteenthId");

            migrationBuilder.CreateIndex(
                name: "IX_ScoreCards_FourthId",
                table: "ScoreCards",
                column: "FourthId");

            migrationBuilder.CreateIndex(
                name: "IX_ScoreCards_NinthId",
                table: "ScoreCards",
                column: "NinthId");

            migrationBuilder.CreateIndex(
                name: "IX_ScoreCards_SecondId",
                table: "ScoreCards",
                column: "SecondId");

            migrationBuilder.CreateIndex(
                name: "IX_ScoreCards_SeventeenthId",
                table: "ScoreCards",
                column: "SeventeenthId");

            migrationBuilder.CreateIndex(
                name: "IX_ScoreCards_SeventhId",
                table: "ScoreCards",
                column: "SeventhId");

            migrationBuilder.CreateIndex(
                name: "IX_ScoreCards_SixteenthId",
                table: "ScoreCards",
                column: "SixteenthId");

            migrationBuilder.CreateIndex(
                name: "IX_ScoreCards_SixthId",
                table: "ScoreCards",
                column: "SixthId");

            migrationBuilder.CreateIndex(
                name: "IX_ScoreCards_TenthId",
                table: "ScoreCards",
                column: "TenthId");

            migrationBuilder.CreateIndex(
                name: "IX_ScoreCards_ThirdId",
                table: "ScoreCards",
                column: "ThirdId");

            migrationBuilder.CreateIndex(
                name: "IX_ScoreCards_ThirteenthId",
                table: "ScoreCards",
                column: "ThirteenthId");

            migrationBuilder.AddForeignKey(
                name: "FK_ScoreCards_Holes_EighthId",
                table: "ScoreCards",
                column: "EighthId",
                principalTable: "Holes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ScoreCards_Holes_EithteenthId",
                table: "ScoreCards",
                column: "EithteenthId",
                principalTable: "Holes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ScoreCards_Holes_EleventhId",
                table: "ScoreCards",
                column: "EleventhId",
                principalTable: "Holes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ScoreCards_Holes_FifteenthId",
                table: "ScoreCards",
                column: "FifteenthId",
                principalTable: "Holes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ScoreCards_Holes_FifthId",
                table: "ScoreCards",
                column: "FifthId",
                principalTable: "Holes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ScoreCards_Holes_FirstId",
                table: "ScoreCards",
                column: "FirstId",
                principalTable: "Holes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ScoreCards_Holes_FourteenthId",
                table: "ScoreCards",
                column: "FourteenthId",
                principalTable: "Holes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ScoreCards_Holes_FourthId",
                table: "ScoreCards",
                column: "FourthId",
                principalTable: "Holes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ScoreCards_Holes_NinthId",
                table: "ScoreCards",
                column: "NinthId",
                principalTable: "Holes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ScoreCards_Holes_SecondId",
                table: "ScoreCards",
                column: "SecondId",
                principalTable: "Holes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ScoreCards_Holes_SeventeenthId",
                table: "ScoreCards",
                column: "SeventeenthId",
                principalTable: "Holes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ScoreCards_Holes_SeventhId",
                table: "ScoreCards",
                column: "SeventhId",
                principalTable: "Holes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ScoreCards_Holes_SixteenthId",
                table: "ScoreCards",
                column: "SixteenthId",
                principalTable: "Holes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ScoreCards_Holes_SixthId",
                table: "ScoreCards",
                column: "SixthId",
                principalTable: "Holes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ScoreCards_Holes_TenthId",
                table: "ScoreCards",
                column: "TenthId",
                principalTable: "Holes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ScoreCards_Holes_ThirdId",
                table: "ScoreCards",
                column: "ThirdId",
                principalTable: "Holes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ScoreCards_Holes_ThirteenthId",
                table: "ScoreCards",
                column: "ThirteenthId",
                principalTable: "Holes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ScoreCards_Holes_TwelwthId",
                table: "ScoreCards",
                column: "TwelwthId",
                principalTable: "Holes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
