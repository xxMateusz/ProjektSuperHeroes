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

            //modelBuilder.Entity<SuperheroEntity>()
            //.HasMany(e => e.HeroPowers)
            //.WithMany(e => e.Superheroes)
            //.UsingEntity(
            //    "hero_power",
            //    l => l.HasOne(typeof(SuperheroEntity)).WithMany().HasForeignKey("fk_hpo_hero").HasPrincipalKey(nameof(SuperheroEntity.Id)),
            //    r => r.HasOne(typeof(SuperpowerEntity)).WithMany().HasForeignKey("fk_hpo_po").HasPrincipalKey(nameof(SuperpowerEntity.Id));

            //modelBuilder.Entity<SuperpowerEntity>(entity =>
            //{
            //    entity.HasKey(e => e.Id).HasName("PK__superpow__3213E83FB682851B");

            //    entity.ToTable("superpower");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedNever()
            //        .HasColumnName("id");
            //    entity.Property(e => e.PowerName)
            //        .HasMaxLength(200)
            //        .IsUnicode(false)
            //        .HasColumnName("power_name");
            //});

            modelBuilder.Entity<HeroPowerEntity>(entity =>
            {
                entity
                    .HasKey(p => new
                    {
                        p.HeroId,
                        p.PowerId
                    });
                    //.ToTable("hero_power");

                entity.Property(e => e.HeroId).HasColumnName("hero_id");
                entity.Property(e => e.PowerId).HasColumnName("power_id");

                entity.HasOne(d => d.Hero).WithMany()
                    .HasForeignKey(d => d.HeroId)
                    .HasConstraintName("fk_hpo_hero");

                entity.HasOne(d => d.Power).WithMany()
                    .HasForeignKey(d => d.PowerId)
                    .HasConstraintName("fk_hpo_po");
            });

            modelBuilder.Entity<SuperheroEntity>()
                .HasMany(h => h.HeroPowers)
                .WithMany(p => p.Superheroes)
                .UsingEntity<HeroPowerEntity>();

        }
    }
}
