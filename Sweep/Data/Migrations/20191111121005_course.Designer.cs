﻿// <auto-generated />
using System;
using GolfSweep.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GolfSweep.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20191111121005_course")]
    partial class course
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GolfSweep.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("GolfSweep.Data.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("GolfSweep.Data.Entry", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("Created");

                    b.Property<Guid?>("EventId");

                    b.Property<bool>("Paid");

                    b.Property<Guid?>("PlayerId");

                    b.Property<Guid?>("ScoreCardId");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("PlayerId");

                    b.HasIndex("ScoreCardId");

                    b.ToTable("Entries");
                });

            modelBuilder.Entity("GolfSweep.Data.Event", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("Created");

                    b.Property<DateTimeOffset>("Date");

                    b.Property<Guid?>("SweepId");

                    b.HasKey("Id");

                    b.HasIndex("SweepId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("GolfSweep.Data.Handicap", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("Created");

                    b.Property<double>("Exact");

                    b.Property<Guid>("PlayerId");

                    b.Property<int>("Playing");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.ToTable("Handicaps");
                });

            modelBuilder.Entity("GolfSweep.Data.Hole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("CourseId");

                    b.Property<int>("Index");

                    b.Property<int>("Number");

                    b.Property<int>("Par");

                    b.Property<int>("Points");

                    b.Property<int>("Score");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Holes");
                });

            modelBuilder.Entity("GolfSweep.Data.Player", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("Created");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("GolfSweep.Data.Result", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("EventId");

                    b.Property<Guid?>("SecondId");

                    b.Property<Guid?>("ThirdId");

                    b.Property<Guid?>("WinnerId");

                    b.HasKey("Id");

                    b.HasIndex("EventId")
                        .IsUnique();

                    b.HasIndex("SecondId");

                    b.HasIndex("ThirdId");

                    b.HasIndex("WinnerId");

                    b.ToTable("Results");
                });

            modelBuilder.Entity("GolfSweep.Data.ScoreCard", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("EighthId");

                    b.Property<Guid?>("EithteenthId");

                    b.Property<Guid?>("EleventhId");

                    b.Property<Guid?>("FifteenthId");

                    b.Property<Guid?>("FifthId");

                    b.Property<Guid?>("FirstId");

                    b.Property<Guid?>("FourteenthId");

                    b.Property<Guid?>("FourthId");

                    b.Property<Guid?>("NinthId");

                    b.Property<Guid>("PlayerId");

                    b.Property<Guid?>("SecondId");

                    b.Property<Guid?>("SeventeenthId");

                    b.Property<Guid?>("SeventhId");

                    b.Property<Guid?>("SixteenthId");

                    b.Property<Guid?>("SixthId");

                    b.Property<Guid?>("TenthId");

                    b.Property<Guid?>("ThirdId");

                    b.Property<Guid?>("ThirteenthId");

                    b.Property<Guid?>("TwelwthId");

                    b.HasKey("Id");

                    b.HasIndex("EighthId");

                    b.HasIndex("EithteenthId");

                    b.HasIndex("EleventhId");

                    b.HasIndex("FifteenthId");

                    b.HasIndex("FifthId");

                    b.HasIndex("FirstId");

                    b.HasIndex("FourteenthId");

                    b.HasIndex("FourthId");

                    b.HasIndex("NinthId");

                    b.HasIndex("PlayerId");

                    b.HasIndex("SecondId");

                    b.HasIndex("SeventeenthId");

                    b.HasIndex("SeventhId");

                    b.HasIndex("SixteenthId");

                    b.HasIndex("SixthId");

                    b.HasIndex("TenthId");

                    b.HasIndex("ThirdId");

                    b.HasIndex("ThirteenthId");

                    b.HasIndex("TwelwthId");

                    b.ToTable("ScoreCards");
                });

            modelBuilder.Entity("GolfSweep.Data.Sweep", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("Created");

                    b.Property<string>("Name");

                    b.Property<string>("OwnerId");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Sweeps");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("GolfSweep.Data.Entry", b =>
                {
                    b.HasOne("GolfSweep.Data.Event")
                        .WithMany("Entries")
                        .HasForeignKey("EventId");

                    b.HasOne("GolfSweep.Data.Player")
                        .WithMany("Entries")
                        .HasForeignKey("PlayerId");

                    b.HasOne("GolfSweep.Data.ScoreCard", "ScoreCard")
                        .WithMany()
                        .HasForeignKey("ScoreCardId");
                });

            modelBuilder.Entity("GolfSweep.Data.Event", b =>
                {
                    b.HasOne("GolfSweep.Data.Sweep")
                        .WithMany("Events")
                        .HasForeignKey("SweepId");
                });

            modelBuilder.Entity("GolfSweep.Data.Handicap", b =>
                {
                    b.HasOne("GolfSweep.Data.Player", "Player")
                        .WithMany("Handicaps")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GolfSweep.Data.Hole", b =>
                {
                    b.HasOne("GolfSweep.Data.Course")
                        .WithMany("Holes")
                        .HasForeignKey("CourseId");
                });

            modelBuilder.Entity("GolfSweep.Data.Player", b =>
                {
                    b.HasOne("GolfSweep.Data.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("GolfSweep.Data.Result", b =>
                {
                    b.HasOne("GolfSweep.Data.Event", "Event")
                        .WithOne("Result")
                        .HasForeignKey("GolfSweep.Data.Result", "EventId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GolfSweep.Data.ScoreCard", "Second")
                        .WithMany()
                        .HasForeignKey("SecondId");

                    b.HasOne("GolfSweep.Data.ScoreCard", "Third")
                        .WithMany()
                        .HasForeignKey("ThirdId");

                    b.HasOne("GolfSweep.Data.ScoreCard", "Winner")
                        .WithMany()
                        .HasForeignKey("WinnerId");
                });

            modelBuilder.Entity("GolfSweep.Data.ScoreCard", b =>
                {
                    b.HasOne("GolfSweep.Data.Hole", "Eighth")
                        .WithMany()
                        .HasForeignKey("EighthId");

                    b.HasOne("GolfSweep.Data.Hole", "Eithteenth")
                        .WithMany()
                        .HasForeignKey("EithteenthId");

                    b.HasOne("GolfSweep.Data.Hole", "Eleventh")
                        .WithMany()
                        .HasForeignKey("EleventhId");

                    b.HasOne("GolfSweep.Data.Hole", "Fifteenth")
                        .WithMany()
                        .HasForeignKey("FifteenthId");

                    b.HasOne("GolfSweep.Data.Hole", "Fifth")
                        .WithMany()
                        .HasForeignKey("FifthId");

                    b.HasOne("GolfSweep.Data.Hole", "First")
                        .WithMany()
                        .HasForeignKey("FirstId");

                    b.HasOne("GolfSweep.Data.Hole", "Fourteenth")
                        .WithMany()
                        .HasForeignKey("FourteenthId");

                    b.HasOne("GolfSweep.Data.Hole", "Fourth")
                        .WithMany()
                        .HasForeignKey("FourthId");

                    b.HasOne("GolfSweep.Data.Hole", "Ninth")
                        .WithMany()
                        .HasForeignKey("NinthId");

                    b.HasOne("GolfSweep.Data.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GolfSweep.Data.Hole", "Second")
                        .WithMany()
                        .HasForeignKey("SecondId");

                    b.HasOne("GolfSweep.Data.Hole", "Seventeenth")
                        .WithMany()
                        .HasForeignKey("SeventeenthId");

                    b.HasOne("GolfSweep.Data.Hole", "Seventh")
                        .WithMany()
                        .HasForeignKey("SeventhId");

                    b.HasOne("GolfSweep.Data.Hole", "Sixteenth")
                        .WithMany()
                        .HasForeignKey("SixteenthId");

                    b.HasOne("GolfSweep.Data.Hole", "Sixth")
                        .WithMany()
                        .HasForeignKey("SixthId");

                    b.HasOne("GolfSweep.Data.Hole", "Tenth")
                        .WithMany()
                        .HasForeignKey("TenthId");

                    b.HasOne("GolfSweep.Data.Hole", "Third")
                        .WithMany()
                        .HasForeignKey("ThirdId");

                    b.HasOne("GolfSweep.Data.Hole", "Thirteenth")
                        .WithMany()
                        .HasForeignKey("ThirteenthId");

                    b.HasOne("GolfSweep.Data.Hole", "Twelwth")
                        .WithMany()
                        .HasForeignKey("TwelwthId");
                });

            modelBuilder.Entity("GolfSweep.Data.Sweep", b =>
                {
                    b.HasOne("GolfSweep.Data.ApplicationUser", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("GolfSweep.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("GolfSweep.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GolfSweep.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("GolfSweep.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
