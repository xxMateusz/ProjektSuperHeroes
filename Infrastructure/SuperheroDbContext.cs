using ApplicationCore.Models;
using Infrastructure.EF.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class SuperheroDbContext : DbContext
    {
        public SuperheroDbContext(DbContextOptions<SuperheroDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(
                "DATA SOURCE=localhost;DATABASE=superhero;Integrated Security=true;TrustServerCertificate=True");
        }
        public DbSet<AlignmentEntity> Alignments { get; set; }
        public DbSet<AttributeEntity> Attributes { get; set; }
        public DbSet<ColorEntity> Colors { get; set; }
        public DbSet<GenderEntity> Genders { get; set; }
        public DbSet<PublisherEntity> Publishers { get; set; }
        public DbSet<RaceEntity> Races { get; set; }
        public DbSet<SuperheroEntity> Superheroes { get; set; }

     
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SuperheroEntity>()
                .HasOne(s => s.Alignment);

            modelBuilder.Entity<SuperheroEntity>()
                .HasOne(s => s.Gender);

            modelBuilder.Entity<SuperheroEntity>()
                .HasOne(s => s.EyeColor);

            modelBuilder.Entity<SuperheroEntity>()
                .HasOne(s => s.HairColor);

            modelBuilder.Entity<SuperheroEntity>()
                .HasOne(s => s.SkinColor);

            modelBuilder.Entity<SuperheroEntity>()
                .HasOne(s => s.Race);

            modelBuilder.Entity<SuperheroEntity>()
                .HasOne(s => s.Publisher);
        }
    }
}
