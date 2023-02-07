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
    [Migration("20191113090738_EntryGroupInt")]
    partial class EntryGroupInt
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

                    b.Property<DateTimeOffset>("Created");

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

                    b.Property<int?>("Group");

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

                    b.Property<Guid?>("CourseId");

                    b.Property<DateTimeOffset>("Created");

                    b.Property<DateTimeOffset>("Date");

                    b.Property<Guid?>("SweepId");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

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

                    b.Property<DateTimeOffset>("Created");

                    b.Property<int>("Index");

                    b.Property<int>("Number");

                    b.Property<int>("Par");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Holes");
                });

            modelBuilder.Entity("GolfSweep.Data.OOMPoints", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("CardId");

                    b.Property<DateTimeOffset>("Created");

                    b.Property<Guid?>("EventId");

                    b.Property<Guid?>("PlayerId");

                    b.Property<int>("Points");

                    b.Property<int>("Position");

                    b.Property<Guid?>("SweepId");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.HasIndex("EventId");

                    b.HasIndex("PlayerId");

                    b.HasIndex("SweepId");

                    b.ToTable("OOMPoints");
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

            modelBuilder.Entity("GolfSweep.Data.Score", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("Created");

                    b.Property<int>("Gross");

                    b.Property<int>("HoleNumber");

                    b.Property<int>("Nett");

                    b.Property<int>("Points");

                    b.Property<Guid?>("ScoreCardId");

                    b.HasKey("Id");

                    b.HasIndex("ScoreCardId");

                    b.ToTable("Score");
                });

            modelBuilder.Entity("GolfSweep.Data.ScoreCard", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("CourseId");

                    b.Property<DateTimeOffset>("Created");

                    b.Property<Guid>("PlayerId");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("PlayerId");

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
                    b.HasOne("GolfSweep.Data.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId");

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

            modelBuilder.Entity("GolfSweep.Data.OOMPoints", b =>
                {
                    b.HasOne("GolfSweep.Data.ScoreCard", "Card")
                        .WithMany()
                        .HasForeignKey("CardId");

                    b.HasOne("GolfSweep.Data.Event")
                        .WithMany("OOMPoints")
                        .HasForeignKey("EventId");

                    b.HasOne("GolfSweep.Data.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId");

                    b.HasOne("GolfSweep.Data.Sweep", "Sweep")
                        .WithMany()
                        .HasForeignKey("SweepId");
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

            modelBuilder.Entity("GolfSweep.Data.Score", b =>
                {
                    b.HasOne("GolfSweep.Data.ScoreCard")
                        .WithMany("Scores")
                        .HasForeignKey("ScoreCardId");
                });

            modelBuilder.Entity("GolfSweep.Data.ScoreCard", b =>
                {
                    b.HasOne("GolfSweep.Data.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId");

                    b.HasOne("GolfSweep.Data.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade);
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
