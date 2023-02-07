using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GolfSweep.Data.Migrations
{
    public partial class InitialClasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Holes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Number = table.Column<int>(nullable: false),
                    Index = table.Column<int>(nullable: false),
                    Par = table.Column<int>(nullable: false),
                    Score = table.Column<int>(nullable: false),
                    Points = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Holes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Players_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sweeps",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Created = table.Column<DateTimeOffset>(nullable: false),
                    OwnerId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sweeps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sweeps_AspNetUsers_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Handicaps",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Exact = table.Column<double>(nullable: false),
                    Playing = table.Column<int>(nullable: false),
                    Created = table.Column<DateTimeOffset>(nullable: false),
                    PlayerId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Handicaps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Handicaps_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Date = table.Column<DateTimeOffset>(nullable: false),
                    SweepId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_Sweeps_SweepId",
                        column: x => x.SweepId,
                        principalTable: "Sweeps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ScoreCards",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FirstId = table.Column<Guid>(nullable: true),
                    SecondId = table.Column<Guid>(nullable: true),
                    ThirdId = table.Column<Guid>(nullable: true),
                    FourthId = table.Column<Guid>(nullable: true),
                    FifthId = table.Column<Guid>(nullable: true),
                    SixthId = table.Column<Guid>(nullable: true),
                    SeventhId = table.Column<Guid>(nullable: true),
                    EighthId = table.Column<Guid>(nullable: true),
                    NinthId = table.Column<Guid>(nullable: true),
                    TenthId = table.Column<Guid>(nullable: true),
                    EleventhId = table.Column<Guid>(nullable: true),
                    TwelwthId = table.Column<Guid>(nullable: true),
                    ThirteenthId = table.Column<Guid>(nullable: true),
                    FourteenthId = table.Column<Guid>(nullable: true),
                    FifteenthId = table.Column<Guid>(nullable: true),
                    SixteenthId = table.Column<Guid>(nullable: true),
                    SeventeenthId = table.Column<Guid>(nullable: true),
                    EithteenthId = table.Column<Guid>(nullable: true),
                    PlayerId = table.Column<Guid>(nullable: false),
                    EventId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScoreCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScoreCards_Holes_EighthId",
                        column: x => x.EighthId,
                        principalTable: "Holes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ScoreCards_Holes_EithteenthId",
                        column: x => x.EithteenthId,
                        principalTable: "Holes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ScoreCards_Holes_EleventhId",
                        column: x => x.EleventhId,
                        principalTable: "Holes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ScoreCards_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ScoreCards_Holes_FifteenthId",
                        column: x => x.FifteenthId,
                        principalTable: "Holes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ScoreCards_Holes_FifthId",
                        column: x => x.FifthId,
                        principalTable: "Holes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ScoreCards_Holes_FirstId",
                        column: x => x.FirstId,
                        principalTable: "Holes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ScoreCards_Holes_FourteenthId",
                        column: x => x.FourteenthId,
                        principalTable: "Holes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ScoreCards_Holes_FourthId",
                        column: x => x.FourthId,
                        principalTable: "Holes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ScoreCards_Holes_NinthId",
                        column: x => x.NinthId,
                        principalTable: "Holes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ScoreCards_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ScoreCards_Holes_SecondId",
                        column: x => x.SecondId,
                        principalTable: "Holes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ScoreCards_Holes_SeventeenthId",
                        column: x => x.SeventeenthId,
                        principalTable: "Holes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ScoreCards_Holes_SeventhId",
                        column: x => x.SeventhId,
                        principalTable: "Holes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ScoreCards_Holes_SixteenthId",
                        column: x => x.SixteenthId,
                        principalTable: "Holes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ScoreCards_Holes_SixthId",
                        column: x => x.SixthId,
                        principalTable: "Holes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ScoreCards_Holes_TenthId",
                        column: x => x.TenthId,
                        principalTable: "Holes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ScoreCards_Holes_ThirdId",
                        column: x => x.ThirdId,
                        principalTable: "Holes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ScoreCards_Holes_ThirteenthId",
                        column: x => x.ThirteenthId,
                        principalTable: "Holes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ScoreCards_Holes_TwelwthId",
                        column: x => x.TwelwthId,
                        principalTable: "Holes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Entries",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ScoreCardId = table.Column<Guid>(nullable: true),
                    Paid = table.Column<bool>(nullable: false),
                    EventId = table.Column<Guid>(nullable: true),
                    PlayerId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entries_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Entries_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Entries_ScoreCards_ScoreCardId",
                        column: x => x.ScoreCardId,
                        principalTable: "ScoreCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Results",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    WinnerId = table.Column<Guid>(nullable: true),
                    SecondId = table.Column<Guid>(nullable: true),
                    ThirdId = table.Column<Guid>(nullable: true),
                    EventId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Results", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Results_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Results_ScoreCards_SecondId",
                        column: x => x.SecondId,
                        principalTable: "ScoreCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Results_ScoreCards_ThirdId",
                        column: x => x.ThirdId,
                        principalTable: "ScoreCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Results_ScoreCards_WinnerId",
                        column: x => x.WinnerId,
                        principalTable: "ScoreCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Entries_EventId",
                table: "Entries",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Entries_PlayerId",
                table: "Entries",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Entries_ScoreCardId",
                table: "Entries",
                column: "ScoreCardId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_SweepId",
                table: "Events",
                column: "SweepId");

            migrationBuilder.CreateIndex(
                name: "IX_Handicaps_PlayerId",
                table: "Handicaps",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_UserId",
                table: "Players",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Results_EventId",
                table: "Results",
                column: "EventId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Results_SecondId",
                table: "Results",
                column: "SecondId");

            migrationBuilder.CreateIndex(
                name: "IX_Results_ThirdId",
                table: "Results",
                column: "ThirdId");

            migrationBuilder.CreateIndex(
                name: "IX_Results_WinnerId",
                table: "Results",
                column: "WinnerId");

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
                name: "IX_ScoreCards_EventId",
                table: "ScoreCards",
                column: "EventId");

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
                name: "IX_ScoreCards_PlayerId",
                table: "ScoreCards",
                column: "PlayerId");

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

            migrationBuilder.CreateIndex(
                name: "IX_ScoreCards_TwelwthId",
                table: "ScoreCards",
                column: "TwelwthId");

            migrationBuilder.CreateIndex(
                name: "IX_Sweeps_OwnerId",
                table: "Sweeps",
                column: "OwnerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Entries");

            migrationBuilder.DropTable(
                name: "Handicaps");

            migrationBuilder.DropTable(
                name: "Results");

            migrationBuilder.DropTable(
                name: "ScoreCards");

            migrationBuilder.DropTable(
                name: "Holes");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Sweeps");
        }
    }
}
