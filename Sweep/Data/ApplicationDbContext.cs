using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GolfSweep.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ScoreCard> ScoreCards { get; set; }
        public DbSet<Entry> Entries { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Handicap> Handicaps { get; set; }
        public DbSet<Hole> Holes { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<Sweep> Sweeps { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<OOMPoints> OOMPoints { get; set; }
        public DbSet<Score> Score { get; set; }
        public DbSet<SweepPlayer> SweepPlayers { get; set; }
        public DbSet<SweepRules> Rules { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<SweepPlayer>()
                .HasKey(s => new { s.SweepId, s.PlayerId });

            builder.Entity<SweepPlayer>()
                .HasOne(sw => sw.Sweep)
                .WithMany(p => p.Members)
                .HasForeignKey(sw => sw.SweepId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<SweepPlayer>()
                .HasOne(p => p.Player)
                .WithMany(sw => sw.Sweeps)
                .HasForeignKey(p => p.PlayerId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(builder);  
        }

    }
}
