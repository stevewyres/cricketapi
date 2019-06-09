using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PlayCricket.Data.Model
{
    public partial class PlayCricketContext : DbContext
    {
        public PlayCricketContext()
        {
        }

        public PlayCricketContext(DbContextOptions<PlayCricketContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BowlingType> BowlingType { get; set; }
        public virtual DbSet<Player> Player { get; set; }
        public virtual DbSet<PlayerType> PlayerType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<BowlingType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Player>(entity =>
            {
                entity.HasOne(d => d.BowlingTypeNavigation)
                    .WithMany(p => p.Player)
                    .HasForeignKey(d => d.BowlingType)
                    .HasConstraintName("FK_Player_BowlingType");

                entity.HasOne(d => d.PlayerTypeNavigation)
                    .WithMany(p => p.Player)
                    .HasForeignKey(d => d.PlayerType)
                    .HasConstraintName("FK_Player_PlayerType");
            });

            modelBuilder.Entity<PlayerType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });
        }
    }
}
