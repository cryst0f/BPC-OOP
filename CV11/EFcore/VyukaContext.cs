using Microsoft.EntityFrameworkCore;

namespace CV11.EFcore
{
    public class VyukaContext : DbContext
    {
        public DbSet<Student> Studenti { get; set; }
        public DbSet<Predmet> Predmety { get; set; }
        public DbSet<Hodnoceni> Hodnoceni { get; set; }
        public DbSet<ZapsanyPredmet> ZapsanyPredmet { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
                @"Server=(localdb)\MSSQLLocalDB;Database=Vyuka;Trusted_Connection=True;"
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .Property(s => s.StudentId)
                .ValueGeneratedNever();

            modelBuilder.Entity<Predmet>()
                .Property(p => p.PredmetId)
                .ValueGeneratedNever();

            modelBuilder.Entity<ZapsanyPredmet>()
                .HasKey(z => new { z.StudentId, z.PredmetId });

            modelBuilder.Entity<Hodnoceni>()
                .HasKey(h => new { h.StudentId, h.PredmetId });
        }
    }
}