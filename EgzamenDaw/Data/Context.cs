using EgzamenDaw.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace EgzamenDaw.Data
{
    public class Lab4Context : DbContext
    {
        public Lab4Context() { }
        public DbSet<Profesor> Professor { get; set; }
        public DbSet<Materii> Materii { get; set; }
        public DbSet<ProfesorMaterie> ProfesorMaterie { get; set; }
        public Lab4Context(DbContextOptions<Lab4Context> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=EgzamenDaw;TrustServerCertificate=True;");

            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //many to many: Professor - Materie
            modelBuilder.Entity<ProfesorMaterie>()
                        .HasKey(sc => new { sc.ProfesorId, sc.MaterieId });

            modelBuilder.Entity<ProfesorMaterie>()
                        .HasOne(sc => sc.Profesor)
                        .WithMany(s => s.ProfesorMaterie)
                        .HasForeignKey(sc => sc.ProfesorId);

            modelBuilder.Entity<ProfesorMaterie>()
                        .HasOne(sc => sc.Materii)
                        .WithMany(c => c.ProfesorMaterie)
                        .HasForeignKey(sc => sc.MaterieId);

        }
    }
}