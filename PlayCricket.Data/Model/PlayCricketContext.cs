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
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=PlayCricketSW;Trusted_Connection=True;");
            }
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
