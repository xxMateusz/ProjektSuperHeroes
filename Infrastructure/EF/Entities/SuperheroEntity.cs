using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Infrastructure.EF.Entities
{
    [Table("superhero")]
    public class SuperheroEntity
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("superhero_name")]
        public string? SuperheroName { get; set; }

        [Column("full_name")]
        public string? FullName { get; set; }

        [Column("gender_id")]
        public int? GenderId { get; set; }

        public GenderEntity? Gender { get; set; }

        [Column("eye_colour_id")]
        public int? EyeColorId { get; set; }

        public ColorEntity? EyeColor { get; set; }

        [Column("hair_colour_id")]
        public int? HairColorId { get; set; }

        public ColorEntity? HairColor { get; set; }

        [Column("skin_colour_id")]
        public int? SkinColorId { get; set; }

        public ColorEntity? SkinColor { get; set; }

        [Column("race_id")]
        public int? RaceId { get; set; }

        public RaceEntity? Race { get; set; }

        [Column("publisher_id")]
        public int? PublisherId { get; set; }

        public PublisherEntity? Publisher { get; set; }

        [Column("alignment_id")]
        public int? AlignmentId { get; set; }

        public AlignmentEntity? Alignment { get; set; }

        [Column("height_cm")]
        public int? HeightCm { get; set; }

        [Column("weight_kg")]
        public int? WeightKg { get; set; }

        //public List<HeroAttributeEntity> HeroAttributes { get; set; } = new List<HeroAttributeEntity>();

        //public List<SuperpowerEntity> HeroPowers { get; set; } = new List<SuperpowerEntity>();
    }
}
