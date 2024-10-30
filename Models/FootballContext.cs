using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EFDay1.Models;

public partial class FootballContext : DbContext
{
    public FootballContext()
    {
    }

    public FootballContext(DbContextOptions<FootballContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Match> Matches { get; set; }

    public virtual DbSet<Player> Players { get; set; }

    public virtual DbSet<PlayerStat> PlayerStats { get; set; }

    public virtual DbSet<Team> Teams { get; set; }

    public virtual DbSet<TransferHistory> TransferHistories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database=Football;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Match>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AwayTeamId).HasColumnName("AwayTeamID");
            entity.Property(e => e.Date).IsUnicode(false);
            entity.Property(e => e.HomeTeamId).HasColumnName("HomeTeamID");
            entity.Property(e => e.MatchId).HasColumnName("MatchID");
            entity.Property(e => e.Referee).IsUnicode(false);
            entity.Property(e => e.Stadium).IsUnicode(false);
        });

        modelBuilder.Entity<Player>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ContractUntil).IsUnicode(false);
            entity.Property(e => e.DateOfBirth).IsUnicode(false);
            entity.Property(e => e.Name).IsUnicode(false);
            entity.Property(e => e.Nationality).IsUnicode(false);
            entity.Property(e => e.PlayerId).HasColumnName("PlayerID");
            entity.Property(e => e.Position).IsUnicode(false);
            entity.Property(e => e.TeamId).HasColumnName("TeamID");
        });

        modelBuilder.Entity<PlayerStat>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.MatchId).HasColumnName("MatchID");
            entity.Property(e => e.PlayerId).HasColumnName("PlayerID");
            entity.Property(e => e.StatId).HasColumnName("StatID");
        });

        modelBuilder.Entity<Team>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Country).IsUnicode(false);
            entity.Property(e => e.HomeCity).IsUnicode(false);
            entity.Property(e => e.ManagerName).IsUnicode(false);
            entity.Property(e => e.StadiumName).IsUnicode(false);
            entity.Property(e => e.TeamId).HasColumnName("TeamID");
            entity.Property(e => e.TeamName).IsUnicode(false);
        });

        modelBuilder.Entity<TransferHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TransferHistory");

            entity.Property(e => e.FromTeamId).HasColumnName("FromTeamID");
            entity.Property(e => e.PlayerId).HasColumnName("PlayerID");
            entity.Property(e => e.ToTeamId).HasColumnName("ToTeamID");
            entity.Property(e => e.TransferDate).IsUnicode(false);
            entity.Property(e => e.TransferId).HasColumnName("TransferID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
