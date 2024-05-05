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
                .HasOne(s => s.Alignment)
                .WithMany()
                .HasForeignKey(s => s.AlignmentId)
                ;

            modelBuilder.Entity<SuperheroEntity>()
                .HasOne(s => s.Gender)
                .WithMany()
                .HasForeignKey(s => s.GenderId);

            modelBuilder.Entity<SuperheroEntity>()
                .HasOne(s => s.EyeColor)
                .WithMany()
                .HasForeignKey(s => s.EyeColorId);

            modelBuilder.Entity<SuperheroEntity>()
                .HasOne(s => s.HairColor)
                .WithMany()
                .HasForeignKey(s => s.HairColorId);

            modelBuilder.Entity<SuperheroEntity>()
                .HasOne(s => s.SkinColor)
                .WithMany()
                .HasForeignKey(s => s.SkinColorId);

            modelBuilder.Entity<SuperheroEntity>()
                .HasOne(s => s.Race)
                .WithMany()
                .HasForeignKey(s => s.RaceId);

            modelBuilder.Entity<SuperheroEntity>()
                .HasOne(s => s.Publisher)
                .WithMany()
                .HasForeignKey(s => s.PublisherId);

            modelBuilder.Entity<HeroAttributeEntity>()
                .HasOne(a => a.Hero)
                .WithMany()
                .HasForeignKey(a => a.HeroId);

            modelBuilder.Entity<HeroAttributeEntity>()
                .HasOne(a => a.Attribute)
                .WithMany()
                .HasForeignKey(a => a.AttributeId);
        }
    }
}
