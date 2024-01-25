using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Data
{
    public class WebAppContext : DbContext
    {
        public WebAppContext(DbContextOptions<WebAppContext> options) : base(options) { }

        public DbSet<Materii> Materii { get; set; }

        public DbSet<Profesori> Profesori { get; set; }

        public DbSet<ModelRelation> ModelRelations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ModelRelation>()
                        .HasKey(mr => new { mr.MateriiId, mr.ProfesoriId });
            modelBuilder.Entity<ModelRelation>()
                        .HasOne(mr => mr.Materii)
                        .WithMany(mat => mat.ModelsRelations)
                        .HasForeignKey(mr => mr.MateriiId);
            modelBuilder.Entity<ModelRelation>()
                        .HasOne(mr => mr.Profesori)
                        .WithMany(prof => prof.ModelsRelations)
                        .HasForeignKey(mr => mr.ProfesoriId);

            base.OnModelCreating(modelBuilder);
        }
    }
}

